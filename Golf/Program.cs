using System;

namespace Golf
{
    // Torneo di golf
    // Scrivere un programma che gestisca l'iscrizione a un torneo di golf.



    // Al momento dell'iscrizione un utente deve fornire i seguenti dati:
    // - Nome
    // - Cognome
    // - Data di nascita
    // - Sesso(Maschio o femmina)
    // - Se è o no tesserato



    // Il programma permette di:
    // - visualizzare tutti gli iscritti
    // - modificare i dati di un iscritto
    // - eliminare un iscritto
    // - inserire un nuovo iscritto
    // - avere le informazioni di un iscritto dato nome e cognome
    // - fitrare gli iscritti tesserati



    // Note:

    // - rispettare la corretta struttura(Ogni classe e ogni metodo hanno uno e un solo scopo)
    // - creare un repository fittizio(quindi anche le interfacce)
    // - salvare i dati su sql server tramite ado

    class Program
    {
        static void Main(string[] args)
        {
            Menu.Start();
        }
    }
}
