using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MvcMovie.Models
{
    public class Movies
    {
        //Properties make use of datatype and validation attributes built into DataAnnotations namespace
        public int Id { get; set; }

        [Required, StringLength(60, MinimumLength = 3)] //listing attributes together for clean code
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)] //DataType attribute used for appropriate formatting
        public DateTime ReleaseDate { get; set; }

        [Required, StringLength(30), RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string Genre { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2")]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")] //first char must be uppercase letter, subsequent can be char and num
        [StringLength(5)]
        [Required]
        public string Rating { get; set; }

    }
}
