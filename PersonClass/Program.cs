using System;

namespace PersonClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creazione di una persona utilizzando il costruttore senza parametri
            Persona persona1 = new Persona();
            persona1.SetNome("Mario");
            persona1.SetCognome("Rossi");
            persona1.SetEta(30);
            persona1.SetIndirizzo("Via Roma, 123");
            persona1.SetEmail("mario.rossi@example.com");
            persona1.SetNumeroDiTelefono("1234567890");
            persona1.SetSesso("M");
            persona1.SetDataDiNascita(new DateTime(1993, 4, 15));
            persona1.SetCodiceFiscale("RSSMRA93D15H501R");
            persona1.SetNazionalita("Italiana");

            // Creazione di una persona utilizzando il costruttore con 3 parametri
            Persona persona2 = new Persona("Laura", "Bianchi", 25);
            persona2.SetIndirizzo("Via Milano, 456");
            persona2.SetEmail("laura.bianchi@example.com");
            persona2.SetNumeroDiTelefono("0987654321");
            persona2.SetSesso("F");
            persona2.SetDataDiNascita(new DateTime(1998, 6, 20));
            persona2.SetCodiceFiscale("BNCURA98H20D612Q");
            persona2.SetNazionalita("Italiana");

            // Creazione di una persona utilizzando il costruttore con tutti i parametri
            Persona persona3 = new Persona(
                "Giuseppe",
                "Verdi",
                40,
                "Via Napoli, 789",
                "giuseppe.verdi@example.com",
                "1122334455",
                "M",
                new DateTime(1983, 11, 5),
                "VRDGPP83S05L219Q",
                "Italiana"
            );

            // Stampa delle informazioni delle persone
            Console.WriteLine("Persona 1:");
            persona1.StampaDati();
            Console.WriteLine();

            Console.WriteLine("Persona 2:");
            persona2.StampaDati();
            Console.WriteLine();

            Console.WriteLine("Persona 3:");
            persona3.StampaDati();
            Console.ReadKey();
        }
    }
}

/* Descrizione del Codice
 * persona1: creata con il costruttore senza parametri. I campi vengono impostati successivamente utilizzando i metodi setter.
 * persona2: creata con il costruttore che accetta tre parametri (nome, cognome, eta). Gli altri campi vengono impostati tramite i metodi setter.
 * persona3: creata con il costruttore completo che accetta tutti i parametri necessari per impostare ogni campo.
 * Il metodo StampaDati() viene chiamato per ogni persona per visualizzare le informazioni, e Console.ReadKey() consente di visualizzare i dati stampati prima che la console si chiuda. 
 */