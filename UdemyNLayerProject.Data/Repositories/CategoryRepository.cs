﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UdemyNLayerProject.Core.Models;
using UdemyNLayerProject.Core.Repositories;

namespace UdemyNLayerProject.Data.Repositories
{
    class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }

        public CategoryRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<Category> GetWithProductByIdAsync(int categoryId)
        {
            var category = _appDbContext.Categories.Include(x => x.Products).SingleOrDefaultAsync
                (x => x.Id == categoryId);
            return await category;
        }
    }
}
