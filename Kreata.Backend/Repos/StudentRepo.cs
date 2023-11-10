using Kreata.Backend.Context;
using Kreata.Backend.Datas.Entities;

namespace Kreata.Backend.Repos
{
    public class StudentRepo : IStudentRepo
    {
        private readonly KretaContext _dbContext;

        public StudentRepo(KretaContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Student? GetBy(Guid id)
        {
            return _dbContext.Students.FirstOrDefault(s => s.Id == id);
        }

        public List<Student> GetAll()
        {
            return _dbContext.Students.ToList();
        }
    }
}
