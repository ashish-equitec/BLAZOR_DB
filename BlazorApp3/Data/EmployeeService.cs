using BlazorApp3.Models;
using BlazorApp3.Pages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorApp3.Data
{
    public class EmployeeService
    {
        private readonly CRUDOPERATIONContext _dbConnection;

        public EmployeeService(CRUDOPERATIONContext dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<List<EmployeeViewResult>> ExecuteStoredProcedureAsync()
        {
            return await _dbConnection.Procedures.EmployeeViewAsync();
        }
    }
}
