using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecnPoint.Infra
{
    public class UsuariosAdd
    {
        public bool Add(Usuario usuario)
        {
            using var conn = new DbConnection();

            string query = @"INSERT INTO public.usuario(
	                        nome, email, senha)
	                        VALUES (@nome, @email, @senha);";

            var result = conn.Connection.Execute(sql: query, param: usuario);

            return result == 1;
        }
    }
}
