using System.ComponentModel.DataAnnotations;

namespace MovieDemoapp.Models
{
    public class Movie
    {

        
            public int Id { get; set; }
            public string? Title { get; set; }
            [DataType(DataType.Date)]
            public DateTime ReleaseDate { get; set; }
            public string? Genre { get; set; }//question mark herre refers that  it can take null value also
            public decimal Price { get; set; }
    }
}

