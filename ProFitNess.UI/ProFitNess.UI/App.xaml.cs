using System;
using System.IO;
using System.Reflection;
using ProFitNess.BLL.Services;
using ProFitNess.UI.Views;

using Xamarin.Forms;

namespace ProFitNess.UI
{
    public partial class App : Application
    {
        private const string DatabaseName = "ProFitNess.db";

        private static ExerciseTypeService _exerciseTypeService;
        private static ExerciseDescriptionService _exerciseDescriptionService;
        private static ExerciseService _exerciseService;
        private static UserService _userService;

        public static ExerciseTypeService ExerciseTypeService =>
            _exerciseTypeService ?? (
                _exerciseTypeService = new ExerciseTypeService(
                    Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), 
                        DatabaseName)));

        public static ExerciseDescriptionService ExerciseDescriptionService =>
            _exerciseDescriptionService ?? (
                _exerciseDescriptionService = new ExerciseDescriptionService(
                    Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                        DatabaseName)));

        public static ExerciseService ExerciseService =>
            _exerciseService ?? (
                _exerciseService = new ExerciseService(
                    Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                        DatabaseName)));

        public static UserService UserService =>
            _userService ?? (
                _userService = new UserService(
                    Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                        DatabaseName)));

        public App()
        {
            InitializeComponent();
            
            /*string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DatabaseName);

            if (!File.Exists(DatabaseName))
            {
                var assembly = IntrospectionExtensions.GetTypeInfo(typeof(App)).Assembly;
                
                using (Stream stream = assembly.GetManifestResourceStream($"ProFitNess.UI.{DatabaseName}"))
                {
                    using (FileStream fs = new FileStream(dbPath, FileMode.OpenOrCreate))
                    {
                        stream.CopyTo(fs); 
                        fs.Flush();
                    }
                }
            }*/

            MainPage = new NavigationPage(new LoginPage());
        }
    }
}
