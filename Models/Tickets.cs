using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TicketsApi.Models
{
    public class Ticket
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("Id")]
        public string Id { get => Id; set => Id = value; }

        [BsonElement("Titulo")] 
        public string Titulo { get => Titulo; set => Titulo = value; }

        [BsonElement("Descricao")]
        public string Descricao { get => Descricao; set => Descricao = value; }

        // [BsonElement("DataCriacao")]
        // public DateTime DataCriacao { get => DataCriacao; set => DataCriacao = value; }

        // [BsonElement("DataModificacao")]
        // public DateTime DataModificacao { get => DataModificacao; set => DataModificacao = value; }

        // [BsonElement("Responsavel")]
        // public string Responsavel { get => Responsavel; set => Responsavel = value; }

        // [BsonElement("Mensagem")]
        // public string Mensagem { get => Mensagem; set => Mensagem = value; }
        
        // public Ticket(){
        //     this.DataCriacao = new DateTime().ToLocalTime();
        // }
    }
}