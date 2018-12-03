using System;

namespace CapaServicios.libColecciones
{
    /// <summary>La interfaz Pila, establece la firma de los métodos públicos que debe implementar cualquier TAD que sea pila independientemente de su implementación: Vectorial, Simple o Doble Enlazada. En la interfaz los métodos no se implementan, solo se definen.</summary> <typeparam name="Tipo"></typeparam>
    public interface iPila<Tipo> where Tipo : IComparable, new ()
    {
        /// <summary>Agrega un nuevo elemento al inicio de la pila.</summary>
        /// <param name="prmElementoApilado">Elemento que será apilado. </param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario. </returns>
        bool Apilar(Tipo prmElementoApilado);

        /// <summary>Quitar un nuevo elemento al inicio de la pila.</summary>
        /// <param name="prmElementoDesapilado">Elemento que será des apilado. </param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario. </returns>
        bool Desapilar(ref Tipo prmElementoDesapilado);

        /// <summary>Recupera (prima su revisión) sin extraer, el Elemento al inicio de la pila. </summary>
        /// <param name="prmElementoRevisado">Elemento que será revisado. </param>
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

