using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{ 
    public enum EnumTipoEvento 
    {
        BackUpBaseDatos = 1,
        RestoreBaseDatos = 2,
        AltaIdioma = 3,
        ModificarIdioma = 4,
        InactivarIdioma = 5,
        ReactivarIdioma = 6,
        Loginok = 7,
        ContraseñaErronea = 8,
        RegistrarUsuario = 9,
        UsuarioBloqueado = 10,
        Logoutok = 11,
        CambiarIdioma = 12,
        NuevoPerfil = 13,
        ModificarPerfil = 14,
        BorrarPerfil = 15,
        DeasociarPermiso = 16,
        AsociarPermiso = 17,
        EliminarPerfil = 18,
        EliminarMenu = 19,
        AgregarMenu = 20,
        ModificarMenu = 21,
        UsuarioInexistente = 22,
        ErrorGeneral = 23,
        InactivarUsuario = 24,
        ReactivarUsuario = 25,
        UsuarioInactivo = 26,
        EliminarTraduccion = 27,
        NuevaTraduccion = 28,
        BaseCorrupta = 29,
        EliminarNoticia = 30,
        ModificarNoticia = 31,
        NuevaNoticia = 32,
        EliminarLineaProducto = 33,
        AltaLineaProducto = 34,
        AltaLineaProductoTraduccion = 35,
        EliminarLineaProductoTraduccion = 36,
        ModificarLineaProductoTraduccion = 37,
        EliminarTipoProducto = 38,
        AltaTipoProducto = 39,
        AltaTipoProductoTraduccion = 40,
        EliminarTipoProductoTraduccion = 41,
        ModificarTipoProductoTraduccion = 42,
        ModificarTipoProducto = 43,
        EliminarMarca = 44,
        AltaMarca = 45,
        ModificarMarca = 46,
        NuevoProducto = 47,
        EliminarProducto = 48,
        AltaProductoTraduccion = 49,
        EliminarProductoTraduccion = 50,
        ModificarProductoTraduccion = 51,
        ModificarProducto = 52,
        ActivarProducto = 53,
        InactivarProducto = 54,
        AltaOrdenCompra = 55,
        ModificarOrdenCompra = 56,
        AsociarPeriodo = 57
    }

}
