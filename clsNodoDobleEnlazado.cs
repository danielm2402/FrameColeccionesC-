using System;

namespace CapaServicios.libColecciones
{
    public class clsNodoDobleEnlazado<Tipo> : clsNodo<Tipo> where Tipo : IComparable, new()
    {
        #region Atributos
        /// <summary> Proporciona acceso al anterior nodo doble enlazado de la colección. </summary>
        private clsNodoDobleEnlazado<Tipo> atrNodoAnterior;

        /// <summary> Proporciona acceso al siguiente nodo doble enlazado de la colección. </summary>
        private clsNodoDobleEnlazado<Tipo> atrNodoSiguiente;
        #endregion
        #region Métodos
        #region Constructores
        /// <summary> Constructor NO parametrizado que indica una nueva instancia de nodo doble enlazado con un elemento con el valor por defecto para Tipo. </summary>
        public clsNodoDobleEnlazado()
        {
            atrMensajeUltimoMetodo = "Se creo un nuevo " + darNombreNodo();
        }

        /// <summary> Constructor parametrizado que inicia una nueva Instancia de Nodo Doble Enlazado con un elemento determinado por el parámetro "prmElemento". </summary>
        /// <param name="prmElemento">Elemento que contendrá el nuevo nodo</param>
        public clsNodoDobleEnlazado(Tipo prmElemento) : base(prmElemento)
        {

        }
        #endregion
        #region Propiedades

        #endregion
        #region Iteradores
        #endregion
        #region Accesores y Mutadores
        /// <summary>Devuelve el nombre o categoria a la cual pertenence el nodo, como una cadena para insertarse dentro de los mensajes devueltos por el patron mensajero. Ej: nodo simple enlazo o nodo doble enlazado.</summary>
        /// <returns>Nombre al que pertenece el nodo.</returns>
        public override string darNombreNodo()
        {
            atrNombreNodo = "Nodo Doble enlazado";
            return atrNombreNodo;
        }

        /// <summary>Devuelve el siguiente nodo simple enlazado con respecto al nodo actual.</summary>
        /// <returns>El nodo siguiente al actual</returns>
        public clsNodoDobleEnlazado<Tipo> darNodoSiguiente()
        {
            atrMensajeUltimoMetodo = "Se retorno el siguiente nodo con respecto del " + atrNombreNodo + " actual.";
            return atrNodoSiguiente;
        }

        /// <summary>Devuelve el anterior nodo simple enlazado con respecto al nodo actual.</summary>
        /// <returns>El nodo anterior al actual</returns>
        public clsNodoDobleEnlazado<Tipo> darNodoAnterior()
        {
            atrMensajeUltimoMetodo = "Se retorno el anterior nodo con respecto del " + atrNombreNodo + " actual.";
            return atrNodoAnterior;
        }

        /// <summary>Establece el nodo siguiente para el nodo actual.</summary>
        /// <param name="prmNuevoNodoSiguiente">Nuevo nodo siguiente con respecto al nodo actual.</param>
        public void ponerNodoSiguiente(clsNodoDobleEnlazado<Tipo> prmNuevoNodoSiguiente)
        {
            atrMensajeUltimoMetodo = "Se establecio el siguiento nodo con respecto del " + atrNombreNodo + " actual.";
            atrNodoSiguiente = prmNuevoNodoSiguiente;
        }

        /// <summary>Establece el nodo anterior para el nodo actual.</summary>
        /// <param name="prmNuevoNodoSiguiente">Nuevo nodo anterior con respecto al nodo actual.</param>
        public void ponerNodoAnterior(clsNodoDobleEnlazado<Tipo> prmNuevoNodoAnterior)
        {
            atrMensajeUltimoMetodo = "Se establecio el anterior nodo con respecto del " + atrNombreNodo + " actual.";
            atrNodoAnterior = prmNuevoNodoAnterior;
        }
        #endregion
        #region Crud`s
        #region Conectores
        /// <summary> Conecta un Nodo doble enlazado antes del Nodo Actual. </summary>
        /// <param name="prmNodo">Nodo doble enlazado que va a ser conectado antes del Nodo Actual. </param>
        /// <returns>True si la Conexión del nuevo Nodo fue exitosa. False de lo contrario. NOTA: Uso de la estrategia Izquierda-Centro/Centro-Izquierda | Derecha-Centro/Centro-Derecha. </returns>
        public bool ConectarAntes(clsNodoDobleEnlazado<Tipo> prmNodo)
        {
            if (prmNodo != null)
            {
                if (atrNodoAnterior != null)
                {
                    atrNodoAnterior.atrNodoSiguiente = prmNodo;
                    prmNodo.atrNodoAnterior = atrNodoAnterior;
                }
                atrNodoAnterior = prmNodo;
                prmNodo.atrNodoSiguiente = this;
                atrMensajeUltimoMetodo = "Se conectó con éxito el Nodo antes del Actual.";
                return true;
            }
            else
            {
                atrMensajeUltimoMetodo = "El Nodo que intenta conectar es Nulo.";
                return false;
            }
        }

        /// <summary> Conecta un Nodo doble enlazado después del Nodo Actual. </summary>
        /// <param name="prmNodo">Nuevo Nodo doble enlazado que va a ser conectado después del Nodo Actual. </param>
        /// <returns>True si la Conexión del nuevo Nodo doble enlazado fue exitosa. False de lo Contrario. </returns>
        public bool ConectarDespues(clsNodoDobleEnlazado<Tipo> prmNodo)
        {
            if (prmNodo != null)
            {
                if (atrNodoSiguiente != null)
                {
                    atrNodoSiguiente.atrNodoAnterior = prmNodo;
                    prmNodo.atrNodoSiguiente = this.atrNodoSiguiente;
                }
                atrNodoSiguiente = prmNodo;
                prmNodo.atrNodoAnterior = this;
                atrMensajeUltimoMetodo = "Se conectó con éxito el nodo después del Actual.";
                return true;
            }
            atrMensajeUltimoMetodo = "El Nodo que intenta conectar es nulo.";
            return false;
        }
        #endregion
        #region Modificadores
        #endregion
        #region Desconectores
        /// <summary> Desconecta el Nodo doble enlazado Actual, al mismo tiempo que reconecta sus nodos anterior y siguiente (si existen). </summary>
        /// <returns>True si la conexión del nodo doble enlazado fue exitosa. False de lo contrario. </returns>
        public bool Desconectar()
        {
            if (atrNodoAnterior != null && atrNodoSiguiente != null)
            {
                atrNodoAnterior.atrNodoSiguiente = atrNodoSiguiente;
                atrNodoSiguiente.atrNodoAnterior = atrNodoAnterior;
            }
            if (atrNodoAnterior == null && atrNodoSiguiente != null)
            {
                atrNodoSiguiente.atrNodoSiguiente = null;
            }
            if (atrNodoAnterior != null && atrNodoSiguiente == null)
            {
                atrNodoAnterior.atrNodoSiguiente = null;
            }
            atrMensajeUltimoMetodo = "Se desconectó el Nodo Actual con éxito.";
            return true;
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

