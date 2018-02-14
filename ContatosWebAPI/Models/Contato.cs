using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ContatosWebAPI.Models
{
    [BsonIgnoreExtraElements]
    public class Contato
    {
        [BsonId]
        public ObjectId Id;

/*        [BsonElement("contato_id")]
        public string Contato_id { get; set; }
        [BsonElement("Nome")]
        public string Nome { get; set; }
        [BsonElement("Email")]
        public string Email { get; set; }
        [BsonElement("DataNascimento")]
        public DateTime DataNascimento { get; set; }
        [BsonElement("CPF")]
        public string CPF { get; set; }
        [BsonElement("Telefones")]
        public ICollection<Telefone> Telefones { get; set; }
        [BsonElement("Enderecos")]
        public ICollection<Endereco> Enderecos { get; set; }
        [BsonElement("TipoContato")]
        public int TipoContato { get; set; }
        [BsonElement("Principal")]
        public bool Principal { get; set; }
        [BsonElement("Observacoes")]
        public string Observacoes { get; set; }
        */

        private string _contato_id;
                [BsonElement("contato_id")]
                public string Contato_id
                {
                    get { return _contato_id; }
                    set { _contato_id = value; }
                }

                private string _nome;
                [BsonElement("Nome")]
                public string Nome
                {
                    get { return _nome; }
                    set { _nome = value; }
                }
                private string _email;

                [BsonElement("Email")]
                public string Email
                {
                    get { return _email; }
                    set { _email = value; }
                }

                private DateTime _dataNascimento;

                [BsonElement("DataNascimento")]
                public DateTime DataNascimento
                {
                    get { return _dataNascimento; }
                    set { _dataNascimento = value; }
                }

                private string _cpf;

                [BsonElement("CPF")]
                public string CPF
                {
                    get { return _cpf; }
                    set { _cpf = value; }
                }

                private ICollection<Telefone> _telefones;

                [BsonElement("Telefones")]
                public ICollection<Telefone> Telefones
                {
                    get { return _telefones; }
                    set { _telefones = value; }
                }

                private ICollection<Endereco> _enderecos;

                [BsonElement("Enderecos")]
                public ICollection<Endereco> Enderecos
                {
                    get { return _enderecos; }
                    set { _enderecos = value; }
                }

                private int _tipoContato;

                [BsonElement("TipoContato")]
                public int TipoContato
                {
                    get { return _tipoContato; }
                    set { _tipoContato = value; }
                }


                private bool _principal;

                [BsonElement("Principal")]
                public bool Principal
                {
                    get { return _principal; }
                    set { _principal = value; }
                }

                private string _observacoes;

                [BsonElement("Observacoes")]
                public string Observacoes
                {
                    get { return _observacoes; }
                    set { _observacoes = value; }
                }
        

        public enum enumTipoContato
        {
            Comercial = 1,
            Administrativo = 2,
            Tecnico = 3
        }
    }
}
