using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NotasAPI.Modules
{
    public class Context: DbContext
    {
        public Context ( DbContextOptions<Context> options):base(options){


        }
        public DbSet<Student> Students {get;set;}
    }
}