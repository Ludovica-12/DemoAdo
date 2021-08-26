using System;

namespace Golf
{
    internal class Menu
    {
        internal static void Start()
        {
            bool continuare = true;

            do
            {
                Console.WriteLine("Premi 1 per visualizzare tutti gli iscritti");
                Console.WriteLine("Premi 2 per modificare i dati di un iscritto");
                Console.WriteLine("Premi 3 per eliminare un iscritto");
                Console.WriteLine("Premi 4 per inserire un nuovo iscritto");
                Console.WriteLine("Premi 5 per le informazioni di un iscritto");
                Console.WriteLine("Premi 6 per cercare gli iscritti tesserati");
                Console.WriteLine("Premi 0 per uscire");
                Console.WriteLine();
                string scelta = Console.ReadLine();

                switch (scelta)
                {
                    case "1":
                        //Visualizzare iscritti
                        SocietyManager.ShowMembers();
                        break;
                    case "2":
                        //Modifica iscritto
                        SocietyManager.UpdateMembers();
                        break;
                    case "3":
                        //Elimina iscritto
                        SocietyManager.DeleteMembers();
                        break;
                    case "4":
                        //Inserisci nuovo iscritto
                        SocietyManager.InsertMembers();
                        break;
                    case "5":
                        //Informazioni iscritto
                        
                        break;
                    case "6":
                        //Cercare tesserati
                        
                        break;
                    case "0":
                        Console.WriteLine("Ciao alla prossima");
                        continuare = false;
                        break;
                    default:
                        Console.WriteLine("Scelta sbagliata riprova");
                        break;
                }
            } while (continuare);
        }
    }
}