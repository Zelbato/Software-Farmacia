using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace Software_Farmacia
{
    internal class Conexao
    {
        public static string conexao =
        @"Data Source=(localdb)\MSSQLLocalDB;
        Initial Catalog=FarmaciaBD;
        Integrated Security=True";
    }
}