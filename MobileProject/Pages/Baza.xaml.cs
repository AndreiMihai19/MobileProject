using Microsoft.Maui.Controls;

using System.Reflection.PortableExecutable;
using MobileProject.Classes;
using Xceed.Wpf.Toolkit;
using System.Windows;
using MySql.Data.MySqlClient;
//using MySqlConnector;

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

        // try
        // {
        string connectionString = "server=localhost;user=andrei;password=1234;database=mobile_app;";
        // string connectionString = "root@localhost:3306";
        MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();
            string query = "SELECT * FROM test";


            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string valoare = reader.GetString(1);
                BazaDeDate1.Text = valoare;

                // Poți accesa valorile din rândurile rezultatei aici
            }
            reader.Close();

            connection.Close();
        //}
        //catch (Exception ex)
        //{

        //    Console.WriteLine("A apărut o eroare: " + ex.Message);
        //}
    }
        
}


