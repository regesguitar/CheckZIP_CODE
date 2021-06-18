using App_CheckZip.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace App_CheckZip.Views
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