﻿using CoreBusiness.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasosDeUso.Interface
{
    public interface IAdicionarObsUseCase
    {
        Task ExecutaAsync(Obs obs);
    }
}
