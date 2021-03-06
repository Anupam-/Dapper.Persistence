﻿using Dapper.Persistence;

namespace Example.Domain.Customers.Repository.SQLite
{
    internal class SqliteCustomerRepository : DbRepository, ICustomerRepository
    {
        public SqliteCustomerRepository(IDbContext context) : base(context)
        {
        }

        public void Insert(Customer customer)
        {
            Context.Execute("INSERT INTO Customers");
        }
    }
}
