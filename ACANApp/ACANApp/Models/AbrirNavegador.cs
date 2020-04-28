using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace ACANApp.Models
{
    public class AbrirNavegador
    {
		Uri uri;
        public async Task OpenBrowser(string endereco)
        {
			try
			{
				uri = new Uri(endereco);
				await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
			}
			catch (Exception)
			{
				throw;
			}
        }
    }
}
