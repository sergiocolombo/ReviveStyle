# ReviveStyle
## Idea iniziale
La nostra idea inizialmente era di fare un'applicazione UWP in stile "Vinted", utilizzando il linguaggio C#, nella quale l'utente poteva mettere in vendita dei capi e
acquistarne altri.

Essendo però vincolati dal tempo di consegna del progetto ci siamo visti costretti a riconsiderare l'idea iniziare e a togliere delle funzionalità, tra cui:

- creazione di un account
- aggiunta manuale di un capo da parte dell'utente

## Funzioni dell'app
La nostra applicazione presenta dei vestiti, che per ora sono pre-inseriti da codice, che l'utente può visualizzare e aggiungere al carrello.

Tutto è racchiuso in un Hamburger menu che ci permette di navigare nelle varie pagine dell'app.

La pagina principale fa visualizzare all'utente una griglia di vestiti sui quali può cliccare per navigare nella pagina di visualizzazione del singolo capo, in quest'ultima 
l'utente visualizza una foto del capo selezionato, il nome del capo, la taglia, una descrizione e il prezzo, inoltre può facilmente aggiungerlo al carrello cliccando sul pulsante
"+" sotto al prezzo.

All'interno del carrello è possibili trovare un elenco dei vestiti al suo interno, con il nome del capo, il prezzo e la quantità di elementi.

Inoltre abbiamo una pagina di informazioni nella quale abbiamo inserito una piccola descrizione dell'app e dei recapiti per contattarci (il numero è scritto a caso).

## Divisione del lavoro
Prima di iniziare il nostro progetto abbiamo strutturato un file di partenza comune, che abbiamo pushato sul main e in seguito abbiamo continuato la programmazione sul branch dev.

Inoltre abbiamo utilizzato un terzo branch, testing, per testare se nei cambiamenti che avevamo apportato ci fossero eventuali bug e nel caso risolverli.

In seguito abbiamo suddiviso la parte grafica dalla parte di programmazione vera e propria.

Inizialmente ci siamo concentrati sulla parte grafica.

Sergio si è occupato della pagina dell'hamburger menù e della pagina dello shop mentre Francesco e Federico si occupavano delle pagine di informazioni, carrello e 
visualizzazione del singolo capo.

Dopo aver terminato la parte grafica ci siamo occupati della programmazione.

Abbiamo creato assieme le classi che rappresentano un capo in vensita e un capo all'interno del carrello.

In seguito ci siamo occupati di inserire i vari riferimenti e inizializzare i metodi dei pulsanti, fin ora inutilizzati.

Per la parte finale della programmazione ("carrello" e "visualizzazione singolo capo"), dato che ogni pagina dipendeva dalla precedente, abbiamo dovuto collaborare a casa 
utilizzando la funzione "Live Share" di Visual Studio, permettendoci così di modificare contemporaneamente gli stessi file senza rischiare di creare collisioni.


