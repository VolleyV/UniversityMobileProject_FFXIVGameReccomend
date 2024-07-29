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
    public partial class StormbloodPage : ContentPage
    {
        public StormbloodPage()
        {
            InitializeComponent();
            trailerBtn.Clicked += TrailerBtn_Clicked;
        }

        async private void TrailerBtn_Clicked(object sender, EventArgs e)
        {
            var tp = new StormbloodTrailer();
            await Navigation.PushAsync(tp);
        }
    }
}