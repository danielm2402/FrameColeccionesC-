using System;

namespace CapaServicios.libColecciones
{
    /// <summary>Cola con implementacion vectorial. La codificacion de la clase Cola Vector debe implementar los metodos publicos propuestos por la interfaz generica iCola<Tipo> usando metodos que ya fueron implementados para el TADVectorial.</Tipo></summary><typeparam name="Tipo"></typeparam>
    public class clsColaVector<Tipo> : clsTADVectorial<Tipo> , iCola<Tipo> where Tipo : IComparable, new()
    {
        /// <summary>Devuelve el nombre del tipo de coleccion para insertarse dentro de los mensajes devueltos por el patron mensajero</summary>
        /// <returns>Cadena con el nombre de la coleccion.</returns>
        protected override string darNombreColeccion()
        {
            atrNombreColeccion = "Cola Vector";
            return base.darNombreColeccion();
        }

        /// <summary>Crea una nueva insrancia de Cola Vector para una coleccion con las siguientes restricciones. La capacidad por defecto sera de 100 elementos. El factor de crecimiento estara ajustado a cero y su tamaño sera fijo.</summary>
        public clsColaVector(): base() { }

        /// <summary>Crea una nueva instancia de Cola vecot para una coleccion cuyo tamaño inicial estara determinado por el vector del parametro "prmCapacidad" si este es mayor que cero; en caso contrario se asumira la capacidad por defecto. El Factor de Crecimiento de la coleccion esta ajustado a cero y la coleccion tendra un tamaño fijo.</summary>
        /// <param name="prmCapacidad">Valor numerico que inidica el numero de posiciones iniciales que la coleccion tendra disponibles para almacenar elementos.</param>
        public clsColaVector(int prmCapacidad): base(prmCapacidad) { }

        /// <summary>Crea una nueva insracia de Cola vector para una coleccion cuyo tamaño es la capacidad por defecto de 100 elementos. El factor de crecimiento esta ajustado a 20 elementos por defecto.</summary>
        /// <param name="prmCapacidadFlexible">Verdadero para una capacidad Flexible. Falso de lo contrario.</param>
        public clsColaVector(bool prmCapacidadFlexible): base(prmCapacidadFlexible) { }

        /// <summary>Crea una nueva instancia de Cola Vector para una coleccion cuya capacidad y Factor de Crecimento iniciales estara determinados por los paramentros "prmCapacidad" y "prmFactorCrecimiento" respectivamente. La coleccion tendra una capacidad Flexible por defecto.</summary>
        /// <param name="prmCapacidad">Corresponde al nuemro inicial de posicion que tendra la coleccion.</param>
        /// <param name="prmFactorCrecimiento">Corresponde al numero de posiciones en el que incrementara la coleccion cada vez que sea necesario.</param>
        public clsColaVector(int prmCapacidad, int prmFactorCrecimiento):base(prmCapacidad, prmFactorCrecimiento) { }

        /// <summary>Agrega un nuevo elemento al inicio de la cola.</summary>
        /// <param name="prmElementoEncolado">Elemento que sera Encolado</param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario.</returns>
        public bool Encolar(Tipo prmElementoEncolado)
        {
            if (base.InsertarPrimero(prmElementoEncolado))
            {
                atrMensajeUltimoMetodo = " Se puso en la cola el nuevo elemento con exito.";
                return true;
            }
            atrMensajeUltimoMetodo = "Imposible encolar el nuevo elemento debido a : " + atrMensajeUltimoMetodo;
            return false;
        }

        /// <summary>Quita un elemento al final de la cola.</summary>
        /// <param name="prmElementoDesencolado">Elemento  que sera desencolado.</param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario.</returns>
        public bool Desencolar(ref Tipo prmElementoDesencolado)
        {
            if (base.ExtraerUltimo(ref prmElementoDesencolado))
            {
                atrMensajeUltimoMetodo = "Se quito de la cola el ultimo elemento con exito";
                return true;
            }
            atrMensajeUltimoMetodo = "Imposible desencolar el ultimo elemento debido a: " + atrMensajeUltimoMetodo;
            return false;
        }

        /// <summary>Recupera (para su revision) sin extraer, el elemento al final de la cola.</summary>
        /// <param name="prmElementoRevisado">Elemento que sera desencolado.</param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario.</returns>
        public bool Revisar(ref Tipo prmElementoRevisado)
        {
            if (RecuperarUltimo(ref prmElementoRevisado))
            {
                atrMensajeUltimoMetodo = "Se recupero de la cola el ultimo elemento con exito para su revision";
                return true;
            }
            atrMensajeUltimoMetodo = "Imposible revisar el ultimo elemento de la cola debido a: " + atrMensajeUltimoMetodo;
            return false;
        }
    }
}

