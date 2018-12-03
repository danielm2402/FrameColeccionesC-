using System;

namespace CapaServicios.libColecciones
{
    public class clsNodoSimpleEnlazado<Tipo> : clsNodo<Tipo> where Tipo : IComparable, new()
    {
        #region Atributos
        /// <summary> Proporciona acceso al siguiente nodo simple enlazado de la colección. </summary>
        private clsNodoSimpleEnlazado<Tipo> atrNodoSiguiente;
        #endregion
        #region Métodos
        #region Constructores
        /// <summary> Constructor NO parametrizado que inicia una nueva instancia de nodo simple enlazado con un elemento cuyo contenido será el valor por defecto para Tipo. </summary>
        public clsNodoSimpleEnlazado()
        {
            atrMensajeUltimoMetodo = "Se creo un nuevo " + darNombreNodo();
        }

        /// <summary> Constructor parametrizado que inicia una nueva instancia de Nodo Simple Enlazado con un elemento determinado por el parámetro "prmElemento". </summary>
        /// <param name="prmElemento">Elemento que contendrá el nuevo nodo</param>
        public clsNodoSimpleEnlazado(Tipo prmElemento) : base(prmElemento) {     }
        #endregion
        #region Accesores y Mutadores
        /// <summary>Devuelve el nombre o categoria a la cual pertenece el nodo, como una cadena para insertarse dentro de los mensajes devueltos por el patron mesajero. Ej: nodo simple enlazado o nodo doble enlazado.</summary>
        /// <returns>Devuelve el nombre del nodo</returns>
        public override string darNombreNodo()
        {
            atrNombreNodo = "Nodo Simple Enlazado";
            return atrNombreNodo;
        }

        /// <summary>Devuelve el siguiento nodo simple enlazado con respecto al nodo actual.</summary>
        /// <returns>El nodo siguiente</returns>
        public clsNodoSimpleEnlazado<Tipo> darNodoSiguiente()
        {
            atrMensajeUltimoMetodo = "Se retorno el siguiente nodo con respecto del " + atrNombreNodo + " actual.";
            return atrNodoSiguiente;
        }

        /// <summary>Establece el nodo siguiento para el nodo actual.</summary>
        /// <param name="prmNuevoNodoSiguiente">Nuevo nodo siguiente.</param>
        public void ponerNodoSiguiente(clsNodoSimpleEnlazado<Tipo> prmNuevoNodoSiguiente)
        {
            atrMensajeUltimoMetodo = "Se establecio el siguente nodo con respecto del " + atrNombreNodo + " actual.";
            atrNodoSiguiente = prmNuevoNodoSiguiente;
        }
        #endregion
        #region Iteradores
        #endregion
        #region Crud`s
        #region Conectores
        /// <summary> Conectar un nodo simple enlazado después del nodo actual.  </summary>
        /// <param name="prmNodo">Nodo simple enlazado que va a ser conectado después del nodo actual</param>
        /// <returns>true si la conexión del nuevo nodo simple enlazado fue exitosa. False de lo contrario. </returns>
        public bool ConectarDespues(clsNodoSimpleEnlazado<Tipo> prmNodo)
        {
            if (prmNodo != null)
            {
                prmNodo.atrNodoSiguiente = atrNodoSiguiente;
                atrNodoSiguiente = prmNodo;
                atrMensajeUltimoMetodo = "El nuevo nodo fue conectado con éxito después del actual";
                return true;
            }
            else
            {
                atrMensajeUltimoMetodo = "El nodo que intenta conectar es nulo";
                return false;
            }
        }

        #endregion
        #region Modificadores
        #endregion
        #region Desconectores
        /// <summary> Extrae (Desconecta y devuelve) un Nodo simple enlazado después del Nodo Actual. </summary>
        /// <param name="prmNodoDesconectado">Nodo simple enlazado desconectado ubicado después del Nodo Actual. </param>
        /// <returns>True si la desconexión del Nodo simple enlazado fue Exitosa. False de lo contrario. </returns>
        public bool DesconectarDespues(ref clsNodoSimpleEnlazado<Tipo> prmNodoDesconectado)
        {
            if (atrNodoSiguiente != null)
            {
                prmNodoDesconectado = atrNodoSiguiente;
                atrNodoSiguiente = atrNodoSiguiente.atrNodoSiguiente;
                atrMensajeUltimoMetodo = "Se desconectó el Nodo después del Actual con éxito.";
                return true;
            }
            else
            {
                atrMensajeUltimoMetodo = "Imposible desconectar un nodo nulo.";
                return false;
            }
        }
        #endregion
        #region Recuperadores
        #endregion
        #region Consultores
        #endregion
        #region Pobladores
        #endregion
        #endregion
        #region Ordenamiento
        #endregion
        #endregion
    }
}

