using System.ComponentModel;
using WebServiceTest.ViewModels;
using Xamarin.Forms;

namespace WebServiceTest.Views
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