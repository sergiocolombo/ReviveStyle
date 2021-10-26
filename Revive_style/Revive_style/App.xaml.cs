using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Revive_style
{
    /// <summary>
    /// Fornisci un comportamento specifico dell'applicazione in supplemento alla classe Application predefinita.
    /// </summary>
    sealed partial class App : Application
    {
        /// <summary>
        /// Inizializza l'oggetto Application singleton. Si tratta della prima riga del codice creato
        /// creato e, come tale, corrisponde all'equivalente logico di main() o WinMain().
        /// </summary>
        public App()
        {
            this.InitializeComponent();
            this.Suspending += OnSuspending;
        }

        public struct vestiti
        {
            public string nome;
            public string taglia;
            public string descrizione;
            public int prezzo;
            public string indirizzoImmagine;
            

            public vestiti(string nome, string taglia, string descrizione, int prezzo, string indirizzoImmagine)
            {
                this.nome = nome;
                this.taglia = taglia;
                this.descrizione = descrizione;
                this.prezzo = prezzo;
                this.indirizzoImmagine = indirizzoImmagine;
            }

        }


        public static vestiti felpa1 = new vestiti("felpa octopus", "L", "felpa in cotone, in condizioni ottimali con decorazioni rosse", 50, "Assets/felpa1.jpeg");
        public static vestiti felpa2 = new vestiti("felpa napapijri", "M", "felpa in cotone, in buona condizioni con box logo napapijri", 40, "Assets/felpa2.jpeg");
        public static vestiti maglia1 = new vestiti("maglia gucci", "XL", "maglia box logo del rinomato marchio italiano gucci", 63, "Assets/maglia1.jpg");
        public static vestiti maglia2 = new vestiti("maglia jordan", "L", "maglia jordan, perfetta per sport, molto leggera e traspirante", 26, "Assets/maglia2.jpg");
        public static vestiti pantalone1 = new vestiti("tuta nike", "M", "tuta in cotone perfetta per attività sportiva", 42, "Assets/pantaloni1.jpg");
        public static vestiti pantalone2 = new vestiti("tuta kappa", "L", "tuta kappa, rossa con marchio kappa nero", 30, "Assets/pantaloni2.jpg");
        public static vestiti gonna1 = new vestiti("gonna rossa", "S", "gonna rossa economica ma molto elegante", 7, "Assets/gonna1.jpg");
        public static vestiti gonna2 = new vestiti("gonna azzurra", "M", "gonna azzurra molto elegante, perfetta per uscite e cene", 15, "Assets/gonna2.jpg");
        public static vestiti scarpa1 = new vestiti("Nike VaporMax", "42", "scarpe nike grige, molto comode e perfette per andare a correre", 130, "Assets/scarpa1.jpg");
        public static vestiti scarpa2 = new vestiti("Nike Air Force One", "40", "scarpa bianca con dettagli arancio e grigi", 80, "Assets/scarpa2.jpg");
        public static vestiti accessorio1 = new vestiti("orecchini pandora", "", "orecchini pandora con fiori", 27, "Assets/accessorio1.jpg");
        public static vestiti accessorio2 = new vestiti("felpa octopus", "16", "anello a corona pandora", 15, "Assets/accessorio2.jpg");

        public static vestiti selezionato = new vestiti("", "", "", 0, "");


        /// <summary>
        /// Richiamato quando l'applicazione viene avviata normalmente dall'utente finale. All'avvio dell'applicazione
        /// verranno usati altri punti di ingresso per aprire un file specifico.
        /// </summary>
        /// <param name="e">Dettagli sulla richiesta e sul processo di avvio.</param>
        protected override void OnLaunched(LaunchActivatedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;

            // Non ripetere l'inizializzazione dell'applicazione se la finestra già dispone di contenuto,
            // assicurarsi solo che la finestra sia attiva
            if (rootFrame == null)
            {
                // Creare un frame che agisca da contesto di navigazione e passare alla prima pagina
                rootFrame = new Frame();

                rootFrame.NavigationFailed += OnNavigationFailed;

                if (e.PreviousExecutionState == ApplicationExecutionState.Terminated)
                {
                    //TODO: caricare lo stato dall'applicazione sospesa in precedenza
                }

                // Posizionare il frame nella finestra corrente
                Window.Current.Content = rootFrame;
            }
            
            if (e.PrelaunchActivated == false)
            {
                if (rootFrame.Content == null)
                {
                    // Quando lo stack di esplorazione non viene ripristinato, passare alla prima pagina
                    // configurando la nuova pagina per passare le informazioni richieste come parametro di
                    // navigazione
                    rootFrame.Navigate(typeof(MainPage), e.Arguments);
                }
                // Assicurarsi che la finestra corrente sia attiva
                Window.Current.Activate();
            }
        }

        /// <summary>
        /// Chiamato quando la navigazione a una determinata pagina ha esito negativo
        /// </summary>
        /// <param name="sender">Frame la cui navigazione non è riuscita</param>
        /// <param name="e">Dettagli sull'errore di navigazione.</param>
        void OnNavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            throw new Exception("Failed to load Page " + e.SourcePageType.FullName);
        }

        /// <summary>
        /// Richiamato quando l'esecuzione dell'applicazione viene sospesa. Lo stato dell'applicazione viene salvato
        /// senza che sia noto se l'applicazione verrà terminata o ripresa con il contenuto
        /// della memoria ancora integro.
        /// </summary>
        /// <param name="sender">Origine della richiesta di sospensione.</param>
        /// <param name="e">Dettagli relativi alla richiesta di sospensione.</param>
        private void OnSuspending(object sender, SuspendingEventArgs e)
        {
            var deferral = e.SuspendingOperation.GetDeferral();
            //TODO: salvare lo stato dell'applicazione e arrestare eventuali attività eseguite in background
            deferral.Complete();
        }
    }
}
