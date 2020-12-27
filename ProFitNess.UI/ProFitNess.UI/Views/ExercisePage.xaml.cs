using ProFitNess.DAL.Entities;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProFitNess.UI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExercisePage : ContentPage
    {
        public ExercisePage(Exercise exercise)
        {
            InitializeComponent();

            ExerciseName.Text = $"Name: {exercise.Name}";
            ExerciseImage.Source = exercise.ImagePath;
            ExerciseCalories.Text = $"Calories for 15 minutes: {exercise.Calories}";
            ExerciseDescription.Text =
                "Description: while inhaling, pulling the pelvis back, bend your knees to a right angle. As you exhale, return to the starting position";
        }
    }
}