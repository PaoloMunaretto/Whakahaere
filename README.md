# Whakahaere
Hotel Management Test - like Boking.com or similar


/****************************************************************************************
Gestionale per Hotel (oppure Hotels di una catena, es: Best Western)

*** Specifiche di progettazione e requisiti + tabelle***

** EMPLOYEES Table**
- Tabella con la lista degli utenti/dipendenti di quello specifico Hotel( no gestione HR, retribuzione, buste paga ed orario di lavoro)
- Ogni utente ha la sua abilitazione, il suo username e login, possibilità di accessi consentiti e rifiutati a determinate transazioni ( decise da IT)

** BEDROOM Table ** 
- Tabella della lista delle stanze disponibili per quell'Hotel ( con tutte le caratteristiche, optional, servizi)
- il dipendente dell'Hotel può crearle, modificarle e renderle non più disponibili (tutte le modifiche devono essere tracciate)

** HOTELINFORMATION Table ** 
- Tabella con le identificazioni dell'Hotel (qui racchiudiamo tutti gli Hotel che si appoggiano a questo gestionale, Ragione sociale,via, P.IVA, ecc...)
- Ogni Hotel, inserisce i propri dati per emettere ricevuta o fattura (documento STD, immagini di riferimento sulle risorse.dll)

** CLIENT Table ** 
- Tabella dei clienti (ogni receptionist inserisce i dati del cliente, eventuale Ragione sociale e P.IVA)

** SERVICEHOTEL Table ** 
- Tabella dei servizi (ogni hotel spunta dalla tabella quali servizi propone, se eventualmente sono a pagamento)

** PRENOTATION Table ** 
- Tabella delle prenotazioni (in questa tabella, vediamo chi ha prenotato cosa, da che giorno a che giorno, se ha dato un anticipo, se ci sono state problematiche, che servizi ha richiesto, ecc...)

** COUNTRYHOTEL Table ** 
- Tabella dei Paesi e Nazioni (ogni paese e città gestisce l'iva e la tassa di soggiorno in modo diverso, un costo da tenere in considerazione)

** MONEYVALUE Table ** 
- Questa tabella ci da le disponibili valute registrate, da stampare nel preventivo / fattura / ricevuta

** SERVICERESTAURANT Table **
- Qui abbiamo il listino dei prodotto disponibili per il ristorante / bar / colazione (da visualizzare ogni elemento oppure il totale nella fattura /ricevuta)



*** Ricerche da gestire *** (da capire come gestirle)

- Implementare database SQL => per comodità, usare MariaDB in locale

- Caricare le informazioni a livello di gestionale, come se avessimo milioni di dati già disponibili (il codice deve essere molto veloce, vedere la Datasource, CurrentRow.DataBoundItem)

- A seconda del login (tipo di accesso dell'utente) abbiamo determinate funzioni attive o meno

- Inserendo nome, e/o cognome, e/o data di nascita, e/o cod. fiscale e/o stanza, visualizziamo la prenotazione dell'ospite (dando conferma del check in e check out in data ed ora)

- Vedere sul calendario, quali stanze sono disponibili nel'hotel(mese per mese oppure wk per wk)

- Inserire sulla 'bill' tutti i costi dell'ospite, se ha dato qualche anticipo, saldo finale, emettere fattura, ...

- la password deve essere criptata (vedere i tipi di Encrypt migliori)

- gli ENUM descrivono tutti i type disponibili

- lo stato delle camere viene aggiornato a mano (a seconda delle prenotazioni, pulizie, manutenzioni)

- implementare anche la Advanced DatagridView filter C#   =>   https://www.youtube.com/watch?v=2MXdc5KmJ2U      =>   https://www.youtube.com/watch?v=RaZeeHRRCGA

- Le immagini vanno implementate con una Libreria di classi (con lo stesso .NET Framework) => genereremo un file.dll per rendere il nostro file .exe + veloce

****************************************************************************************/

/***************************************************************************************


    /// <summary>
    /// Enum describe status Hotel's room (single room)
    /// </summary>
    public enum STATUSROOM
    {
        AVAILABLE,
        BUSY,
        REPAIR,
        RESTRUCTURATION
    }

    /// <summary>
    /// Enum of restaurant
    /// </summary>
    public enum SERVICERESTAURANT
    {
        ANTIPASTI,
        PRIMI,
        RISOTTI,
        PESCI,       
        CARNI,        
        DESSER
    }

    /// <summary>
    /// Enum of service of Hotel (what can you find in room or in hotel)
    /// </summary>
    public enum SERVICEHOTEL
    { 
        BATHROOM,
        GENERAL_SERVICE,
        ROOM,
        FREE_SPACE,
        KITCHEN,
        ACCESSIBILITY,
        BAR_RESTAURANT,
        MEDIA_TV,
        INTERNET,
        PARKING,
        CLEANING_ROOM,       
        WELLNESS,
        HOSPITALITY,
        SNACK_DRINK,
        ENTERTAINMENT,
        BUSINESS,
        SECURITY,
        LANGUAGES
    }

    /// <summary>
    /// Tipi di accesso disponibili, ogniuno con funzioni diverse
    /// </summary>
    public enum ACCESSEMPLOYEES
    { 
        RECEPTION, //Accesso limitato (visualizza alcune informazioni)
        MANAGER, //Accesso completo (ma non tutto modificabile)
        ADMINISTRATION,//Accesso completo e modificabile
        MASTERUSER//Accesso completo, modificabile e cancellabile
    }

    ****************************************************************************************/

    => distingui gli oggetti che ci servono a RUNTIME da quelli che ci servono sporadicamente

    => Escape con il $ prima dello string format per migliorarne

    => provare ad usare una ListView