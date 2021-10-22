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

// Il modello di elemento Pagina vuota è documentato all'indirizzo https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x410

namespace Revive_style
{
    /// <summary>
    /// Pagina vuota che può essere usata autonomamente oppure per l'esplorazione all'interno di un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            Titolo.Text = "Shop";
            ShopListItem.IsSelected = true;
            MyFrame.Navigate(typeof(ZonaVendita));
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ShopListItem.IsSelected)
            {
                MyFrame.Navigate(typeof(ZonaVendita));
                Titolo.Text = "Shop";
                MySplitView.IsPaneOpen = false;
            }
            else if (InfoListItem.IsSelected)
            {
                MyFrame.Navigate(typeof(Info));
                Titolo.Text = "Info";
                MySplitView.IsPaneOpen = false;
            }
        }

        private void CarrelloButton_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(Carrello));
            Titolo.Text = "Carrello";
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
