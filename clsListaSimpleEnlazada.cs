using System;

namespace CapaServicios.libColecciones
{
    /// <summary>LIsta con implementacion simple enlazada. La codificacion de la clase LIsta Simple elanzada debe implementar los metodos publicos propuestos por la interfaz generica iLista<Tipo> usando metodos que ya fueron implementados para el TADSimpleEnlazado.</Tipo></summary>
    /// <typeparam name="Tipo"></typeparam>
    public class clsListaSimpleEnlazada<Tipo> : clsTADSimpleEnlazada<Tipo>, iLista<Tipo> where Tipo : IComparable, new()
    {
        /// <summary>Devuelve el nombre del tipo de coleccion para insertarse dentro de los mensajes devueltos por el patron mensajero</summary>
        /// <returns>Cadena con el nombre de la coleccion.</returns>
        protected override string darNombreColeccion()
        {
            atrNombreColeccion = "Lista Simple Enlazada";
            return base.darNombreColeccion();
        }

        /// <summary>Agrega un nuevo elemento al final de la lista.</summary>
        /// <param name="prmElementoAgregado">Elemento que sera agregado.</param>
        /// <returns>True si elk proceso fue exitoso. False de lo contrario.</returns>
        public bool Agregar(Tipo prmElementoAgregado)
        {
            return base.AgregarUltimo(prmElementoAgregado);
        }

        /// <summary>Extrae el elemento ubicado en el indice indicado.</summary>
        /// <param name="prmIndice">Indice de base cero elegido para la extraccion.</param>
        /// <param name="prmElementoRemovido">Elemento que extrae de la coleccion y que esta ubicado en el indice </param>
        /// <returns>true si el proceso fue exitoso. False de lo contrario.</returns>
        public bool RemoverEn(int prmIndice, ref Tipo prmElementoRemovido)
        {
            return base.ExtraerEn(prmIndice, ref prmElementoRemovido);
        }

        /// <summary>Extrae si exitste el primer elemento coincidente con el elemento dado.</summary>
        /// <param name="prmElementoRemovido">Elemento extraido.</param>
        /// <returns>true si el proceso fue exitos. False de lo contrario.</returns>
        public bool RemoverEste(ref Tipo prmElementoRemovido)
        {
            return false;
            //pc
        }

        /// <summary>Invierte el orden de los elementos de toda la coleccion. El priemro pasa a ser ultimo y el utlimo primero y asi sucesivamente.</summary>
        /// <returns>True si el proceso fue exitoso. False de lo contrario.</returns>
        public bool Reversar()
        {
            return false;
//pc
        }

        /// <summary>Agrega un nuevoelemento al final de la lista.</summary>
        /// <param name="prmIndice">Indice de base cero donde ocurrira la insercion.</param>
        /// <param name="prmElementoInsertado">Elemento que sera insertado.</param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario.</returns>
        public bool Insertaren(int prmIndice, Tipo prmElementoInsertado)
        {
            return base.InsertarEn(prmIndice, prmElementoInsertado);
        }

        /// <summary>Intercambia el contendi ode los elementos ulbicados en Indice1 e Indice 2</summary>
        /// <param name="prmIndice1">Primer indice de base cero elegido para el intercambio.</param>
        /// <param name="prmIndice2">Segundo indice de base cero elegido para el intercambio.</param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario.</returns>
        public bool Intercambiarentre(int prmIndice1, int prmIndice2)
        {
            return base.IntercambiarEntre(prmIndice1, prmIndice2);
        }

        /// <summary>Modifica el contenido del  elemento ubicado en el indice de base cero indicado por el indice.</summary>
        /// <param name="prmIndice">Indice de base cero donde ocurrira la modificacion.</param>
        /// <param name="prmElementoModificado">Elemento que reemplaza al elemento que estaba antes ubicado en esa posicion.</param>
        /// <returns>true si el proceso fue exitoso. False de lo contrario.</returns>
        public bool Modificaren(int prmIndice, Tipo prmElementoModificado)
        {
            return base.ModificarEn(prmIndice, prmElementoModificado);
        }
    }
}
