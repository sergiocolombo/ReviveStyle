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
using Windows.UI.Xaml.Navigation;

// Il modello di elemento Pagina vuota è documentato all'indirizzo https://go.microsoft.com/fwlink/?LinkId=234238

namespace Revive_style
{
    /// <summary>
    /// Pagina vuota che può essere usata autonomamente oppure per l'esplorazione all'interno di un frame.
    /// </summary>
    public sealed partial class ZonaVendita : Page
    {
        public ZonaVendita()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string nome = ((Button)sender).Name;
            switch (nome)
            {
                case "felpa1":
                    App.selezionato = App.felpa1;
                    break;
                case "felpa2":
                    App.selezionato = App.felpa2;
                    break;
                case "maglia1":
                    App.selezionato = App.maglia1;
                    break;
                case "maglia2":
                    App.selezionato = App.maglia2;
                    break;
                case "pantaloni1":
                    App.selezionato = App.pantalone1;
                    break;
                case "pantaloni2":
                    App.selezionato = App.pantalone2;
                    break;
                case "gonna1":
                    App.selezionato = App.gonna1;
                    break;
                case "gonna2":
                    App.selezionato = App.gonna2;
                    break;
                case "scarpa1":
                    App.selezionato = App.scarpa1;
                    break;
                case "scarpa2":
                    App.selezionato = App.scarpa2;
                    break;
                case "accessorio1":
                    App.selezionato = App.accessorio1;
                    break;
                case "accessorio2":
                    App.selezionato = App.accessorio2;
                    break;
            }
            this.Frame.Navigate(typeof(VisualizzazioneCapo));
        }
    }
}
