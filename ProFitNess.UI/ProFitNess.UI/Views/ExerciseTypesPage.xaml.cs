using System.Collections.Generic;
using System.Linq;
using ProFitNess.DAL;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProFitNess.UI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExerciseTypesPage : ContentPage
    {
        private IEnumerable<ExerciseType> _exerciseTypes;

        public ExerciseTypesPage()
        {
            InitializeComponent();

            _exerciseTypes = App.ExerciseTypeService.GetAll();

            ExerciseTypes.ItemsSource = _exerciseTypes.Select(et => et.Name);
        }

        private void ExerciseTypes_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var exerciseTypeId = _exerciseTypes.Where(ex => ex.Name == e.Item.ToString()).Select(ex => ex.Id).FirstOrDefault();
            var exercisesList = App.ExerciseService.GetNameByTypeId(exerciseTypeId);

            Navigation.PushAsync(new ExercisesListPage(exercisesList));
        }
    }
}