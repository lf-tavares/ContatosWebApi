using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

using ContatosWebAPI.Interfaces;
using ContatosWebAPI.Models;
using MongoDB.Bson;


namespace ContatosWebAPI.Data
{
    public class ContatoRepository : IContatoRepository
    {
        private DBContext _DBcontext = null;
        private IMongoCollection<Contato> _context = null;
        public ContatoRepository(IOptions<Settings> settings)
        {
            _DBcontext = new DBContext(settings);
            _context = _DBcontext.Db.GetCollection<Contato>("Contatos");
        }

        public Contato Get(string id)
        {
            //var filter = Builders<Contato>.Filter.Eq("id", id);
            try
            {
                return _context
                                .Find( x => x.Id.Equals(id))
                                .FirstOrDefault();
            }
            catch (Exception ex)
            {
                // log or manage the exception
                throw ex;
            }
        }
        public IEnumerable<Contato> Get()
        {
            try
            {

                var dados = _context
                                .Find(_ => true)
                                .ToEnumerable<Contato>();

                return dados;
            }
            catch (Exception ex)
            {
                // log or manage the exception
                throw ex;
            }
        }

        public bool Add(Contato item)
        {
            bool retorno = false;
            try
            {
                _context.InsertOne(item);
                retorno = true;
            }
            catch (Exception ex)
            {
                // log or manage the exception
                retorno = false;
            }
            return retorno;
        }
        public bool Update(Contato item)
        {
            bool retorno = false;

            try
            {

                var filter = Builders<Contato>.Filter.Eq(s => s.Contato_id, item.Contato_id);
                //var result = _colecao.UpdateOne(filter, Update<Contato>.Replace(contatos));
                //var result = _colecao.ReplaceOneAsync(filter, contatos);
                //return true;

                var update = Builders<Contato>.Update
                    //.Set(t => t.Id, contatos.Id)
                    .Set(t => t.Nome, item.Nome)
                    .Set(t => t.Principal, item.Principal)
                    .Set(t => t.Telefones, item.Telefones)
                    .Set(t => t.CPF, item.CPF)
                    .Set(t => t.DataNascimento, item.DataNascimento)
                    .Set(t => t.Email, item.Email)
                    .Set(t => t.Enderecos, item.Enderecos)
                    .Set(t => t.TipoContato, item.TipoContato)
                    .Set(t => t.Observacoes, item.Observacoes);

                var updateResult = _context.UpdateOne(filter, update);
                retorno =  true;
            //}


            //    ReplaceOneResult actionResult = _context
            //                                    .ReplaceOne(n => n.Id.Equals(id)
            //                                                    , item
            //                                                    , new UpdateOptions { IsUpsert = true });
            //    return actionResult.IsAcknowledged
            //        && actionResult.ModifiedCount > 0;
            }
            catch (Exception ex)
            {
                retorno = false;
                // log or manage the exception
                throw ex;
            }
            return retorno;
        }
        public bool Remove(string id)
        {
            try
            {
                DeleteResult actionResult = _context.DeleteOne(x => x.Contato_id.Equals(id));
//                     Builders<Contato>.Filter.Eq("Id", id));

                return actionResult.IsAcknowledged
                    && actionResult.DeletedCount > 0;
            }
            catch (Exception ex)
            {
                // log or manage the exception
                throw ex;
            }
        }

        //public bool UpdateContato(string CPF, string nome)
        //{
        //    var filter = Builders<Contato>.Filter.Eq(s => s.CPF, CPF);
        //    var update = Builders<Contato>.Update
        //                    .Set(s => s.Nome, nome)
        //                    .CurrentDate(s => s..UpdatedOn);

        //    try
        //    {
        //        UpdateResult actionResult = _context.UpdateOne(filter, update);

        //        return actionResult.IsAcknowledged
        //            && actionResult.ModifiedCount > 0;
        //    }
        //    catch (Exception ex)
        //    {
        //        // log or manage the exception
        //        throw ex;
        //    }
        //}

        //public async Task<bool> RemoveAllContatos()
        //{
        //    try
        //    {
        //        DeleteResult actionResult = await _context.DeleteManyAsync(new BsonDocument());

        //        return actionResult.IsAcknowledged
        //            && actionResult.DeletedCount > 0;
        //    }
        //    catch (Exception ex)
        //    {
        //        // log or manage the exception
        //        throw ex;
        //    }
        //}

        //public IEnumerable<Contato> GetAllContatos()
        //{
        //    try
        //    {
        //        return _context.Find(_ => true).ToList();
        //    }
        //    catch (Exception ex)
        //    {
        //        // log or manage the exception
        //        throw ex;
        //    }
        //}

    }
}
