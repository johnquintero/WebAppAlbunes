using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using System.IO;

namespace Agente
{
    public static class AgenteAlbum
    {

        public static string fn_listaAlbum_Consultar()
        {

            string Lista;
            try
            {
                string servicio = "https://jsonplaceholder.typicode.com/albums";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(servicio);
                request.Method = "GET";
                request.ContentType = "application/json; charset=UTF-8";
                request.Accept = "application/json";
                //Stream dataStream = request.GetRequestStream();
                WebResponse response = request.GetResponse();

                Console.WriteLine(((HttpWebResponse)response).StatusDescription);
                // Get the stream containing content returned by the server.  
                // dataStream = response.GetResponseStream();
                // Open the stream using a StreamReader for easy access.  
                var stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                // Read the content.  
                //string responseFromServer = reader.ReadToEnd();
                Lista = reader.ReadToEnd();
                // Display the content.  


                // Clean up the streams.  
                reader.Close();
                // dataStream.Close();
                response.Close();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return Lista;
        }


        public static string fn_listaFotos_Consultar()
        {

            string Lista;
            try
            {
                string servicio = "https://jsonplaceholder.typicode.com/photos";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(servicio);
                request.Method = "GET";
                request.ContentType = "application/json; charset=UTF-8";
                request.Accept = "application/json";
                //Stream dataStream = request.GetRequestStream();
                WebResponse response = request.GetResponse();

                Console.WriteLine(((HttpWebResponse)response).StatusDescription);
                // Get the stream containing content returned by the server.  
                // dataStream = response.GetResponseStream();
                // Open the stream using a StreamReader for easy access.  
                var stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                // Read the content.  
                //string responseFromServer = reader.ReadToEnd();
                Lista = reader.ReadToEnd();
                // Display the content.  


                // Clean up the streams.  
                reader.Close();
                // dataStream.Close();
                response.Close();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return Lista;
        }
        public static string fn_listaComentario_Consultar()
        {

            string Lista;
            try
            {
                string servicio = "https://jsonplaceholder.typicode.com/comments";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(servicio);
                request.Method = "GET";
                request.ContentType = "application/json; charset=UTF-8";
                request.Accept = "application/json";
                //Stream dataStream = request.GetRequestStream();
                WebResponse response = request.GetResponse();

                Console.WriteLine(((HttpWebResponse)response).StatusDescription);
                // Get the stream containing content returned by the server.  
                // dataStream = response.GetResponseStream();
                // Open the stream using a StreamReader for easy access.  
                var stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                // Read the content.  
                //string responseFromServer = reader.ReadToEnd();
                Lista = reader.ReadToEnd();
                // Display the content.  


                // Clean up the streams.  
                reader.Close();
                // dataStream.Close();
                response.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Lista;
        }
    }
}

