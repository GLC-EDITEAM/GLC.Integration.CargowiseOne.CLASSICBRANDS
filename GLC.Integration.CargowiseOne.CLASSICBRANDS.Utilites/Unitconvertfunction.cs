using GLC.Integration.CargowiseOne.CLASSICBRANDS.Utilites;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace GLC.Integration.CargowiseOne.CLASSICBRANDS.Utility
{
    
    public class Unitconvertfunction
    {
        public static List<WeightClass> dataWeight=new List<WeightClass>();
        public static int Get940convCTN(string prodcode,int pceunit)
        {
            try
            {
                //PROD Connectionstring

               // string connectionString = @"Data Source=PROD01\CARGOPROD;Initial Catalog=Cargowiseone;Integrated Security=true";

                //Test Connectionstring

                System.Diagnostics.EventLog.WriteEntry("ProdCiode",prodcode + "_" + pceunit);
                string connectionString = @"Data Source=WEBDEV01;Initial Catalog=Cargowiseone;Integrated Security=true";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand("Select PCE from dbo.TblunitLookup940CB where ProductCode=@prodcode", connection);
                command.Parameters.AddWithValue("@prodcode", prodcode);
                connection.Open();
                var codectn = command.ExecuteScalar();
                connection.Close();
                pceunit = pceunit / Convert.ToInt32(codectn);

                return pceunit;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public static int Get945convPCE(string prodcode,string CTN)
        {
            try
            {
                //PROD Connectionstring

               // string connectionString = @"Data Source=PROD01\CARGOPROD;Initial Catalog=Cargowiseone;Integrated Security=true";

                //Test Connectionstring

                string connectionString = @"Data Source=WEBDEV01;Initial Catalog=Cargowiseone;Integrated Security=true";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand("Select PCE from dbo.TblunitLookup940CB where ProductCode=" + "'" + prodcode + "'", connection);
                connection.Open();
                var codectn = command.ExecuteScalar();
                connection.Close();
                int CTNval =  Convert.ToInt32(CTN)*Convert.ToInt32(codectn);
                return CTNval;
            }
            catch (Exception exception)
            {
                throw exception;
            }

        }


        public static string Get945convPCEWeight(string prodcode, string CTN)
        {
            try
            {
                //PROD Connectionstring

                // string connectionString = @"Data Source=PROD01\CARGOPROD;Initial Catalog=Cargowiseone;Integrated Security=true";

                //Test Connectionstring

                string connectionString = @"Data Source=WEBDEV01;Initial Catalog=Cargowiseone;Integrated Security=true";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand("Select CTNWeight from dbo.TblunitLookup940CB where ProductCode=" + "'" + prodcode + "'", connection);
                connection.Open();
                var codectn = command.ExecuteScalar();
                connection.Close();
                decimal CTNval = Convert.ToDecimal(CTN) * Convert.ToDecimal(codectn);
                return CTNval.ToString();
            }
            catch (Exception exception)
            {
                throw exception;
            }

        }

        public static string GetProdCode(string proddec)
        {
            try
            {
                //PROD Connectionstring

                // string connectionString = @"Data Source=PROD01\CARGOPROD;Initial Catalog=Cargowiseone;Integrated Security=true";

                //Test Connectionstring

                string connectionString = @"Data Source=WEBDEV01;Initial Catalog=Cargowiseone;Integrated Security=true";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand("Select ProductCode from dbo.TblunitLookup940CB where Description=" + "'" + proddec + "'", connection);
                connection.Open();
                var codectn = command.ExecuteScalar();
                connection.Close();
               // int CTNval = Convert.ToInt32(CTN) * Convert.ToInt32(codectn);
                return Convert.ToString(codectn);
            }
            catch (Exception exception)
            {
                throw exception;
            }

        }

        public static string Getpcecount(string prodcode)
        {
            try
            {
                //PROD Connectionstring

                // string connectionString = @"Data Source=PROD01\CARGOPROD;Initial Catalog=Cargowiseone;Integrated Security=true";

                //Test Connectionstring

                string connectionString = @"Data Source=WEBDEV01;Initial Catalog=Cargowiseone;Integrated Security=true";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand("Select PCE from dbo.TblunitLookup940CB where ProductCode=" + "'" + prodcode + "'", connection);
                connection.Open();
                var codectn = command.ExecuteScalar();
                connection.Close();
                // int CTNval = Convert.ToInt32(CTN) * Convert.ToInt32(codectn);
                return Convert.ToString(codectn);
            }
            catch (Exception exception)
            {
                throw exception;
            }

        }


    }
}
