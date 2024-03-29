﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Location
    {
        public Location()
        {
            Part = new HashSet<Part>();
        }
        [System.ComponentModel.DataAnnotations.Key]
        public int LocationID { get; set; }
        public string LocationName { get; set; }
        public string Area { get; set; }
        public byte[] Photo { get; set; }
        public int? Aisle { get; set; }
        public string Row { get; set; }

        public virtual ICollection<Part> Part { get; set; }
    }
}