using System.Collections.Generic;
using sms.Models;

namespace sms.Services.StudentServices.Usecase
{
    public class StudentUsecase : IStudentUsecase
    {
        private readonly IStudentRepository _repository;

        public StudentUsecase(IStudentRepository repository)
        {
            _repository = repository;
        }

        public List<Result> ViewResults(string studentId)
        {
            return _repository.ViewResults(studentId);
        }
    }
}