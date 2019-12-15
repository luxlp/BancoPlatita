using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace TPFinal
{
    public class Controlador
    {
        public Usuario Login(string DNI, string PIN)
        {
            var mUrl = ("https://my-json-server.typicode.com/utn-frcu-isi-tdp/tas-db/clients?id=" + DNI + "&pass=" + PIN); 

            // Se crea el request http
            HttpWebRequest mRequest = (HttpWebRequest)WebRequest.Create(mUrl);

            // Se ejecuta la consulta
            WebResponse mResponse = mRequest.GetResponse();

            // Se obtiene los datos de respuesta
            using (Stream responseStream = mResponse.GetResponseStream())
            {
                StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);

                // Se parsea la respuesta y se serializa a JSON a un objeto dynamic
                dynamic mResponseJSON = JsonConvert.DeserializeObject(reader.ReadToEnd());

                if (mResponseJSON.Count >= 1)
                {
                    string iNombre = mResponseJSON[0].response.client.name;
                    string iCategoria = mResponseJSON[0].response.client.segment;
                    return new Usuario(iNombre, iCategoria);
                }
                else
                {
                    return null;
                }
            }
        }

        public object BlanquearPin(string NumeroTarjeta)
        {
            var mUrl = ("https://my-json-server.typicode.com/utn-frcu-isi-tdp/tas-db/product-reset?number=" + NumeroTarjeta);

            // Se crea el request http
            HttpWebRequest mRequest = (HttpWebRequest)WebRequest.Create(mUrl);

            // Se ejecuta la consulta
            WebResponse mResponse = mRequest.GetResponse();

            // Se obtiene los datos de respuesta
            using (Stream responseStream = mResponse.GetResponseStream())
            {
                StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);

                // Se parsea la respuesta y se serializa a JSON a un objeto dynamic
                dynamic mResponseJSON = JsonConvert.DeserializeObject(reader.ReadToEnd());

                if (mResponseJSON.Count >= 1)
                {
                    return mResponseJSON[0].response;
                }
                else
                {
                    return null;
                }
            }
        }

        public List<Product> ObtenerTarjetas(string DNI)
        {
            var mUrl = ("https://my-json-server.typicode.com/utn-frcu-isi-tdp/tas-db/products?id=" + DNI);

            // Se crea el request http
            HttpWebRequest mRequest = (HttpWebRequest)WebRequest.Create(mUrl);

            // Se ejecuta la consulta
            WebResponse mResponse = mRequest.GetResponse();

            // Se obtiene los datos de respuesta
            using (Stream responseStream = mResponse.GetResponseStream())
            {
                StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);

                // Se parsea la respuesta y se serializa a JSON a un objeto dynamic
                dynamic mResponseJSON = JsonConvert.DeserializeObject(reader.ReadToEnd());

                if (mResponseJSON.Count >= 1)
                {
                    List<Product> iLista = new List<Product>();
                    foreach (var obj in mResponseJSON[0].response.product)
                    {
                        string iNumero = obj.number;
                        string iNombre = obj.name;
                        string iTipo = obj.type;
                        Product iTarjeta = new Product(iNumero, iNombre, iTipo);
                        iLista.Add(iTarjeta);
                    }
                    return iLista;
                }
                else
                {
                    return null;
                }
            }
        }

        public float? SaldoCuentaCorriente(string DNI)
        {
            var mUrl = ("https://my-json-server.typicode.com/utn-frcu-isi-tdp/tas-db/account-balance?id=" + DNI);

            // Se crea el request http
            HttpWebRequest mRequest = (HttpWebRequest)WebRequest.Create(mUrl);

            // Se ejecuta la consulta
            WebResponse mResponse = mRequest.GetResponse();

            // Se obtiene los datos de respuesta
            using (Stream responseStream = mResponse.GetResponseStream())
            {
                StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);

                // Se parsea la respuesta y se serializa a JSON a un objeto dynamic
                dynamic mResponseJSON = JsonConvert.DeserializeObject(reader.ReadToEnd());

                if (mResponseJSON.Count >= 1)
                {
                    float iSaldo = mResponseJSON[0].response.balance;
                    return iSaldo;
                }
                else
                {
                    return null;
                }
            }
        }

        public List<Movement> UltimosMovimientos(string DNI)
        {
            var mUrl = ("https://my-json-server.typicode.com/utn-frcu-isi-tdp/tas-db/account-movements?id=" + DNI);

            // Se crea el request http
            HttpWebRequest mRequest = (HttpWebRequest)WebRequest.Create(mUrl);

            // Se ejecuta la consulta
            WebResponse mResponse = mRequest.GetResponse();

            // Se obtiene los datos de respuesta
            using (Stream responseStream = mResponse.GetResponseStream())
            {
                StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);

                // Se parsea la respuesta y se serializa a JSON a un objeto dynamic
                dynamic mResponseJSON = JsonConvert.DeserializeObject(reader.ReadToEnd());

                if (mResponseJSON.Count >= 1)
                {
                    List<Movement> iLista = new List<Movement>();
                    foreach (var obj in mResponseJSON[0].response.movements)
                    {
                        string iDate = obj.date;
                        float iAmount = obj.ammount;
                        Movement iMovimiento = new Movement(iDate, iAmount);
                        iLista.Add(iMovimiento);
                    }
                    return iLista;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}

