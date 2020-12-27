using System.Collections.Generic;
using System.Linq;
using ProFitNess.DAL.Entities;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProFitNess.UI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExercisesListPage : ContentPage
    {
        public ExercisesListPage(IEnumerable<Exercise> exercises)
        {
            InitializeComponent();

            ExerciseDescriptions.ItemsSource = exercises.Select(e => e.Name);
        }

        public void ExerciseDescriptions_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var exercise = App.ExerciseService.GetByName(e.Item.ToString());

            Navigation.PushAsync(new ExercisePage(exercise));
        }
    }
}