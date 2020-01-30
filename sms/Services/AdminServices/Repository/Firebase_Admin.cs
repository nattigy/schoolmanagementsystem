using System;
using System.Collections.Generic;
using System.Windows;
using FireSharp;
using FireSharp.Interfaces;
using FireSharp.Response;
using sms.Models;
using sms.Utils;
using Task = System.Threading.Tasks.Task;

namespace sms.Services.AdminServices.Repository
{
    public class FirebaseAdmin : IAdminRepository
    {
        private readonly IFirebaseClient _client;
        private FirebaseResponse _firebaseResponse;

        public FirebaseAdmin(IFirebaseConfig config)
        {
            _client = new FirebaseClient(config);
        }

        public async Task AddStudent(Student newStudent)
        {
            if (ConnectionUtil.CheckConnection())
            {
                _firebaseResponse = await _client.GetAsync("Student/" + newStudent.UserName);
                var foundStudent = _firebaseResponse.ResultAs<Student>();
                if (foundStudent == null)
                    await _client.SetAsync("Admin/" + newStudent.UserName, newStudent);
                else
                    MessageBox.Show("Username taken");
            }
            else
            {
                MessageBox.Show("Connection error");
            }
        }

        public async Task AddTeacher(Teacher newTeacher)
        {
            if (ConnectionUtil.CheckConnection())
            {
                _firebaseResponse = await _client.GetAsync("Teacher/" + newTeacher.UserName);
                var foundTeacher = _firebaseResponse.ResultAs<Teacher>();
                if (foundTeacher == null)
                {
                    var response = await _client.SetAsync("Admin/" + newTeacher.UserName, newTeacher);
                }
                else
                {
                    MessageBox.Show("Username taken");
                }
            }
            else
            {
                MessageBox.Show("Connection error");
            }
        }

        public List<Student> StudentsList()
        {
            throw new NotImplementedException();
        }

        public List<Teacher> TeachersList()
        {
            throw new NotImplementedException();
        }

        public void DeleteStudent(string studentId)
        {
            throw new NotImplementedException();
        }

        public void DeleteTeacher(string teacherId)
        {
            throw new NotImplementedException();
        }
    }
}