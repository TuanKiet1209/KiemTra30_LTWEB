using System.ComponentModel.DataAnnotations;

namespace LeTangHuyTuanKiet.Models
{
    public class News
    {
        public int ID { get; set; }
        public string Title { get; set; } = string.Empty;
        [Required] [MaxLength(200)][MinLength(50)]

        [System.ComponentModel.Bindable(true)]
        public virtual string ImageURL  { get; set; } = string.Empty;
        [Required]
        public string Author { get; set; } = string.Empty;
        [Required]
        public int Content { get; set; }
        [Required] [MaxLength(500)][MinLength(50)]
        public string CreatedAt { get; set; } = string.Empty;
        public IEquatable<Comment>? Listcomments { get; set; }
        
    }
}