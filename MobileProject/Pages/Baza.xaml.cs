using Microsoft.Maui.Controls;
using MySql.Data.MySqlClient;
using System.Reflection.PortableExecutable;
using MobileProject.Classes;
using Mysqlx.Connection;

namespace MobileProject.Pages;

public partial class Baza : ContentPage
{
	public Baza()
	{
		InitializeComponent();
        
    }
     
    private async void button_baza_Clicked(object sender, EventArgs e)
    {
        string connectionString = "server=localhost;port:3306;user=andrei;password=1234;database=mobile_app";
        MySqlConnection connection = new MySqlConnection(connectionString);
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
        



    }
}
