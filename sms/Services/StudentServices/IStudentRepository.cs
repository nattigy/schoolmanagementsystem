using System.Collections.Generic;
using sms.Models;

namespace sms.Services.StudentServices
{
    public interface IStudentRepository
    {
        List<Result> ViewResults(string studentId);
    }
}