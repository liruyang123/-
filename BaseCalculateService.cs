﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager
{
    public abstract class BaseCalculateService
    {
        public abstract string CalcuteMoney(Employee user);
    }
}