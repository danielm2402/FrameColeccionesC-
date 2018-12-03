using System;

namespace CapaServicios.libColecciones
{
    /// <summary>Cola con implementación simple enlazada. La codificación de la clase cola Simple Enlazada debe implementar los métodos públicos propuestos por la interfaz genérica iCola<Tipo> usando métodos que ya fueron implementados para el TADSimpleEnlazado. </Tipo></summary><typeparam name="Tipo"></typeparam>
    public class clsColaSimpleEnlazada<Tipo> : clsTADSimpleEnlazada<Tipo>, iCola<Tipo> where Tipo : IComparable, new()
    {
        /// <summary>Devuelve el nombre del tipo de coleccion para insertarse dentro de los mensajes devueltos por el patron mensajero</summary>
        /// <returns>Cadena con el nombre de la coleccion.</returns>
        protected override string darNombreColeccion()
        {
            atrNombreColeccion = "Cola Simple Enlazada";
            return base.darNombreColeccion();
        }

        /// <summary>Agrega un nuevo elemento al inicio de la cola. </summary>
        /// <param name="prmElementoEncolado">Elemento que será encolado. </param>
        /// <returns>>True si el proceso fue exitoso. False de lo contrario. </returns>
        public bool Encolar(Tipo prmElementoEncolado)
        {
            if (base.InsertarPrimero(prmElementoEncolado))
            {
                atrMensajeUltimoMetodo = "Se puso en la cola el nuevo elemento con exito";
                return true;
            }
            atrMensajeUltimoMetodo = "Imposible encolar el nuevo elemento debido a: " + atrMensajeUltimoMetodo;
            return false;
        }

        /// <summary>Quita un elemento al final de la cola.</summary>
        /// <param name="prmElementoDesencolado">Elemento que será Desencolado. </param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario. </returns>
        public bool Desencolar(ref Tipo prmElementoDesencolado)
        {
            if (base.ExtraerUltimo(ref prmElementoDesencolado))
            {
                atrMensajeUltimoMetodo = "Se quito de la cola el ultimo elemento con exito.";
                return true;
            }
            atrMensajeUltimoMetodo = "Imposible desencolar el ultimo elemento debido: " + atrMensajeUltimoMetodo;
            return false;
        }

        /// <summary>Recupera (para su revisión) sin extraer, el elemento al final de la cola. </summary>
        /// <param name="prmElementoRevisado">Elemento que será revisado. </param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario. </returns>
        public bool Revisar(ref Tipo prmElementoRevisado)
        {
            if(base.RecuperarUltimo(ref prmElementoRevisado))
            {
                atrMensajeUltimoMetodo = "Se recupero de la cola el ultimo elemento con exito para su revision.";
                return true;
            }
            atrMensajeUltimoMetodo = "Imposible revisar el ultimo elemento de la cola debido: " + atrMensajeUltimoMetodo;
            return false;
        }
    }
}


