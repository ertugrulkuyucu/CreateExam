using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SınavOlusturma.Models
{
    public class Answer
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
        public bool isTrue { get; set; }
        public int QuestionId { get; set; }
    }
}
