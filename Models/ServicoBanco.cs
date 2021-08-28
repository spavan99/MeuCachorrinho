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
    public class ServicoBanco : BancoConexao
    {

    
        public void Insert(servico nServico)
        {
            // inserir Servico no banco de dados
            Conexao_BD.Open();
            
            // sql insert   DtNascimentoUsuario
            nServico.estadoServico = nServico.estadoServico.Substring(0,2);
            string _sql = "INSERT INTO servico(nomeServico, detalheServico, valorServico, fotoServico, tipoServico, estadoServico, cidadeServico,  idForServico )"+
                          " VALUES (@nomeServico, @detalheServico, @valorServico, @fotoServico, @tipoServico, @estadoServico, @cidadeServico, @idForServico )";


            //Console.WriteLine( nServico.nomeServico);

             MySqlCommand comando = new MySqlCommand( _sql, Conexao_BD);
            comando.Parameters.AddWithValue("@nomeServico", nServico.nomeServico);
            comando.Parameters.AddWithValue("@detalheServico", nServico.detalheServico);
            comando.Parameters.AddWithValue("@valorServico", nServico.valorServico);
            comando.Parameters.AddWithValue("@fotoServico", nServico.fotoServico);
            comando.Parameters.AddWithValue("@tipoServico", nServico.tipoServico);
            comando.Parameters.AddWithValue("@estadoServico", nServico.estadoServico);
            comando.Parameters.AddWithValue("@cidadeServico", nServico.cidadeServico);
            comando.Parameters.AddWithValue("@idForServico", nServico.idForServico);
                        
            comando.ExecuteNonQuery();
            Conexao_BD.Close();

        }

        public void Alterar(servico nServico){

            // acertad dados do estado
            nServico.estadoServico = nServico.estadoServico.Substring(0,2);
            // Altear dados do Servico no banco
            // travar campos para nao mexer na pagina   1) idUsuarioCli  2) dtcadServico
            Conexao_BD.Open();
            // sql insert   DtNascimentoUsuario
            string _sql = "UPDATE servico SET nomeServico=@nomeServico, detalheServico=@detalheServico, ";
            _sql = _sql + "valorServico=@valorServico, fotoServico=@fotoServico, tipoServico=@tipoServico, ";
            _sql = _sql + "cidadeServico=@cidadeServico, idForServico=@idForServico, estadoServico=@estadoServico ";
            _sql = _sql + " WHERE idServico=" + nServico.idServico;

           Console.WriteLine( nServico.fotoServico);
 
            MySqlCommand comando = new MySqlCommand( _sql, Conexao_BD);
          //  comando.Parameters.AddWithValue("@idServico", nServico.idServico);
            comando.Parameters.AddWithValue("@nomeServico", nServico.nomeServico);
            comando.Parameters.AddWithValue("@detalheServico", nServico.detalheServico);
            comando.Parameters.AddWithValue("@valorServico", nServico.valorServico);
            comando.Parameters.AddWithValue("@fotoServico", nServico.fotoServico);
            comando.Parameters.AddWithValue("@tipoServico", nServico.tipoServico);
            comando.Parameters.AddWithValue("@estadoServico", nServico.estadoServico);
            comando.Parameters.AddWithValue("@cidadeServico", nServico.cidadeServico);
            comando.Parameters.AddWithValue("@idForServico", nServico.idForServico);
            
            comando.ExecuteNonQuery();
            Conexao_BD.Close();

       }

        public List<servico> Listar(int pID, string nTipoServico, string nEstado, string nCidade)
        {

            if( nTipoServico == null){
                nTipoServico = "";
            }
            if( nEstado == null ){
                nEstado = "";
            }

            if( nCidade == null){
                nCidade = "";
            }
            if( nTipoServico == null){
                nTipoServico = "";
            }
            // id vai ser tipo de servio  tipoServico
            // Buscar  ID = 0 (por causa ser int) tabela toda caso contratio o usuario especificado
            string _sql = null;
            // vier ID seleciona pelo idSerivoc
            if( pID == 0 ){
                _sql = "SELECT * FROM servico" ;
            }else{
              _sql = "SELECT * FROM servico WHERE idServico = "+ pID +";" ;

            }

            // ser vier Ntipo Faz selecao por tipo caso contrario prevalece if acima
            if( nTipoServico.Length > 0){
                _sql = "SELECT * FROM servico WHERE tipoServico = '"+ nTipoServico+ "'";

               // montar as pesuqisa por estado
                if( nEstado.Length > 0){
                   string pUF = nEstado.Substring(0,2);
                   _sql = _sql + " AND estadoServico LIKE '%" + pUF + "%'";
                   
                }
                // montar pesquisa da cidade
                if( nCidade.Length > 0){
                      if( nEstado.Length > 0){
                         _sql = _sql + " OR cidadeServico LIKE '%" + nCidade + "%'";
                      }else{
                        _sql = _sql + " AND cidadeServico LIKE '%" + nCidade + "%'"; 
                      }
                }

            }

            // Console.WriteLine( "Pesquisa......"+_sql);
           
           
            Conexao_BD.Open();
            MySqlCommand comandoQuery = new MySqlCommand(_sql, Conexao_BD);
            MySqlDataReader Resultado = comandoQuery.ExecuteReader();
           // Resultado.Read();
           
            List<servico> retPesquisa = new List<servico>();
            servico item = null;
            
            while(Resultado.Read())
            {
                item = new servico();

                item.idServico              =  Resultado.GetInt32("IdServico");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("nomeServico")))
                    item.nomeServico    =  Resultado.GetString("nomeServico");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("detalheServico")))
                    item.detalheServico    =  Resultado.GetString("detalheServico");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("valorServico")))
                    item.valorServico    =  Resultado.GetDouble("valorServico");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("fotoServico")))
                    item.fotoServico    =  Resultado.GetString("fotoServico");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("tipoServico")))
                    item.tipoServico    =  Resultado.GetString("tipoServico");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("estadoServico")))
                    item.estadoServico    =  Resultado.GetString("estadoServico");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("cidadeServico")))
                    item.cidadeServico    =  Resultado.GetString("cidadeServico");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("idForServico")))
                    item.idForServico    =  Resultado.GetInt32("idForServico");
             
               retPesquisa.Add(item);
            }
 
            return retPesquisa;
            
        }

        public servico BuscarID(int pID){

            Conexao_BD.Open();

            string _sql = "SELECT * FROM servico WHERE idServico=" + pID + ";";
            MySqlCommand comando = new MySqlCommand( _sql, Conexao_BD);
            //comando.Parameters.AddWithValue( "@id", Id);

            MySqlDataReader Resultado = comando.ExecuteReader();
            servico  item = new servico();
            
            if(Resultado.Read()){
                           
                item.idServico              =  Resultado.GetInt32("IdServico");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("nomeServico")))
                    item.nomeServico    =  Resultado.GetString("nomeServico");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("detalheServico")))
                    item.detalheServico    =  Resultado.GetString("detalheServico");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("valorServico")))
                    item.valorServico    =  Resultado.GetDouble("valorServico");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("fotoServico")))
                    item.fotoServico    =  Resultado.GetString("fotoServico");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("tipoServico")))
                    item.tipoServico    =  Resultado.GetString("tipoServico");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("estadoServico")))
                    item.estadoServico    =  Resultado.GetString("estadoServico");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("cidadeServico")))
                    item.cidadeServico    =  Resultado.GetString("cidadeServico");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("idForServico")))
                    item.idForServico    =  Resultado.GetInt32("idForServico");
            }
 
            return item;

        }

        public void Deletar( int ID){
            
            // MySqlConnection Conexao = new MySqlConnection(_strConexao);
            Conexao_BD.Open();
           // string sql = "DELETE FROM viagens WHERE IdViagem=@ViagemDeletar";
            string _sql = "DELETE FROM servico WHERE IdServico=" + ID;
            MySqlCommand comando = new MySqlCommand( _sql, Conexao_BD);

            //comando.Parameters.AddWithValue( "@ViagemDeletar", IdViagem );
            comando.ExecuteNonQuery();
            Conexao_BD.Close();

        }

         public string GravaFoto(List<IFormFile> ListAarquivos, string pDiretorio, string nFotoChave){
            
            string nomeArquivo = "ERRO";
            long tamanhoArquivos = ListAarquivos.Sum(f => f.Length);
            // caminho completo do arquivo na localização temporária
            var caminhoArquivo = Path.GetTempFileName();
            // processa o arquivo enviado

            //percorre a lista de arquivos selecionados
            foreach (var arquivo in ListAarquivos)
            {

                //verifica se existem arquivos 
                if (arquivo == null || arquivo.Length == 0)
                {
                    return nomeArquivo;
                }

                // < define a pasta onde vamos salvar os arquivos >
                string pasta = "recebidas";
                // Define um nome para o arquivo enviado incluindo o sufixo obtido de milesegundos
                nomeArquivo = nFotoChave+"_"+DateTime.Now.Year.ToString()+DateTime.Now.Month.ToString()+DateTime.Now.Day.ToString()+DateTime.Now.Hour.ToString()+DateTime.Now.Millisecond.ToString();

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
                string caminho_WebRoot = pDiretorio;
                // monta o caminho onde vamos salvar o arquivo :  ~\wwwroot\Arquivos\Arquivos_Usuario\Recebidos
                string caminhoDestinoArquivo = caminho_WebRoot + "\\fotos\\" + pasta + "\\";
                // incluir a pasta Recebidos e o nome do arquiov enviado : ~\wwwroot\Arquivos\Arquivos_Usuario\Recebidos\
                //string caminhoDestinoArquivoOriginal = caminhoDestinoArquivo + "\\fotos\\" + nomeArquivo;
                string caminhoDestinoArquivoOriginal = caminhoDestinoArquivo  + nomeArquivo;

                //copia o arquivo para o local de destino original
                using (var stream = new FileStream(caminhoDestinoArquivoOriginal, FileMode.Create))
                {
                    arquivo.CopyTo(stream);
                    //arquivo.CopyToAsync(stream);
                }
            }

            //retorna a viewdata
            return nomeArquivo;
            
        }

    }
}