using System.Collections.Generic;
using sms.Models;
using Task = System.Threading.Tasks.Task;

namespace sms.Services.AdminServices
{
    public interface IAdminRepository
    {
        Task AddStudent(Student newStudent);
        Task AddTeacher(Teacher newTeacher);
        List<Student> StudentsList();
        List<Teacher> TeachersList();
        void DeleteStudent(string studentId);
        void DeleteTeacher(string teacherId);
    }
}