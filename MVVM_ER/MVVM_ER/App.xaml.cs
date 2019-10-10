using MVVM_ER.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MVVM_ER
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var inicio = new NavigationPage(new InicioView());

            MainPage = inicio;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
