using sms.Models;

namespace sms.Services.TeacherServices
{
    public interface ITeacherRepository
    {
        void ReportGrade(Result newResult, string studentId);
    }
}