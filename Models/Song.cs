using System.ComponentModel.DataAnnotations;

//This is the model that is going to also be the structure of the database. 
namespace PlaylistAPI.Models{
    public class Song{

       
        public int? Id { get; set; }

        [Required]
        public string? Artist { get; set; }
        [Required]
        public string? SongTitle { get; set; }
        [Required]
        public string? Length { get; set; }
        public string? Category { get; set; }
    }
    
}