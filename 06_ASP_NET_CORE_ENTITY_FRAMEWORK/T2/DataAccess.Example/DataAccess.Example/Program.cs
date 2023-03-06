// See https://aka.ms/new-console-template for more information
using DataAccess.Example.Entities;
using System.Runtime.CompilerServices;

internal class Program
{


    const string mySqlConnectionString = "server=localhost;port=3306;database=sqltesting;user=root;password=cevh35xz24eli;CharSet=utf8;SslMode=none;Pooling=false;AllowPublicKeyRetrieval=True";
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var users = getAllUsers();

        var usuario1 = getUserById(1);

        var usuario2 = getUserById(2);

        var company = createCompany("HP", "MX", "juanPerez@gmail.com", "wil@yahoo.com");

        Console.ReadKey();



    }


    private static List<User> getAllUsers()
    {
        List<User> users = new List<User>();

        //Conexión a la bdd
        MySqlConnector.MySqlConnection connection = new MySqlConnector.MySqlConnection(mySqlConnectionString);

        connection.Open();


        try
        {
            MySqlConnector.MySqlCommand command = new MySqlConnector.MySqlCommand("GetAllUsers", connection);

            command.CommandType = System.Data.CommandType.StoredProcedure;

            var reader = command.ExecuteReader();

            while (reader.Read()) //Leer los registros de:
            {

                User user = new User()
                {
                    ID = (int)reader["iduser"],
                    UserName = (string)reader["username"],
                    Email = (string)reader["email"],
                    CompanyID = (int)reader["idcompany"]
                };


                users.Add(user);
            }

        }
        finally {
            connection.Clone();

        }

        return users;
    }




    private static User getUserById(int _IdParam)
    {

        MySqlConnector.MySqlConnection connection = new MySqlConnector.MySqlConnection(mySqlConnectionString);

        connection.Open();

        User user = null;

        try
        {
            MySqlConnector.MySqlCommand command = new MySqlConnector.MySqlCommand("GetUserById", connection);

            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("IdParam", _IdParam);

            //Función que sirve para leer los registros de las columnas que se devuelven
            var reader = command.ExecuteReader();

            while (reader.Read()) //Leer los registros de:
            {

                //Aignar los valores de cada columna de la tabla a los atributos de la entidad User
                user = new User()
                {
                    ID = (int)reader["iduser"],
                    UserName = (string)reader["username"],
                    Email = (string)reader["email"],
                    CompanyID = (int)reader["idcompany"]
                };
            }

        }
        finally
        {
            connection.Clone();

        }

        return user;
    }




    private static CompanyCreateResult createCompany(string companyName, string companyLocation, string adminEmail, string userEmail)
    {

        MySqlConnector.MySqlConnection connection = new MySqlConnector.MySqlConnection(mySqlConnectionString);

        connection.Open();

        CompanyCreateResult company = null;

        try
        {
            MySqlConnector.MySqlCommand command = new MySqlConnector.MySqlCommand("CreateCompany", connection);

            //Establecer que tipo de comando fue el que le pasamos
            command.CommandType = System.Data.CommandType.StoredProcedure;

            //Agregar los parametros in
            command.Parameters.AddWithValue("_companyName", companyName);
            command.Parameters.AddWithValue("_location", companyLocation);
            command.Parameters.AddWithValue("_adminEmail", adminEmail);
            command.Parameters.AddWithValue("_userEmail", userEmail);

            //Asignar los parametros de salida y su tipo a las variables
            var outputParameterIdCompany = command.Parameters.Add("_idcompany", System.Data.DbType.Int32);
            var outputParameterIdUser = command.Parameters.Add("_iduser", System.Data.DbType.Int32);
            var outputParameterIdAdmin = command.Parameters.Add("_idadmin", System.Data.DbType.Int32);

            //Inddicar en la dirección que son parametros de salida
            outputParameterIdCompany.Direction = System.Data.ParameterDirection.Output;
            outputParameterIdUser.Direction = System.Data.ParameterDirection.Output;
            outputParameterIdAdmin.Direction = System.Data.ParameterDirection.Output;


            //Usar executeNoQuery para insert, delete y update (funciones crud que pueden devolver parametros de salida)
            var reader = command.ExecuteNonQuery();


            //Se le asigna los parametros a los atributos de la entidad que creamos
            company = new CompanyCreateResult
            {
                IdCompany = (int)outputParameterIdCompany.Value,
                IdUser = (int)outputParameterIdUser.Value,
                IdAdmin = (int)outputParameterIdAdmin.Value
            };


        }
        finally
        {
            connection.Clone();

        }

        return company;
    }


}