using System.Linq;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProFitNess.UI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExerciseTypesPage : ContentPage
    {
        public ExerciseTypesPage()
        {
            InitializeComponent();

            ExerciseTypes.ItemsSource = App.ExerciseTypeService.GetAll().Select(et => et.Name);
        }

        private void ExerciseTypes_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Navigation.PushAsync(new ExercisesListPage());
        }
    }
}