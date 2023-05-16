using Microsoft.Maui.Controls;
//using MySql.Data.MySqlClient;
using System.Reflection.PortableExecutable;
using MobileProject.Classes;
using Xceed.Wpf.Toolkit;
using System.Windows;
using MySqlConnector;

namespace MobileProject.Pages;

public partial class Baza : ContentPage
{
    public Baza()
    {
        InitializeComponent();

    }

    [Obsolete]
    private async void button_baza_Clicked(object sender, EventArgs e)
    {
        /*
        try
        {
            string connectionString = "server=localhost;uid=andrei;pwd=1234;database=mobile_app";
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();
            string query = "SELECT * FROM test";


            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string valoare = reader.GetString(3);
                BazaDeDate1.Text = valoare;

                // Poți accesa valorile din rândurile rezultatei aici
            }
            reader.Close();

            connection.Close();
        }
        catch (Exception ex)
        {

            Console.WriteLine("A apărut o eroare: " + ex.Message);
        }
    }
        */


        //string connectionString = "server=localhost;user=andrei;password=1234;database=mobile_app";

        //MySqlConnection conn = new MySqlConnection(connectionString);

        //try
        //{
        //    // Deschide conexiunea
        //    conn.Open();

        //    // Exemplu de interogare
        //    string query = "SELECT * FROM test";
        //    MySqlCommand command = new MySqlCommand(query, conn);

        //    // Execută interogarea și preia rezultatele
        //    MySqlDataReader reader = command.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        string valoare = reader.GetString(3);
        //        BazaDeDate1.Text = valoare;
        //    }

        //    // Închide cititorul și conexiunea
        //    reader.Close();
        //}
        //catch (Exception ex)
        //{
        //    // Gestionează excepțiile
        //    Console.WriteLine("A apărut o eroare: " + ex.Message);
        //}
        //finally
        //{
        //    // Închide conexiunea
        //    conn.Close();
        //}

        string connectionString = "server=localhost; port=3306; database=mobile_app; user=root; password=mobile123$root;";
        using (var connection = new MySqlConnection(connectionString))
        {
            // Folosiți conexiunea pentru a accesa baza de date
            connection.Open();

            //string query = "SELECT * FROM test";
            //using (var command = new MySqlCommand(query, connection))
            //{
            //    using (var reader = command.ExecuteReader())
            //    {
            //        while (reader.Read())
            //        {
            //            // Procesați rândurile rezultatului interogării aici
            //            BazaDeDate1.Text = reader.GetString(1);
            //        }
            //    }

            //}

        }

    }
}

