﻿using PrimeiraAPI.Model;

namespace PrimeiraAPI.Infraestrutura
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ConnectionContext _context = new ConnectionContext();

        public void Add(Employee employee)
        {
            _context.employees
            //_context.Employees.Add(employee);
            _context.ToString();
        }

        public List<Employee> Get()
        {
            throw new NotImplementedException();
        }
    }
}
