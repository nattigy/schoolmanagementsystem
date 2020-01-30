using System;
using System.Collections.Generic;
using FireSharp;
using FireSharp.Interfaces;
using FireSharp.Response;
using sms.Models;

namespace sms.Services.StudentServices.Repository
{
    public class FirebaseStudent : IStudentRepository
    {
        private readonly IFirebaseClient _client;
        private FirebaseResponse _firebaseResponse;

        public FirebaseStudent(IFirebaseConfig config)
        {
            _client = new FirebaseClient(config);
        }

        public List<Result> ViewResults(string studentId)
        {
            throw new NotImplementedException();
        }
    }
}