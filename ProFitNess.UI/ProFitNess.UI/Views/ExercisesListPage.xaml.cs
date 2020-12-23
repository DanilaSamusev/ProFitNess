using System.Linq;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProFitNess.UI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExercisesListPage : ContentPage
    {
        public ExercisesListPage()
        {
            InitializeComponent();

            ExerciseDescriptions.ItemsSource = App.ExerciseDescriptionService.GetAll().Select(ed => ed.Name);
        }
        public void ExerciseDescriptions_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Navigation.PushAsync(new ExercisePage());
        }
    }
}