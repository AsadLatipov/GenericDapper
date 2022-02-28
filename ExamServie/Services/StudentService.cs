using Dapper;
using Exam.Data.Repositories;
using Exam.Domain.Models;
using ExamServie.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamServie.Services
{
    public class StudentService : IStundentService
    {
        GenericRepository generic = new GenericRepository();
        public async Task<Student> CreateASync(string query, DynamicParameters pars, CommandType cmd)
        {
            return await generic.CreateASync<Student>(query, pars, cmd);
        }

        public async Task<Student> DeleteASync(string query, DynamicParameters pars, CommandType cmd)
        {
            return await generic.DeleteASync<Student>(query, pars, cmd);

        }

        public async Task<IEnumerable<Student>> GetAllAsync(string query, DynamicParameters pars, CommandType cmd)
        {
            return await generic.GetAllAsync<Student>(query, pars, cmd);
        }

        public async Task<Student> GetAsync(string query, DynamicParameters pars, CommandType cmd)
        {
            return await generic.GetAsync<Student>(query, pars, cmd);
        }

        public DbConnection GetConnection()
        {
            throw new NotImplementedException();
        }

        public async Task<Student> UpdateAsync(string query, DynamicParameters pars, CommandType cmd)
        {
            return await generic.UpdateAsync<Student>(query, pars, cmd);
        }
    }
}
