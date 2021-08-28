using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Meucachorro.Models;
using System.ComponentModel.DataAnnotations;
using MySqlConnector;
using System.Data.SqlClient;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.IO;


namespace Meucachorro.Models
{
    public class UsuarioBanco : BancoConexao
    {


          public usuario LoginUsuarioBD(usuario user, string ntipo)
        {
           
            Conexao_BD.Open();
            // sql pesquisa usuaria
            string _sql = "";
            if( ntipo == "USER"){
                _sql = "SELECT * FROM usuario WHERE loginUsuario = @loginUsuario ";
            }else{
                _sql = "SELECT * FROM usuario WHERE loginUsuario = @loginUsuario AND senhaUsuario = @senhaUsuario";
            }
            MySqlCommand comandoQuery = new MySqlCommand( _sql, Conexao_BD);

            comandoQuery.Parameters.AddWithValue("@loginUsuario", user.loginUsuario);
            comandoQuery.Parameters.AddWithValue("@senhaUsuario", user.senhaUsuario);
            
            MySqlDataReader reader = comandoQuery.ExecuteReader();
            usuario usr = null;   

            if(reader.Read())
            {
                usr = new usuario();
                usr.idUsuario = reader.GetInt32("idUsuario");
                 if(!reader.IsDBNull(reader.GetOrdinal("loginUsuario")))
                    usr.loginUsuario = reader.GetString("loginUsuario");
                if(!reader.IsDBNull(reader.GetOrdinal("senhaUsuario")))
                    usr.senhaUsuario = reader.GetString("senhaUsuario");
            }
        
            Conexao_BD.Close();
            return usr;
        }

  
        public void Insert(usuario nPar)
        {
            // inserir Usuario no banco de dados
            Conexao_BD.Open();
            
            // data cadastro data atual
            //DateTime DataHoje  = DateTime.Now; 
            // sql insert   DtNascimentoUsuario
            nPar.tipoUsuario = nPar.tipoUsuario.Substring(0,1);
            string _sql = "INSERT INTO usuario(emailUsuario, loginUsuario, senhaUsuario, tipoUsuario, dtcadUsuario )"+
                          " VALUES (@emailUsuario, @loginUsuario, @senhaUsuario, @tipoUsuario, @dtCadUsuario )";

            MySqlCommand comando = new MySqlCommand( _sql, Conexao_BD);
            comando.Parameters.AddWithValue("@emailUsuario", nPar.emailUsuario);
            comando.Parameters.AddWithValue("@loginUsuario", nPar.loginUsuario);
            comando.Parameters.AddWithValue("@senhaUsuario", nPar.senhaUsuario);
            comando.Parameters.AddWithValue("@tipoUsuario", nPar.tipoUsuario);
            comando.Parameters.AddWithValue("@dtcadUsuario", nPar.dtcadUsuario);
           
            comando.ExecuteNonQuery();
            Conexao_BD.Close();

        }

        public void Alterar(usuario nPar){

            // Altear dados do Usuario no banco
            // travar campos para nao mexer na pagina   1) idUsuarioCli  2) dtcadusuaio
            Conexao_BD.Open();
            // sql insert   DtNascimentoUsuario
            nPar.tipoUsuario = nPar.tipoUsuario.Substring(0,1);
            string _sql = "UPDATE usuario SET emailUsuario=@emailUsuario, loginUsuario=@loginUsuario, ";
            _sql = _sql + "senhaUsuario=@senhaUsuario, tipoUsuario=@tipoUsuario, dtcadUsuario=@dtcadUsuario ";
            _sql = _sql+ "  WHERE idUsuario= "+ nPar.idUsuario;
//            _sql = _sql+ "  WHERE idCliente=@idCliente; ";

            MySqlCommand comando = new MySqlCommand( _sql, Conexao_BD);
            comando.Parameters.AddWithValue("@emailUsuario", nPar.emailUsuario);
            comando.Parameters.AddWithValue("@loginUsuario", nPar.loginUsuario);
            comando.Parameters.AddWithValue("@senhaUsuario", nPar.senhaUsuario);
            comando.Parameters.AddWithValue("@tipoUsuario", nPar.tipoUsuario);
            comando.Parameters.AddWithValue("@dtcadUsuario", nPar.dtcadUsuario);
            
            comando.ExecuteNonQuery();
            Conexao_BD.Close();

       }

        public List<usuario> Listar(int pID)
        {

            // Buscar  ID = 0 (por causa ser int) tabela toda caso contratio o usuario especificado
            string _sql = null;
            if( pID == 0 ){
                _sql = "SELECT * FROM usuario" ;
            }else{
              _sql = "SELECT * FROM usuario WHERE IdUsuario = "+ pID +";" ;

            }

            Conexao_BD.Open();
            MySqlCommand comandoQuery = new MySqlCommand(_sql, Conexao_BD);
            MySqlDataReader Resultado = comandoQuery.ExecuteReader();
           // Resultado.Read();
           
            List<usuario> retPesquisa = new List<usuario>();
            usuario item = null;
            
            while(Resultado.Read())
            {
                item = new usuario();

                item.idUsuario              =  Resultado.GetInt32("idUsuario");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("emailUsuario")))
                    item.emailUsuario    =  Resultado.GetString("emailUsuario");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("loginUsuario")))
                    item.loginUsuario    =  Resultado.GetString("loginUsuario");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("senhaUsuario")))
                    item.senhaUsuario    =  Resultado.GetString("senhaUsuario");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("tipoUsuario")))
                    item.tipoUsuario   =  Resultado.GetString("tipoUsuario");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("dtcadUsuario")))
                    item.dtcadUsuario    =  Resultado.GetDateTime("dtcadUsuario");
               retPesquisa.Add(item);
            }
 
            return retPesquisa;
            
        }

        public usuario BuscarID(int pID){

            Conexao_BD.Open();

            string _sql = "SELECT * FROM usuario WHERE idUsuario=" + pID + ";";
            MySqlCommand comando = new MySqlCommand( _sql, Conexao_BD);
            //comando.Parameters.AddWithValue( "@id", Id);

            MySqlDataReader Resultado = comando.ExecuteReader();
            usuario  item = new usuario();
            
            if(Resultado.Read()){
                           
                item = new usuario();

                item.idUsuario              =  Resultado.GetInt32("idUsuario");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("emailUsuario")))
                    item.emailUsuario    =  Resultado.GetString("emailUsuario");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("loginUsuario")))
                    item.loginUsuario    =  Resultado.GetString("loginUsuario");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("senhaUsuario")))
                    item.senhaUsuario    =  Resultado.GetString("senhaUsuario");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("tipoUsuario")))
                    item.tipoUsuario   =  Resultado.GetString("tipoUsuario");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("dtcadUsuario")))
                    item.dtcadUsuario    =  Resultado.GetDateTime("dtcadUsuario");
            }
 
            return item;

        }

        public void Deletar( int ID){
            
            // MySqlConnection Conexao = new MySqlConnection(_strConexao);
            Conexao_BD.Open();
           // string sql = "DELETE FROM viagens WHERE IdViagem=@ViagemDeletar";
            string _sql = "DELETE FROM usuario WHERE IdUsuario=" + ID;
            MySqlCommand comando = new MySqlCommand( _sql, Conexao_BD);

            //comando.Parameters.AddWithValue( "@ViagemDeletar", IdViagem );
            comando.ExecuteNonQuery();
            Conexao_BD.Close();

        }


       //método para enviar os arquivos usando a interface IFormFile
        public string GravaFoto( List<IFormFile> ListaArquivos, string Diretorio)
        {
           
           string nOK = "OK";
           Console.WriteLine( ListaArquivos);
           Console.WriteLine( ListaArquivos.Count);
           
            long tamanhoArquivos = ListaArquivos.Sum(f => f.Length);
            // caminho completo do arquivo na localização temporária
            var caminhoArquivo = Path.GetTempFileName();
            // processa o arquivo enviado

            //percorre a lista de arquivos selecionados
            foreach (var arquivo in ListaArquivos)
            {
                //verifica se existem arquivos 
                if (arquivo == null || arquivo.Length == 0)
                {
                   nOK = "ERRO";
                   return nOK; 
                }

                // < define a pasta onde vamos salvar os arquivos >
                string pasta = "recebidas";
                // Define um nome para o arquivo enviado incluindo o sufixo obtido de milesegundos
                string nomeArquivo = "Usuario_arquivo_" + DateTime.Now.Millisecond.ToString();

                //verifica qual o tipo de arquivo : jpg, gif, png, pdf ou tmp
                if (arquivo.FileName.Contains(".jpg"))
                    nomeArquivo += ".jpg";
                else if (arquivo.FileName.Contains(".gif"))
                    nomeArquivo += ".gif";
                else if (arquivo.FileName.Contains(".png"))
                    nomeArquivo += ".png";
                else if (arquivo.FileName.Contains(".pdf"))
                    nomeArquivo += ".pdf";
                else
                    nomeArquivo += ".tmp";

                //< obtém o caminho físico da pasta wwwroot >
                string caminho_WebRoot = Diretorio;
                // monta o caminho onde vamos salvar o arquivo :  ~\wwwroot\Arquivos\Arquivos_Usuario\Recebidos
                string caminhoDestinoArquivo = caminho_WebRoot + "\\fotos\\" + pasta + "\\";
                // incluir a pasta Recebidos e o nome do arquiov enviado : ~\wwwroot\Arquivos\Arquivos_Usuario\Recebidos\
                //string caminhoDestinoArquivoOriginal = caminhoDestinoArquivo + "\\fotos\\" + nomeArquivo;
                string caminhoDestinoArquivoOriginal = caminhoDestinoArquivo  + nomeArquivo;

                //copia o arquivo para o local de destino original
                using (var stream = new FileStream(caminhoDestinoArquivoOriginal, FileMode.Create))
                {
                    arquivo.CopyToAsync(stream);
                }
            }

            return nOK;

            
        }
 








    }
}