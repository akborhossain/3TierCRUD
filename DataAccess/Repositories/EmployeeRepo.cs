using Business.DTOs;
using Business.Entities;
using DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    internal class EmployeeRepo: IEmployee
    {
        private readonly ApplicationDbContext dbContext;

        public EmployeeRepo( ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Task<ServiceResponse> AddAsync(Employee employee) { 

             
        
         throw new NotImplementedException();
        }
        public Task<ServiceResponse> UpdateAsync(Employee employee)
        {

            throw new NotImplementedException();
        }
        public Task<ServiceResponse> DeleteAsync(int id)
        {

            throw new NotImplementedException();
        }

        public Task<List<Employee>> GetAsync() { 
        
        throw new NotImplementedException();
        }

        public Task<Employee> GetByIdAsync(int id) { 
            throw new NotImplementedException(); 
        }
    }
}
