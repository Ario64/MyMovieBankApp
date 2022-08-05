using System.Threading;
using System.Windows;
using MovieWpfApp.Utility;

namespace MyMovieBankApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            PersianCulture culture = new PersianCulture();
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
        }
    }
}
