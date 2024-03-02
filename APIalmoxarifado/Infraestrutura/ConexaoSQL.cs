using APIalmoxarifado.Model;
using APIalmoxarifado.Model.Descrição;
using Microsoft.EntityFrameworkCore;

namespace APIalmoxarifado.Infraestrutura
{
    public class ConexaoSQL : DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
            =>
              optionBuilder.UseSqlServer(
                  @"Server=PC03LAB2038\SENAI;" +
                  "Database=dbAlmoxarifado;" +
                  "User id=sa;" +
                  "Password=senai.123"


              );

        public DbSet<Produto> Produto { get; set; }

        public DbSet<Categoria> Categoria { get; set; }

        public DbSet<Departamento> Departamento { get; set; }


    }
}
