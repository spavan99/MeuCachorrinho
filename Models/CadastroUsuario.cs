using System;
using System.Collections.Generic;
using Meucachorro.Models;

namespace Meucachorro.Models
{
    public class NovoUsuario
    {

        public static List<usuario> CadUsuario = new List<usuario>();

        public NovoUsuario()
        {
            CadUsuario = new List<usuario>();
        }

        public static void Incluir( usuario usuario){

            CadUsuario.Add(usuario);
        
        }

        public static List<usuario> ListarUsuario(){

            return CadUsuario;
        }


    }
}

