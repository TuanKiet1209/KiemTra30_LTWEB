using System.ComponentModel.DataAnnotations;

namespace LeTangHuyTuanKiet.Models
{
    public class Comment
    {
        public int ID { get; set; }
        public string Author { get; set; } = string.Empty;
        [Required] 
        public int Content { get; set; }
        [Required]
        public string CreatedAt { get; set; } = string.Empty;
        
    }
}