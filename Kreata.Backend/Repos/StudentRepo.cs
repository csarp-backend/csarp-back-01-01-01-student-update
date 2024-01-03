﻿using Kreata.Backend.Context;
using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Datas.Responses;
using Microsoft.EntityFrameworkCore;

namespace Kreata.Backend.Repos
{
    public class StudentRepo : IStudentRepo
    {
        private readonly KretaInMemoryContext _dbContext;

        public StudentRepo(KretaInMemoryContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Student?> GetBy(Guid id)
        {
            return await _dbContext.Students.FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task<List<Student>> GetAll()
        {
            return await _dbContext.Students.ToListAsync();
        }

        public Task<ControllerResponse> UpdateStudentAsync(Student student)
        {
            _dbContext.ChangeTracker.Clear();
            _dbContext.Entry(student).State = EntityState.Modified;
        }
    }
}
