using System;

namespace CapaServicios.libColecciones
{
    /// <summary>Lista con implementacion vectorial. La codificacion de la clase Lista Vector debe implementar los metodos publicos propuestos por la interfaz generica iLista<Tipo> usando metodos que ya fueron implementacion para el TADVectorial.</Tipo></summary><typeparam name="Tipo"></typeparam>
    public class clsListaVector<Tipo> : clsTADVectorial<Tipo>, iLista<Tipo> where Tipo : IComparable, new()
    {
        /// <summary>Devuelve el nombre del tipo de coleccion para insertarse dentro de los mensajes devueltos por el patron mensajero</summary>
        /// <returns>Cadena con el nombre de la coleccion.</returns>
        protected override string darNombreColeccion()
        {
            atrNombreColeccion = "Lista Vector";
            return atrNombreColeccion;
        }

        /// <summary>Crea una nueva insrancia de Lista Vector para una coleccion con las siguientes restricciones. La capacidad por defecto sera de 100 elementos. El factor de crecimiento estara ajustado a cero y su tamaño sera fijo.</summary>
        public clsListaVector() : base() { }

        /// <summary>Crea una nueva instancia de Lista Vector para una coleccion cuyo tamaño inicial estara determinado por el vector del parametro "prmCapacidad" si este es mayor que cero; en caso contrario se asumira la capacidad por defecto. El Factor de Crecimiento de la coleccion esta ajustado a cero y la coleccion tendra un tamaño fijo.</summary>
        /// <param name="prmCapacidad">Valor numerico que inidica el numero de posiciones iniciales que la coleccion tendra disponibles para almacenar elementos.</param>
        public clsListaVector(int prmCapacidad) : base(prmCapacidad) { }

        /// <summary>Crea una nueva insracia de Lista Vector para una coleccion cuyo tamaño es la capacidad por defecto de 100 elementos. El factor de crecimiento esta ajustado a 20 elementos por defecto.</summary>
        /// <param name="prmCapacidadFlexible">Verdadero para una capacidad Flexible. Falso de lo contrario.</param>
        public clsListaVector(bool prmCapacidadFlexible) : base(prmCapacidadFlexible) { }

        /// <summary>Crea una nueva instancia de Lista Vector para una coleccion cuya capacidad y Factor de Crecimento iniciales estara determinados por los paramentros "prmCapacidad" y "prmFactorCrecimiento" respectivamente. La coleccion tendra una capacidad Flexible por defecto.</summary>
        /// <param name="prmCapacidad">Corresponde al nuemro inicial de posicion que tendra la coleccion.</param>
        /// <param name="prmFactorCrecimiento">Corresponde al numero de posiciones en el que incrementara la coleccion cada vez que sea necesario.</param>
        public clsListaVector(int prmCapacidad, int prmFactorCrecimiento) : base(prmCapacidad, prmFactorCrecimiento) { }

        /// <summary>Agregar un nuevo elemento al final de la Lista.</summary>
        /// <param name="prmElementoAgregado">Elemento que sera agregado.</param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario.</returns>
        public bool Agregar(Tipo prmElementoAgregado)
        {
            return base.AgregarUltimo(prmElementoAgregado);
        }

        /// <summary>Inserta un nuevo elemento en el indice indicado.</summary>
        /// <param name="prmIndice">Indice de base cero donde ocurrira la insercion.</param>
        /// <param name="prmElementoInsertado">Elemento que sera insertado.</param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario.</returns>
        public bool Insertaren(int prmIndice, Tipo prmElementoInsertado)
        {
            return base.InsertarEn(prmIndice, prmElementoInsertado);
        }

        /// <summary>Modifica el contenido del elemento ubicado en el indice indicado.</summary>
        /// <param name="prmIndice">Indice de base cero donde ocurrira la modificacion.</param>
        /// <param name="prmElementoModificado">Elemento que reemplaza al elemento antiguo</param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario.</returns>
        public bool Modificaren(int prmIndice, Tipo prmElementoModificado)
        {
            return base.ModificarEn(prmIndice, prmElementoModificado);
        }

        /// <summary>Intercambi el contenido de los elemento ubicados en los par de indices indicados.</summary>
        /// <param name="prmIndice1">Primer indice de base cero elegido para el intercambio.</param>
        /// <param name="prmIndice2">Segundo indice de base cero elegido para el intercambio.</param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario.</returns>
        public bool Intercambiarentre(int prmIndice1, int prmIndice2)
        {
            return base.IntercambiarEntre(prmIndice1, prmIndice2);
        }

        /// <summary>Extrae el elemento ubicado en el indice indicado.</summary>
        /// <param name="prmIndice">Indice de base cero elegido para la extraccion.</param>
        /// <param name="prmElementoRemovido">Elemento que extrae de la coleccion y que esta ubicado en el indice.</param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario.</returns>
        public bool RemoverEn(int prmIndice, ref Tipo prmElementoRemovido)
        {
            return base.ExtraerEn(prmIndice, ref prmElementoRemovido);
        }

        /// <summary>Extrae si existe el primer elemento coincidente con el elemento ingresado.</summary>
        /// <param name="prmElementoRemovido">Elemento extraido.</param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario.</returns>
        public bool RemoverEste(ref Tipo prmElementoRemovido)
        {
            return base.ExtraerEste(ref prmElementoRemovido);
        }

        /// <summary>Invierte el orden de los elementos de toda la coleccion.El primero pasa a ser el ultimo y el ultimo primero y asi sucesivamente.</summary>
        /// <returns>True si el proceso fue exitoso. False de lo contrario.</returns>
        public bool Reversar() 
        {
            return base.Invertir();
        }
    }
}

