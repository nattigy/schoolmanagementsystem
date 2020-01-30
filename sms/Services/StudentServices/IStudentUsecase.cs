using System.Collections.Generic;
using sms.Models;

namespace sms.Services.StudentServices
{
    public interface IStudentUsecase
    {
        List<Result> ViewResults(string studentId);
    }
}