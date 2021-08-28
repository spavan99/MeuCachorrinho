using System;
using System.Collections.Generic;
using Meucachorro.Models;

namespace Meucachorro.Models
{
    public class NovoServico
    {
        
       public static List<servico> CadServico = new List<servico>();

         public NovoServico()
        {
            CadServico = new List<servico>();
        }

        public static void Incluir( servico servico){

            CadServico.Add(servico);
        
        }

        public static List<servico> ListarServico(){

            return CadServico;
        }


    }
}