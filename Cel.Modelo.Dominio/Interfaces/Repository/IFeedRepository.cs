﻿using Cel.Modelo.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cel.Modelo.Dominio.Interfaces.Repository
{
    public interface IfeedRepository : IRepositoryBase<Feed>
    {
        void SalvaFeed(string Feed);
        Task<IEnumerable<Feed>> ListAllAsync();
    }
}
