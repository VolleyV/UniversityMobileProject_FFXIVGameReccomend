using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MTProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            DLC_more.Clicked += DLC_more_Clicked;
            class_more.Clicked += Class_more_Clicked;
            playBtn.Clicked += PlayBtn_Clicked;
        }

        async private void PlayBtn_Clicked(object sender, EventArgs e)
        {
            var tp = new LoginPage();
            await Navigation.PushAsync(tp);
        }

        async  private void Class_more_Clicked(object sender, EventArgs e)
        {
            var tp = new TabbedPage();
            tp.Children.Add(new TankPage());
            tp.Children.Add(new DPSPage());
            tp.Children.Add(new HealerPage());
            await Navigation.PushAsync(tp);

        }

        async private void DLC_more_Clicked(object sender, EventArgs e)
        {
            var tp = new ExpansionPage();
            await Navigation.PushAsync(tp);
            

        }
    }
}