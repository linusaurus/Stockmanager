﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Job
    {
        public Job()
        {
            Product = new HashSet<Product>();
            PurchaseOrder = new HashSet<PurchaseOrder>();
        }

        public int jobID { get; set; }
        public int? company_id { get; set; }
        public int? project_id { get; set; }
        public int? structurelevel { get; set; }
        public string jobname { get; set; }
        public int? jobnumber { get; set; }
        public string jobdesc { get; set; }
        public int? leftNode { get; set; }
        public int? rightnode { get; set; }
        public int? ParentID { get; set; }
        public bool? Retired { get; set; }
        public int? Manager { get; set; }
        public bool? Visible { get; set; }
        public DateTime? start_ts { get; set; }

        public virtual ICollection<Product> Product { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrder { get; set; }
    }
}