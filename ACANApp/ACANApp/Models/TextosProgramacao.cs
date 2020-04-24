using System;
using System.Collections.Generic;
using System.Text;

namespace ACANApp.Models
{
    public class TextosProgramacao
    {
        private string janeiro;
        private string fevereiro;
        private string marco;
        private string abril;
        private string maio;
        private string junho;
        private string julho;
        private string agosto;
        private string setembro;
        private string outubro;
        private string novembro;
        private string dezembro;

        public string Janeiro 
        {
            get
            {
                return janeiro;
            }
            set
            {
                janeiro = value;
            }
        }
        public string Fevereiro
        {
            get
            {
                return fevereiro;
            }
            set
            {
                fevereiro = value;
            }
        }
        public string Marco
        {
            get
            {
                return marco;
            }
            set
            {
                marco = value;
            }

        }
        public string Abril
        {
            get
            {
                return abril;
            }
            set
            {
                abril = value;
            }

        }
        public string Maio
        {
            get
            {
                return maio;
            }
            set
            {
                maio = value;
            }

        }
        public string Junho
        {
            get
            {
                return junho;
            }
            set
            {
                junho = value;
            }

        }
        public string Julho
        {
            get
            {
                return julho;
            }
            set
            {
                julho = value;
            }

        }
        public string Agosto
        {
            get
            {
                return agosto;
            }
            set
            {
                agosto = value;
            }

        }
        public string Setembro
        {
            get
            {
                return setembro;
            }
            set
            {
                setembro = value;
            }

        }
        public string Outubro
        {
            get
            {
                return outubro;
            }
            set
            {
                outubro = value;
            }

        }
        public string Novembro
        {
            get
            {
                return novembro;
            }
            set
            {
                novembro = value;
            }

        }
        public string Dezembro
        {
            get
            {
                return dezembro;
            }
            set
            {
                dezembro = value;
            }

        }

        public TextosProgramacao()
        {
            Janeiro = "1(SEG) - COVID-19";
            Fevereiro = "2(TER) - COVID-19";
            Marco = "3(QUA) - COVID-19";
            Abril = "4(QUI) - COVID-19";
            Maio = "5(SEX) - COVID-19";
            Junho = "6(SAB) - COVID-19";
            Julho = "7(DOM) - COVID-19";
            Agosto = "8(SEG) - COVID-19";
            Setembro = "9(TER) - COVID-19";
            Outubro = "10(QUA) - COVID-19";
            Novembro = "11(QUI) - COVID-19";
            Dezembro = "12(SEX) - COVID-19";

        }
    }
}
