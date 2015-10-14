using Echo_PersistentLayer.Entities.Util;
using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Common;
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

        public T2SmallContext(DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {


        }

        public T2SmallContext()
            : base()
        {
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.Entity<DebugEntity>().MapToStoredProcedures();
        //}
    }
}
