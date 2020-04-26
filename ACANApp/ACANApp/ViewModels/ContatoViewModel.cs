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

        public ICommand AbrirEmailCommand { get; set; }

        public ContatoViewModel()
        {
            AbrirEmailCommand = new Command(AbrirEmail);
        }

        
        public async void AbrirEmail()
        {
            await enviarEmail.SendMail();
        }
        
    }
}
