using sms.Models;

namespace sms.Services.TeacherServices
{
    public interface ITeacherUsecase
    {
        void ReportGrade(Result newResult, string studentId);
    }
}