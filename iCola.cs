using System;

namespace CapaServicios.libColecciones
{
    /// <summary>La interfaz Cola, establece la firma de los métodos públicos que debe implementar cualquier TAD que sea Cola independientemente de su implementación: Vectorial, Simple o Doble Enlazada. En la interfaz los métodos no se implementan, solo se definen. </summary> <typeparam name="Tipo"></typeparam>
    public interface iCola<Tipo> where Tipo : IComparable, new()
    {
        /// <summary>Agrega un nuevo elemento al inicio de la Cola. </summary>
        /// <param name="prmElementoEncolado">Elemento que sera Encolado. </param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario. </returns>
        bool Encolar(Tipo prmElementoEncolado);

        /// <summary>Quita un nuevo elemento al final de la cola. </summary>
        /// <param name="prmElementoDesencolado">Elemento que sera Desencolado. </param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario. </returns>
        bool Desencolar(ref Tipo prmElementoDesencolado);

        /// <summary>Recupera (prima su revisión) sin extraer, el elemento al final de la cola. </summary>
        /// <param name="prmElementoRevisado">Elemento que sera revisado. </param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario. </returns>
        bool Revisar(ref Tipo prmElementoRevisado);

        /// <summary>Ordena la coleccion segun el metodo burbuja simple y el criterio de ordenamiento elegido.</summary>
        /// <param name="prmOrdenarPorDescendente">Si es verdadero ordenara en sentido Descendente. Si es falso ordenara en sentido Ascendente.</param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario.</returns>
        bool OrdenarBurbujaSimple(bool prmOrdenarPorDescendente);

        /// <summary>Ordena la coleccion segun el metodo burbuja Mejorado y el criterio de ordenamiento elegido.</summary>
        /// <param name="prmOrdenarPorDescendente">Si es verdadero ordenara en sentido Descendente. Si es falso ordenara en sentido Ascendente.</param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario.</returns>
        bool OrdenarBurbujaMejorado(bool prmOrdenarPorDescendente);

        /// <summary>Ordena la coleccion segun el metodo burbuja BiDireccional y el criterio de ordenamiento elegido.</summary>
        /// <param name="prmOrdenarPorDescendente">Si es verdadero ordenara en sentido Descendente. Si es falso ordenara en sentido Ascendente.</param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario.</returns>
        bool OrdenarBurbujaBiDireccional(bool prmOrdenarPorDescendente);

        /// <summary>Ordena la coleccion segun el metodo Insercion y el criterio de ordenamiento elegido.</summary>
        /// <param name="prmOrdenarPorDescendente">Si es verdadero ordenara en sentido Descendente. Si es falso ordenara en sentido Ascendente.</param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario.</returns>
        bool OrdenarInsercion(bool prmOrdenarPorDescendente);

        /// <summary>Ordena la coleccion segun el metodo Seleccion y el criterio de ordenamiento elegido.</summary>
        /// <param name="prmOrdenarPorDescendente">Si es verdadero ordenara en sentido Descendente. Si es falso ordenara en sentido Ascendente.</param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario.</returns>
        bool OrdenarSeleccion(bool prmOrdenarPorDescendente);

        /// <summary>Ordena la coleccion segun el metodo Quick Sorty el criterio de ordenamiento elegido.</summary>
        /// <param name="prmOrdenarPorDescendente">Si es verdadero ordenara en sentido Descendente. Si es falso ordenara en sentido Ascendente.</param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario.</returns>
        bool OrdenarQuickSort(bool prmOrdenarPorDescendente);
    }
}

