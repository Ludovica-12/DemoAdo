using System;

namespace NegozioElettronica
{
    internal class Menu
    {
        internal static void Start()
        {
            bool continuare = true;

            do
            {
                Console.WriteLine("Premi 1 per visualizzare tutti i Prodotti");
                Console.WriteLine("Premi 2 per visualizzare tutti i Cellulari");
                Console.WriteLine("Premi 3 per visualizzare tutti i Pc");
                Console.WriteLine("Premi 4 per visualizzare tutti le Tv");
                Console.WriteLine("Premi 5 per inserire un nuovo Prodotto");
                Console.WriteLine("Premi 6 per modificare un Prodotto");
                Console.WriteLine("Premi 7 per eliminare un Prodotto");
                Console.WriteLine("Premi 8 per filtrare i cellulare per memoria");
                Console.WriteLine("Premi 9 per filtrare i pc per sistema operativo");
                Console.WriteLine("Premi 10 per filtrare la tv per i pollici");
                Console.WriteLine("Premi 0 per uscire");
                Console.WriteLine();
                string scelta = Console.ReadLine();

                switch (scelta)
                {
                    case "1":
                        //Visualizzare i prodotti
                        {
                            NegozioManager.ShowProduct();
                            break;
                        }

                    case "2":
                        //Visualizzare i cellulari
                        {
                            NegozioManager.ShowTelephone();
                            break;
                        }

                    case "3":
                        //Visualizzare i Pc
                        {
                            NegozioManager.ShowPc();
                            break;
                        }

                    case "4":
                        //Visualizzare le tv
                        {
                            NegozioManager.ShowTv();
                            break;
                        }

                    case "5":
                        //Inserisci prodotto
                        NegozioManager.InsertProduct();
                        break;

                    case "6":
                        //Modifica prodotto
                        NegozioManager.UpdateProduct();
                        break;

                    case "7":
                        //Elimina prodotto

                        break;

                    case "8":
                        //Filtra cellulare

                        break;

                    case "9":
                        //Filtra pc

                        break;

                    case "10":
                        //Filtra tv

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