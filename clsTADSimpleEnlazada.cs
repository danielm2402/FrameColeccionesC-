using System;

namespace CapaServicios.libColecciones
{
    /// <summary>Encapsula el abanico completo de operaciones que seran fundamentales a la hora de manipular completamente cualquier estructura de datos lineal basada en nodos simples enlazados. Las operaciones se agruparan en las siguientes familias: Constructores, Propiedades, INteradores, Cruds(insertadores, modificadores, extractores, consultroes, pobladores) y de ordenamiento.</summary>
    /// <typeparam name="Tipo"></typeparam>
    public class clsTADSimpleEnlazada<Tipo> : clsTAD<Tipo> where Tipo : IComparable, new()
    {
        #region Atributos
        /// <summary> Proporciona acceso al primer nodo simple enlazado de la colección o cabeza. </summary>
        protected clsNodoSimpleEnlazado<Tipo> atrNodoPrimero;

        /// <summary> Proporciona acceso al último nodo simple enlazado de la colección o cola. </summary>
        protected clsNodoSimpleEnlazado<Tipo> atrNodoUltimo;
        #endregion
        #region Métodos
        #region Constructores
        /// <summary> Crea una nueva instancia de TADSimpleEnlazado para una colección basada en una estructura de nodos simple enlazados. </summary>
        public clsTADSimpleEnlazada()
        {
            atrMensajeUltimoMetodo = "Se creo una nueva instancia de tad simple enlazado para una coleccion basada en una estructura de nodos simple enlazado."; //pc
        }
        #endregion
        #region Accesores y Mutadores
        /// <summary>Devuelve el primer nodo con respecto la coleccion actual.</summary>
        /// <returns></returns>
        public clsNodoSimpleEnlazado<Tipo> darNodoPrimero()
        {
            atrMensajeUltimoMetodo = "Se retorno el primer nodo de la colecion " + atrNombreColeccion;
            return atrNodoPrimero;
        }

        /// <summary>Establece el primer nodo del la coleccion actual.</summary>
        /// <param name="prmNodo">nuevo primer nodo</param>
        public void ponerNodoPrimero(clsNodoSimpleEnlazado<Tipo> prmNodo)
        {
            atrMensajeUltimoMetodo = "Se establecio el primer nodo de la " + atrNombreColeccion;
            atrNodoPrimero = prmNodo;
        }

        /// <summary>Devuelve el ultimo nodo simple enlazado con respecto a la coleccion actual.</summary>
        /// <returns>El ultimo nodo de la coleccion actual</returns>
        public clsNodoSimpleEnlazado<Tipo> darNodoUltimo()
        {
            atrMensajeUltimoMetodo = "Se retorno el ultimo nodo de la coleccion";
            return atrNodoUltimo;
        }

        /// <summary>Establece el ultimo nodo para la coleccion actual</summary>
        /// <param name="prmNodo">Nuevo nodo ultimo </param>
        public void ponerNodoUltimo(clsNodoSimpleEnlazado<Tipo> prmNodo)
        {
            atrMensajeUltimoMetodo = "Se establecio el ultimo nodo de la " + atrNombreColeccion;
            atrNodoUltimo = prmNodo;
        }

        #endregion
        #region Iteradores
        #endregion
        #region Crud`s
        #region Insertadores
        /// <summary> Inserta un nuevo Nodo Simple Enlazado en la Cabeza (Primera Posición) de la Colección. </summary>
        /// <param name="prmNuevoNodo">Nuevo Nodo que será Insertado. </param>
        /// <returns>True si el Nodo fue insertado en la primera posición de la Colección con éxito, False de lo contrario. </returns>
        protected bool InsertarPrimero(clsNodoSimpleEnlazado<Tipo> prmNuevoNodo)
        {
            if (prmNuevoNodo != null)
            {
                if (EstaVacia())
                {
                    atrNodoPrimero = prmNuevoNodo;
                    atrNodoUltimo = prmNuevoNodo;
                }
                else
                {
                    prmNuevoNodo.ponerNodoSiguiente(atrNodoPrimero);
                    atrNodoPrimero = prmNuevoNodo;
                }
                atrLongitud++;
                atrMensajeUltimoMetodo = "Se insertó con exito el nuevo "+prmNuevoNodo.darNombreNodo()+" en la Cabeza de la "+darNombreColeccion()+".";
                return true;
            }
            else
            {
                atrMensajeUltimoMetodo = "Imposible Insertar: El Nodo es nulo.";
                return false;
            }
        }

        /// <summary> Agrega un nuevo Nodo simple enlazado en la Cola (Última Posición) de la Colección. </summary>
        /// <param name="prmNuevoNodo">Nuevo Nodo que será Insertado.</param>
        /// <returns>True si el Nodo fue agregado en la última posición de la Colección con éxito o false de lo contrario. </returns>
        protected bool AgregarUltimo(clsNodoSimpleEnlazado<Tipo> prmNuevoNodo)
        {
            if (prmNuevoNodo != null)
            {
                if (EstaVacia())
                {
                    atrNodoPrimero = prmNuevoNodo;
                    atrNodoUltimo = prmNuevoNodo;
                }
                else
                {
                    if (atrNodoUltimo.ConectarDespues(prmNuevoNodo))
                    {
                        atrNodoUltimo = prmNuevoNodo;
                    }
                    else
                    {
                        atrMensajeUltimoMetodo = "Imposible Agregar: " + atrNodoUltimo.darMensajeUltimoMetodo();
                        return false;
                    }
                }
                atrLongitud++;
                atrMensajeUltimoMetodo = "Se agregó con éxito  el elemento en la última posición de la "+darNombreColeccion()+".";
                return true;
            }
            else
            {
                atrMensajeUltimoMetodo = "Imposible Agregar: El nodo que intenta agregar es Nulo.";
                return false;
            }
        }

        /// <summary> Inserta en la Posición indicada por "parIndice" un nuevo Nodo Simple Enlazado. </summary>
        /// <param name="parIndice">Posición donde ocurrirá la inserción. </param>
        /// <param name="parNuevoNodo">Nuevo Nodo que será Insertado. </param>
        /// <returns>True si el nuevo Nodo simple enlazado fue insertado en la posición indicada o False de lo contrario. </returns>
        protected bool InsertarEn(int parIndice, clsNodoSimpleEnlazado<Tipo> parNuevoNodo)
        {
            if (parNuevoNodo != null)
            {
                if (!EstaVacia())
                {
                    if (EsValido(parIndice))
                    {
                        clsNodoSimpleEnlazado<Tipo> varNodo = atrNodoPrimero;
                        for (int varIndice = 0; varIndice < parIndice; varIndice++)
                        {
                            varNodo = varNodo.darNodoSiguiente();
                        }
                        if (varNodo.ConectarDespues(parNuevoNodo))
                        {
                            atrLongitud = atrLongitud + 1;
                            atrMensajeUltimoMetodo = "Se insertó con éxito un elemento en la posición " + parIndice+" de la "+darNombreColeccion()+".";
                            return true;
                        }
                        else
                        {
                            atrMensajeUltimoMetodo="Imposible Insertar en la "+darNombreColeccion()+": "+varNodo.darMensajeUltimoMetodo();
                            return false;
                        }
                    }
                    else
                    {
                        atrMensajeUltimoMetodo = "Imposible Insertar: " + atrMensajeUltimoMetodo;
                        return false;
                    }
                }
                else
                {
                    atrMensajeUltimoMetodo = "Imposible Insertar: " + atrMensajeUltimoMetodo;
                    return false;
                }
            }
            else
            {
                atrMensajeUltimoMetodo += "Imposible insertar: El nodo que intenta insertar es Nulo. ";
                return false;
            }
        }

        /// <summary> Inserta en la Cabeza de la Colección (Primera Posición) un nuevo Nodo simple enlazado cuyo contenido será el elemento especificado por el parámetro "prmElemento". </summary>
        /// <param name="prmNuevoElemento">Elemento que contendrá el nuevo Nodo que será insertado en la primera posición. </param>
        /// <returns>True si el nuevo Nodo simple enlazado que contiene a parElemento fue Insertado en la primera posición de la Colección con éxito, False de lo contrario. </returns>
        protected override bool InsertarPrimero(Tipo prmNuevoElemento)
        {
            clsNodoSimpleEnlazado<Tipo> varNuevoNodo = new clsNodoSimpleEnlazado<Tipo>(prmNuevoElemento);
            return InsertarPrimero(varNuevoNodo);
        }

        /// <summary> Inserta en la cola (Última Posición) de la Colección un nuevo Nodo simple enlazado cuyo contenido será el elemento especificado por el parámetro "parElemento”. </summary>
        /// <param name="prmNuevoElemento">Elemento que contendrá el nuevo Nodo que será inserto en la última posición. </param>
        /// <returns>True si el nuevo Nodo simple enlazado que contiene a parElemento fue Insertado en la Cola de la Colección con éxito o false de lo contrario. </returns>
        protected override bool AgregarUltimo(Tipo prmNuevoElemento)
        {
            clsNodoSimpleEnlazado<Tipo> varNuevoNodo = new clsNodoSimpleEnlazado<Tipo>(prmNuevoElemento);
            return AgregarUltimo(varNuevoNodo);
        }

        /// <summary> Inserta en la posición "parIndice" un nuevo nodo simple enlazado cuyo contenido será el elemento especificado por el parámetro "parElemento". </summary>
        /// <param name="prmIndice">Posición en la que se hará la Inserción. </param>
        /// <param name="prmNuevoElemento">Elemento que contendrá el Nuevo Nodo que será Insertado. </param>
        /// <returns>True si parElemento fue Insertado en la Colección con éxito o false de lo contrario. </returns>
        protected override bool InsertarEn(int prmIndice, Tipo prmNuevoElemento)
        {
            clsNodoSimpleEnlazado<Tipo> varNuevoNodo = new clsNodoSimpleEnlazado<Tipo>(prmNuevoElemento);
            return InsertarEn(prmIndice, varNuevoNodo);
        }
        #endregion
        #region Modificadores
        /// <summary>Modifica el nodo simple enlazado ubicado en la cabeza de la coleccion. </summary>
        /// <param name="prmNodoModificado">Nodo que contiene al elemento modificado.</param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario</returns>
        protected bool ModificarPrimero(clsNodoSimpleEnlazado<Tipo> prmNodoModificado)
        {
            if (prmNodoModificado != null)
            {
                if (!EstaVacia())
                {
                    atrNodoPrimero.ponerElemento(prmNodoModificado.darElemento());
                    atrMensajeUltimoMetodo = "Se modifico el primer " + prmNodoModificado.darNombreNodo() + " de la " + darNombreColeccion() + " con exito";
                    return true;
                }
                else
                {
                    atrMensajeUltimoMetodo = "Imposible modificar el primer "+prmNodoModificado.darNombreNodo() + atrMensajeUltimoMetodo;
                    return false;
                }
            }else
            {
                atrMensajeUltimoMetodo = "Imposible modificar el primero nodo de la " + darNombreColeccion() + "porque es nulo.";
                return false;
            }
        }

        /// <summary>Modifica el nodo simple enlazado ubicado en la cola de la coleccion. </summary>
        /// <param name="prmNodoModificado">Nodo que contiene al elemento modificado.</param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario</returns>
        protected bool ModificarUltimo(clsNodoSimpleEnlazado<Tipo> prmNodoModificado)
        {
            if (prmNodoModificado != null)
            {
                if (!EstaVacia())
                {
                    atrNodoPrimero.ponerElemento(prmNodoModificado.darElemento());
                    atrMensajeUltimoMetodo = "Se modifico el ultimo nodo con exito";
                    return true;
                }
                else
                {
                    atrMensajeUltimoMetodo = "Imposible modificar el ultimo nodo: " + atrMensajeUltimoMetodo;
                    return false;
                }
            }else
            {
                atrMensajeUltimoMetodo = "Imposible modificar el ultimo nodo de la " + darNombreColeccion() + " porque es nulo.";
                return false;
            }
        }

        /// <summary>Modifica el nodo simple enlazado ubicado en la posicion indicada por prmIndice de la coleccion</summary>
        /// <param name="prmIndice">Indice de base cero que indica el punto de modificacion.</param>
        /// <param name="prmNodoModificado">Nodo reemplazara al ubicado en la posicion indicada por el parametro Indice</param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario.</returns>
        protected bool ModificarEn(int prmIndice, clsNodoSimpleEnlazado<Tipo> prmNodoModificado)
        {
            if (prmNodoModificado == null)
            {
                if (!EstaVacia())
                {
                    if (EsValido(prmIndice))
                    {
                        int varIndice;
                        clsNodoSimpleEnlazado<Tipo> varNodoActual;
                        varNodoActual = atrNodoPrimero;
                        for (varIndice = 0; varIndice < prmIndice - 2; varIndice++)
                        {
                            varNodoActual = varNodoActual.darNodoSiguiente();
                        }
                        varNodoActual.ponerElemento(prmNodoModificado.darElemento());
                        atrMensajeUltimoMetodo = "Se ha modificado con exito el elemento ubicado en la posicion" + prmIndice;
                        return true;
                    }
                    else
                    {
                        atrMensajeUltimoMetodo = "Imposible Modificar: " + atrMensajeUltimoMetodo;
                        return false;
                    }
                }
                else
                {
                    atrMensajeUltimoMetodo = "Imposible Modificar: " + atrMensajeUltimoMetodo;
                    return false;
                }
            }else
            {
                atrMensajeUltimoMetodo = "Imposible Modificar el "+prmIndice+" e-simo nodo de la "+darNombreColeccion()+" porque es nulo.";
                return false;
            }
        }

        /// <summary> Modifica el contenido del nodo simple enlazado que esta ubicado en la cabeza de la coleccion. </summary>
        /// <param name="prmElementoModificado">Elemento que reemplaza al antigua primer elemento.</param>
        /// <returns>True si el proceso fue exitos. False de lo contrario.</returns>
        protected override bool ModificarPrimero(Tipo prmElementoModificado)
        {
            clsNodoSimpleEnlazado<Tipo> varNodoModificado = new clsNodoSimpleEnlazado<Tipo>(prmElementoModificado);
            if (ModificarPrimero(varNodoModificado))
            {
                return true;
            }
            return false;
        }

        /// <summary>Modifica el elemento contenido en el nodo simple enlazado que esta ubicado en la cola de la coleccion.</summary>
        /// <param name="prmElementoModificado">Elemento modificado que reemplaza al elemento contenido en el ultimo nodo.</param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario.</returns>
        protected override bool ModificarUltimo(Tipo prmElementoModificado)
        {
            clsNodoSimpleEnlazado<Tipo> varNodoModificado = new clsNodoSimpleEnlazado<Tipo>(prmElementoModificado);
            if (ModificarUltimo(varNodoModificado))
            {
                return true;
            }
            return false;
        }

        /// <summary>Modifica el elemento contenido en el nodo simple enlazado que esta ubicado en la posicion indicada</summary>
        /// <param name="prmIndice">Indice de base cero que indica el punto de modificacion.</param>
        /// <param name="prmElementoModificado">Elemento nuevo que reemplaza al elemento contenido en el nodo en <"prmIndice"></param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario.</returns>
        protected override bool ModificarEn(int prmIndice, Tipo prmElementoModificado)
        {
            clsNodoSimpleEnlazado<Tipo> varNodoModificado;
            varNodoModificado = new clsNodoSimpleEnlazado<Tipo>(prmElementoModificado);
            if (ModificarEn(prmIndice, varNodoModificado))
            {
                return true;
            }
            return false;
        }

        /// <summary> Intercambia el contenido (Elementos) de los nodos ubicados en indice1 e indice2. </summary>
        /// <param name="prmIndice1">Primer Inidce para intercambiar</param>
        /// <param name="prmIndice2">Segundo Inidce para intercambiar</param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario.</returns>
        protected override bool IntercambiarEntre(int prmIndice1, int prmIndice2)
        {
            if (!EstaVacia())
            {
                if(SonValidos(prmIndice1, prmIndice2))
                {
                    clsNodoSimpleEnlazado<Tipo> varNodoActual, varNodoEnIndice1, varNodoEnIndice2;
                    varNodoEnIndice1 = null;
                    varNodoEnIndice2 = null;
                    int varIndice = 0;
                    varNodoActual = atrNodoPrimero;
                    while ((varNodoActual.darNodoSiguiente() != null) || (varNodoEnIndice1 == null || varNodoEnIndice2 == null))
                    {
                        if (varIndice == prmIndice1)
                        {
                            varNodoEnIndice1 = varNodoActual;
                        }
                        if (varIndice == prmIndice2)
                        {
                            varNodoEnIndice2 = varNodoActual;
                        }
                        varNodoActual = varNodoActual.darNodoSiguiente();
                        varIndice++;
                    }
                    Tipo varElementoTemporal;
                    varElementoTemporal = varNodoEnIndice1.darElemento();
                    varNodoEnIndice1.ponerElemento(varNodoEnIndice2.darElemento());
                    varNodoEnIndice2.ponerElemento(varElementoTemporal);
                    atrMensajeUltimoMetodo = "Se intercambiaron los nodos[Elemento] con exito.";
                    return true;
                }else
                {
                    atrMensajeUltimoMetodo = "Imposible intercambiar los nodos "+prmIndice1+" y "+prmIndice2+": " + atrMensajeUltimoMetodo;
                    return false;
                }
            }else
            {
                atrMensajeUltimoMetodo = "Imposible intercambiar los nodos [Elemento]" + atrMensajeUltimoMetodo;
                return false;
            }
        }
        #endregion
        #region Extractores
        /// <summary> Extrae (Elimina y devuelve) el nodo simple enlazado ubicado en la cabeza (primera posición) de la Colección. </summary>
        /// <param name="prmNodoExtraido">Nodo que será extraído. </param>
        /// <returns>True si el Nodo fue extraído con éxito, false de lo contrario. </returns>
        protected bool ExtraerPrimero(ref clsNodoSimpleEnlazado<Tipo> prmNodoExtraido)
        {
            if (!EstaVacia())
            {
                prmNodoExtraido = atrNodoPrimero;
                atrNodoPrimero = atrNodoPrimero.darNodoSiguiente();
                prmNodoExtraido.ponerNodoSiguiente(null); 
                atrLongitud--;
                atrMensajeUltimoMetodo = "Se extrajo con éxito el primer nodo de la ."+darNombreColeccion();
                return true;
            }
            atrMensajeUltimoMetodo = "Imposible extraer primer elemento: " + atrMensajeUltimoMetodo;
            return false;
        }

        /// <summary> Extrae (Elimina y devuelve) el Nodo simple enlazado ubicado en la Cola (Última posición) de la Colección. </summary>
        /// <param name="prmNodoExtraido">Nodo que será extraído.</param>
        /// <returns>True si el Nodo fue extraído exitosamente o False de lo contrario</returns>
        protected bool ExtraerUltimo(ref clsNodoSimpleEnlazado<Tipo> prmNodoExtraido)
        {
            if (!EstaVacia())
            {
                clsNodoSimpleEnlazado<Tipo> varNodoActual = atrNodoPrimero;
                for (int varIndice = 0; varIndice < atrLongitud - 2; varIndice++)
                {
                    varNodoActual = varNodoActual.darNodoSiguiente();
                }
                if (varNodoActual.DesconectarDespues(ref prmNodoExtraido))
                {
                    prmNodoExtraido.ponerNodoSiguiente(null);
                    atrNodoUltimo = varNodoActual;
                    atrLongitud--;
                    atrMensajeUltimoMetodo = "Se extrajo con éxito el último Nodo de la "+darNombreColeccion();
                    return true;
                }
                else
                {
                    atrMensajeUltimoMetodo = "Imposible extraer ultimo nodo[Elemento]: " + varNodoActual.darMensajeUltimoMetodo();
                    return false;
                }
            }
            atrMensajeUltimoMetodo = "Imposible extraer ultimo Nodo[Elemento]: " + atrMensajeUltimoMetodo;
            return false;
        }

        /// <summary> Extrae (Elimina y devuelve) el Nodo simple enlazado ubicado en la posición indicada por "parIndice". </summary>
        /// <param name="prmIndice">Posición donde ocurrirá la extracción. </param>
        /// <param name="prmNodoExtraido">Nodo extraído. </param>
        /// <returns>True si el Nodo simple enlazado fue extraído de la posición indicada con éxito, False de lo contrario. </returns>
        protected bool ExtraerEn(int prmIndice, ref clsNodoSimpleEnlazado<Tipo> prmNodoExtraido)
        {
            if (!EstaVacia())
            {
                if (EsValido(prmIndice))
                {
                    clsNodoSimpleEnlazado<Tipo> varNodoActual = atrNodoPrimero;
                    for (int varIndice = 0; varIndice < prmIndice; varIndice++)
                    {
                        varNodoActual = varNodoActual.darNodoSiguiente();
                    }
                    if (varNodoActual.DesconectarDespues(ref prmNodoExtraido))
                    {
                        prmNodoExtraido.ponerNodoSiguiente(null);
                        atrLongitud--;
                        atrMensajeUltimoMetodo = "Se extrajo con éxito el Nodo ubicado en la posición " + prmIndice+ " de la "+darNombreColeccion();
                        return true;
                    }
                    atrMensajeUltimoMetodo = "Imposible extraer nodo[elemento]: " + varNodoActual.darMensajeUltimoMetodo();
                    return false;
                }
                atrMensajeUltimoMetodo = "Imposible extraer nodo[elemento]: " + atrMensajeUltimoMetodo;
                return false;
            }
            atrMensajeUltimoMetodo = "Imposible extraer: " + atrMensajeUltimoMetodo;
            return false;
        }
             
        /// <summary> Extrae (Elimina) el Nodo simple enlazado ubicado en la Cabeza (Primera Posición) de la Colección y además devuelve su elemento a través del parámetro(parElemento). </summary>
        /// <param name="prmElementoExtraido">Elemento devuelto que está contenido en el Nodo eliminado. </param>
        /// <returns>True si el elemento fue extraído de la cabeza de la Colección con éxito, False de lo contrario. </returns>
        protected override bool ExtraerPrimero(ref Tipo prmElementoExtraido)
        {
            clsNodoSimpleEnlazado<Tipo> varNodoExtraido = new clsNodoSimpleEnlazado<Tipo>();
            if (ExtraerPrimero(ref varNodoExtraido))
            {
                prmElementoExtraido = varNodoExtraido.darElemento();
                return true;
            }
            return false;
        }

        /// <summary> Extrae (Elimina) el Nodo simple enlazado ubicado en la Cola (Última Posición) de la Colección y además devuelve su elemento a través del parámetro "parElemento". </summary>
        /// <param name="prmElementoExtraido">Elemento devuelto que está contenido en el Nodo Eliminado.</param>
        /// <returns>True si elemento fue extraído de la cola de la Colección con éxito o False de lo contrario. </returns>
        protected override bool ExtraerUltimo(ref Tipo prmElementoExtraido)
        {
            clsNodoSimpleEnlazado<Tipo> varNodoExtraido = new clsNodoSimpleEnlazado<Tipo>();
            if (ExtraerUltimo(ref varNodoExtraido))
            {
                prmElementoExtraido = varNodoExtraido.darElemento();
                return true;
            }
            return false;
        }

        /// <summary> Extrae (Elimina) el Nodo simple enlazado ubicado en la posición indicada por "parIndice" y al mismo tiempo devuelvesu elemento en "parElemento". </summary>
        /// <param name="prmIndice">Posición donde ocurrirá la extracción. </param>
        /// <param name="prmElementoExtraido">Elemento contenido en el Nodo extraído. </param>
        /// <returns>true si el Nodo y su Elemento fueron extraídos de la posición indicada o False de lo contrario. </returns>
        protected override bool ExtraerEn(int prmIndice, ref Tipo prmElementoExtraido)
        {
            clsNodoSimpleEnlazado<Tipo> varNodoExtraido = new clsNodoSimpleEnlazado<Tipo>();
            if (ExtraerEn(prmIndice, ref varNodoExtraido))
            {
                prmElementoExtraido = varNodoExtraido.darElemento();
                return true;
            }
            return false;
        }
        #endregion
        #region Recuperadores
        /// <summary>Devuelve (sin extraer) el nodo simple enlazado ubicado en la cabeza de la coleccion. </summary>
        /// <param name="prmNodoRecuperado">Nodo que será recuperado</param>
        /// <returns>True si el nodo fue recuperado con exito o false de lo contrario. </returns>
        protected bool RecuperarPrimero(ref clsNodoSimpleEnlazado<Tipo> prmNodoRecuperado)
        {
            if (!EstaVacia())
            {
                prmNodoRecuperado = atrNodoPrimero;
                atrMensajeUltimoMetodo= "Se recuperó con exito el primer nodo";
                return true;
            }
            else
            {
                atrMensajeUltimoMetodo = "Imposible recuperar el primer elemento: " + atrMensajeUltimoMetodo;
                return false;
            }
        }

        /// <summary> Devuelve (sin extraer) un nodo simple enlazado ubicado cola de la coleccion. </summary>
        /// <param name="prmNodoRecuperado">Nodo que será recuperado</param>
        /// <returns>true si el nodo fue recuperado desde la posicion indicada con exito. False de lo contrario. </returns>
        protected bool RecuperarUltimo(ref clsNodoSimpleEnlazado<Tipo> prmNodoRecuperado)
        {
            if (!EstaVacia())
            {
                prmNodoRecuperado = atrNodoUltimo;
                atrMensajeUltimoMetodo = "Se recuperó el ultimo nodo con exito";
                return true;
            }
            else
            {
                atrMensajeUltimoMetodo = "Imposible recuperar el primer elemento: " + atrMensajeUltimoMetodo;
                return false;
            }
        }

        /// <summary> Devuelve (sin extraer) un nodo simple enlazado ubicado en la posicion indicada por "parIndice" de la coleccion. </summary>
        /// <param name="prmIndice">Índice de base cero que indica el punto de recuperación</param>
        /// <param name="prmNodoRecuperado">Nodo que será recuperado</param>
        /// <returns>true si el nodo fue recuperado desde la posicion indicada con exito. False de lo contrario. </returns>
        protected bool RecuperarEn(int prmIndice, ref clsNodoSimpleEnlazado<Tipo> prmNodoRecuperado)
        {
            if (!EstaVacia())
            {
                if (EsValido(prmIndice))
                {
                    int varIndice;
                    prmNodoRecuperado = atrNodoPrimero;
                    for (varIndice = 0; varIndice < prmIndice + 1; varIndice++) // verificar prmInidice +1 pc
                        prmNodoRecuperado = prmNodoRecuperado.darNodoSiguiente();
                    atrMensajeUltimoMetodo = "Se ha recuperado con éxito el elemento ubicado en la última posicion " + prmIndice+" de la "+darNombreColeccion();
                    return true;
                }
                else
                {
                    atrMensajeUltimoMetodo = "Imposible recuperar elemento: " + atrMensajeUltimoMetodo;
                    return false;
                }
            }
            else
            {
                atrMensajeUltimoMetodo = "Imposible recuperar elemento: " + atrMensajeUltimoMetodo;
                return false;
            }
        }

        /// <summary>Devuelve (sin extraer) el nodo simple enlazado ubicado en la cabeza de la coleccion. </summary>
        /// <param name="prmElementoRecuperado">Nodo que será recuperado</param>
        /// <returns>True si el nodo fue recuperado con exito o false de lo contrario. </returns>
        protected override bool RecuperarPrimero(ref Tipo prmElementoRecuperado)
        {
            clsNodoSimpleEnlazado<Tipo> varNodoRecuperado = new clsNodoSimpleEnlazado<Tipo>();
            if (RecuperarPrimero(ref varNodoRecuperado))
            {
                prmElementoRecuperado = varNodoRecuperado.darElemento();
                return true;
            }
                return false;
        }

        /// <summary> Devuelve (sin extraer) el elemento contenido en el nodo simple enlazado que está ubicado en la cola de la coleccion. </summary>
        /// <param name="prmElementoRecuperado">Elemento que será recuperado</param>
        /// <returns>true si el elemento fue recuperado con exito. False de lo contrario. </returns>
        protected override bool RecuperarUltimo(ref Tipo prmElementoRecuperado)
        {
            clsNodoSimpleEnlazado<Tipo> varNodoRecuperado = new clsNodoSimpleEnlazado<Tipo>();
            if (RecuperarPrimero(ref varNodoRecuperado))
            {
                prmElementoRecuperado = varNodoRecuperado.darElemento();
                return true;
            }
            return false;
        }

        /// <summary> Devuelve (sin extraer) el elemento contenido en el nodo simple enlazado ubicado en la posicion indicada por "parIndice" de la coleccion. </summary>
        /// <param name="prmIndice">Índice de base cero que indica el punto de recuperación</param>
        /// <param name="prmElementoRecuperado">Elemento que será recuperado</param>
        /// <returns>true si el Elemento fue recuperado con exito. False de lo contrario. </returns>
        protected override bool RecuperarEn(int prmIndice, ref Tipo prmElementoRecuperado)
        {
            clsNodoSimpleEnlazado<Tipo> varNodoRecuperado = new clsNodoSimpleEnlazado<Tipo>();
            if (RecuperarEn(prmIndice, ref varNodoRecuperado))
            {
                prmElementoRecuperado = varNodoRecuperado.darElemento();
                return true;
            }
                return false;
        }
        #endregion
        #region Consultores
        #endregion
        #region Pobladores
        #endregion
        #endregion
        #region Ordenamiento
        //pc
        #endregion
        #endregion
    }
}


