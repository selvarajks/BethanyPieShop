﻿using BethanyPieShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanyPieShop.Interface
{
   public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
