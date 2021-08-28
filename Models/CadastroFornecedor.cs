using System;
using System.Collections.Generic;
using Meucachorro.Models;


namespace Meucachorro.Models
{
    public class NovoFornecedor
    {
        
         // Forneceodor de dados
        public static List<fornecedor> CadFornecedor = new List<fornecedor>(); 
        
        public NovoFornecedor()
        {
            CadFornecedor = new List<fornecedor>();
        }

        public static void Incluir( fornecedor fornecedor){

            CadFornecedor.Add(fornecedor);
        
        }

        public static List<fornecedor> ListarFornecedor(){

            return CadFornecedor;
        }


    }
}