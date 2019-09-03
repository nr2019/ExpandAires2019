using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using SRV;

namespace BLL
{ 
    public class BLLUsuario
    {
        private DALUsuario mpusu = new DALUsuario();
        private SRVGestorEncriptacion srvencriptacion = new SRVGestorEncriptacion();

        // Dim ngbitacora As New BLLBitacora
        private BEBitacora bitacora = new BEBitacora();
        private SRVFunciones funciones = new SRVFunciones();

        public event MostrarErrorEventHandler MostrarError;

        public delegate void MostrarErrorEventHandler(string mensaje);

        public event CreacionOkEventHandler CreacionOk;

        public delegate void CreacionOkEventHandler(BEUsuario unusuario);

        public event ModificacionOkEventHandler ModificacionOk;

        public delegate void ModificacionOkEventHandler();

        public event BorradoOkEventHandler BorradoOk;

        public delegate void BorradoOkEventHandler();

        public event PassActualizadaEventHandler PassActualizada;

        public delegate void PassActualizadaEventHandler();

        public event PassIncorrectaEventHandler PassIncorrecta;

        public delegate void PassIncorrectaEventHandler();

        public event UsuarioBloqueadoEventHandler UsuarioBloqueado;

        public delegate void UsuarioBloqueadoEventHandler();

        public event BienvenidoEventHandler Bienvenido;

        public delegate void BienvenidoEventHandler();

        public event RecuperaUsuarioInexistenteEventHandler RecuperaUsuarioInexistente;

        public delegate void RecuperaUsuarioInexistenteEventHandler();

        public event UsuarioBloqueadoOKEventHandler UsuarioBloqueadoOK;

        public delegate void UsuarioBloqueadoOKEventHandler();

        public event UsuarioDesbloqueadoOKEventHandler UsuarioDesbloqueadoOK;

        public delegate void UsuarioDesbloqueadoOKEventHandler();

        public event UsuarioBloqueadoActualmenteEventHandler UsuarioBloqueadoActualmente;

        public delegate void UsuarioBloqueadoActualmenteEventHandler();

        public event UsuarioDesbloqueadoActualmenteEventHandler UsuarioDesbloqueadoActualmente;

        public delegate void UsuarioDesbloqueadoActualmenteEventHandler();

        public event ValidarPassVaciaEventHandler ValidarPassVacia;

        public delegate void ValidarPassVaciaEventHandler();

        public event ValidarPassLargaEventHandler ValidarPassLarga;

        public delegate void ValidarPassLargaEventHandler();

        public event ValidarNombreSoloLetrasEventHandler ValidarNombreSoloLetras;

        public delegate void ValidarNombreSoloLetrasEventHandler();

        public event ValidarNombreVacioEventHandler ValidarNombreVacio;

        public delegate void ValidarNombreVacioEventHandler();

        public event ValidarApellidoSoloLetrasEventHandler ValidarApellidoSoloLetras;

        public delegate void ValidarApellidoSoloLetrasEventHandler();

        public event ValidarApellidoVacioEventHandler ValidarApellidoVacio;

        public delegate void ValidarApellidoVacioEventHandler();

        public event ValidarDNIYaExisteEventHandler ValidarDNIYaExiste;

        public delegate void ValidarDNIYaExisteEventHandler();

        public event ValidarDNILongitudEventHandler ValidarDNILongitud;

        public delegate void ValidarDNILongitudEventHandler();

        public event ValidarDNISoloNumerosEventHandler ValidarDNISoloNumeros;

        public delegate void ValidarDNISoloNumerosEventHandler();

        public event ValidarDNIVacioEventHandler ValidarDNIVacio;

        public delegate void ValidarDNIVacioEventHandler();

        public event ValidarBloqueoIncorrectoEventHandler ValidarBloqueoIncorrecto;

        public delegate void ValidarBloqueoIncorrectoEventHandler();

        public BEUsuario Crear(BEUsuario UnUsuario)
        {
            int ok = 1;
            string pass;
            ok = ValidarCrear(UnUsuario);

            if (ok > 0)
            {
                pass = UnUsuario.Password;
                // UnUsuario.Password = ngencriptado.Encriptar(UnUsuario.Password)
                UnUsuario.Password = srvencriptacion.EncriptarConMD5(UnUsuario.Password);
                // Se inserta el usuario
                if (mpusu.Create(UnUsuario) < 0)
                {
                    UnUsuario.Password = pass;
                    // Error al crear
                    UnUsuario.IDusuario = -1;
                    MostrarError?.Invoke("Error al crear usuario.");
                }
                else
                {
                    UnUsuario.Password = pass;
                    // Se selecciona el último usuario creado para devolver el ID
                    UnUsuario = mpusu.UsuarioCreado();

                    // bitacora.Accion = "Alta Usuario: Se creó el usuario: " + UnUsuario.IDusuario.ToString + " - " + UnUsuario.Apellido + ", " + UnUsuario.Nombre

                    // ngbitacora.RegistrarBitacora(bitacora)
                    CreacionOk?.Invoke(UnUsuario);
                }
            }
            else
                // NO VALIDO
                UnUsuario.IDusuario = -1;

            return UnUsuario;
        }

        private int ValidarCrear(BEUsuario unusuario)
        {
            int res;
            BEUsuario usuariobd = new BEUsuario();

            if (ValidarNombre(unusuario.Nombre) < 0)
                // Error en nombre
                res = -1;
            else if (ValidarApellido(unusuario.Apellido) < 0)
                // Error en apellido 
                res = -1;
            else if (ValidarDNI(unusuario.DNI) < 0)
                // Error en DNI
                res = -1;
            else if (ValidarPass(unusuario.Password) < 0)
                // Error en Pass
                res = -1;
            else if (ValidarBloqueo(unusuario.Bloqueado) < 0)
                // Error en bloqueo
                res = -1;
            else
                // Usuario OK
                res = 1;

            return res;
        }

        private int ValidarModificar(BEUsuario unusuario)
        {
            int res;
            BEUsuario usuariobd = new BEUsuario();

            if (ValidarNombre(unusuario.Nombre) < 0)
                // Error en nombre
                res = -1;
            else if (ValidarApellido(unusuario.Apellido) < 0)
                // Error en apellido 
                res = -1;
            else if (ValidarDNIModificar(unusuario) < 0)
                // Error en DNI
                res = -1;
            else if (ValidarPass(unusuario.Password) < 0)
                // Error en Pass
                res = -1;
            else if (ValidarBloqueo(unusuario.Bloqueado) < 0)
                // Error en bloqueo
                res = -1;
            else
                // Usuario OK
                res = 1;

            return res;
        }

        private int ValidarBloqueo(string bloqueo)
        {
            int res = 1;

            if (bloqueo == "" | bloqueo == "X")
                res = 1;
            else
            {
                res = -1;
                ValidarBloqueoIncorrecto?.Invoke();
            }

            return res;
        }

        private int ValidarPass(string pass)
        {
            int res = 1;

            if (pass == "")
            {
                // Pass vacía
                ValidarPassVacia?.Invoke();
                res = -1;
            }
            else if (pass.Length < 5 | pass.Length > 10)
            {
                // error, la clave no puede tener más de 10
                ValidarPassLarga?.Invoke();
                res = -1;
            }
            else
                // OK
                res = 1;

            return res;
        }

        private int ValidarNombre(string nombre)
        {
            int res = 1;
            int nro;

            if (nombre == "")
            {
                // usuario vacìo
                ValidarNombreVacio?.Invoke();
                res = -1;
            }
            else
            {
                nro = funciones.ValidarSoloLetras(nombre);
                if (nro < 0)
                {
                    // error
                    ValidarNombreSoloLetras?.Invoke();
                    res = -1;
                }
                else
                    // ok
                    res = 1;
            }

            return res;
        }

        private int ValidarApellido(string Apellido)
        {
            int res = 1;
            int nro;

            if (Apellido == "")
            {
                // usuario vacìo
                ValidarApellidoVacio?.Invoke();
                res = -1;
            }
            else
            {
                nro = funciones.ValidarSoloLetras(Apellido);
                if (nro < 0)
                {
                    // error
                    ValidarApellidoSoloLetras?.Invoke();
                    res = -1;
                }
                else
                    // ok
                    res = 1;
            }

            return res;
        }

        private int ValidarDNI(string dni)
        {
            int res = 1;
            int nro;
            BEUsuario usuariobd = new BEUsuario();
            BEUsuario unusuario = new BEUsuario();
            string chardni;


            if (string.IsNullOrEmpty(dni.ToString()))
            {
                // DNI vacío
                ValidarDNIVacio?.Invoke();
                res = -1;
            }
            else
            {
                nro = funciones.ValidarSoloNumeros(dni);
                if (nro < 0)
                {
                    // DNI error sòlo números
                    ValidarDNISoloNumeros?.Invoke();
                    res = -1;
                }
                else
                {
                    chardni = dni;
                    nro = chardni.Length;
                    if (nro != 8)
                    {
                        // error
                        ValidarDNILongitud?.Invoke();
                        res = -1;
                    }
                    else
                    {
                        // validar dni
                        unusuario.DNI = dni;
                        usuariobd = mpusu.BuscarDNI(unusuario);

                        if (usuariobd.IDusuario > 0)
                        {
                            // error dni ya exixte
                            ValidarDNIYaExiste?.Invoke();
                            res = -1;
                        }
                        else
                            res = 1;
                    }
                }
            }

            return res;
        }

        private int ValidarDNIModificar(BEUsuario UnUsuario)
        {
            int res = 1;
            int nro;
            BEUsuario usuariobd = new BEUsuario();
            // Dim unusuario As New BEUsuario
            string chardni;


            if (string.IsNullOrEmpty(UnUsuario.DNI))
            {
                // DNI vacío
                ValidarDNIVacio?.Invoke();
                res = -1;
            }
            else
            {
                nro = funciones.ValidarSoloNumeros(UnUsuario.DNI);
                if (nro < 0)
                {
                    // DNI error sòlo números
                    ValidarDNISoloNumeros?.Invoke();
                    res = -1;
                }
                else
                {
                    chardni = UnUsuario.DNI;
                    nro = chardni.Length;
                    if (nro != 8)
                    {
                        // error
                        ValidarDNILongitud?.Invoke();
                        res = -1;
                    }
                    else
                    {
                        // validar dni
                        // unusuario.DNI = unusuario.dni
                        usuariobd = mpusu.BuscarDNI(UnUsuario);

                        if (usuariobd.IDusuario > 0)
                        {
                            if (UnUsuario.IDusuario == usuariobd.IDusuario)
                                res = 1;
                            else
                            {
                                // error dni ya exixte
                                ValidarDNIYaExiste?.Invoke();
                                res = -1;
                            }
                        }
                        else
                            res = 1;
                    }
                }
            }

            return res;
        }

        /*public int ValidarSoloLetras(string cadena)
        {
            int res;
            string caracter;

            //Se recorre la cadena y se consulta caracter a caracter si es número
            for (var i = 1; i <= cadena.Length; i++)
            {
                //caracter = Strings.Mid(cadena, i, 1);
                caracter = cadena.Substring(i, 1);
                //if ((Information.IsNumeric(caracter)))
                //    res = -1;
                
                
            }

            return res;
        }*/

        /*public int ValidarSoloNumeros(string cadena)
        {
            int res = 1;
            int val = 0;
            string caracter;

            // Se recorre la cadena y se consulta caracter a caracter si es del mismo tipo que "val"
            for (var i = 1; i <= cadena.Length; i++)
            {
                caracter = Strings.Mid(cadena, i, 1);

                if (!Int32.TryParse(caracter, ref val))
                    res = -1;
            }

            
            return res;
        }*/

        public int Modificar(BEUsuario UnUsuario)
        {
            int res;

            res = ValidarModificar(UnUsuario);
            UnUsuario.Password = srvencriptacion.EncriptarConMD5(UnUsuario.Password);

            if (res > 0)
            {
                if (mpusu.Update(UnUsuario) < 0)
                    MostrarError?.Invoke("Error al editar usuario.");
                else
                    ModificacionOk?.Invoke();
            }

            return res;
        }

        public BEUsuario LogOn(BEUsuario UnUsuario)
        {
            BEUsuario usbd;
            bool acceder;

            // ID Usuario ingresado
            if (UnUsuario.IDusuario > 0)
            {
                if (UnUsuario.Password != "")
                {
                    // Lectura de usuario
                    usbd = mpusu.RecuperarUsuario(UnUsuario);
                    if (usbd.IDusuario > 0)
                    {

                        // Verifica clave
                        acceder = autenticar(UnUsuario, usbd);
                        if (acceder == true)
                        {
                            // Verificar permisos
                            if (usbd.Bloqueado == "X")
                            {
                                UnUsuario.IDusuario = -1;
                                UsuarioBloqueado?.Invoke();
                            }
                            else
                            {
                                // Accedió 
                                UnUsuario.IDusuario = usbd.IDusuario;
                                UnUsuario.Nombre = usbd.Nombre;
                                UnUsuario.Apellido = usbd.Apellido;
                                UnUsuario.DNI = usbd.DNI;
                                UnUsuario.Bloqueado = usbd.Bloqueado;
                                // UnUsuario.Password = ngencriptado.desencriptar(UnUsuario.Password)
                                Bienvenido?.Invoke();
                            }
                        }
                        else
                        {
                            UnUsuario.IDusuario = -1;
                            PassIncorrecta?.Invoke();
                        }
                    }
                    else
                    {
                        // Error usuario inexistente
                        UnUsuario.IDusuario = -1;
                        MostrarError?.Invoke("El usuario no está registrado. Contacte a un administrador.");
                    }
                }
                else
                    // Error Pass vacía
                    MostrarError?.Invoke("Debe ingresar una contraseña.");
            }
            else
                // Error id usuario vacío
                MostrarError?.Invoke("Debe ingresar un código de usuario.");

            return UnUsuario;
        }

        public BEUsuario RecuperarUsuario(BEUsuario UnUsuario)
        {
            // Seleccionar un usuario
            UnUsuario = mpusu.RecuperarUsuario(UnUsuario);
            if (UnUsuario.IDusuario < 0)
                // No encontrado
                RecuperaUsuarioInexistente?.Invoke();
            else
                UnUsuario.Password = srvencriptacion.EncriptarConMD5(UnUsuario.Password);
            return UnUsuario;
        }

        private bool autenticar(BEUsuario unusuario, BEUsuario usrbd)
        {
            bool res;
            string pass;

            // pass = ngencriptado.Desencriptar(usrbd.Password)
            // If pass = unusuario.Password Then
            // res = True
            // Else
            // res = False
            // End If
            pass = srvencriptacion.EncriptarConMD5(usrbd.Password);
            if (usrbd.Password == pass)
                res = true;
            else
                res = false;

            return res;
        }

        public int CambiarPass(BEUsuario UnUsuario, string passnueva)
        {
            int res = -1;
            // Dim usupd As New BEUsuario

            if (UnUsuario.Password != passnueva)
            {
                UnUsuario.Password = passnueva;
                // Actualiza
                UnUsuario.Password = srvencriptacion.EncriptarConMD5(UnUsuario.Password);
                if (mpusu.CambiarPass(UnUsuario) < 0)
                {
                    MostrarError?.Invoke("Error al actualizar la contraseña.");
                    res = -1;
                }
                else
                {
                    // Se actualizó correctamente, se pisa el usuario
                    res = 1;
                    PassActualizada?.Invoke();
                }
            }
            else
            {
                MostrarError?.Invoke("La contraseña ingresada, no puede ser igual a la anterior.");
                res = -1;
            }

            return res;
        }

        public int Bloquear(BEUsuario UnUsuario)
        {
            int res;

            // verifcar permisos


            UnUsuario = mpusu.RecuperarUsuario(UnUsuario);
            if (UnUsuario.IDusuario > 0)
            {
                if (UnUsuario.Bloqueado == "X")
                {
                    UsuarioBloqueadoActualmente?.Invoke();
                    res = 0;
                }
                else
                {
                    UnUsuario.Bloqueado = "X";


                    res = mpusu.Bloquear(UnUsuario);
                    if (res > 0)
                        UsuarioBloqueadoOK?.Invoke();
                }
            }
            else
            {
                res = -1;
                RecuperaUsuarioInexistente?.Invoke();
            }



            return res;
        }

        public int Desbloquear(BEUsuario UnUsuario)
        {
            int res;

            // verifcar permisos


            UnUsuario = mpusu.RecuperarUsuario(UnUsuario);
            if (UnUsuario.IDusuario > 0)
            {
                if (UnUsuario.Bloqueado == "")
                {
                    UsuarioDesbloqueadoActualmente?.Invoke();
                    res = 0;
                }
                else
                {
                    UnUsuario.Bloqueado = "";


                    res = mpusu.Desbloquear(UnUsuario);
                    if (res > 0)
                        UsuarioDesbloqueadoOK?.Invoke();
                }
            }
            else
            {
                res = -1;
                RecuperaUsuarioInexistente?.Invoke();
            }

            return res;
        }

        public int Borrar(BEUsuario UnUsuario)
        {
            int res = -1;
            BEUsuario usubd = new BEUsuario();

            if (UnUsuario.IDusuario < 0)
                // Debe ingresar ususario
                ValidarNombreVacio?.Invoke();
            else
            {
                usubd = mpusu.RecuperarUsuario(UnUsuario);
                if (usubd.IDusuario < 0)
                    // El usuario no existe
                    RecuperaUsuarioInexistente?.Invoke();
                else
                {
                    res = mpusu.Delete(UnUsuario);
                    BorradoOk?.Invoke();
                }
            }

            return res;
        }
    
}
}
