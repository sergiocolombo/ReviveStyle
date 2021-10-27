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
    public sealed partial class Carrello : Page
    {
        public Carrello()
        {
            this.InitializeComponent();
            felpa1.Text = App.elementiFelpa1.ToString();
            felpa2.Text = App.elementiFelpa2.ToString();
            maglia1.Text = App.elementiMaglia1.ToString();
            maglia2.Text = App.elementiMaglia2.ToString();
            pantaloni1.Text = App.elementiPantalone1.ToString();
            pantaloni2.Text = App.elementiPantalone2.ToString();
            gonna1.Text = App.elementiGonna1.ToString();
            gonna2.Text = App.elementiGonna2.ToString();
            scarpa1.Text = App.elementiScarpa1.ToString();
            scarpa2.Text = App.elementiScarpa2.ToString();
            accessorio1.Text = App.elementiAccessorio1.ToString();
            accessorio2.Text = App.elementiAccessorio2.ToString();

            if (App.elementiFelpa1.quantità > 0)
            {
                felpa1.Visibility = Visibility.Visible;
            }
            if (App.elementiFelpa2.quantità > 0)
            {
                felpa2.Visibility = Visibility.Visible;
            }

            if (App.elementiMaglia1.quantità > 0)
            {
                maglia1.Visibility = Visibility.Visible;
            }
            if (App.elementiMaglia2.quantità > 0)
            {
                maglia2.Visibility = Visibility.Visible;
            }

            if (App.elementiPantalone1.quantità > 0)
            {
                pantaloni1.Visibility = Visibility.Visible;
            }
            if (App.elementiPantalone2.quantità > 0)
            {
                pantaloni2.Visibility = Visibility.Visible;
            }

            if (App.elementiGonna1.quantità > 0)
            {
                gonna1.Visibility = Visibility.Visible;
            }
            if (App.elementiGonna2.quantità > 0)
            {
                gonna2.Visibility = Visibility.Visible;
            }

            if (App.elementiScarpa1.quantità > 0)
            {
                scarpa1.Visibility = Visibility.Visible;
            }
            if (App.elementiScarpa2.quantità > 0)
            {
                scarpa2.Visibility = Visibility.Visible;
            }

            if (App.elementiAccessorio1.quantità > 0)
            {
                accessorio1.Visibility = Visibility.Visible;
            }
            if (App.elementiAccessorio2.quantità > 0)
            {
                accessorio2.Visibility = Visibility.Visible;
            }
        }

        private void clearCarrello_Click(object sender, RoutedEventArgs e)
        {
            App.elementiFelpa1.quantità = 0;
            App.elementiFelpa2.quantità = 0;
            App.elementiMaglia1.quantità = 0;
            App.elementiMaglia2.quantità = 0;
            App.elementiPantalone1.quantità = 0;
            App.elementiPantalone2.quantità = 0;
            App.elementiGonna1.quantità = 0;
            App.elementiGonna2.quantità = 0;
            App.elementiScarpa1.quantità = 0;
            App.elementiScarpa2.quantità = 0;
            App.elementiAccessorio1.quantità = 0;
            App.elementiAccessorio2.quantità = 0;
            this.Frame.Navigate(typeof(Carrello));
        }
    }
}
