using Golf.Entites;
using Golf.ListRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golf
{
    class SocietyManager
    {
        public static UserListRepository userRepository = new UserListRepository();

        internal static void ShowMembers()
        {
            List<User> users = userRepository.Fetch();
            foreach (var user in users)
            {
               user.Print();
            }
        }

        internal static void UpdateMembers()
        {
            List<User> users = userRepository.Fetch();
            int i = 1;
            foreach (var u in users)
            {
                Console.WriteLine($"Premi {i} per modificare l'utente");
                u.Print();
                i++;
            }
            bool isInt;
            int utenteScelto;
            do
            {
                Console.WriteLine("Quale utente?");

                isInt = int.TryParse(Console.ReadLine(), out utenteScelto);

            } while (!isInt || utenteScelto <= 0 || utenteScelto > users.Count);

            Console.WriteLine("Hai scelto di modificare");
            User user = users.ElementAt(utenteScelto - 1);
            if (user.Id == null)
            {
                userRepository.Delete(user);
            }

            bool continuare = true;
            string risposta;
            do
            {
                Console.WriteLine("Vuoi modificare il nome?");
                risposta = Console.ReadLine();
                if (risposta == "si" || risposta == "no")
                    continuare = false;
            } while (continuare);
            if (risposta == "si")
            {
                user.FirstName = InsertNome();
            }

            do
            {
                Console.WriteLine("Vuoi modificare il cognome?");
                risposta = Console.ReadLine();
                if (risposta == "si" || risposta == "no")
                    continuare = false;
            } while (continuare);
            if (risposta == "si")
            {
                user.Cognome = InsertCognome();
            }

            do
            {
                Console.WriteLine("Vuoi modificare la data di nascita?");
                risposta = Console.ReadLine();
                if (risposta == "si" || risposta == "no")
                    continuare = false;
            } while (continuare);
            if (risposta == "si")
            {
                user.DataDiNascita = InsertDate();
            }

            do
            {
                Console.WriteLine("Vuoi modificare il sesso?");
                risposta = Console.ReadLine();
                if (risposta == "si" || risposta == "no")
                    continuare = false;
            } while (continuare);
            if (risposta == "si")
            {
                user.Sesso = InsertSesso();
            }

            do
            {
                Console.WriteLine("Vuoi modificare se è o no tesserato?");
                risposta = Console.ReadLine();
                if (risposta == "si" || risposta == "no")
                    continuare = false;
            } while (continuare);
            if (risposta == "si")
            {
                user.Tesserato = InsertTesserato();
            }

            userRepository.Update(user);
        }

        internal static void DeleteMembers()
        {
            Console.WriteLine("Scegli chi vuoi eliminare");
            User user = ScegliUser();
            userRepository.Delete(user);
        }

        private static User ScegliUser()
        {
            List<User> users = userRepository.Fetch();
            User user1 = new User();

            int i = 1;
            foreach(var user in users)
            {
                Console.WriteLine($"\nPremi {i} per selezionare il seguente partecipante: ");
                user.Print();

                i++;
            }

            int scelta;
            do
            {
                Console.WriteLine("\nQuale partecipante vuoi scegliere?");

            } while (!int.TryParse(Console.ReadLine(), out scelta) || scelta < 0 || scelta > users.Count);
            //{
            //    Console.WriteLine("Scelta errata! Riprova");
            //}
            return users.ElementAt(scelta - 1);
        }

        internal static void InsertMembers()
        {

            User user = new User();

            user.FirstName = InsertNome();
            user.LastName = InsertCognome();
            user.Date = InsertDate();
            user.Gender = InsertSesso();
            user.Member = InsertTesserato();
            userRepository.Insert(user);
        }

        private static bool InsertTesserato()
        {
            //bool continuare = true;
            //string risposta;
            //do
            //{
            //    Console.WriteLine("Sei tesserato? Scrivi si o no");
            //    risposta = Console.ReadLine();
            //    if (risposta == "si" || risposta == "no")
            //        continuare = false;
            //} while (continuare);

            //return risposta == "si" ? true : false;

            //-----OPPURE-----------------

            bool member = true;
            string risposta;

            do
            {
                Console.WriteLine("Il partecipante è tesserato? Digita 'si' se il partecipante è tesserato, altrimenti digita 'no'.");
                risposta = Console.ReadLine();

            } while (risposta != "si" && risposta != "no");

            if (risposta != "si") member = false;
            
            return member;

        }

        private static GenderEnum InsertSesso()
        {
            bool isInt = false;
            int sesso = 0;
            do
            {
                Console.WriteLine("Inserisci il sesso");
                foreach (var genere in Enum.GetValues(typeof(GenderEnum)))
                {
                    Console.WriteLine($"Premi {(int)genere} per {(GenderEnum)genere}");
                }

                isInt = int.TryParse(Console.ReadLine(), out sesso);
            } while (!isInt || sesso < 1 || sesso > 2);
            return (GenderEnum)sesso;
        }

        private static DateTime InsertDate()
        {
            //DateTime dt = new DateTime();
            //bool isDate;
            //do
            //{
            //    Console.WriteLine("Inserisci la data di nascita");

            //    isDate = DateTime.TryParse(Console.ReadLine(), out dt);

            //} while (!isDate);
            //return dt;

            //----------------------OPPURE-----------------------------

            Console.WriteLine("Inserisci la data di nascita.");
            DateTime data;
            while (!DateTime.TryParse(Console.ReadLine(), out data))
            {
                Console.WriteLine("Inserisci una data valida.");
            }
            return data;
        }

        private static string InsertCognome()
        {
            string cognome = String.Empty;
            do
            {
                Console.WriteLine("Inserisci cognome");
                cognome = Console.ReadLine();

            } while (String.IsNullOrEmpty(cognome));
            return cognome;
        }

        private static string InsertNome()
        {
            string nome = String.Empty;
            do
            {
                Console.WriteLine("Inserisci nome");
                nome = Console.ReadLine();

            } while (String.IsNullOrEmpty(nome));
            return nome;
        }
    }
}
