using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BLL
{ 
    public class BLLIdioma
    {
        private DALIdioma mpidioma = new DALIdioma();
        // Dim mptextos As New DALTexto
        // Dim ngbitacora As New BLLBitacora

        public event IdiomavacioEventHandler Idiomavacio;

        public delegate void IdiomavacioEventHandler();

        public event idiomalongitudEventHandler idiomalongitud;

        public delegate void idiomalongitudEventHandler();

        public event IdiomaInsertarErrorEventHandler IdiomaInsertarError;

        public delegate void IdiomaInsertarErrorEventHandler();

        public event IdiomaModificacionOkEventHandler IdiomaModificacionOk;

        public delegate void IdiomaModificacionOkEventHandler();

        public event IdiomaModificacionErrorEventHandler IdiomaModificacionError;

        public delegate void IdiomaModificacionErrorEventHandler();

        public event IdiomaBorradoOkEventHandler IdiomaBorradoOk;

        public delegate void IdiomaBorradoOkEventHandler();

        public event IdiomaBorradoErrorEventHandler IdiomaBorradoError;

        public delegate void IdiomaBorradoErrorEventHandler();

        public BEIdioma Crear(BEIdioma UnIdioma)
        {
            if (ValidarIdioma(UnIdioma) == 0)
            {
                if (mpidioma.Create(UnIdioma) < 0)
                    IdiomaInsertarError?.Invoke();
            }
            else
            {
                UnIdioma.Idioma = "";
                UnIdioma.Descripcion = "";
            }

            return UnIdioma;
        }

        public int Editar(BEIdioma UnIdioma)
        {
            int res;

            if (ValidarIdioma(UnIdioma) > 0)
            {
                res = mpidioma.Update(UnIdioma);
                if (res <= 0)
                    // Error
                    res = -1;
            }
            else
                res = -1;

            return res;
        }

        public int Borrar(BEIdioma UnIdioma)
        {
            int res = -1;


            if (UnIdioma.Idioma == "")
                res = -1;
            else if (UnIdioma.Idioma == "ES")
                // no se puede borrar ES
                IdiomaBorradoError?.Invoke();
            else
            {
                // Inicio Transacción
                res = mpidioma.Delete(UnIdioma);
                if (res > 0)
                {
                    res = 0;

                    // '''''''''''''''''HABILITAR CUANDO SE APLIQUE TRADUCCIONES
                    // res = mptextos.Borrar(UnIdioma.Idioma)

                    if (res > 0)
                        IdiomaBorradoOk?.Invoke();
                    else
                        IdiomaBorradoError?.Invoke();
                }
            }

            return res;
        }

        public List<BEIdioma> CargarIdiomas()
        {
            List<BEIdioma> idiomas = new List<BEIdioma>();
            List<object> obj;
            // Dim dt As New DataTable

            // dt = mpidioma.Listar()
            obj = mpidioma.RetrieveAll();




            // For Each dr As DataRow In obj
            foreach (dynamic dr in obj)
            {
                BEIdioma idioma = new BEIdioma();
                if (dr is BEIdioma)
                    idioma = dr;

                idiomas.Add(idioma);
                idioma = null/* TODO Change to default(_) if this is not a reference type */;
            }

            return idiomas;
        }

        // Function CargarIdiomasSinTexto() As List(Of BEIdioma)
        // Dim ict As New List(Of BEIdioma) ' Idiomas con texto
        // Dim idiomas As New List(Of BEIdioma)
        // Dim resultado As New List(Of BEIdioma)
        // Dim esta As String = ""

        // idiomas = CargarIdiomas()
        // If idiomas.Count > 0 Then
        // ict = mptextos.RecuperarIdiomaConTexto()
        // If ict.Count > 0 Then
        // For Each i As BEIdioma In idiomas
        // For Each ct As BEIdioma In ict
        // If i.Idioma = ct.Idioma Then
        // esta = "X"
        // End If
        // Next
        // If esta = "" Then
        // resultado.Add(i)
        // End If
        // esta = ""
        // Next
        // End If
        // End If

        // Return resultado
        // End Function

        // Function CargarIdiomasConTexto() As List(Of BEIdioma)
        // Dim ict As New List(Of BEIdioma) ' Idiomas con texto
        // Dim res As New List(Of BEIdioma)

        // ' Se recuperan los idiomas que figuran en la tabla de textos
        // ict = mptextos.RecuperarIdiomaConTexto()

        // For Each i As BEIdioma In ict
        // ' Se recueran las descripciones de los idiomas
        // i = mpidioma.Validar(i)
        // If i.Idioma <> "" Then
        // ' En caso de encontrarlos, los devuelve al gui
        // res.Add(i)
        // End If
        // Next

        // Return ict
        // End Function

        public BEIdioma RecuperarIdioma(BEIdioma UnIdioma)
        {
            UnIdioma = mpidioma.Validar(UnIdioma);

            return UnIdioma;
        }

        public int ValidarIdioma(BEIdioma idioma)
        {
            int res;
            BEIdioma idiomabd = new BEIdioma();

            idiomabd.Idioma = idioma.Idioma;
            idiomabd.Descripcion = idioma.Descripcion;

            idiomabd.Idioma = idiomabd.Idioma.ToUpper();

            if (idiomabd.Idioma == "")
            {
                // error idioma vacío
                res = -1;
                Idiomavacio?.Invoke();
            }
            else if (idiomabd.Idioma.Length != 2)
            {
                // error 2 caracteres
                res = -1;
                idiomalongitud?.Invoke();
            }
            else
            {
                // Busca si existe el idioma
                idiomabd = mpidioma.Validar(idiomabd);
                if (idiomabd.Idioma == "")
                    // No existe
                    res = 0;
                else
                    // Existe
                    res = 1;
            }

            return res;
        }
    }

}
