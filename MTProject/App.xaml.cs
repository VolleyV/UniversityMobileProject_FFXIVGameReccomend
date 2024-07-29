using MTProject.Services;
using MTProject.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MTProject
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
           //NavigationPage
            var page1 = new MainPage();
            var np = new NavigationPage(page1);
            //TabbedPage
            var tp = new TabbedPage();
            tp.Children.Add(new TankPage());
            tp.Children.Add(new DPSPage());
            tp.Children.Add(new HealerPage());
            //FlayoutPa
            var fp = new FlyoutPage();
            fp.Flyout = new FlayoutPage();
            fp.Detail = new NavigationPage(new MainPage());
            MainPage = fp;
           

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
