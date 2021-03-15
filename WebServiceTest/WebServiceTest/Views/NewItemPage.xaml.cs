using System;
using System.Collections.Generic;
using System.ComponentModel;
using WebServiceTest.Models;
using WebServiceTest.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WebServiceTest.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}