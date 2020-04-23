using ACANApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACANApp.ViewModels
{
    public class CulturaViewModel
    {
        public TextosCultura TextosCultura = new TextosCultura();

        public string TextoEspirito
        {
            get
            {
                return TextosCultura.txtEspirito;
            }
        }
        public string TextoHakama
        {
            get
            {
                return TextosCultura.txtHakama;
            }
        }
        public string TextoKimono
        {
            get
            {
                return TextosCultura.txtKimono;
            }
        }
        public string TextoCaligrafia
        {
            get
            {
                return TextosCultura.txtCaligrafia;
            }
        }
        public string TextoTienShen
        {
            get
            {
                return TextosCultura.txtTienShen;
            }
        }
        public string TextoZanshin
        {
            get
            {
                return TextosCultura.txtZanshin;
            }
        }
        public string TextoSeiza
        {
            get
            {
                return TextosCultura.txtSeiza;
            }
        }
    }
}
