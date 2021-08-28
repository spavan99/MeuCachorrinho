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


namespace Meucachorro.Models
{
    public class ClientesBanco : BancoConexao
    {

    
        public void Insert(cliente nCliente)
        {
            // inserir cliente no banco de dados
            Conexao_BD.Open();
            
            nCliente.estadoCliente = nCliente.estadoCliente.Substring(0,2);
            nCliente.pessoaCliente = nCliente.pessoaCliente.Substring(0,1);

            // sql insert   DtNascimentoUsuario
            string _sql = "INSERT INTO cliente(nomeCliente, enderecoCliente, nrresCliente, bairroCliente, complCliente, cepCliente, cidadeCliente, estadoCliente, tel1Cliente, tel2Cliente, tel3Cliente, pessoaCliente, tpindCliente, identCliente, idUsuarioCli, dtcadCliente )"+
                          " VALUES (@nomeCliente, @enderecoCliente, @nrresCliente, @bairroCliente, @complCliente, @cepCliente, @cidadeCliente, @estadoCliente, @tel1Cliente, @tel2Cliente, @tel3Cliente, @pessoaCliente, @tpindCliente, @identCliente, @idUsuarioCli, @dtcadCliente )";

            MySqlCommand comando = new MySqlCommand( _sql, Conexao_BD);
            comando.Parameters.AddWithValue("@nomeCliente", nCliente.nomeCliente);
            comando.Parameters.AddWithValue("@enderecoCliente", nCliente.enderecoCliente);
            comando.Parameters.AddWithValue("@nrresCliente", nCliente.nrresCliente);
            comando.Parameters.AddWithValue("@bairroCliente", nCliente.bairroCliente);
            comando.Parameters.AddWithValue("@complCliente", nCliente.complCliente);
            comando.Parameters.AddWithValue("@cepCliente", nCliente.cepCliente);
            comando.Parameters.AddWithValue("@cidadeCliente", nCliente.cidadeCliente);
            comando.Parameters.AddWithValue("@estadoCliente", nCliente.estadoCliente);
            comando.Parameters.AddWithValue("@tel1Cliente", nCliente.tel1Cliente);
            comando.Parameters.AddWithValue("@tel2Cliente", nCliente.tel2Cliente);
            comando.Parameters.AddWithValue("@tel3Cliente", nCliente.tel3Cliente);
            comando.Parameters.AddWithValue("@pessoaCliente", nCliente.pessoaCliente);
            comando.Parameters.AddWithValue("@tpindCliente", nCliente.tpindCliente);
            comando.Parameters.AddWithValue("@identCliente", nCliente.identCliente);
            comando.Parameters.AddWithValue("@idUsuarioCli", nCliente.idUsuarioCli);
            comando.Parameters.AddWithValue("@dtcadCliente", nCliente.dtcadCliente);
            
            comando.ExecuteNonQuery();
            Conexao_BD.Close();

        }

        public void Alterar(cliente nCliente){

            // Altear dados do cliente no banco
            // travar campos para nao mexer na pagina   1) idUsuarioCli  2) dtcadCliente
            Conexao_BD.Open();
            nCliente.estadoCliente = nCliente.estadoCliente.Substring(0,2);
            nCliente.pessoaCliente = nCliente.pessoaCliente.Substring(0,1);

            // sql insert   DtNascimentoUsuario
            string _sql = "UPDATE cliente SET nomeCliente=@nomeCliente, enderecoCliente=@enderecoCliente, ";
            _sql = _sql + "bairroCliente=@bairroCliente, complCliente=@complCliente, cepCliente=@cepCliente, cidadeCliente=@cidadeCliente, ";
            _sql = _sql + "estadoCliente=@estadoCliente, tel1Cliente=@tel1Cliente, tel2Cliente=@tel2Cliente, tel3Cliente=@tel3Cliente, ";
            _sql = _sql + "pessoaCliente=@pessoaCliente, tpindCliente=@tpindCliente, identCliente=@identCliente, idUsuarioCli=@idUsuarioCli";
            _sql = _sql+ "  WHERE idCliente= "+ nCliente.idCliente;
//            _sql = _sql+ "  WHERE idCliente=@idCliente; ";

            MySqlCommand comando = new MySqlCommand( _sql, Conexao_BD);
            comando.Parameters.AddWithValue("@nomeCliente", nCliente.nomeCliente);
            comando.Parameters.AddWithValue("@enderecoCliente", nCliente.enderecoCliente);
            comando.Parameters.AddWithValue("@nrresCliente", nCliente.nrresCliente);
            comando.Parameters.AddWithValue("@bairroCliente", nCliente.bairroCliente);
            comando.Parameters.AddWithValue("@complCliente", nCliente.complCliente);
            comando.Parameters.AddWithValue("@cepCliente", nCliente.cepCliente);
            comando.Parameters.AddWithValue("@cidadeCliente", nCliente.cidadeCliente);
            comando.Parameters.AddWithValue("@estadoCliente", nCliente.estadoCliente);
            comando.Parameters.AddWithValue("@tel1Cliente", nCliente.tel1Cliente);
            comando.Parameters.AddWithValue("@tel2Cliente", nCliente.tel2Cliente);
            comando.Parameters.AddWithValue("@tel3Cliente", nCliente.tel3Cliente);
            comando.Parameters.AddWithValue("@pessoaCliente", nCliente.pessoaCliente);
            comando.Parameters.AddWithValue("@tpindCliente", nCliente.tpindCliente);
            comando.Parameters.AddWithValue("@identCliente", nCliente.identCliente);
            comando.Parameters.AddWithValue("@idUsuarioCli", nCliente.idUsuarioCli);
            comando.Parameters.AddWithValue("@dtcadCliente", nCliente.dtcadCliente);
            
            comando.ExecuteNonQuery();
            Conexao_BD.Close();

       }

        public List<cliente> Listar(int pID)
        {

            // Buscar  ID = 0 (por causa ser int) tabela toda caso contratio o usuario especificado
            string _sql = null;
            if( pID == 0 ){
                _sql = "SELECT * FROM cliente" ;
            }else{
              _sql = "SELECT * FROM cliente WHERE IdCliente = "+ pID +";" ;

            }

            Conexao_BD.Open();
            MySqlCommand comandoQuery = new MySqlCommand(_sql, Conexao_BD);
            MySqlDataReader Resultado = comandoQuery.ExecuteReader();
           // Resultado.Read();
           
            List<cliente> retPesquisa = new List<cliente>();
            cliente item = null;
            
            while(Resultado.Read())
            {
                item = new cliente();

                item.idCliente              =  Resultado.GetInt32("IdCliente");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("nomeCliente")))
                    item.nomeCliente    =  Resultado.GetString("nomeCliente");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("enderecoCliente")))
                    item.enderecoCliente    =  Resultado.GetString("enderecoCliente");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("nrresCliente")))
                    item.nrresCliente    =  Resultado.GetInt32("nrresCliente");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("bairroCliente")))
                    item.bairroCliente    =  Resultado.GetString("bairroCliente");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("complCliente")))
                    item.complCliente    =  Resultado.GetString("complCliente");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("cepCliente")))
                    item.cepCliente    =  Resultado.GetString("cepCliente");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("cidadeCliente")))
                    item.cidadeCliente    =  Resultado.GetString("cidadeCliente");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("estadoCliente")))
                    item.estadoCliente    =  Resultado.GetString("estadoCliente");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("tel1Cliente")))
                    item.tel1Cliente    =  Resultado.GetString("tel1Cliente");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("tel2Cliente")))
                        item.tel2Cliente    =  Resultado.GetString("tel2Cliente");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("tel3Cliente")))
                        item.tel3Cliente    =  Resultado.GetString("tel3Cliente");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("pessoaCliente")))
                        item.pessoaCliente    =  Resultado.GetString("pessoaCliente");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("tpindCliente")))
                        item.tpindCliente    =  Resultado.GetString("tpindCliente");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("identCliente")))
                        item.identCliente    =  Resultado.GetString("identCliente");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("idUsuarioCli")))
                        item.idUsuarioCli    =  Resultado.GetInt32("idUsuarioCli");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("dtcadCliente")))
                        item.dtcadCliente    =  Resultado.GetDateTime("dtcadCliente");
 
               retPesquisa.Add(item);
            }
 
            return retPesquisa;
            
        }

        public cliente BuscarID(int pID){

            Conexao_BD.Open();

            string _sql = "SELECT * FROM cliente WHERE idCliente=" + pID + ";";
            MySqlCommand comando = new MySqlCommand( _sql, Conexao_BD);
            //comando.Parameters.AddWithValue( "@id", Id);

            MySqlDataReader Resultado = comando.ExecuteReader();
            cliente  item = new cliente();
            
            if(Resultado.Read()){
                           
                item = new cliente();
                item.idCliente              =  Resultado.GetInt32("IdCliente");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("nomeCliente")))
                    item.nomeCliente    =  Resultado.GetString("nomeCliente");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("enderecoCliente")))
                    item.enderecoCliente    =  Resultado.GetString("enderecoCliente");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("nrresCliente")))
                    item.nrresCliente    =  Resultado.GetInt32("nrresCliente");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("bairroCliente")))
                    item.bairroCliente    =  Resultado.GetString("bairroCliente");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("complCliente")))
                    item.complCliente    =  Resultado.GetString("complCliente");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("cepCliente")))
                    item.cepCliente    =  Resultado.GetString("cepCliente");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("cidadeCliente")))
                    item.cidadeCliente    =  Resultado.GetString("cidadeCliente");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("estadoCliente")))
                    item.estadoCliente    =  Resultado.GetString("estadoCliente");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("tel1Cliente")))
                    item.tel1Cliente    =  Resultado.GetString("tel1Cliente");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("tel2Cliente")))
                        item.tel2Cliente    =  Resultado.GetString("tel2Cliente");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("tel3Cliente")))
                        item.tel3Cliente    =  Resultado.GetString("tel3Cliente");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("pessoaCliente")))
                        item.pessoaCliente    =  Resultado.GetString("pessoaCliente");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("tpindCliente")))
                        item.tpindCliente    =  Resultado.GetString("tpindCliente");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("identCliente")))
                        item.identCliente    =  Resultado.GetString("identCliente");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("idUsuarioCli")))
                        item.idUsuarioCli    =  Resultado.GetInt32("idUsuarioCli");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("dtcadCliente")))
                        item.dtcadCliente    =  Resultado.GetDateTime("dtcadCliente");
            }
 
            return item;

        }

        public void Deletar( int ID){
            
            // MySqlConnection Conexao = new MySqlConnection(_strConexao);
            Conexao_BD.Open();
           // string sql = "DELETE FROM viagens WHERE IdViagem=@ViagemDeletar";
            string _sql = "DELETE FROM cliente WHERE IdCliente=" + ID;
            MySqlCommand comando = new MySqlCommand( _sql, Conexao_BD);

            //comando.Parameters.AddWithValue( "@ViagemDeletar", IdViagem );
            comando.ExecuteNonQuery();
            Conexao_BD.Close();

        }



    }
}