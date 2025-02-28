using Microsoft.EntityFrameworkCore;

namespace WebApplication.Models
{
    public class Yapılacaklar
    {
        public int Id { get; set; }
        public required string Gorev { get; set; }
    }
}
