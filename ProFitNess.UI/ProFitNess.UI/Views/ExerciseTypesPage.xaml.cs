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

            ExerciseTypes.ItemsSource = App.ExerciseTypesTable.GetAll().Select(et => et.Name);
        }
    }
}