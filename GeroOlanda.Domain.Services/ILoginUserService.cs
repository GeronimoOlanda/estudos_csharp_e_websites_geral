﻿using GeroOlanda.Domain.Entities;
using GeroOlanda.Domain.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeroOlanda.Domain.Services
{
    public interface ILoginUserService
    {

        UserLogin CadastrarDadosLogin(UserLogin userLogin);


    }
}
