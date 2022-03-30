using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Models
{
    public class WriterMessage
    {
        [Key] public int WriterMessageId { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
    }
}