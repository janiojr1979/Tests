﻿using HungryPizza.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HungryPizza.Domain.Core.Interfaces.Repositories
{
    public interface IRepositoryPizza 
    {
        Task<IEnumerable<Pizza>> GetAll();

        Task<Pizza> Get(Guid id);

        Task<bool> Add(Pizza pizza);

        Task<bool> Update(Pizza pizza);

        Task<bool> Delete(Guid id);
    }
}
