using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProFitNess.UI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        public void LoginButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HomePage());
        }

        public void RegisterButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegistrationPage());
        }
    }
}