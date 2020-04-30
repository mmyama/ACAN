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
                return TextosAikido.TXTCAMINHO;
            }
        }
        public string TextoFilosofia
        {
            get
            {
                return TextosAikido.TXTFILOSOFIA;
            }
        }
        public string TextoLivros
        {
            get
            {
                return TextosAikido.TXTLIVROS;
            }
        }
        public string TextoTecnicas
        {
            get
            {
                return TextosAikido.TXTECNICAS;
            }
        }
        public string TextoGlossario
        {
            get
            {
                return TextosAikido.TXTGLOSSARIO;
            }
        }
        public string TextoAtaques
        {
            get
            {
                return TextosAikido.TXTATAQUES;
            }
        }

    }
}
