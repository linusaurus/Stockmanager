﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class WorkOrder
    {
        public int WorkOrderID { get; set; }
        public int? ProjectID { get; set; }
        public DateTime? WorkOrderDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual WorkOrderRouting WorkOrderNavigation { get; set; }
    }
}