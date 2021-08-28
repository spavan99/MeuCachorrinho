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
    public class FornecedorBanco : BancoConexao
    {

   
        public void Insert(fornecedor nFornecedor)
        {
            // inserir Fornecedor no banco de dados
            Conexao_BD.Open();
            // sql insert   DtNascimentoUsuario
            nFornecedor.estadoFornecedor = nFornecedor.estadoFornecedor.Substring(0,2);
            nFornecedor.pessoaFornecedor = nFornecedor.pessoaFornecedor.Substring(0,1);
            string _sql = "INSERT INTO fornecedor(nomeFornecedor, enderecoFornecedor, nrresFornecedor, bairroFornecedor, complFornecedor, cepFornecedor, cidadeFornecedor, estadoFornecedor, tel1Fornecedor, tel2Fornecedor, tel3Fornecedor, pessoaFornecedor, tpindFornecedor, identFornecedor, idUsuarioFor, dtcadFornecedor )"+
                          " VALUES (@nomeFornecedor, @enderecoFornecedor, @nrresFornecedor, @bairroFornecedor, @complFornecedor, @cepFornecedor, @cidadeFornecedor, @estadoFornecedor, @tel1Fornecedor, @tel2Fornecedor, @tel3Fornecedor, @pessoaFornecedor, @tpindFornecedor, @identFornecedor, @idUsuarioFor, @dtcadFornecedor )";

            MySqlCommand comando = new MySqlCommand( _sql, Conexao_BD);
            comando.Parameters.AddWithValue("@nomeFornecedor", nFornecedor.nomeFornecedor);
            comando.Parameters.AddWithValue("@enderecoFornecedor", nFornecedor.enderecoFornecedor);
            comando.Parameters.AddWithValue("@nrresFornecedor", nFornecedor.nrresFornecedor);
            comando.Parameters.AddWithValue("@bairroFornecedor", nFornecedor.bairroFornecedor);
            comando.Parameters.AddWithValue("@complFornecedor", nFornecedor.complFornecedor);
            comando.Parameters.AddWithValue("@cepFornecedor", nFornecedor.cepFornecedor);
            comando.Parameters.AddWithValue("@cidadeFornecedor", nFornecedor.cidadeFornecedor);
            comando.Parameters.AddWithValue("@estadoFornecedor", nFornecedor.estadoFornecedor);
            comando.Parameters.AddWithValue("@tel1Fornecedor", nFornecedor.tel1Fornecedor);
            comando.Parameters.AddWithValue("@tel2Fornecedor", nFornecedor.tel2Fornecedor);
            comando.Parameters.AddWithValue("@tel3Fornecedor", nFornecedor.tel3Fornecedor);
            comando.Parameters.AddWithValue("@pessoaFornecedor", nFornecedor.pessoaFornecedor);
            comando.Parameters.AddWithValue("@tpindFornecedor", nFornecedor.tpindFornecedor);
            comando.Parameters.AddWithValue("@identFornecedor", nFornecedor.identFornecedor);
            comando.Parameters.AddWithValue("@idUsuarioFor", nFornecedor.idUsuarioFor);
            comando.Parameters.AddWithValue("@dtcadFornecedor", nFornecedor.dtcadFornecedor);
            
            comando.ExecuteNonQuery();
            Conexao_BD.Close();

        }

        public void Alterar(fornecedor nFornecedor){

            // Altear dados do Fornecedor no banco
            // travar campos para nao mexer na pagina   1) idUsuarioFor  2) dtcadFornecedor
            Conexao_BD.Open();

            nFornecedor.estadoFornecedor = nFornecedor.estadoFornecedor.Substring(0,2);
            nFornecedor.pessoaFornecedor = nFornecedor.pessoaFornecedor.Substring(0,1);
            // sql insert   DtNascimentoUsuario
            string _sql = "UPDATE fornecedor SET nomeFornecedor=@nomeFornecedor, enderecoFornecedor=@enderecoFornecedor, ";
            _sql = _sql + "bairroFornecedor=@bairroFornecedor, complFornecedor=@complFornecedor, cepFornecedor=@cepFornecedor, cidadeFornecedor=@cidadeFornecedor, ";
            _sql = _sql + "estadoFornecedor=@estadoFornecedor, tel1Fornecedor=@tel1Fornecedor, tel2Fornecedor=@tel2Fornecedor, tel3Fornecedor=@tel3Fornecedor, ";
            _sql = _sql + "pessoaFornecedor=@pessoaFornecedor, tpindFornecedor=@tpindFornecedor, identFornecedor=@identFornecedor, idUsuarioFor=@idUsuarioFor";
            _sql = _sql+ "  WHERE idFornecedor= "+ nFornecedor.idFornecedor;
//            _sql = _sql+ "  WHERE idFornecedor=@idFornecedor; ";

            MySqlCommand comando = new MySqlCommand( _sql, Conexao_BD);
            comando.Parameters.AddWithValue("@nomeFornecedor", nFornecedor.nomeFornecedor);
            comando.Parameters.AddWithValue("@enderecoFornecedor", nFornecedor.enderecoFornecedor);
            comando.Parameters.AddWithValue("@nrresFornecedor", nFornecedor.nrresFornecedor);
            comando.Parameters.AddWithValue("@bairroFornecedor", nFornecedor.bairroFornecedor);
            comando.Parameters.AddWithValue("@complFornecedor", nFornecedor.complFornecedor);
            comando.Parameters.AddWithValue("@cepFornecedor", nFornecedor.cepFornecedor);
            comando.Parameters.AddWithValue("@cidadeFornecedor", nFornecedor.cidadeFornecedor);
            comando.Parameters.AddWithValue("@estadoFornecedor", nFornecedor.estadoFornecedor);
            comando.Parameters.AddWithValue("@tel1Fornecedor", nFornecedor.tel1Fornecedor);
            comando.Parameters.AddWithValue("@tel2Fornecedor", nFornecedor.tel2Fornecedor);
            comando.Parameters.AddWithValue("@tel3Fornecedor", nFornecedor.tel3Fornecedor);
            comando.Parameters.AddWithValue("@pessoaFornecedor", nFornecedor.pessoaFornecedor);
            comando.Parameters.AddWithValue("@tpindFornecedor", nFornecedor.tpindFornecedor);
            comando.Parameters.AddWithValue("@identFornecedor", nFornecedor.identFornecedor);
            comando.Parameters.AddWithValue("@idUsuarioFor", nFornecedor.idUsuarioFor);
            comando.Parameters.AddWithValue("@dtcadFornecedor", nFornecedor.dtcadFornecedor);
            
            comando.ExecuteNonQuery();
            Conexao_BD.Close();

       }

        public List<fornecedor> Listar(int pID)
        {

            // Buscar  ID = 0 (por causa ser int) tabela toda caso contratio o usuario especificado
            string _sql = null;
            if( pID == 0 ){
                _sql = "SELECT * FROM fornecedor" ;
            }else{
              _sql = "SELECT * FROM fornecedor WHERE IdFornecedor = "+ pID +";" ;

            }

            Conexao_BD.Open();
            MySqlCommand comandoQuery = new MySqlCommand(_sql, Conexao_BD);
            MySqlDataReader Resultado = comandoQuery.ExecuteReader();
           // Resultado.Read();
           
            List<fornecedor> retPesquisa = new List<fornecedor>();
            fornecedor item = null;
            
            while(Resultado.Read())
            {
                item = new fornecedor();

                item.idFornecedor              =  Resultado.GetInt32("IdFornecedor");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("nomeFornecedor")))
                    item.nomeFornecedor    =  Resultado.GetString("nomeFornecedor");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("enderecoFornecedor")))
                    item.enderecoFornecedor    =  Resultado.GetString("enderecoFornecedor");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("nrresFornecedor")))
                    item.nrresFornecedor    =  Resultado.GetInt32("nrresFornecedor");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("bairroFornecedor")))
                    item.bairroFornecedor    =  Resultado.GetString("bairroFornecedor");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("complFornecedor")))
                    item.complFornecedor    =  Resultado.GetString("complFornecedor");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("cepFornecedor")))
                    item.cepFornecedor    =  Resultado.GetString("cepFornecedor");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("cidadeFornecedor")))
                    item.cidadeFornecedor    =  Resultado.GetString("cidadeFornecedor");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("estadoFornecedor")))
                    item.estadoFornecedor    =  Resultado.GetString("estadoFornecedor");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("tel1Fornecedor")))
                    item.tel1Fornecedor    =  Resultado.GetString("tel1Fornecedor");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("tel2Fornecedor")))
                        item.tel2Fornecedor    =  Resultado.GetString("tel2Fornecedor");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("tel3Fornecedor")))
                        item.tel3Fornecedor    =  Resultado.GetString("tel3Fornecedor");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("pessoaFornecedor")))
                        item.pessoaFornecedor    =  Resultado.GetString("pessoaFornecedor");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("tpindFornecedor")))
                        item.tpindFornecedor    =  Resultado.GetString("tpindFornecedor");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("identFornecedor")))
                        item.identFornecedor    =  Resultado.GetString("identFornecedor");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("idUsuarioFor")))
                        item.idUsuarioFor    =  Resultado.GetInt32("idUsuarioFor");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("dtcadFornecedor")))
                        item.dtcadFornecedor    =  Resultado.GetDateTime("dtcadFornecedor");
 
               retPesquisa.Add(item);
            }
 
            return retPesquisa;
            
        }

        public fornecedor BuscarID(int pID){

            Conexao_BD.Open();

            string _sql = "SELECT * FROM fornecedor WHERE idFornecedor=" + pID + ";";
            MySqlCommand comando = new MySqlCommand( _sql, Conexao_BD);
            //comando.Parameters.AddWithValue( "@id", Id);

            MySqlDataReader Resultado = comando.ExecuteReader();
            fornecedor  item = new fornecedor();
            
            if(Resultado.Read()){
                           
                item = new fornecedor();
                item.idFornecedor              =  Resultado.GetInt32("IdFornecedor");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("nomeFornecedor")))
                    item.nomeFornecedor    =  Resultado.GetString("nomeFornecedor");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("enderecoFornecedor")))
                    item.enderecoFornecedor    =  Resultado.GetString("enderecoFornecedor");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("nrresFornecedor")))
                    item.nrresFornecedor    =  Resultado.GetInt32("nrresFornecedor");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("bairroFornecedor")))
                    item.bairroFornecedor    =  Resultado.GetString("bairroFornecedor");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("complFornecedor")))
                    item.complFornecedor    =  Resultado.GetString("complFornecedor");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("cepFornecedor")))
                    item.cepFornecedor    =  Resultado.GetString("cepFornecedor");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("cidadeFornecedor")))
                    item.cidadeFornecedor    =  Resultado.GetString("cidadeFornecedor");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("estadoFornecedor")))
                    item.estadoFornecedor    =  Resultado.GetString("estadoFornecedor");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("tel1Fornecedor")))
                    item.tel1Fornecedor    =  Resultado.GetString("tel1Fornecedor");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("tel2Fornecedor")))
                        item.tel2Fornecedor    =  Resultado.GetString("tel2Fornecedor");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("tel3Fornecedor")))
                        item.tel3Fornecedor    =  Resultado.GetString("tel3Fornecedor");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("pessoaFornecedor")))
                        item.pessoaFornecedor    =  Resultado.GetString("pessoaFornecedor");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("tpindFornecedor")))
                        item.tpindFornecedor    =  Resultado.GetString("tpindFornecedor");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("identFornecedor")))
                        item.identFornecedor    =  Resultado.GetString("identFornecedor");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("idUsuarioFor")))
                        item.idUsuarioFor    =  Resultado.GetInt32("idUsuarioFor");
                if(!Resultado.IsDBNull(Resultado.GetOrdinal("dtcadFornecedor")))
                        item.dtcadFornecedor    =  Resultado.GetDateTime("dtcadFornecedor");
            }
 
            return item;

        }

        public void Deletar( int ID){
            
            // MySqlConnection Conexao = new MySqlConnection(_strConexao);
            Conexao_BD.Open();
           // string sql = "DELETE FROM viagens WHERE IdViagem=@ViagemDeletar";
            string _sql = "DELETE FROM fornecedor WHERE IdFornecedor=" + ID;
            MySqlCommand comando = new MySqlCommand( _sql, Conexao_BD);

            //comando.Parameters.AddWithValue( "@ViagemDeletar", IdViagem );
            comando.ExecuteNonQuery();
            Conexao_BD.Close();

        }



    }
}