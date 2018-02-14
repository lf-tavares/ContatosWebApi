using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ContatosWebAPI.Models
{
    public class Endereco
    {
        private string _nome;
        [BsonElement("Nome")]
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private string _cep;

        [BsonElement("CEP")]
        public string CEP
        {
            get { return _cep; }
            set { _cep = value; }
        }

        private string _logradouro;

        [BsonElement("Logradouro")]
        public string Logradouro
        {
            get { return _logradouro; }
            set { _logradouro = value; }
        }
        private string _numero;

        [BsonElement("Numero")]
        public string Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

        private string _complemento;

        [BsonElement("Complemento")]
        public string Complemento
        {
            get { return _complemento; }
            set { _complemento = value; }
        }

        private string _bairro;

        [BsonElement("Bairro")]
        public string Bairro
        {
            get { return _bairro; }
            set { _bairro = value; }
        }

        private string _cidade;

        [BsonElement("Cidade")]
        public string Cidade
        {
            get { return _cidade; }
            set { _cidade = value; }
        }

        private string _estado;

        [BsonElement("Estado")]
        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        private string _referencia;

        [BsonElement("Referencia")]
        public string Referencia
        {
            get { return _referencia; }
            set { _referencia = value; }
        }
    }
}
