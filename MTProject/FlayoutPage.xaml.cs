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
	public partial class FlayoutPage : ContentPage
	{
		public FlayoutPage ()
		{
			InitializeComponent ();
            jobsBtn.Clicked += JobsBtn_Clicked;
            homeBtn.Clicked += HomeBtn_Clicked;
            DLCBtn.Clicked += DLCBtn_Clicked;
		}

        private void DLCBtn_Clicked(object sender, EventArgs e)
        {
            var mp = Parent as FlyoutPage;
            mp.Detail = new NavigationPage(new ExpansionPage());
            mp.IsPresented = false;
        }

        private void HomeBtn_Clicked(object sender, EventArgs e)
        {
            var mp = Parent as FlyoutPage;
            mp.Detail = new NavigationPage(new MainPage());
            mp.IsPresented = false;
        }

        private void JobsBtn_Clicked(object sender, EventArgs e)
        {
            var tp = new TabbedPage();
            tp.Children.Add(new TankPage());
            tp.Children.Add(new DPSPage());
            tp.Children.Add(new HealerPage());
            var mp = Parent as FlyoutPage;
            mp.Detail = new NavigationPage(tp);
            mp.IsPresented = false;
        }
    }
}