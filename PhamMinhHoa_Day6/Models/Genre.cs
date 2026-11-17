using System.ComponentModel.DataAnnotations;

namespace PhamMinhHoa_Day6.Models
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Tên phải hơn 3 ký tự nhỏ hơn 60")]
        public string? Name { get; set; }
        public ICollection<Movie>? Movies { get; set; }
    }
}
