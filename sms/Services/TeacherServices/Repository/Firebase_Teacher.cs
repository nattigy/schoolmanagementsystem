using System;
using FireSharp;
using FireSharp.Interfaces;
using FireSharp.Response;
using sms.Models;

namespace sms.Services.TeacherServices.Repository
{
    public class FirebaseTeacher : ITeacherRepository
    {
        private readonly IFirebaseClient _client;
        private FirebaseResponse _firebaseResponse;

        public FirebaseTeacher(IFirebaseConfig config)
        {
            _client = new FirebaseClient(config);
        }

        public void ReportGrade(Result newResult, string studentId)
        {
            throw new NotImplementedException();
        }
    }
}