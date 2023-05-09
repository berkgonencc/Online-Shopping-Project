﻿using MiniShopAPI.Application.Repositories;
using MiniShopAPI.Domain.Entities;
using MiniShopAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShopAPI.Persistence.Repositories
{
    public class CustomerWriteRepository : WriteRepository<Customer>, ICustomerWriteRepository
    {
        public CustomerWriteRepository(MiniShopAPIDbContext context) : base(context)
        {
            
        }
    }
}
