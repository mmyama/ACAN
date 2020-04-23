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
    public partial class CulturaView : TabbedPage
    {
        public CulturaView()
        {
            InitializeComponent();

            this.BindingContext = new CulturaViewModel();
        }
    }
}