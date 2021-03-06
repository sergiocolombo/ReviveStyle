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
            Taglia.Text = "Taglia: "+App.selezionato.taglia;
            Descrizione.Text = App.selezionato.descrizione;
            Prezzo.Text = App.selezionato.prezzo.ToString();

            Uri imageUri = (new Uri(base.BaseUri, @App.selezionato.indirizzoImmagine));
            BitmapImage source = new BitmapImage(imageUri);
            ImmagineCapo.Source = source;
        }

        private void AddCarrello_Click(object sender, RoutedEventArgs e)
        {
            switch (App.button)
            {
                case "felpa1":
                    App.elementiFelpa1.quantità += 1;
                    break;
                case "felpa2":
                    App.elementiFelpa2.quantità += 1;
                    break;
                case "maglia1":
                    App.elementiMaglia1.quantità += 1;
                    break;
                case "maglia2":
                    App.elementiMaglia2.quantità += 1;
                    break;
                case "pantaloni1":
                    App.elementiPantalone1.quantità += 1;
                    break;
                case "pantaloni2":
                    App.elementiPantalone2.quantità += 1;
                    break;
                case "gonna1":
                    App.elementiGonna1.quantità += 1;
                    break;
                case "gonna2":
                    App.elementiGonna2.quantità += 1;
                    break;
                case "scarpa1":
                    App.elementiScarpa1.quantità += 1;
                    break;
                case "scarpa2":
                    App.elementiScarpa2.quantità += 1;
                    break;
                case "accessorio1":
                    App.elementiAccessorio1.quantità += 1;
                    break;
                case "accessorio2":
                    App.elementiAccessorio2.quantità += 1;
                    break;
            }
        }
    }
}
