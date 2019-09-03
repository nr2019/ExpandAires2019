using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;

namespace SRV
{
    public class SRVGestorErrores
    {
        private static SRVGestorErrores _instancia = new SRVGestorErrores();

        public static SRVGestorErrores instancia
        {
            get
            {
                return _instancia;
            }
        }

        private SRVGestorErrores()
        {
        }
         
        public void RegistrarError(Exception ex, string unUsuario)
        {
            string ruta;
            // En caso de que no tome el ConfigurationManager, hay que agregar la referencia en el proyecto
            /*ruta = ConfigurationManager.AppSettings("rutaErrores");
            string archivo = "LogError-" + DateTime.Today.Year.ToString() + DateTime.Today.Month.ToString() + DateTime.Today.Day.ToString() + ".txt";
            StreamWriter unStreamWriter = new StreamWriter(ruta + @"\" + archivo, true);
            unStreamWriter.WriteLine("----------------------------");
            unStreamWriter.WriteLine(DateTime.Now);
            unStreamWriter.WriteLine("Excepción: " + ex.Message);
            unStreamWriter.WriteLine("Source: " + ex.Source);
            string texto;
            texto = "InnerException :" + ex.InnerException.ToString();
            unStreamWriter.WriteLine(texto);
            unStreamWriter.WriteLine("Usuario: " + unUsuario);
            unStreamWriter.Close();*/
        }
    }

}
