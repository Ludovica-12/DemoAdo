using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado
{
    class DbManagerDisconnectedMode
    {
        const string connectionString = @"Data Source = (localdb)\MSSQLLocalDB;" +
                                      "Initial Catalog = DemoAdo;" +
                                      "Integrated Security = true;";

        public void Fetch()
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();

                SqlCommand selectCommand = new SqlCommand();
                selectCommand.Connection = connection;
                selectCommand.CommandType = System.Data.CommandType.Text;
                selectCommand.CommandText = "selec * from Book";

                adapter.SelectCommand = selectCommand;

                connection.Open();

                DataSet dataSet = new DataSet();

                adapter.Fill(dataSet, "Book");

                foreach(DataRow row in dataSet.Tables["Book"].Rows)
                {
                    var titolo = row["Title"];
                    var autore = row["Author"];
                    var prezzo = row["Price"];
                    var id = row["Id"];

                    Console.WriteLine($"{titolo} - {autore} - {prezzo} - {id}");

                }

            }
        }

        public void Insert(Book book)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //Comando di selec
                SqlCommand selectCommand = new SqlCommand();
                selectCommand.Connection = connection;
                selectCommand.CommandType = System.Data.CommandType.Text;
                selectCommand.CommandText = "select * from Book";

                //Comando di insert
                SqlCommand insertCommand = new SqlCommand();
                insertCommand.Connection = connection;
                insertCommand.CommandType = System.Data.CommandType.Text;
                insertCommand.CommandText = "insert into Book values(@titolo, @autore, @prezzo)";

                //insertCommand.Parameters.AddWithValue("@titolo", book.Title); //Altro modo per scrivere
                insertCommand.Parameters.Add("@titolo", SqlDbType.VarChar, 50, "Title");
                insertCommand.Parameters.Add("@autore", SqlDbType.VarChar, 50, "Author");
                insertCommand.Parameters.Add("@autore", SqlDbType.Decimal, 500, "Price");

                SqlDataAdapter adapter = new SqlDataAdapter();

                adapter.SelectCommand = selectCommand;
                adapter.InsertCommand = insertCommand;

                DataSet dataSet = new DataSet();
                connection.Open();

                //Carica
                adapter.Fill(dataSet, "Book");

                //Riga vuota
                DataRow row = dataSet.Tables["Book"].NewRow();

                //Che abbiamo valorizzato
                row["Title"] = book.Title;
                row["Author"] = book.Author;
                row["Price"] = book.Price;

                //Aggiungi riga
                dataSet.Tables["Book"].Rows.Add(row);

                //Update dell'intera tabella
                adapter.Update(dataSet, "Book");

            }
        }

        public void Delete(Book book)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //Comando di select
                SqlCommand selectCommand = new SqlCommand();
                selectCommand.Connection = connection;
                selectCommand.CommandType = System.Data.CommandType.Text;
                selectCommand.CommandText = "select * from Book";

                //Comando di delete
                SqlCommand deleteCommand = new SqlCommand();
                deleteCommand.Connection = connection;
                deleteCommand.CommandType = System.Data.CommandType.Text;
                deleteCommand.CommandText = "delete from Book where Id = @id";
                deleteCommand.Parameters.Add("@id", SqlDbType.Int);

                //Associo all'adapter i command che dovrà verificare ed eseguire
                SqlDataAdapter adapter = new SqlDataAdapter();

                adapter.SelectCommand = selectCommand;
                adapter.DeleteCommand = deleteCommand;

                connection.Open();

                //Definisco un dataset che è una struttura che contiene tutti i dati
                DataSet dataSet = new DataSet();

                //Dico all'adapter di caricarmi i dati i questo dataset
                adapter.Fill(dataSet, "Book");//-> Ho in locale tutti i dati e le proprietà della tabella

                int count = 0;
                //Prendi tutte le righe della tabella
                foreach(DataRow row in dataSet.Tables["Book"].Rows)
                {
                    if ((int)row["Id"] == book.Id)
                    {
                        break;
                    }
                    count++;

                    //Ho cancellato dal dataset(dalla mia tabella in locale) la riga in posizione count
                    dataSet.Tables["Book"].Rows[count].Delete();

                    //Aggiorna il db verificando che la tabella che sta andando a modificare
                    //è effettivamente modificata con il comando che ho definito (deleteCommand
                    adapter.Update(dataSet, "Book");// -> Ho il db aggiornato


                }



            }
        }

    }
}
