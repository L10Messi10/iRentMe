using iRentMe.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace iRentMe.Views
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