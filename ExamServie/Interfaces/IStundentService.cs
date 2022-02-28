using Dapper;
using Exam.Data.IRepositories;
using Exam.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamServie.Interfaces
{
    public interface IStundentService 
    {
        public Task<Student> CreateASync(string query, DynamicParameters pars, CommandType cmd);

        public Task<Student> DeleteASync(string query, DynamicParameters pars, CommandType cmd);

        public Task<IEnumerable<Student>> GetAllAsync(string query, DynamicParameters pars, CommandType cmd);

        public Task<Student> GetAsync(string query, DynamicParameters pars, CommandType cmd);

        public Task<Student> UpdateAsync(string query, DynamicParameters pars, CommandType cmd);

        public DbConnection GetConnection();

    }
}
