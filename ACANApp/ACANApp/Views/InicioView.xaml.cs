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
    public partial class InicioView : ContentPage
    {
        /*
         * Falta:   - Banner superior móvel (carousel??)
         *          - ícones com links para redes sociais
         */
        public InicioView()
        {
            InitializeComponent();
        }
    }
}