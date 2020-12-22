using System;
using System.IO;

using ProFitNess.BLL.Services;
using ProFitNess.UI.Views;

using Xamarin.Forms;

namespace ProFitNess.UI
{
    public partial class App : Application
    {
        private const string ExerciseTypesTableName = "ExerciseTypes.db";

        public static ExerciseTypeService _exerciseTypesTable;

        public static ExerciseTypeService ExerciseTypesTable =>
            _exerciseTypesTable ?? (
                _exerciseTypesTable = new ExerciseTypeService(
                    Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                ExerciseTypesTableName)));

        public App()
        {
            InitializeComponent();

            /*var legExerciseType = new ExerciseType() { Name = "Legs" };
            var armExerciseType = new ExerciseType() { Name = "Arms" };
            var headExerciseType = new ExerciseType() { Name = "Head" };

            ExerciseTypesTable.Save(legExerciseType);
            ExerciseTypesTable.Save(armExerciseType);
            ExerciseTypesTable.Save(headExerciseType);*/

            MainPage = new NavigationPage(new LoginPage());
        }
    }
}
