using System;
using Meucachorro.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MySqlConnector;

namespace Meucachorro.Models
{
    public class BancoConexao
    {

        protected const string _strConexao = "Database=petmais;Data Source=localhost;User Id=root; Allow User Variables=True";
        protected MySqlConnection Conexao_BD = new MySqlConnection(_strConexao);

    }
}