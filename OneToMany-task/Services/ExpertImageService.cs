using System;
using Microsoft.EntityFrameworkCore;
using OneToMany_task.Data;
using OneToMany_task.Models;
using OneToMany_task.Services.Interfaces;

namespace OneToMany_task.Services
{
    public class ExpertImageService : IExpertImageService
    {
        private readonly AppDbContext _context;

        public ExpertImageService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<ExpertImage>> GetAllAsync()
        {
            return await _context.ExpertImages.Where(m => !m.SoftDeleted).ToListAsync();
        }
    }
}

