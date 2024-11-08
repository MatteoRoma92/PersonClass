using System; // Importa il namespace System per l'uso di tipi e funzionalità di base, come DateTime e Console.
using System.Threading.Tasks; // Importa il namespace System.Threading.Tasks per l'uso di metodi asincroni.

namespace PersonClass // Definisce lo spazio dei nomi PersonClass, dove risiede la classe Persona.
{
    public class Persona // Definisce la classe Persona, che rappresenta una persona con vari attributi e metodi.
    {
        // Campi privati
        private string nome; // Nome della persona
        private string cognome; // Cognome della persona
        private int eta; // Età della persona
        private string indirizzo; // Indirizzo della persona
        private string email; // Email della persona
        private string numeroDiTelefono; // Numero di telefono della persona
        private string sesso; // Sesso della persona
        private DateTime dataDiNascita; // Data di nascita della persona
        private string codiceFiscale; // Codice fiscale della persona
        private string nazionalita; // Nazionalità della persona

        // Costruttore senza parametri
        public Persona() { }

        // Costruttore con alcuni parametri
        public Persona(string nome, string cognome, int eta)
        {
            this.nome = nome; // Inizializza il campo nome
            this.cognome = cognome; // Inizializza il campo cognome
            this.eta = eta; // Inizializza il campo eta
        }

        // Costruttore completo con tutti i parametri
        public Persona(string nome, string cognome, int eta, string indirizzo, string email,
                       string numeroDiTelefono, string sesso, DateTime dataDiNascita,
                       string codiceFiscale, string nazionalita)
        {
            this.nome = nome; // Inizializza il campo nome
            this.cognome = cognome; // Inizializza il campo cognome
            this.eta = eta; // Inizializza il campo eta
            this.indirizzo = indirizzo; // Inizializza il campo indirizzo
            this.email = email; // Inizializza il campo email
            this.numeroDiTelefono = numeroDiTelefono; // Inizializza il campo numeroDiTelefono
            this.sesso = sesso; // Inizializza il campo sesso
            this.dataDiNascita = dataDiNascita; // Inizializza il campo dataDiNascita
            this.codiceFiscale = codiceFiscale; // Inizializza il campo codiceFiscale
            this.nazionalita = nazionalita; // Inizializza il campo nazionalita
        }

        // Metodi getter e setter per ogni campo

        public string GetNome() { return nome; } // Restituisce il nome della persona
        public void SetNome(string value) { nome = value; } // Imposta il nome della persona

        public string GetCognome() { return cognome; } // Restituisce il cognome della persona
        public void SetCognome(string value) { cognome = value; } // Imposta il cognome della persona

        public int GetEta() { return eta; } // Restituisce l'età della persona
        public void SetEta(int value) { eta = value; } // Imposta l'età della persona

        public string GetIndirizzo() { return indirizzo; } // Restituisce l'indirizzo della persona
        public void SetIndirizzo(string value) { indirizzo = value; } // Imposta l'indirizzo della persona

        public string GetEmail() { return email; } // Restituisce l'email della persona
        public void SetEmail(string value) { email = value; } // Imposta l'email della persona

        public string GetNumeroDiTelefono() { return numeroDiTelefono; } // Restituisce il numero di telefono della persona
        public void SetNumeroDiTelefono(string value) { numeroDiTelefono = value; } // Imposta il numero di telefono della persona

        public string GetSesso() { return sesso; } // Restituisce il sesso della persona
        public void SetSesso(string value) { sesso = value; } // Imposta il sesso della persona

        public DateTime GetDataDiNascita() { return dataDiNascita; } // Restituisce la data di nascita della persona
        public void SetDataDiNascita(DateTime value) { dataDiNascita = value; } // Imposta la data di nascita della persona

        public string GetCodiceFiscale() { return codiceFiscale; } // Restituisce il codice fiscale della persona
        public void SetCodiceFiscale(string value) { codiceFiscale = value; } // Imposta il codice fiscale della persona

        public string GetNazionalita() { return nazionalita; } // Restituisce la nazionalità della persona
        public void SetNazionalita(string value) { nazionalita = value; } // Imposta la nazionalità della persona

        // Metodo privato - Calcola l'anno di nascita in base all'età
        private int CalcolaAnnoDiNascita()
        {
            return DateTime.Now.Year - eta; // Restituisce l'anno di nascita basato sull'età corrente
        }

        // Metodo privato - Restituisce una descrizione formattata dell'indirizzo
        private string FormattaIndirizzo()
        {
            return $"Indirizzo: {indirizzo}"; // Formatta e restituisce l'indirizzo
        }

        // Metodo pubblico che utilizza un metodo privato
        public void StampaAnnoDiNascita()
        {
            int annoDiNascita = CalcolaAnnoDiNascita(); // Chiama il metodo privato CalcolaAnnoDiNascita
            Console.WriteLine($"Anno di nascita di {nome} {cognome}: {annoDiNascita}"); // Stampa l'anno di nascita
        }

        // Metodo statico - Non richiede un'istanza della classe per essere chiamato
        public static void Saluta()
        {
            Console.WriteLine("Ciao! Sono una persona."); // Saluto generico da una persona
        }

        // Metodo virtuale - Può essere sovrascritto nelle classi derivate
        public virtual void Parla()
        {
            Console.WriteLine($"{nome} sta parlando."); // Stampa un messaggio che indica che la persona sta parlando
        }

        // Override del metodo ToString per una descrizione della persona
        public override string ToString()
        {
            return $"{nome} {cognome}, {eta} anni, {nazionalita}"; // Restituisce una stringa descrittiva della persona
        }

        // Metodo asincrono che simula un'attesa
        public async Task SimulaAttesaAsync()
        {
            Console.WriteLine("Attesa in corso..."); // Stampa un messaggio di inizio attesa
            await Task.Delay(2000); // Simula un'attesa di 2 secondi
            Console.WriteLine("Attesa completata."); // Stampa un messaggio al termine dell'attesa
        }

        // Metodo che combina l'uso di un metodo privato per il formato dell'indirizzo
        public string StampaIndirizzoFormattato()
        {
            return FormattaIndirizzo(); // Chiama il metodo privato FormattaIndirizzo e restituisce il risultato
        }

        // Metodo per confrontare età tra due persone
        public static int CalcolaDifferenzaEta(Persona persona1, Persona persona2)
        {
            return Math.Abs(persona1.eta - persona2.eta); // Restituisce la differenza assoluta tra le età delle due persone
        }

        public void StampaDati()
        {
            Console.WriteLine("Dati della Persona:");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Cognome: {cognome}");
            Console.WriteLine($"Età: {eta}");
            Console.WriteLine($"Indirizzo: {indirizzo}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Telefono: {numeroDiTelefono}");
            Console.WriteLine($"Sesso: {sesso}");
            Console.WriteLine($"Data di Nascita: {dataDiNascita.ToShortDateString()}");
            Console.WriteLine($"Codice Fiscale: {codiceFiscale}");
            Console.WriteLine($"Nazionalità: {nazionalita}");
        }
    }
}


/*
 * Ecco una definizione semplice e comprensibile di classe e di oggetto:
 * 
 * Classe
 * Una classe è un modello o schema che definisce le caratteristiche e i comportamenti di un tipo di "cosa". In programmazione, la classe descrive quali proprietà (campi o attributi)
 * e azioni (metodi o funzioni) quel tipo di cosa può avere. Pensa a una classe come a una ricetta: contiene le istruzioni su come creare e definire qualcosa, ma non è l'oggetto stesso.
 * 
 * Ad esempio, una classe Persona potrebbe definire che ogni persona ha:
 * Campi come nome, cognome, età.
 * Azioni come parla() o cammina().
 * 
 * Oggetto
 * Un oggetto è un'istanza (cioè una versione concreta) della classe. È il risultato dell'applicazione del modello definito dalla classe. 
 * L'oggetto è reale e utilizzabile nel programma, con i propri valori per le proprietà definite dalla classe.
 * Se la classe è una "ricetta", un oggetto è la "torta" che hai preparato seguendo quella ricetta. Puoi avere molti oggetti creati dalla stessa classe, ognuno con i propri valori. 
 * Ad esempio:
 * persona1 e persona2 possono essere due oggetti della classe Persona.
 * persona1 potrebbe avere nome = "Mario" e età = 30, mentre persona2 potrebbe avere nome = "Laura" e età = 25.
 * 
 * In sintesi:
 * La classe è il modello teorico.
 * L’oggetto è l'elemento reale che usiamo nel programma, creato seguendo quel modello. 
 */


/*
 * Riassunto dei Metodi
 * Metodi Privati:
 * CalcolaAnnoDiNascita(): calcola l'anno di nascita basato sull'età.
 * FormattaIndirizzo(): formatta e restituisce una stringa con l'indirizzo.
 * Metodi Pubblici che Utilizzano Metodi Privati:
 * 
 * StampaAnnoDiNascita(): utilizza il metodo privato CalcolaAnnoDiNascita() per calcolare e stampare l'anno di nascita.
 * StampaIndirizzoFormattato(): utilizza FormattaIndirizzo() per ottenere una versione formattata dell'indirizzo.
 * Metodo Statico:
 * 
 * Saluta(): un metodo statico che stampa un saluto generico. Non richiede un'istanza della classe Persona.
 * Metodo Virtuale:
 * 
 * Parla(): un metodo virtuale che può essere sovrascritto nelle classi derivate per fornire comportamenti specifici.
 * Override del Metodo ToString():
 * Fornisce una rappresentazione personalizzata dell'oggetto Persona come stringa, includendo nome, cognome, età e nazionalità.
 * Metodo Asincrono:
 * 
 * SimulaAttesaAsync(): un metodo asincrono che simula un’attesa di due secondi e stampa messaggi prima e dopo l’attesa.
 * Metodo Statico per il Confronto:
 * 
 * CalcolaDifferenzaEta(): un metodo statico che calcola la differenza di età tra due oggetti Persona. 
 */


/*
 * 
 * Un metodo è statico quando è dichiarato con la parola chiave static e non appartiene a una specifica istanza (oggetto) della classe, ma alla classe stessa. 
 * In altre parole, un metodo statico può essere chiamato direttamente dalla classe senza creare un oggetto di quella classe.
 * 
 * Caratteristiche di un Metodo Statico
 * Non richiede un’istanza: Puoi chiamare un metodo statico utilizzando solo il nome della classe.
 * 
 * Persona.Saluta(); // Chiama il metodo statico Saluta() dalla classe Persona
 * Accesso limitato ai membri della classe: Un metodo statico può accedere solo ad altri membri statici della classe (come campi o metodi statici). 
 * Non può accedere ai membri di istanza (non statici), perché non ha un riferimento a un oggetto specifico della classe.
 * Usi comuni: I metodi statici sono spesso utilizzati per operazioni generali o per funzionalità che non dipendono dai dati specifici di un oggetto. 
 * 
 * Ad esempio, un metodo che calcola una distanza o una conversione di unità potrebbe essere statico. 
 * 
 * Esempio di Metodo Statico
 * Considera la seguente classe Matematica con un metodo statico Somma:
 *
 * public class Matematica
 * {
 *     public static int Somma(int a, int b)
 *     {
 *         return a + b;
 *     }
 * }
 * Puoi chiamare Somma direttamente sulla classe Matematica senza creare un’istanza della classe:
 *
 * int risultato = Matematica.Somma(3, 5); // Risultato sarà 8
 * Confronto con i Metodi di Istanza
 * Al contrario, i metodi di istanza (non statici) richiedono che tu crei un'istanza (oggetto) della classe prima di poterli chiamare, perché operano sui dati di quell'oggetto specifico.
 * 
 * Esempio:   
 * public class Persona
 * {
 *     public string Nome { get; set; }
 *       public void Presentati()
 *     {
 *         Console.WriteLine($"Ciao, sono {Nome}");
 *     }
 * }
 *
 * // Utilizzo
 * Persona persona = new Persona();
 * persona.Nome = "Mario";
 * persona.Presentati(); // Stampa "Ciao, sono Mario"
 * In sintesi, un metodo statico appartiene alla classe nel suo complesso, mentre un metodo di istanza è legato a un singolo oggetto.
 */