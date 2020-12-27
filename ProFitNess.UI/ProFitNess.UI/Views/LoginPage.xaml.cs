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
            var user = App.UserService.GetByMailAndPassword(UserMail.Text, UserPassword.Text);

            if (user != null)
            {
                LoginErrorLabel.IsVisible = false;
                Navigation.PushAsync(new ExerciseTypesPage());
            }
            else
            {
                LoginErrorLabel.IsVisible = true;
            }
        }

        public void RegisterButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegistrationPage());
        }
    }
}