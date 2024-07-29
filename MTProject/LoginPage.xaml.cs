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
	public partial class LoginPage : ContentPage
	{
        public LoginPage()
        {
            InitializeComponent();
            submitBtn.Clicked += SubmitBtn_Clicked;
            cancelBtn.Clicked += CancelBtn_Clicked;
            registerBtn.Clicked += RegisterBtn_Clicked;
        }

        async private void CancelBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }

        private void SubmitBtn_Clicked(object sender, EventArgs e)
        {
            username.Text = "";
            pass.Text = "";
        }

        async private void RegisterBtn_Clicked(object sender, EventArgs e)
        {
            var tp = new RegisterPage();
            await Navigation.PushAsync(tp);
        }
    }
}