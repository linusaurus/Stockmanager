﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Resource
    {
        public int ResourceID { get; set; }
        public int? PartID { get; set; }
        public string ResourceDescription { get; set; }
        public string Createdby { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? Lastmod { get; set; }
        public string FileSize { get; set; }
        public string filesource { get; set; }
        public Guid RowID { get; set; }
        public byte[] ResourceFile { get; set; }

        public virtual Part Part { get; set; }
    }
}