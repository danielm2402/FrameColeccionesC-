using System;

namespace CapaServicios.libColecciones
{
    /// <summary>Pila con implementación vectorial. La codificación de la clase Pila Vector debe implementar los métodos públicos propuestos por la interfaz genérica ipil<Tipo> usando métodos que ya fueron implementados para el TADVectorial. </Tipo></summary> <typeparam name="Tipo"></typeparam>
    public class clsPilaVector<Tipo> : clsTADVectorial<Tipo>, iPila<Tipo> where Tipo : IComparable, new()
    {
        /// <summary>Devuelve el nombre del tipo de coleccion para insertarse dentro de los mensajes devueltos por el patron mensajero</summary>
        /// <returns>Cadena con el nombre de la coleccion.</returns>
        protected override string darNombreColeccion()
        {
            atrNombreColeccion = "pila vectorial";
            return atrNombreColeccion;
        }

        /// <summary>Crea una nueva instancia de Pila Vector para una coleccion con las siguientes restricciones. La capacidad por defecto sera de 100 elementos. El factor de crecimiento estara ajustado a cero y su tamaño sera fijo.</summary>
        public clsPilaVector(): base() { }

        /// <summary>Crea una nueva instancia de pila vecot para una coleccion cuyo tamaño inicial estara determinado por el vector del parametro "prmCapacidad" si este es mayor que cero; en caso contrario se asumira la capacidad por defecto. El Factor de Crecimiento de la coleccion esta ajustado a cero y la coleccion tendra un tamaño fijo.</summary>
        /// <param name="prmCapacidad">Valor numerico que inidica el numero de posiciones iniciales que la coleccion tendra disponibles para almacenar elementos.</param>
        public clsPilaVector(int prmCapacidad): base(prmCapacidad) { }

        /// <summary>Crea una nueva instancia de pila vector para una coleccion cuyo tamaño es la capacidad por defecto de 100 elementos. El factor de crecimiento esta ajustado a 20 elementos por defecto.</summary>
        /// <param name="prmCapacidadFlexible">Verdadero para una capacidad Flexible. Falso de lo contrario.</param>
        public clsPilaVector(bool prmCapacidadFlexible): base(prmCapacidadFlexible) { }

        /// <summary>Crea una nueva instancia de Pila Vector para una coleccion cuya capacidad y Factor de Crecimento iniciales estara determinados por los paramentros "prmCapacidad" y "prmFactorCrecimiento" respectivamente. La coleccion tendra una capacidad Flexible por defecto.</summary>
        /// <param name="prmCapacidad">Corresponde al nuemro inicial de posicion que tendra la coleccion.</param>
        /// <param name="prmFactorCrecimiento">Corresponde al numero de posiciones en el que incrementara la coleccion cada vez que sea necesario.</param>
        public clsPilaVector(int prmCapacidad, int prmFactorCrecimiento):base(prmCapacidad, prmFactorCrecimiento) { }

        /// <summary>Agrega un nuevo al inicio de la Pila</summary>
        /// <param name="prmElementoApilado">Elemento que sera Apilado</param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario. </returns>
        public bool Apilar(Tipo prmElementoApilado)
        {
            if (base.InsertarPrimero(prmElementoApilado))
            {
                atrMensajeUltimoMetodo = Mensajero("Exito", "apilar", atrMensajeUltimoMetodo);
                return true;
            }
            atrMensajeUltimoMetodo = Mensajero("Fracaso", "apilar", atrMensajeUltimoMetodo);
            return false;
        }

        /// <summary>Quita un nuevo elemento al inicio de la Pila. </summary>
        /// <param name="prmElementoDesapilado">Elemento que sera Desopilado. </param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario. </returns>
        public bool Desapilar(ref Tipo prmElementoDesapilado)
        {
            if (base.ExtraerPrimero(ref prmElementoDesapilado))
            {
                atrMensajeUltimoMetodo = Mensajero("Exito", "desapilar", atrMensajeUltimoMetodo);
                return true;
            }
            atrMensajeUltimoMetodo = Mensajero("Fracaso", "desapilar", atrMensajeUltimoMetodo);
            return false;
        }

        /// <summary>Recupera (para su revisión) sin extraer, el elemento al inicio de la Pila. </summary>
        /// <param name="prmElementoRevisado">Elemento que sera revisado. </param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario. </returns>
        public bool Revisar(ref Tipo prmElementoRevisado)
        {
            if (base.RecuperarPrimero(ref prmElementoRevisado))
            {
                atrMensajeUltimoMetodo = Mensajero("Exito", "revisar", darMensajeUltimoMetodo());
                return true;
            }
            atrMensajeUltimoMetodo = Mensajero("Fracaso", "revisar", darMensajeUltimoMetodo());
            return false;
        }
    }
}

