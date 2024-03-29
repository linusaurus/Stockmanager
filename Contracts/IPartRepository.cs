﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities.Models;
using System.Threading.Tasks;
using Shared.DataTransferObjects;

namespace Contracts
{
    public interface IPartRepository 
    {
        IEnumerable<Part> GetAllParts(bool trackChanges);
        IEnumerable<Part> Search(string[] searchTerm, bool trackChanges);
        Part GetPartById(int id, bool trackChanges);

        Part GetPartBySKU(string sku,bool trackChanges);

        Part? GetDeepPart(int id,bool trackChnages);

        IEnumerable<Part> GetPartsByLocation(int locationID, bool trackChanges);
        void UpdatePart(Part part);

    }
}
