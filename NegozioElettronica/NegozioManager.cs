using NegozioElettronica.Entites;
using NegozioElettronica.ListRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegozioElettronica
{
    class NegozioManager
    {
        static ProductListRepository productRepository = new ProductListRepository();
        static TelephoneListRepository telephoneRepository = new TelephoneListRepository();
        static PcListRepository pcRepository = new PcListRepository();
        static TvListRepository tvRepository = new TvListRepository();


        internal static void ShowProduct()
        {
            List<Product> phones = productRepository.Fetch();
            foreach (var p in phones)
            {
                p.Print();
            }
        }

        internal static void ShowTelephone()
        {
            List<Telephone> phones = telephoneRepository.Fetch();
            foreach(var p in phones)
            {
                p.Print();
            }
        }

        internal static void ShowPc()
        {
            List<Pc> computers = pcRepository.Fetch();
            foreach (var p in computers)
            {
                p.Print();
            }
        }

        internal static void ShowTv()
        {
            List<Tv> tvs = tvRepository.Fetch();
            foreach (var t in tvs)
            {
                t.Print();
            }
        }

        internal static void InsertProduct()
        {
            int scelta = ScegliProdotto();
            switch (scelta)
            {
                case 1:
                    {
                        //Telephone cell = new Telephone();
                        Telephone cell = InsertTelephone();
                        telephoneRepository.Insert(cell);
                        break;
                    }
                case 2:
                    {
                        //Pc computer = new Pc();
                        Pc computer = InsertPc();
                        pcRepository.Insert(computer);
                        break;
                    }
                case 3:
                    {
                        //Tv tvs = new Tv();
                        Tv tvs = InsertTv();
                        tvRepository.Insert(tvs);
                        break;
                    }
                default:
                    break;
            }

        }

        internal static void UpdateProduct()
        {
            int scelta = ModificaProdotto();
            switch (scelta)
            {
                case 1:
                    {
                        Telephone cell = UpdateTelephone();
                        telephoneRepository.Update(cell);
                        break;
                    }
                case 2:
                    {
                        Pc computer = UpdatePc();
                        pcRepository.Update(computer);
                        break;
                    }
                case 3:
                    {
                        Tv tvs = UpdateTv();
                        tvRepository.Update(tvs);
                        break;
                    }
                default:
                    break;
            }

        }

        private static int ModificaProdotto()
        {
            int scelta;

            do
            {
                Console.WriteLine("Premi 1 per modificare un Cellulare");
                Console.WriteLine("Premi 2 per modificare un Pc");
                Console.WriteLine("Premi 3 per modificare una Tv");

            } while (!int.TryParse(Console.ReadLine(), out scelta) || scelta < 0 || scelta > 3);

            return scelta;
        }

        private static Tv InsertTv()
        {
            Tv tvs = new Tv();

            tvs.Marca = InserisciMarca();
            tvs.Modello = InserisciModello();
            tvs.Quantita = InserisciQuantita();
            tvs.Pollici = InserisciPollici();

            return tvs;
        }

        private static int InserisciPollici()
        {
            bool isInt;
            int n;
            do
            {
                Console.WriteLine("Inserisci i pollici");
                isInt = int.TryParse(Console.ReadLine(), out n);
            } while (!isInt);

            return n;
        }

        private static Pc InsertPc()
        {
            Pc computer = new Pc();

            computer.Marca = InserisciMarca();
            computer.Modello = InserisciModello();
            computer.Quantita = InserisciQuantita();
            computer.SistemaOperativo = InserisciSistemaOp();
            computer.IsTouch = InserisciTouch();

            return computer;

        }

        private static bool InserisciTouch()
        {
            string risposta;
            do
            {
                Console.WriteLine("Touch screen presente? Si o no?");
                risposta = Console.ReadLine();

            } while (risposta != "si" && risposta != "no");

            return risposta == "si" ? true : false;
        }

        private static EnumSistema InserisciSistemaOp()
        {
            int sistemaOp = 0;
            bool isInt = false;
            do
            {
                Console.WriteLine("Inserisci il sistema operativo:");
                foreach(var sistema in Enum.GetValues(typeof(EnumSistema)))
                {
                    Console.WriteLine($"Premi {(int)sistema} per {(EnumSistema)sistema}");
                }

                isInt = int.TryParse(Console.ReadLine(), out sistemaOp);

            } while (!isInt || sistemaOp < 1 || sistemaOp > 2);

            return (EnumSistema)sistemaOp;
        }

        private static Telephone InsertTelephone()
        {
            Telephone cell = new Telephone();

            cell.Marca = InserisciMarca();
            cell.Modello = InserisciModello();
            cell.Quantita = InserisciQuantita();
            cell.Memoria = InserisciMemoria();

            return cell;
        }

        private static int InserisciMemoria()
        {
            bool isInt;
            int n;
            do
            {
                Console.WriteLine("Inserisci la memoria");
                isInt = int.TryParse(Console.ReadLine(), out n);
            } while (!isInt);

            return n;
        }

        private static int InserisciQuantita()
        {
            bool isInt;
            int n;
            do
            {
                Console.WriteLine("Inserisci la quantità in magazzino");
                isInt = int.TryParse(Console.ReadLine(), out n);
            } while (!isInt);

            return n;
        }

        private static string InserisciModello()
        {
            string modello = String.Empty;
            do
            {
                Console.WriteLine("Inserisci il modello");
                modello = Console.ReadLine();

            } while (String.IsNullOrEmpty(modello));

            return modello;
        }

        private static string InserisciMarca()
        {
            string marca = String.Empty;
            do
            {
                Console.WriteLine("Inserisci la marca");
                marca = Console.ReadLine();

            } while (String.IsNullOrEmpty(marca));

            return marca;
        }

        private static int ScegliProdotto()
        {
            int scelta;

            do
            {
                Console.WriteLine("Premi 1 per inserire un nuovo Cellulare");
                Console.WriteLine("Premi 2 per inserire un nuovo Pc");
                Console.WriteLine("Premi 3 per inserire una nuova Tv");

            } while (!int.TryParse(Console.ReadLine(), out scelta) || scelta < 0 || scelta > 3 );

            return scelta;
        }
    }
}
