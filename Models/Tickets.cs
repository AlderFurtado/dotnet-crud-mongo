using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TicketsApi.Models
{
    public class Ticket
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } 

        [BsonElement("Titulo")] 
        public string Titulo { get; set; }

        [BsonElement("Descricao")]
        public string Descricao { get; set; }

        [BsonElement("DataCriacao")]
        public DateTime? DataCriacao { get; set; } = DateTime.Now;

        [BsonElement("DataModificacao")]
        public DateTime? DataModificacao { get; set; }

        [BsonElement("Responsavel")]
        public string Responsavel { get; set; }

        [BsonElement("Mensagem")]
        public string Mensagem { get; set; }
        
        // public Ticket(){
        //     this.DataCriacao = new DateTime().ToLocalTime();
        // }
    }
}