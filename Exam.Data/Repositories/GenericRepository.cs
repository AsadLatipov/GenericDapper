using Dapper;
using Exam.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Data.Repositories
{
    public class GenericRepository : IGenericRepository
    {
        public async Task<T> CreateASync<T>(string query, DynamicParameters pars=null, CommandType cmd = CommandType.Text)
        {
            DbConnection db = GetConnection();
            var res = await db.QueryAsync<T>(query, param: pars, commandType: cmd);
            return res.FirstOrDefault();
        }

        public async Task<T> DeleteASync<T>(string query, DynamicParameters pars=null, CommandType cmd = CommandType.Text)
        {
            DbConnection db = GetConnection();
            var res = await db.QueryAsync<T>(query, param: pars, commandType: cmd);
            return res.FirstOrDefault();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetAllAsync<T>(string query, DynamicParameters pars=null, CommandType cmd = CommandType.Text)
        {
            DbConnection db = GetConnection();
            var res = await db.QueryAsync<T>(query, param: pars, commandType: cmd);
            return res;
        }

        public async Task<T> GetAsync<T>(string query, DynamicParameters pars=null, CommandType cmd = CommandType.Text)
        {
            DbConnection db = GetConnection();
            var res = await db.QueryAsync<T>(query, param: pars, commandType: cmd);
            return res.FirstOrDefault();
        }

        public DbConnection GetConnection()
        {
            return new SqlConnection("server=(LocalDB)\\MSSQLocalDB; Database=Asad; Trusted_Connection=True;");
        }

        public async Task<T> UpdateAsync<T>(string query, DynamicParameters pars=null, CommandType cmd = CommandType.Text)
        {
            DbConnection db = GetConnection();
            var res = await db.QueryAsync<T>(query, param: pars, commandType: cmd);
            return res.FirstOrDefault();
        }
    }
}
