using ACANApp.Models;
using Microsoft.Toolkit.Parsers.Rss;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ACANApp.ViewModels
{
    public class InicioViewModel : INotifyPropertyChanged
    {
        #region
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if(EqualityComparer<T>.Default.Equals(storage, value))
            {
                return false;
            }

            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        #endregion

        private bool _isBusy;

        public bool IsBusy
        {
            get => _isBusy;
            set => SetProperty(ref _isBusy, value);
        }

        public ObservableCollection<RssData> RSSFeed { get; }


        private EnviarEmail enviarEmail = new EnviarEmail();
        private AbrirNavegador abrirNavegador = new AbrirNavegador();


        public ICommand AbrirEmailCommand { get; set; }
        public ICommand AbrirNavegadorCommand { get; set; }

        public InicioViewModel()
        {
            RSSFeed = new ObservableCollection<RssData>();
            CarregarRSS();
            IsBusy = false;

            AbrirEmailCommand = new Command<string>(AbrirEmail);
            AbrirNavegadorCommand = new Command<string>(AbrirNavegador);
        }



        private ICommand _refreshNewsFeedCommand;

        public ICommand RefreshNewsFeedCommand =>
            _refreshNewsFeedCommand ?? (_refreshNewsFeedCommand = new Command(
                async () =>
                {
                    await CarregarRSS();
                }));
        
        private async Task CarregarRSS()
        {
            IsBusy = true;
            string feed = null;
            using(var client = new HttpClient())
            {
                feed = await client.GetStringAsync("https://twitrss.me/twitter_user_to_rss/?user=aikidorn");
            }

            if (feed != null)
            {
                RSSFeed.Clear();

                var parser = new RssParser();
                var rss = parser.Parse(feed).OrderByDescending(e => e.PublishDate).ToList(); ;

                foreach (var rssSchema in rss)
                {
                    RSSFeed.Add(new RssData
                    {
                        Title = rssSchema.Title,
                        PubDate = rssSchema.PublishDate,
                        Link = rssSchema.FeedUrl,
                        Guid = rssSchema.InternalID,
                        Author = rssSchema.Author,
                        Thumbnail = string.IsNullOrEmpty(rssSchema.ImageUrl)?$"":rssSchema.ImageUrl,
                        Description = rssSchema.Summary
                    });
                }
//                IsBusy = false;
            }
            IsBusy = false;
        }

        public async void AbrirEmail(string endereco)
        {
            await enviarEmail.SendMail(endereco);
        }
        public async void AbrirNavegador(string endereco)
        {
            await abrirNavegador.OpenBrowser(endereco);
        }

    }
}
