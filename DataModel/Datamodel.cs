using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAcademico.Classes;

namespace SistemaAcademico.DataModel
{
    public class AcademicSystemContext : DbContext
    {
        public DbSet<User> Usuarios { get; set; }
    }
}
