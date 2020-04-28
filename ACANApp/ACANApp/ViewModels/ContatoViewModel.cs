using ACANApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ACANApp.ViewModels
{
    public class ContatoViewModel
    {

        private EnviarEmail enviarEmail = new EnviarEmail();
        private AbrirNavegador abrirNavegador = new AbrirNavegador();
        public ICommand AbrirEmailCommand { get; set; }
        public ICommand AbrirNavegadorCommand { get; set; }
        public ContatoViewModel()
        {
            AbrirEmailCommand = new Command<string>(AbrirEmail);
            AbrirNavegadorCommand = new Command<string>(AbrirNavegador);
        }


        public async void AbrirEmail(string email)
        {
            await enviarEmail.SendMail(email);
        }

        public async void AbrirNavegador(string endereco)
        {
            await abrirNavegador.OpenBrowser(endereco);
        }
    }
}
