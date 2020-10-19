using System;
using System.Collection.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace PRACTICALAB01.Data{
    1 reference 
    public class DatabaseContext: DbContext
    {
        0 reference
        public DatabaseContext(DbContextOption<DatabaseContext> options)
            : base(options)
            {

            }
            0 reference
            public DbSet<PRACTICALAB01.Models.Formulario> Formulario {get; set}
    }

}