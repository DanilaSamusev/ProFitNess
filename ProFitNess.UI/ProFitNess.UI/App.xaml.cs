using ProFitNess.UI.Views;

using Xamarin.Forms;

namespace ProFitNess.UI
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new HomePage());
        }
    }
}
