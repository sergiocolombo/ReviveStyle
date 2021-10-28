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
            public string prezzo;
            public string indirizzoImmagine;
            

            public vestiti(string nome, string taglia, string descrizione, string prezzo, string indirizzoImmagine)
            {
                this.nome = nome;
                this.taglia = taglia;
                this.descrizione = descrizione;
                this.prezzo = prezzo;
                this.indirizzoImmagine = indirizzoImmagine;
            }

        }


        public static vestiti felpa1 = new vestiti("Felpa Octopus", "L", "felpa in cotone, in condizioni ottimali con decorazioni rosse", "50€", "Assets/felpa1.jpeg");
        public static vestiti felpa2 = new vestiti("Felpa Napapijri", "M", "felpa in cotone, in buona condizioni con box logo napapijri", "40€", "Assets/felpa2.jpeg");
        public static vestiti maglia1 = new vestiti("Maglia Gucci", "XL", "maglia box logo del rinomato marchio italiano gucci", "63€", "Assets/maglia1.jpg");
        public static vestiti maglia2 = new vestiti("Maglia Jordan", "L", "maglia jordan, perfetta per sport, molto leggera e traspirante", "26€", "Assets/maglia2.jpg");
        public static vestiti pantalone1 = new vestiti("Tuta Nike", "M", "tuta in cotone perfetta per attività sportiva", "42€", "Assets/pantaloni1.jpg");
        public static vestiti pantalone2 = new vestiti("Tuta Kappa", "L", "tuta kappa, rossa con marchio kappa nero", "30€", "Assets/pantaloni2.jpg");
        public static vestiti gonna1 = new vestiti("Gonna rossa", "S", "gonna rossa economica ma molto elegante", "7€", "Assets/gonna1.jpg");
        public static vestiti gonna2 = new vestiti("Gonna azzurra", "M", "gonna azzurra molto elegante, perfetta per uscite e cene", "15€", "Assets/gonna2.jpg");
        public static vestiti scarpa1 = new vestiti("Nike VaporMax", "42", "scarpe nike grige, molto comode e perfette per andare a correre", "130€", "Assets/scarpa1.jpg");
        public static vestiti scarpa2 = new vestiti("Nike Air Force One", "40", "scarpa bianca con dettagli arancio e grigi", "80€", "Assets/scarpa2.jpg");
        public static vestiti accessorio1 = new vestiti("Orecchini Pandora", "", "orecchini pandora con fiori", "27€", "Assets/accessorio1.jpg");
        public static vestiti accessorio2 = new vestiti("Anello Pandora", "16", "anello a corona pandora", "15€", "Assets/accessorio2.jpg");

        public static vestiti selezionato = new vestiti("", "", "","", "");

        static public string button;

        public struct elementiCarrello
        {
            public string nome;
            public string prezzo;
            public int quantità;

            public elementiCarrello(string nome, string prezzo, int quantità)
            {
                this.nome = nome;
                this.prezzo = prezzo;
                this.quantità = quantità;
            }

            public override string ToString()
            {
                return nome+"\t\t\tprezzo:"+prezzo+"\t\t\t"+quantità+" pezzi";
            }
        }

        public static elementiCarrello elementiFelpa1 = new elementiCarrello("Felpa Octopus        ", "50€", 0);
        public static elementiCarrello elementiFelpa2 = new elementiCarrello("Felpa Napapijri        ", "40€", 0);
        public static elementiCarrello elementiMaglia1 = new elementiCarrello("Maglia Gucci            ", "63€", 0);
        public static elementiCarrello elementiMaglia2 = new elementiCarrello("Maglia Jordan        ", "26€", 0);
        public static elementiCarrello elementiPantalone1 = new elementiCarrello("Tuta Nike               ", "42€", 0);
        public static elementiCarrello elementiPantalone2 = new elementiCarrello("Tuta Kappa              ", "30€", 0);
        public static elementiCarrello elementiGonna1 = new elementiCarrello("Gonna rossa             ", "7€", 0);
        public static elementiCarrello elementiGonna2 = new elementiCarrello("Gonna azzurra        ", "15€", 0);
        public static elementiCarrello elementiScarpa1 = new elementiCarrello("Nike VaporMax        ", "130€", 0);
        public static elementiCarrello elementiScarpa2 = new elementiCarrello("Nike Air Force One", "80€", 0);
        public static elementiCarrello elementiAccessorio1 = new elementiCarrello("Orecchini Pandora", "27€", 0);
        public static elementiCarrello elementiAccessorio2 = new elementiCarrello("Anello Pandora        ", "15€", 0);


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
