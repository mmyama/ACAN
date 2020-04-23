using ACANApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACANApp.ViewModels
{
    class AikidoViewModel
    {
        public TextosAikido TextosAikido = new TextosAikido();

        public string TextoCaminho
        {
            get
            {
                return TextosAikido.TxtCaminho;
            }
        }
        public string TextoFilosofia
        {
            get
            {
                return TextosAikido.TxtFilosofia;
            }
        }
        public string TextoLivros
        {
            get
            {
                return TextosAikido.TxtLivros;
            }
        }
        public string TextoTecnicas
        {
            get
            {
                return TextosAikido.TxtTecnicas;
            }
        }
        public string TextoGlossario
        {
            get
            {
                return TextosAikido.TxtGlossario;
            }
        }

    }
}
