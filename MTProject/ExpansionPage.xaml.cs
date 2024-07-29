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
	public partial class ExpansionPage : ContentPage
	{
		public ExpansionPage ()
		{
			InitializeComponent ();
            ARR.Clicked += ARR_Clicked;
            Heavensward.Clicked += Heavensward_Clicked;
            Stormblood.Clicked += Stormblood_Clicked;
            Shadowbringer.Clicked += Shadowbringer_Clicked;
            Endwalker.Clicked += Endwalker_Clicked;

		}

        async private void Endwalker_Clicked(object sender, EventArgs e)
        {
            var tp = new EndwalkerPage();
            await Navigation.PushAsync(tp);
        }

        async private void Shadowbringer_Clicked(object sender, EventArgs e)
        {
            var tp = new ShadowbringerPage();
            await Navigation.PushAsync(tp);
        }

        async private void Stormblood_Clicked(object sender, EventArgs e)
        {
            var tp = new StormbloodPage();
            await Navigation.PushAsync(tp);
        }

        async private void Heavensward_Clicked(object sender, EventArgs e)
        {
            var tp = new HeavenswardPage();
            await Navigation.PushAsync(tp);
        }

        async private void ARR_Clicked(object sender, EventArgs e)
        {
            var tp = new ARRPage();
            await Navigation.PushAsync(tp);
        }
    }
}