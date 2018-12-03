using System;

namespace CapaServicios.libColecciones
{
    public class clsPilaDobleEnlazada<Tipo> : clsTADDobleEnlazada<Tipo>, iPila<Tipo> where Tipo : IComparable, new()
    {
        /// <summary>Devuelve el nombre del tipo de coleccion para insertarse detnro de los mensajes devueltos por el patron mensajero.</summary>
        protected override string darNombreColeccion()
        {
            atrNombreColeccion = "Pila Doble Enlazada";
            return base.darNombreColeccion();
        }

        /// <summary>Agrega un nuevo elemento al inicio de la pila.</summary>
        /// <param name="prmElementoApilado">Elemento que será apilado. </param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario. </returns>
        public bool Apilar(Tipo prmElementoApilado)
        {
            if (base.InsertarPrimero(prmElementoApilado))
            {
                atrMensajeUltimoMetodo = "Se apilo el nuevo elemento con exito en la " + darNombreColeccion();
                return true;
            }
            atrMensajeUltimoMetodo = "Imposible apilar el nuevo elemento debido a: " + atrMensajeUltimoMetodo;
            return false;
        }

        /// <summary>Quitar un nuevo elemento al inicio de la pila.</summary>
        /// <param name="prmElementoDesapilado">Elemento que será des apilado. </param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario. </returns>
        public bool Desapilar(ref Tipo prmElementoDesapilado)
        {
            if(base.ExtraerPrimero(ref prmElementoDesapilado))
            {
                atrMensajeUltimoMetodo = "Se desapilo el primer elemento con exito";
                return true;
            }
            atrMensajeUltimoMetodo = "Imposible desapilar el primer elemento debido a: " + atrMensajeUltimoMetodo;
            return false;        
        }

        /// <summary>Recupera (prima su revisión) sin extraer, el Elemento al inicio de la pila. </summary>
        /// <param name="prmElementoRevisado">Elemento que será revisado. </param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario. </returns>
        public bool Revisar(ref Tipo prmElementoRevisado)
        {
            if(base.RecuperarPrimero(ref prmElementoRevisado))
            {
                atrMensajeUltimoMetodo = "Se recupero el primer elemento de la pila con exito para su revision.";
                return true;
            }
            atrMensajeUltimoMetodo = "Imposible revisar el primer elemento debido a : " + atrMensajeUltimoMetodo;
            return false;
        }
    }
}

