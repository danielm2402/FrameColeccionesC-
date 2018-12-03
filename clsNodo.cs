using System;

namespace CapaServicios.libColecciones
{
    public class clsNodo<Tipo> where Tipo : IComparable, new()
    {
        #region Atributos
        /// <summary>/ Elemento de Tipo Genérico que contiene el objeto Nodo. </summary>
        protected Tipo atrElemento = default(Tipo);

        /// <summary> Cadena de texto que especifica el resultado (éxito o fracaso) del ultimo método ejecutado. </summary>
        protected string atrMensajeUltimoMetodo;

        /// <summary>Nombre o categoria a la cual pertenece el nodo. Ej: Nodo Simple Enlazado O Doble Enlazado.</summary>
        protected string atrNombreNodo;
        #endregion
        #region Métodos
        #region Constructores 
        /// <summary> Constructor No parametrizado que inicia una nueva instancia de nodo con un elemento cuyo contenido será el valor por defecto para el "Tipo" </summary>
        public clsNodo()
        {
            atrMensajeUltimoMetodo = "Se creo un nuevo nodo" ;
        }

        /// <summary> Constructor parametrizado que inicia una nueva instancia de nodo con un elemento cuyo contenido estará determinado por el parámetro "prmElemento". </summary>
        /// <param name="prmElemento">Elemento que contendrá el nuevo nodo. </param>
        public clsNodo(Tipo prmElemento)
        {
            atrElemento = prmElemento;
            atrMensajeUltimoMetodo = "Se creo un nuevo nodo el cual contiene un elemento.";
        }
        #endregion
        #region Accesores y Mutadores
        /// <summary>Devuelve el valor del atributo elemento del nodo actual.</summary>
        /// <returns>El elemento del nodo actual</returns>
        public Tipo darElemento()
        {
            atrMensajeUltimoMetodo = "Se retorno el valor del elemento para el " + atrNombreNodo + " actual.";
            return atrElemento;
        }

        /// <summary>Devuelve el nombre del metodo que se esta ejecutando para la coleccion para luego insertarse dentro de los mensajes devueltos por el patron mensajero. Ej: Apilar o Insertar, etc.</summary>
        /// <returns></returns>
        protected virtual string darNombreMetodoEnEjecucion()
        {
            return "Retorna el nombre del metodo que actualmente estaria ejecutando la Coleccion.";
        }

        /// <summary>Establece el valor del atributo elemento para el nodo actual.</summary>
        /// <param name="prmValor">Nuevo valor que tomara el elemento.</param>
        public void ponerElemento(Tipo prmValor)
        {
            atrMensajeUltimoMetodo = "Se establecio el valor del elemento para el " + atrNombreNodo + " actual.";
            atrElemento = prmValor;
        }

        public string darMensajeUltimoMetodo()
        {
            return atrMensajeUltimoMetodo;
        }

        /// <summary> Devuelve el nombre del nodo al que pertenece.</summary>
        /// <returns></returns>
        public virtual string darNombreNodo()
        {
            return atrNombreNodo;
        }
        #endregion
        #region Iteradores
        #endregion
        #region Crud`s
        #region Conectores
        #endregion
        #region Modificadores
        #endregion
        #region Desconectores
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

