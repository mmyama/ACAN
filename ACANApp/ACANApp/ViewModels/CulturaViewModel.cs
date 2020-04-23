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
                return TextosCultura.TxtEspirito;
            }
        }
        public string TextoHakama
        {
            get
            {
                return TextosCultura.TxtHakama;
            }
        }
        public string TextoKimono
        {
            get
            {
                return TextosCultura.TxtKimono;
            }
        }
        public string TextoCaligrafia
        {
            get
            {
                return TextosCultura.TxtCaligrafia;
            }
        }
        public string TextoTienShen
        {
            get
            {
                return TextosCultura.TxtTienShen;
            }
        }
        public string TextoZanshin
        {
            get
            {
                return TextosCultura.TxtZanshin;
            }
        }
        public string TextoSeiza
        {
            get
            {
                return TextosCultura.TxtSeiza;
            }
        }
    }
}
