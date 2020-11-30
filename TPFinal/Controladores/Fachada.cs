using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using TPFinal.DTO;

namespace TPFinal
{
    public class Fachada
    {
        private static readonly Type refleccion = System.Reflection.MethodBase.GetCurrentMethod().DeclaringType;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(refleccion);

        public DTOUsuario Login(string DNI, string PIN)
        {
            var mUrl = ("https://my-json-server.typicode.com/utn-frcu-isi-tdp/tas-db/clients?id=" + DNI + "&pass=" + PIN);
            try
            {
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
                        return new DTOUsuario(iNombre, iCategoria);
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new TimeoutException(ex.Message); 
            }
            
        }

        public DTOUsuario ObtenerUsuario(UserControl f)
        {
            FormPrincipal iForm;
            iForm = (FormPrincipal)f.FindForm();
            return iForm.iUsuario;
        }

        public string ObtenerTiempoAplicacion(UserControl f)
        {
            FormPrincipal iForm;
            iForm = (FormPrincipal)f.FindForm();
            return iForm.iCronometro.Elapsed.ToString();
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

        public List<Producto> ObtenerTarjetas(string DNI)
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
                    List<Producto> iLista = new List<Producto>();
                    foreach (var obj in mResponseJSON[0].response.product)
                    {
                        string iNumero = obj.number;
                        string iNombre = obj.name;
                        string iTipo = obj.type;
                        Producto iTarjeta = new Producto(iNumero, iNombre, iTipo);
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

        public List<Movimiento> UltimosMovimientos(string DNI)
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
                    List<Movimiento> iLista = new List<Movimiento>();
                    foreach (var obj in mResponseJSON[0].response.movements)
                    {
                        string iFecha = obj.date;
                        float iCantidad = obj.ammount;
                        Movimiento iMovimiento = new Movimiento(iFecha, iCantidad);
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

