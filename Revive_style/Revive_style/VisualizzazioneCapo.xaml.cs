using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// Il modello di elemento Pagina vuota è documentato all'indirizzo https://go.microsoft.com/fwlink/?LinkId=234238

namespace Revive_style
{
    /// <summary>
    /// Pagina vuota che può essere usata autonomamente oppure per l'esplorazione all'interno di un frame.
    /// </summary>
    public sealed partial class VisualizzazioneCapo : Page
    {
        public VisualizzazioneCapo()
        {
            this.InitializeComponent();
            Nome.Text = App.selezionato.nome;
            Taglia.Text = App.selezionato.taglia;
            Descrizione.Text = App.selezionato.descrizione;
            Prezzo.Text = App.selezionato.prezzo.ToString();

            Uri imageUri = (new Uri(base.BaseUri, @App.selezionato.indirizzoImmagine));
            BitmapImage source = new BitmapImage(imageUri);
            ImmagineCapo.Source = source;
        }

        private void AddCarrello_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
