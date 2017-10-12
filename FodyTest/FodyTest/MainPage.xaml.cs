using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyChanged;
using Xamarin.Forms;
using System.Threading;
using FodyTest.PCL;

namespace FodyTest
{
    [AddINotifyPropertyChangedInterface]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BindingContext = new FodyTestVm();
        }
    }
}
