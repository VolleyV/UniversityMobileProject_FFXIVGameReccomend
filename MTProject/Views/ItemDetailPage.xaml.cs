using MTProject.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MTProject.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}