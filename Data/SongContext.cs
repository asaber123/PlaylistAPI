using Microsoft.EntityFrameworkCore;
using PlaylistAPI.Models;
namespace PlaylistAPI.Data{
    //Unherrit from db context 
    public class SongContext : DbContext{
        public SongContext(DbContextOptions<SongContext> options) : base(options)
        {

        }
        public DbSet<Song> Songs {get; set;}
    }
}