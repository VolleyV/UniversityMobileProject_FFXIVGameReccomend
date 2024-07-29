﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MTProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShadowbringerPage : ContentPage
    {
        public ShadowbringerPage()
        {
            InitializeComponent();
            trailerBtn.Clicked += TrailerBtn_Clicked;
        }

        async private void TrailerBtn_Clicked(object sender, EventArgs e)
        {
            var tp = new ShadowbringerTrailer();
            await Navigation.PushAsync(tp);
        }
    }
}