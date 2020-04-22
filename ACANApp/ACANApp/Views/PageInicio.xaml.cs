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
    public partial class PageInicio : ContentPage
    {
        /*
         * Falta:   - Banner superior móvel
         *          - ícones com links para redes sociais
         */
        public PageInicio()
        {
            InitializeComponent();
        }
    }
}