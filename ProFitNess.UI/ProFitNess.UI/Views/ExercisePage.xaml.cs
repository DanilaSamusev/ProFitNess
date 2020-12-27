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

            ExerciseName.Text = $"Название: {exercise.Name}";
            ExerciseImage.Source = exercise.ImagePath;
            ExerciseCalories.Text = $"Калорий за 15 минут: {exercise.Calories}";
            ExerciseDescription.Text =
                "Description: while inhaling, pulling the pelvis back, bend your knees to a right angle. As you exhale, return to the starting position";
        }
    }
}