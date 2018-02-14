using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ContatosWebAPI.Models
{
    public class Telefone
    {
        //public ObjectId Id { get; set; }
        private string _nome;
        [BsonElement("Nome")]
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        private string _numero;
        [BsonElement("Numero")]
        public string Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }
    }
}
