using System;
using System.Resources;
using System.Globalization;
using System.Reflection;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProFitNess.UI.Localization
{
    [ContentProperty("Text")]
    public class TranslateExtension : IMarkupExtension
    {
        private readonly CultureInfo _cultureInfo;
        private const string ResourcePath = "ProFitNess.UI.Localization.Resource";

        public TranslateExtension()
        {
            _cultureInfo = new CultureInfo("ru");
        }

        public string Text { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Text == null)
            {
                return string.Empty;
            }

            var resourceManager = new ResourceManager(ResourcePath, typeof(TranslateExtension).GetTypeInfo().Assembly);
            var translation = resourceManager.GetString(Text, _cultureInfo) ?? Text;

            return translation;
        }
    }
}
