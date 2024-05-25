using System;
using Microsoft.EntityFrameworkCore;
using OneToMany_task.Data;
using OneToMany_task.Models;
using OneToMany_task.Services.Interfaces;

namespace OneToMany_task.Services
{
    public class ExpertService : IExpertService
    {
        private readonly AppDbContext _context;

        public ExpertService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Expert>> GetAllAsync()
        {
            return await _context.Experts.Where(m => !m.SoftDeleted).ToListAsync();
        }
    }
}

