using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhamMinhHoa_Day6.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Tên phải hơn 3 ký tự nhỏ hơn 60")]
        public string? Title { get; set; }
        [DataType(DataType.Date)]
        public string? ReleaseDate { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        [ForeignKey("Genre")]
        public int GenreId { get; set; }
        //liên kết giữa Movie và Genre
        public virtual Genre? Genre { get; set; }

    }
}
