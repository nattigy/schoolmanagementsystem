using sms.Models;

namespace sms.Services.TeacherServices.Usecase
{
    public class TeacherUsecase : ITeacherUsecase
    {
        private readonly ITeacherRepository _repository;

        public TeacherUsecase(ITeacherRepository repository)
        {
            _repository = repository;
        }

        public void ReportGrade(Result newResult, string studentId)
        {
            _repository.ReportGrade(newResult, studentId);
        }
    }
}