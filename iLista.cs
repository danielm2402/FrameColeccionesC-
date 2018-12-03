using System;

namespace CapaServicios.libColecciones
{
    /// <summary>La interfaz Lista, establece la firma de los métodos públicos que debe implementar cualquier TAD que sea Lista independientemente de su implementación: Vectorial, Simple o Doble Enlazada. En la interfaz los métodos no se implementan, solo se definen. </summary> <typeparam name="Tipo"></typeparam>
    public interface iLista<Tipo> where Tipo : IComparable, new()
    {
        /// <summary>Agrega un nuevo elemento al final de la Lista. </summary>
        /// <param name="prmElementoAgregado">Elemento que sera Agregado. </param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario. </returns>
        bool Agregar(Tipo prmElementoAgregado);

        /// <summary>Insertar un nuevo elemento en el índice de base cero indicado. </summary>
        /// <param name="prmIndice">Índice de base cero donde ocurrirá la inserción. </param>
        /// <param name="prmElementoInsertado">Elemento que sera insertado.</param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario. </returns>
        bool Insertaren(int prmIndice, Tipo prmElementoInsertado);

        /// <summary>Modifica el contenido del elemento ubicado en el índice indicado. </summary>
        /// <param name="prmIndice">Índice de base cero donde ocurrirá la Modificación. </param>
        /// <param name="prmElementoModificado">Elemento que reemplazara al elemento que esta ubicado en la posición indicada. </param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario. </returns>
        bool Modificaren(int prmIndice, Tipo prmElementoModificado);

        /// <summary>Intercambio el contenido del elemento ubicado en Indice1 y Indice2. </summary>
        /// <param name="prmIndice1">Primer índice de base cero elegidos priman el intercambio. </param>
        /// <param name="prmIndice2">Segundo índice de base cero elegidos priman el intercambio. </param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario. </returns>
        bool Intercambiarentre(int prmIndice1, int prmIndice2);

        /// <summary>Extraer el elemento ubicado en el índice indicado. </summary>
        /// <param name="prmIndice">Índice de base cero elegidos priman la extracción. </param>
        /// <param name="prmElementoRemovido">Elemento que extrae de la colección</param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario. </returns>
        bool RemoverEn(int prmIndice, ref Tipo prmElementoRemovido);

        /// <summary>Extraer si existe el primer elemento coincidente con el elemento indicado. </summary>
        /// <param name="prmElementoRemovido">Elemento extraído</param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario. </returns>
        bool RemoverEste(ref Tipo prmElementoRemovido);

        /// <summary>Invierte el orden de los elementos de toda la colección. El primero pasa a ser el último y el ultimo pasa a ser el primero y así sucesivamente con los demás. </summary>
        /// <returns>True si el proceso fue exitoso. False de lo contrario. </returns>
        bool Reversar();

        /// <summary>Ordena la colección según el método burbuja simple y el criterio de ordenamiento elegido. </summary>
        /// <param name="prmOrdenarPorDescendente">Si es verdadero ordenara en sentido descendente. Si es falso ordenara en sentido Ascendente. </param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario. </returns>
        bool OrdenarBurbujaSimple(bool prmOrdenarPorDescendente);

        /// <summary>Ordena la colección según el método burbuja mejorado y el criterio de ordenamiento elegido. </summary>
        /// <param name="prmOrdenarPorDescendente">Si es verdadero ordenara en sentido Descendente. Si es falso ordenara en sentido Ascendente. </param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario. </returns>
        bool OrdenarBurbujaMejorado(bool prmOrdenarPorDescendente);

        /// <summary>Ordena la colección según el método burbuja bidireccional y el criterio de ordenamiento elegido. </summary>
        /// <param name="prmOrdenarPorDescendente">Si es verdadero ordenara en sentido Descendente. Si es falso ordenara en sentido Ascendente. </param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario. </returns>
        bool OrdenarBurbujaBiDireccional(bool prmOrdenarPorDescendente);

        /// <summary>Ordena la colección según el método Inserción y el criterio de ordenamiento elegido. </summary>
        /// <param name="prmOrdenarPorDescendente">Si es verdadero ordenara en sentido Descendente. Si es falso ordenara en sentido Ascendente. </param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario. </returns>
        bool OrdenarInsercion(bool prmOrdenarPorDescendente);

        /// <summary>Ordena la colección según el método Selección y el criterio de ordenamiento elegido. </summary>
        /// <param name="prmOrdenarPorDescendente">Si es verdadero ordenara en sentido Descendente. Si es falso ordenara en sentido Ascendente. </param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario. </returns>
        bool OrdenarSeleccion(bool prmOrdenarPorDescendente);

        /// <summary>Ordena la colección según el método Quick Sort y el criterio de ordenamiento elegido. </summary>
        /// <param name="prmOrdenarPorDescendente">Si es verdadero ordenara en sentido Descendente. Si es falso ordenara en sentido Ascendente. </param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario. </returns>
        bool OrdenarQuickSort(bool prmOrdenarPorDescendente);
    }
}

