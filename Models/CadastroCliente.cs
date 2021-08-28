using System;
using System.Collections.Generic;
using Meucachorro.Models;


namespace Meucachorro.Models
{
    public class NovoCliente
    {

         // CLIENTES base de dados
        public static List<cliente> CadCliente = new List<cliente>();
        
        public NovoCliente()
        {
            CadCliente = new List<cliente>();
        }

        public static void Incluir( cliente cliente){

            CadCliente.Add(cliente);
        
        }

        public static List<cliente> ListarCliente(){

            return CadCliente;
        }

    }
}