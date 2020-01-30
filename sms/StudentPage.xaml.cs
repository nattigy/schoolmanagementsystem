using System.Windows;
using sms.Services.StudentServices;
using sms.Services.StudentServices.Repository;
using sms.Services.StudentServices.Usecase;

namespace sms
{
    public partial class StudentPage : Window
    {
        private IStudentUsecase _studentUsecase;

        public StudentPage()
        {
            InitializeComponent();

            IStudentRepository studentRepo = new FirebaseStudent(FirebaseConfig.FirebaseConfig.Config);
            _studentUsecase = new StudentUsecase(studentRepo);
        }
    }
}