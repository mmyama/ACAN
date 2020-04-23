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
                return TextosAikido.txtCaminho;
            }
        }
        public string TextoFilosofia
        {
            get
            {
                return TextosAikido.txtFilosofia;
            }
        }
        public string TextoLivros
        {
            get
            {
                return TextosAikido.txtLivros;
            }
        }
        public string TextoTecnicas
        {
            get
            {
                return TextosAikido.txtTecnicas;
            }
        }
        public string TextoGlossario
        {
            get
            {
                return TextosAikido.txtGlossario;
            }
        }

    }
}
