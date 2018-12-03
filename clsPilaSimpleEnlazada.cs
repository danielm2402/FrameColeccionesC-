using System;

namespace CapaServicios.libColecciones
{
    /// <summary>Pila con implementacion simple enlazada. la codificacion de la clase Pila Simple Enlazada debe implementar los metodos publicos propuestoss por la interfaz generica iPila<Tipo> usando los metodos que ya fueron implementados para el TADSimpleEnlazado.</Tipo></summary> <typeparam name="Tipo"></typeparam>
    public class clsPilaSimpleEnlazada<Tipo> : clsTADSimpleEnlazada<Tipo> , iPila<Tipo> where Tipo : IComparable, new()
    {   
        /// <summary>Devuelve el nombre del tipo de coleccion para insertarse dentro de los mensajes devueltos por el patron mensajero</summary>
        /// <returns>Cadena con el nombre de la coleccion.</returns>
        protected override string darNombreColeccion()
        {
            atrNombreColeccion = "Pila Simple Enlazada";
            return base.darNombreColeccion();
        }

        /// <summary>Agrega un nuevo elemento al inicio de la Pila</summary>
        /// <param name="prmElementoApilado">Elemento que sera apilado.</param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario.</returns>
        public bool Apilar(Tipo prmElementoApilado)
        {
            if (base.InsertarPrimero(prmElementoApilado))
            {
                atrMensajeUltimoMetodo = "Se apilo el nuevo elemento con exito";
                return true;
            }
            atrMensajeUltimoMetodo = "Imposible apilar el nuevo elemento debido a: " + atrMensajeUltimoMetodo;
            return false;
        }

        /// <summary>Quita un Elemento al inicio de la Pila.</summary>
        /// <param name="prmElementoDesapilado">Elemento que sera Desapilado.</param>
        /// <returns>True si fue exitoso. False de lo contrario.</returns>
        public bool Desapilar(ref Tipo prmElementoDesapilado)
        {
           if(base.ExtraerPrimero(ref prmElementoDesapilado))
            {
                atrMensajeUltimoMetodo = " Se desapilo primer elemento con exito";
                return true;
            }
            atrMensajeUltimoMetodo = "Imposible desapilar el primer elemento debido a: " + atrMensajeUltimoMetodo;
            return false;
        }

        /// <summary>Recupera ( para su revision) sin extraer, el Elemento al inicio de la Pila.</summary>
        /// <param name="prmElementoRevisado">Elemento que sera revisado.</param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario.</returns>
        public bool Revisar(ref Tipo prmElementoRevisado)
        {
            if (base.RecuperarPrimero(ref prmElementoRevisado))
            {
                atrMensajeUltimoMetodo = "Se recupero el primer elemento de la pila con exito para su revision.";
                return true;
            }
            atrMensajeUltimoMetodo = " Imposible revisar el primer elemento debido a: " + atrMensajeUltimoMetodo;
            return false;
        }
    }
}

