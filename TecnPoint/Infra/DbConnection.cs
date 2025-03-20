using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecnPoint.Infra
{
    public class DbConnection : IDisposable
    {
        public NpgsqlConnection Connection { get; set; }
        
        public DbConnection()
        {
            Connection = new NpgsqlConnection("Host=localhost;Port=5432;Database=supt;User Id=postgres;Password=L@lpkbr123;");
            Connection.Open();
        }

        public void Dispose()
        {
            Connection.Dispose();
        }
    }
}
