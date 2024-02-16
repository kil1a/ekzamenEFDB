using ConsoleApp2.DataBaseSTO.TablesBd;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.DataBase
{
    internal class STODataBase:DbContext

    {
        public DbSet<BillSTO> Bill { get; set; }
        public DbSet<CarsSTO> Car { get; set; }
        public DbSet<OrdersSTO> OrdersTable { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionStringBuilder = new SqliteConnectionStringBuilder()
                {
                    DataSource = "STOAuto.sqlite"
                };
                var connectionString = connectionStringBuilder.ToString();
                var connection = new SqliteConnection(connectionString);

                optionsBuilder.UseSqlite(connection);
            }


        }
       


    }

}



















