using System;

namespace CapaServicios.libColecciones
{
    public class clsColaDobleEnlazada<Tipo> : clsTADDobleEnlazada<Tipo>, iCola<Tipo> where Tipo : IComparable, new()
    {
        /// <summary>Devuelve el nombre del tipo de coleccion para insertarse detnro de los mensajes devueltos por el patron mensajero.</summary>
        protected override string darNombreColeccion()
        {
            atrNombreColeccion = "Cola Doble Enlazada";
            return base.darNombreColeccion();
        }

        /// <summary>Agrega un nuevo elemento al inicio de la Cola. </summary>
        /// <param name="prmElementoEncolado">Elemento que sera Encolado. </param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario. </returns>
        public bool Encolar(Tipo prmElementoEncolado)
        {
            if (InsertarPrimero(prmElementoEncolado))
            {
                atrMensajeUltimoMetodo = "Se puso en la cola el nuevo elemento con exito";
                return true;
            }
            atrMensajeUltimoMetodo = "Imposible encolar el nuevo elemento debido a: " + atrMensajeUltimoMetodo;
            return false;
        }

        /// <summary>Quita un nuevo elemento al final de la cola. </summary>
        /// <param name="prmElementoDesencolado">Elemento que sera Desencolado. </param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario. </returns>
        public bool Desencolar(ref Tipo prmElementoDesencolado)
        {
            if (base.ExtraerUltimo(ref prmElementoDesencolado))
            {
                atrMensajeUltimoMetodo = "Se quito de la cola el ultimo elemento con exito.";
                return true;
            }
            atrMensajeUltimoMetodo = "Imposible desencolar el ultimo elemento debido a: " + atrMensajeUltimoMetodo;
            return false;
        }

        /// <summary>Recupera (prima su revisión) sin extraer, el elemento al final de la cola. </summary>
        /// <param name="prmElementoRevisado">Elemento que sera revisado. </param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario. </returns>
        public bool Revisar(ref Tipo prmElementoRevisado)
        {
            if(base.RecuperarUltimo(ref prmElementoRevisado))
            {
                atrMensajeUltimoMetodo = "Se recupero de la cola el ultimo elemento con exito para su revision.";
                return true;
            }
            atrMensajeUltimoMetodo = "Imposible revisar el ultimo elemento de la cola debido a: " + atrMensajeUltimoMetodo;
            return false;
        }

    }
}
