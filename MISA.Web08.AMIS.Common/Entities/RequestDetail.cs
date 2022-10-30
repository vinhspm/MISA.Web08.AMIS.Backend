﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Web08.AMIS.Common.Entities
{
    public class RequestDetail
    {
        [PrimaryKey]
        public Guid RequestDetailId { get; set; }

        public Guid? RequestId { get; set; } 

        public string? EmployeeCode { get; set; }

        public string? FullName { get; set; }

        public string? PositionName { get; set; }

        public string? DepartmentName { get; set; }

        public string? PhoneNumber { get; set; }

        public string? Email { get; set; }
    }
}
