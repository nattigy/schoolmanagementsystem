using System.Windows;
using sms.Services.TeacherServices;
using sms.Services.TeacherServices.Repository;
using sms.Services.TeacherServices.Usecase;

namespace sms
{
    public partial class TeacherPage : Window
    {
        private ITeacherUsecase _teacherUsecase;

        public TeacherPage()
        {
            InitializeComponent();

            ITeacherRepository teacherRepo = new FirebaseTeacher(FirebaseConfig.FirebaseConfig.Config);
            _teacherUsecase = new TeacherUsecase(teacherRepo);
        }
    }
}