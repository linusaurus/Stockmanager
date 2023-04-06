﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Document
    {
        public Document()
        {
            Part = new HashSet<Part>();
        }

        public int DocID { get; set; }
        public string Description { get; set; }
        public string DocumentPath { get; set; }
        public string DocumentView { get; set; }
        public int? PartID { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Creator { get; set; }
        public string Modifier { get; set; }
        public DateTime? DateModified { get; set; }

        public virtual ICollection<Part> Part { get; set; }
    }
}