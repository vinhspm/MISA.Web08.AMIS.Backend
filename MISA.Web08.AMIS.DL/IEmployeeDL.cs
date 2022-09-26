﻿using MISA.Web08.AMIS.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Web08.AMIS.DL
{
    public interface IEmployeeDL
    {
        public List<Employee> GetAllEmployees();

        public int InsertEmployee(Employee employee);

        public int UpdateEmployee(Employee employee);
    }
}