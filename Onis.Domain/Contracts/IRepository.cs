﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Onis.Domain.Contracts
{
    public interface IRepository
    {
        Task Actualizar(object obj);
    }
}
