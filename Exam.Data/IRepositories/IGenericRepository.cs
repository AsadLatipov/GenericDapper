using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Data.IRepositories
{
    public interface IGenericRepository : IDisposable
    {
        Task<T> CreateASync<T>(string query, DynamicParameters pars, CommandType cmd);
        Task<T> GetAsync<T>(string query, DynamicParameters pars, CommandType cmd);
        Task<IEnumerable<T>> GetAllAsync<T>(string query, DynamicParameters pars, CommandType cmd);
        Task<T> UpdateAsync<T>(string query, DynamicParameters pars, CommandType cmd);
        Task<T> DeleteASync<T>(string query, DynamicParameters pars, CommandType cmd);
        DbConnection GetConnection();


    }
}
