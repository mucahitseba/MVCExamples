using MVC_Examples.DAL.MyEntities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Examples.DAL
{
    public class MVCExamplesContext:DbContext
    {
        public MVCExamplesContext():base("name=MyCon")
        {

        }
        public DbSet<User> User { get; set; }
    }
}
