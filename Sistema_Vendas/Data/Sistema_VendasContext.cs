using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sistema_Vendas.Models;

namespace Sistema_Vendas.Data
{
    public class Sistema_VendasContext : DbContext
    {
        public Sistema_VendasContext (DbContextOptions<Sistema_VendasContext> options)
            : base(options)
        {
        }

        public DbSet<Sistema_Vendas.Models.Departamento> Departamento { get; set; } = default!;
    }
}
