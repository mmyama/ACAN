using ACANApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACANApp.ViewModels
{
    public class NossoDojoViewModel
    {
        private TextosNossoDojo TextosNossoDojo = new TextosNossoDojo();

        public string TextoEtiqueta
        {
            get
            {
                return TextosNossoDojo.TXTETIQUETA;
            }
        }
    }
}
