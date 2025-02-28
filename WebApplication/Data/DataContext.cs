using Microsoft.EntityFrameworkCore;
using WebApplication.Models;

namespace WebApplication.Data
{
    public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
    {

        // Veritabanındaki tabloları temsil eder yapılacaklar modeli ile works adında tablo oluşturduk
        public DbSet<Yapılacaklar> Works { get; set; }
    }
}

