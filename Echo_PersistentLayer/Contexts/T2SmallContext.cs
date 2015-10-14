using Echo_PersistentLayer.Entities.Debug;
using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo_PersistentLayer.Contexts
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    class T2SmallContext : DbContext
    {

        public DbSet<DebugEntity> DebugEntities{ get; set; }

        public T2SmallContext(String connectionString)
            : base(connectionString)
        {


        }

        public T2SmallContext()
        {


        }
    }
}
