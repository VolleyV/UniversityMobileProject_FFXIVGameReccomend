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
	public partial class RegisterPage : ContentPage
	{
		public RegisterPage ()
		{
			InitializeComponent ();
            submitBtn.Clicked += SubmitBtn_Clicked;
            cancelBtn.Clicked += CancelBtn_Clicked;
		}

        async private void CancelBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync ();
        }

        private void SubmitBtn_Clicked(object sender, EventArgs e)
        {
			email.Text = "";
			username.Text = "";
			pass.Text = "";
        }
    }
}