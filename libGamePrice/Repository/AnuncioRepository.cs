using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibFilmes.API.Repository;
using libGamePrice.Repository.Interface;
using Dapper;
using libGamePrice.Model;


namespace libGamePrice.Repository
{
    public class AnuncioRepository : Conexao, IAnuncioRepository
    {
        public dynamic cadastraAnuncio()
        {
            string query= "";
            ConexaoBase.Execute(query);
            query = "";
            return ConexaoBase.Query<dynamic>(query).FirstOrDefault();

        }

        public AnuncioModel getAnuncio()
        {
            string query= "";
            return ConexaoBase.Query<dynamic>(query).FirstOrDefault();
        }

        public List<dynamic> getAnuncios()
        {
            string query= "";
            return ConexaoBase.Query<dynamic>(query).ToList();
        }

        public List<dynamic> getAnunciosByGenero()
        {
            string query= "";
            return ConexaoBase.Query<dynamic>(query).ToList();
        }
    }
}