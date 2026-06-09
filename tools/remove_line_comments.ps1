param(
	[string]$RootPath = "."
)

$files = Get-ChildItem -Path $RootPath -Recurse -Include *.cs -File
Write-Host "Found $($files.Count) .cs files"

foreach ($f in $files) {
	try {
		$txt = Get-Content -Raw -Encoding UTF8 -LiteralPath $f.FullName
	} catch {
		Write-Host "Skipping $($f.FullName): can't read" -ForegroundColor Yellow
		continue
	}

	$len = $txt.Length
	$i = 0
	$output = New-Object System.Text.StringBuilder

	$inDouble = $false
	$inSingle = $false
	$inVerbatim = $false

	while ($i -lt $len) {
		$ch = $txt[$i]
		$next = if ($i + 1 -lt $len) { $txt[$i+1] } else { "" }

		if (-not $inDouble -and -not $inSingle -and $ch -eq '/' -and $next -eq '/') {
			# skip until end of line (keep newline)
			while ($i -lt $len -and $txt[$i] -ne "`n") { $i++ }
			continue
		}

		# handle verbatim string start @"
		if (-not $inDouble -and -not $inSingle -and $ch -eq '@' -and $next -eq '"') {
			[void]$output.Append($ch)
			$i++
			$ch = $txt[$i]
			[void]$output.Append($ch)
			$inDouble = $true; $inVerbatim = $true
			$i++
			continue
		}

		if (-not $inDouble -and -not $inSingle -and $ch -eq '"') {
			$inDouble = $true; $inVerbatim = $false
			[void]$output.Append($ch)
			$i++
			continue
		}

		if ($inDouble -and -not $inVerbatim -and $ch -eq '"') {
			# count preceding backslashes
			$backslashes = 0
			$j = $i - 1
			while ($j -ge 0 -and $txt[$j] -eq '\\') { $backslashes++; $j-- }
			if ($backslashes % 2 -eq 0) { $inDouble = $false }
			[void]$output.Append($ch)
			$i++
			continue
		}

		if ($inVerbatim -and $ch -eq '"') {
			if ($next -eq '"') {
				[void]$output.Append('""')
				$i += 2
				continue
			} else {
				[void]$output.Append($ch)
				$inVerbatim = $false; $inDouble = $false
				$i++
				continue
			}
		}

		if (-not $inDouble -and -not $inSingle -and $ch -eq "'") {
			$inSingle = $true
			[void]$output.Append($ch)
			$i++
			continue
		}

		if ($inSingle -and $ch -eq "'") {
			# naive check for escape
			$back = ($i -gt 0 -and $txt[$i-1] -eq '\\')
			if (-not $back) { $inSingle = $false }
			[void]$output.Append($ch)
			$i++
			continue
		}

		[void]$output.Append($ch)
		$i++
	}

	$new = $output.ToString()
	if ($new -ne $txt) {
		Set-Content -LiteralPath $f.FullName -Value $new -Encoding UTF8
		Write-Host "Updated: $($f.FullName)" -ForegroundColor Green
	}
}

Write-Host "Done" -ForegroundColor Cyan
