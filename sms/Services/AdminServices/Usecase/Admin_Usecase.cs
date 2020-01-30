using System.Collections.Generic;
using sms.Models;
using Task = System.Threading.Tasks.Task;

namespace sms.Services.AdminServices.Usecase
{
    public class AdminUsecase : IAdminUsecase
    {
        private readonly IAdminRepository _repository;

        public AdminUsecase(IAdminRepository repository)
        {
            _repository = repository;
        }

        public async Task AddStudent(Student newStudent)
        {
            await _repository.AddStudent(newStudent);
        }

        public async Task AddTeacher(Teacher newTeacher)
        {
            await _repository.AddTeacher(newTeacher);
        }

        public List<Student> StudentsList()
        {
            return _repository.StudentsList();
        }

        public List<Teacher> TeachersList()
        {
            return _repository.TeachersList();
        }

        public void DeleteStudent(string studentId)
        {
            _repository.DeleteStudent(studentId);
        }

        public void DeleteTeacher(string teacherId)
        {
            _repository.DeleteTeacher(teacherId);
        }
    }
}