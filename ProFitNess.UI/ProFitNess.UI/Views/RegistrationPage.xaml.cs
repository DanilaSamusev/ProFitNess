using System;
using ProFitNess.DAL.Entities;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProFitNess.UI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        public void RegistrationButton_Clicked(object sender, EventArgs e)
        {
            var user = new User()
            {
                Name = UserName.Text,
                Password = UserPassword.Text,
                Sex = UserSex.Text,
                Mail = UserMail.Text
            };

            if (!string.IsNullOrWhiteSpace(user.Name) &&
                !string.IsNullOrWhiteSpace(user.Mail) &&
                !string.IsNullOrWhiteSpace(user.Sex) &&
                !string.IsNullOrWhiteSpace(user.Password))
            {
                App.UserService.Save(user);
                RegistrationErrorLabel.IsVisible = false;
                Navigation.PushAsync(new ExerciseTypesPage());
            }
            else
            {
                RegistrationErrorLabel.IsVisible = true;
            }
        }
    }
}