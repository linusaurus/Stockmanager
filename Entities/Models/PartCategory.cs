﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class PartCategory
    {
        public PartCategory()
        {
            PartTypes = new HashSet<PartTypes>();
        }

        public int PartCategoryID { get; set; }
        public string PartCategoryName { get; set; }

        public virtual ICollection<PartTypes> PartTypes { get; set; }
    }
}