using Microsoft.EntityFrameworkCore;
using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Data
{
    internal class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS; Initial Catalog=BDBiblioteca; Integrated Security=SSPI");
        }

        public DbSet<Livro> TBLivro { get; set; }
    }
}
