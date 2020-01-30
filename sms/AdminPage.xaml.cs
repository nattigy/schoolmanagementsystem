using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using sms.Services.AdminServices;
using sms.Services.AdminServices.Repository;
using sms.Services.AdminServices.Usecase;

namespace sms
{
    public partial class AdminPage
    {
        private IAdminUsecase _adminUsecase;

        public AdminPage()
        {
            InitializeComponent();

            IAdminRepository adminRepo = new FirebaseAdmin(FirebaseConfig.FirebaseConfig.Config);
            _adminUsecase = new AdminUsecase(adminRepo);
        }

        private void ButtonPower_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var index = ListViewMenu.SelectedIndex;
            MoveCursorMenu(index);
        }

        private void MoveCursorMenu(int index)
        {
            TransitioningContentSlide.OnApplyTemplate();
            GridCursor.Margin = new Thickness(0, 100 + 60 * index, 0, 0);
        }
    }
}