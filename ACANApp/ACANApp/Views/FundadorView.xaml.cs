using ACANApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ACANApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FundadorView : TabbedPage
    {
        public FundadorView()
        {
            InitializeComponent();
            this.BindingContext = new FundadorViewModel();
        }
    }
}