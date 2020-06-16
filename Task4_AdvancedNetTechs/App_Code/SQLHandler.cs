using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;

public class SQLHandler
{
    private string sqlConnection;

    public SQLHandler(string sqlConnection)
    {
        this.sqlConnection = sqlConnection;
    }

    public void Update_DB(decimal money)
    {
        try
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = sqlConnection;
                connection.Open();


                string fullCommand = $"UPDATE Farm SET money = {money} WHERE id=1;";

                SqlCommand command = new SqlCommand(fullCommand, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }
        catch(Exception e)
        {
            //there should be an alert            
        }
    }

    public void Update_DB(DateTime dateTime)
    {
        try
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = sqlConnection;
                connection.Open();


                string fullCommand = $"UPDATE Farm SET dateTime = {dateTime} WHERE id=1;";

                SqlCommand command = new SqlCommand(fullCommand, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }
        catch (Exception e)
        {
            //there should be an alert            
        }
    }

    public void Update_DB(int actualProduction)
    {
        try
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = sqlConnection;
                connection.Open();


                string fullCommand = $"UPDATE Farm SET actualProduction = {actualProduction} WHERE id=1;";

                SqlCommand command = new SqlCommand(fullCommand, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }
        catch (Exception e)
        {
            //there should be an alert            
        }
    }

    public DateTime GetLastActionDate()
    {
        using (SqlConnection connection = new SqlConnection())
        {
            connection.ConnectionString = sqlConnection;
            connection.Open();

            string command = "SELECT TOP(1) dateTime FROM Farm;";
            SqlCommand sqlCommand = new SqlCommand(command, connection);

            SqlDataReader reader = sqlCommand.ExecuteReader();
            string column = "dateTime";

            DateTime result = (DateTime)reader[column];
            return result;
        }
    }

    public decimal GetMoney()
    {
        using (SqlConnection connection = new SqlConnection())
        {
            connection.ConnectionString = sqlConnection;
            connection.Open();

            string command = "SELECT TOP(1) money FROM Farm;";
            SqlCommand sqlCommand = new SqlCommand(command, connection);

            SqlDataReader reader = sqlCommand.ExecuteReader();
            string column = "money";

            decimal result = (decimal)reader[column];
            return result;
        }
    }

    public int GetActualProduction()
    {
        using (SqlConnection connection = new SqlConnection())
        {
            connection.ConnectionString = sqlConnection;
            connection.Open();

            string command = "SELECT TOP(1) actualProduction FROM Farm;";
            SqlCommand sqlCommand = new SqlCommand(command, connection);

            SqlDataReader reader = sqlCommand.ExecuteReader();
            string column = "actualProduction";

            int result = (int)reader[column];
            return result;
        }
    }
}