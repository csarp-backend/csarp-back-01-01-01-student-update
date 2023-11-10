using Kreata.Backend.Datas.Entities;

namespace Kreata.Backend.Repos
{
    public interface IStudentRepo
    {
        List<Student> GetAll();
        Student? GetBy(Guid id);
    }
}
