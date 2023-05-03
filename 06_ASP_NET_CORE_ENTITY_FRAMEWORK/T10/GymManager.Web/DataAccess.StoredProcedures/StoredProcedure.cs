using DataAccess.StoredProcedures.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.StoredProcedures
{
    public class StoredProcedure : IStoredProcedure
    {

        const string mySqlConnectionString = "server=localhost;port=3306;database=gym;user=root;password=cevh35xz24eli;CharSet=utf8;SslMode=none;Pooling=false;AllowPublicKeyRetrieval=True";

        public ProductInStock ConsultInventory(int id)
        {
            MySqlConnector.MySqlConnection connection = new MySqlConnector.MySqlConnection(mySqlConnectionString);

            connection.Open();

            ProductInStock product = null;

            try
            {
                MySqlConnector.MySqlCommand command = new MySqlConnector.MySqlCommand("consultInventory", connection);

                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("idProduct", id);

                //Función que sirve para leer los registros de las columnas que se devuelven
                var reader = command.ExecuteReader();

                while (reader.Read()) //Leer los registros de:
                {

                    //Aignar los valores de cada columna de la tabla a los atributos de la entidad User
                    product = new ProductInStock()
                    {
                        ProductId = (int)reader["id_ProductType"],
                        ProductName = (string)reader["name"],
                        Existence = (int)reader["Products_in_stock"],
                    };
                }

            }
            finally
            {
                connection.Clone();

            }

            return product;
        }

        public List<LastMembersRegistered> GetLastMembersRegistered()
        {
            List<LastMembersRegistered> members = new List<LastMembersRegistered>();

            //Conexión a la bdd
            MySqlConnector.MySqlConnection connection = new MySqlConnector.MySqlConnection(mySqlConnectionString);

            connection.Open();


            try
            {
                MySqlConnector.MySqlCommand command = new MySqlConnector.MySqlCommand("getLastMembersRegistered", connection);

                command.CommandType = System.Data.CommandType.StoredProcedure;

                var reader = command.ExecuteReader();

                while (reader.Read()) //Leer los registros de:
                {

                    LastMembersRegistered member = new LastMembersRegistered()
                    {
                        Id = (int)reader["id_Member"],
                        CreatedOn = (DateTime)reader["created_on"],
                        MemberName = (string)reader["name"],
                    };


                    members.Add(member);
                }

            }
            finally
            {
                connection.Clone();

            }

            return members;
        }

        public RecordSaleResult RecordSale(int idProduct, int idUser)
        {
            MySqlConnector.MySqlConnection connection = new MySqlConnector.MySqlConnection(mySqlConnectionString);

            connection.Open();

            RecordSaleResult sale = null;

            try
            {
                MySqlConnector.MySqlCommand command = new MySqlConnector.MySqlCommand("recordSale", connection);

                //Establecer que tipo de comando fue el que le pasamos
                command.CommandType = System.Data.CommandType.StoredProcedure;

                //Agregar los parametros in
                command.Parameters.AddWithValue("idProduct", idProduct);
                command.Parameters.AddWithValue("idUser", idUser);

                //Asignar los parametros de salida y su tipo a las variables
                var outputIdSale = command.Parameters.Add("idSale", System.Data.DbType.Int32);


                //Inddicar en la dirección que son parametros de salida
                outputIdSale.Direction = System.Data.ParameterDirection.Output;



                //Usar executeNoQuery para insert, delete y update (funciones crud que pueden devolver parametros de salida)
                var reader = command.ExecuteNonQuery();


                //Se le asigna los parametros a los atributos de la entidad que creamos
                sale = new RecordSaleResult
                {
                    Id = (int)outputIdSale.Value,
                };


            }
            finally
            {
                connection.Clone();

            }

            return sale;
        }
    
    }
}
