using System;

namespace CapaServicios.libColecciones
{
    public class clsListaDobleEnlazada<Tipo> : clsTADDobleEnlazada<Tipo>, iLista<Tipo> where Tipo : IComparable, new()
    {
        /// <summary>Devuelve el nombre del tipo de coleccion para insertarse detnro de los mensajes devueltos por el patron mensajero.</summary>
        protected override string darNombreColeccion()
        {
            atrNombreColeccion = "Lista Doble Enlazada";
            return base.darNombreColeccion();
        }

        /// <summary>Agrega un nuevo elemento al final de la Lista. </summary>
        /// <param name="prmElementoAgregado">Elemento que sera Agregado. </param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario. </returns>
        public bool Agregar(Tipo prmElementoAgregado)
        {
            return base.AgregarUltimo(prmElementoAgregado);
        }

        /// <summary>Insertar un nuevo elemento en el índice de base cero indicado. </summary>
        /// <param name="prmIndice">Índice de base cero donde ocurrirá la inserción. </param>
        /// <param name="prmElementoInsertado">Elemento que sera insertado.</param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario. </returns>
        public bool Insertaren(int prmIndice, Tipo prmElementoInsertado)
        {
            return base.InsertarEn(prmIndice, prmElementoInsertado);
        }

        /// <summary>Intercambio el contenido del elemento ubicado en Indice1 y Indice2. </summary>
        /// <param name="prmIndice1">Primer índice de base cero elegidos priman el intercambio. </param>
        /// <param name="prmIndice2">Segundo índice de base cero elegidos priman el intercambio. </param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario. </returns>
        public bool Intercambiarentre(int prmIndice1, int prmIndice2)
        {
            return base.IntercambiarEntre(prmIndice1, prmIndice2);
        }

        /// <summary>Modifica el contenido del elemento ubicado en el índice indicado. </summary>
        /// <param name="prmIndice">Índice de base cero donde ocurrirá la Modificación. </param>
        /// <param name="prmElementoModificado">Elemento que reemplazara al elemento que esta ubicado en la posición indicada. </param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario. </returns>
        public bool Modificaren(int prmIndice, Tipo prmElementoModificado)
        {
            return base.ModificarEn(prmIndice, prmElementoModificado);
        }

        /// <summary>Extraer el elemento ubicado en el índice indicado. </summary>
        /// <param name="prmIndice">Índice de base cero elegidos priman la extracción. </param>
        /// <param name="prmElementoRemovido">Elemento que extrae de la colección</param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario. </returns>
        public bool RemoverEn(int prmIndice, ref Tipo prmElementoRemovido)
        {
            return base.ExtraerEn(prmIndice, ref prmElementoRemovido);
        }

        /// <summary>Extraer si existe el primer elemento coincidente con el elemento indicado. </summary>
        /// <param name="prmElementoRemovido">Elemento extraído</param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario. </returns>
        public bool RemoverEste(ref Tipo prmElementoRemovido)
        {
            //pc implementar
            return false;
        }

        /// <summary>Invierte el orden de los elementos de toda la colección. El primero pasa a ser el último y el ultimo pasa a ser el primero y así sucesivamente con los demás. </summary>
        /// <returns>True si el proceso fue exitoso. False de lo contrario. </returns>
        public bool Reversar()
        {
            //pc implementar
            return false;
        }
    }
}

