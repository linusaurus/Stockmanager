﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Claim
    {
        public int ClaimID { get; set; }
        public int? SupplierID { get; set; }
        public int? OrderNum { get; set; }
        public string SupplierOrder { get; set; }
        public DateTime? ClaimDate { get; set; }
        public int? EmployeeID { get; set; }
    }
}