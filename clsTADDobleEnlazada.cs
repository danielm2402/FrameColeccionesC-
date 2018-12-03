using System;

namespace CapaServicios.libColecciones
{
    /// <summary>Encapsula el abanico completo de operaciones que seran fundamentales a la hora de manipular completamente cualquier estructura de datos lineal basada en nodos doble enlazados. Las operaciones se agruparan en las siguientes familias: Constructores, Propiedades, INteradores, Cruds(insertadores, modificadores, extractores, consultroes, pobladores) y de ordenamiento.</summary>
    /// <typeparam name="Tipo"></typeparam>
    public class clsTADDobleEnlazada<Tipo> : clsTAD<Tipo> where Tipo : IComparable, new()
    {
        #region Atributos
        /// <summary> Proporciona acceso al primer nodo doble enlazado de la colección o cabeza. </summary>
        protected clsNodoDobleEnlazado<Tipo> atrNodoPrimero;

        /// <summary> Proporciona acceso al último nodo doble enlazado de la colección o cola. </summary>
        protected clsNodoDobleEnlazado<Tipo> atrNodoUltimo;
        #endregion
        #region Métodos
        #region Constructores
        /// <summary> Crea una nueva instancia de TAD Doble Enlazado para una colección basada en una estructura de nodos doble enlazados </summary>
        public clsTADDobleEnlazada() { }
        #endregion
        #region Accesores y Mutadores
        /// <summary>Devuelve el primer nodo de la coleccion</summary>
        /// <returns>El primer nodo</returns>
        public clsNodoDobleEnlazado<Tipo> darNodoPrimero()
        {
            atrMensajeUltimoMetodo = "Se retorno el primer nodo de la " + atrNombreColeccion;
            return atrNodoPrimero;
        }

        /// <summary>Establece el nodo primero para la coleccion actual.</summary>
        /// <param name="prmNodo">Nuevo nodo primero</param>
        public void ponerNodoPrimero(clsNodoDobleEnlazado<Tipo> prmNodo)
        {
            atrMensajeUltimoMetodo = "Se establecio el primer nodo de la " + atrNombreColeccion;
            atrNodoPrimero = prmNodo;
        }

        /// <summary>Devuelve el ultimo nodo de la coleccion.</summary>
        /// <returns>Ultimo nodo de la coleccion.</returns>
        public clsNodoDobleEnlazado<Tipo> darNodoUltimo()
        {
            atrMensajeUltimoMetodo = "Se retorno el ultimo nodo de la " + atrNombreColeccion;
            return atrNodoUltimo;
        }

        /// <summary>Establece el nodo sigueinte para el nodo actual.</summary>
        /// <param name="prmNodo">Nuevo nodo siguiente con respecto al nodo actual.</param>
        public void ponerNodoUltimo(clsNodoDobleEnlazado<Tipo> prmNodo)
        {
            atrMensajeUltimoMetodo = "Se establecio el ultimo nodo de la " + atrNombreColeccion;
            atrNodoUltimo = prmNodo;
        }

        #endregion
        #region Iteradores
        #endregion
        #region Crud`s
        #region Insertadores
        /// <summary> Inserta un nuevo Nodo doble enlazado en la cabeza (Primera Posición) de la Colección. </summary>
        /// <param name="prmNuevoNodo">Nuevo Nodo que será insertado. </param>
        /// <returns>True si el Nodo fue Insertado exitosamente, False de lo contrario. </returns>
        protected bool InsertarPrimero(clsNodoDobleEnlazado<Tipo> prmNuevoNodo)
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
                    if (atrNodoPrimero.ConectarAntes(prmNuevoNodo)==true)
                    {
                        atrNodoPrimero = prmNuevoNodo;
                    }
                    else
                    {
                        atrMensajeUltimoMetodo = "Imposible insertar: " + atrNodoPrimero.darMensajeUltimoMetodo()+ " de la " +darNombreColeccion();
                        return false;
                    }
                }
                atrLongitud++;
                atrMensajeUltimoMetodo = "Se insertó con éxito en la primera posición de la "+darNombreColeccion()+".";
                return true;
            }
            else
            {
                atrMensajeUltimoMetodo= "Imposible insertar: El nodo [elemento] es nulo.";
                return false;
            }
        }

        /// <summary> Inserta en la posición indicada por "parIndice" un nuevo Nodo doble enlazado </summary>
        /// <param name="prmIndice">Posición donde ocurrirá la inserción. </param>
        /// <param name="prmNuevoNodo">Nuevo Nodo que será insertado. </param>
        /// <returns>True si el nuevo Nodo doble enlazado fue insertado en la posición indicada o False de lo contrario. </returns>
        protected bool InsertarEn(int prmIndice, clsNodoDobleEnlazado<Tipo> prmNuevoNodo)
        {
            if (prmNuevoNodo != null)
            {
                if (!EstaVacia())
                {
                    if (EsValido(prmIndice))
                    {
                        int varIndice;
                        clsNodoDobleEnlazado<Tipo> varNodoActual;
                        if (prmIndice <= (atrLongitud - 1) / 2)
                        {
                            varNodoActual = atrNodoPrimero;
                            for (varIndice = 0; varIndice < prmIndice; varIndice++)
                            {
                                varNodoActual = varNodoActual.darNodoSiguiente();
                            }
                        }
                        else
                        {
                            varNodoActual = atrNodoUltimo;
                            for (varIndice = atrLongitud - 1; varIndice > prmIndice+1; varIndice--)
                            {
                                varNodoActual = varNodoActual.darNodoSiguiente();
                            }
                        }
                        if (varNodoActual.ConectarDespues(prmNuevoNodo))
                        {
                            atrLongitud++;
                            atrMensajeUltimoMetodo = "Se insertó con éxito en la posición " + prmIndice +" de la "+darNombreColeccion()+ ".";
                            return true;
                        }
                        else
                        {
                            atrMensajeUltimoMetodo = "Imposible insertar nodo[elemento]: " + varNodoActual.darMensajeUltimoMetodo();
                            return false;
                        }
                    }
                    else
                    {
                        atrMensajeUltimoMetodo = "Imposible insertar el nodo[Elemento]: " + atrMensajeUltimoMetodo;
                        return false;
                    }
                }
                else
                {
                    atrMensajeUltimoMetodo = "Imposible insertar el nodo[Elemento]: " + atrMensajeUltimoMetodo;
                    return false;
                }
            }
            else
            {
                atrMensajeUltimoMetodo = "Imposible insertar: el nodo[Elemento] que intenta insertar es nulo";
                return false;
            }
        }

        /// <summary> Agrega un nuevo Nodo doble enlazado en la Cola (última posición) de la Colección </summary>
        /// <param name="prmNuevoNodo">Nuevo nodo que será insertado. </param>
        /// <returns>True si el Elemento fue insertado exitosamente o false de lo contrario. </returns>
        protected bool AgregarUltimo(clsNodoDobleEnlazado<Tipo> prmNuevoNodo)
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
                        atrMensajeUltimoMetodo = "Imposible agregar ultimo nodo [elemento]: " + atrNodoUltimo.darMensajeUltimoMetodo();
                        return false;
                    }
                }
                atrLongitud++;
                atrMensajeUltimoMetodo= "Se agregó Nodo[elemento] en la ultima posicion de la "+darNombreColeccion()+" con exito.";
                return true;
            }
            else
            {
                atrMensajeUltimoMetodo = "Imposible agregar: El Nodo[elemento] que intenta agregar es nulo.";
                return false;
            }
        }

        /// <summary> Inserta en la Cabeza de la Colección (Primera Posición) un nuevo Nodo doble enlazado cuyo contenido será el elemento especificado por el parámetro "parElemento". </summary>
        /// <param name="prmElemento">Elemento que contendrá el nuevo Nodo que será insertado en primera posición. </param>
        /// <returns>True si el nuevo Nodo doble enlazado que contiene a parElemento fue insertado en la cabeza de la Colección con éxito, false de lo contrario. </returns>
        protected override bool InsertarPrimero(Tipo prmElemento)
        {
            clsNodoDobleEnlazado<Tipo> varNuevoNodo = new clsNodoDobleEnlazado<Tipo>(prmElemento);
            return InsertarPrimero(varNuevoNodo);
        }

        /// <summary> Inserta en la Cola (Última Posición) de la Colección un nuevo Nodo doble enlazado cuyo Contenido será el elemento especificado por el parámetro "parElemento". </summary>
        /// <param name="prmElemento">Elemento que contendrá el nuevo Nodo que será agregado en la última posición. </param>
        /// <returns>True si el nuevo Nodo Doble enlazado que contiene a parElemento fue Insertado en la Cola de la Colección con éxito o false de lo contrario. </returns>
        protected override bool AgregarUltimo(Tipo prmElemento)
        {
            clsNodoDobleEnlazado<Tipo> varNuevoNodo = new clsNodoDobleEnlazado<Tipo>(prmElemento);
            return AgregarUltimo(varNuevoNodo);
        }

        /// <summary> Inserta en la posición "parIndice" un nuevo Nodo doble enlazado cuyo contenido será el elemento especificado por el parámetro "parElemento". </summary>
        /// <param name="parIndice">Indica la posición en la que se hará la inserción. </param>
        /// <param name="prmElemento">Elemento que contendrá el nuevo Nodo que será insertado. </param>
        /// <returns>True si el parElemento fue insertado en la Colección con éxito o false de lo contrario. </returns>
        protected override bool InsertarEn(int parIndice, Tipo prmElemento)
        {
            clsNodoDobleEnlazado<Tipo> varNuevoNodo = new clsNodoDobleEnlazado<Tipo>(prmElemento);
            return InsertarEn(parIndice, varNuevoNodo);
        }
        #endregion
        #region Modificadores
        /// <summary>Modifica el nodo doble enlazado ubicado en la cabeza de la coleccion.</summary>
        /// <param name="prmNodoModificado">NOdo que contiene al elemento modificado.</param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario.</returns>
        protected bool ModificarPrimero(clsNodoDobleEnlazado<Tipo> prmNodoModificado)
        {
            if (prmNodoModificado == null)
            {
                if (!EstaVacia())
                {
                    atrNodoPrimero.ponerElemento(prmNodoModificado.darElemento());
                    atrMensajeUltimoMetodo = "Se modifico el primer nodo[elemento] de la coleccion con exito.";
                    return true;
                }
                else
                {
                    atrMensajeUltimoMetodo = "Imposible modificar el primer nodo [elemento]: " + atrMensajeUltimoMetodo;
                    return false;
                }
            }else
            {
                atrMensajeUltimoMetodo = "Imposible Modificar el primer nodo [elemento]: El nodo es Nulo.";
                return false;
            }
        }

        /// <summary>Modifica el nodo doble enlazado ubicado en la cola de la coleccion.</summary>
        /// <param name="prmNodoModificado">NOdo que contiene al elemento modificado.</param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario.</returns>
        protected bool ModificarUltimo(clsNodoDobleEnlazado<Tipo> prmNodoModificado)
        {
            if (prmNodoModificado == null)
            {
                if (!EstaVacia())
                {
                    atrNodoUltimo.ponerElemento(prmNodoModificado.darElemento());
                    atrMensajeUltimoMetodo = "Se modifico con exito el ultimo nodo [elemento] de la "+darNombreColeccion();
                    return true;
                }
                else
                {
                    atrMensajeUltimoMetodo = "Imposible modificar el ultimo nodo[elemento]:" + atrMensajeUltimoMetodo;
                    return false;
                }
            }else
            {
                atrMensajeUltimoMetodo = " Imposible modificar el ultimo: El nodo es nulo.";
                return false;
            }
        }

        /// <summary>Modifica el nodo doble enlazado ubicado en la posicion indicada por el indice de la coleccion</summary>
        /// <param name="prmIndice">Indice de base cero que indica el punto de modificacion.</param>
        /// <param name="prmNodoModificado">Nodo que reemplazara al ubicado en <"prmIndice"></param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario.</returns>
        protected bool ModificarEn(int prmIndice, clsNodoDobleEnlazado<Tipo> prmNodoModificado)
        {
            if (prmNodoModificado != null)
            {
                if (!EstaVacia())
                {
                    if (EsValido(prmIndice))
                    {
                        int varIndice;
                        clsNodoDobleEnlazado<Tipo> varNodoActual;
                        if (prmIndice <= (atrLongitud - 1) / 2)
                        {
                            varNodoActual = atrNodoPrimero;
                            for (varIndice = 0; varIndice <= prmIndice; varIndice++)//pc +1
                            {
                                varNodoActual = varNodoActual.darNodoSiguiente();
                            }
                        }
                        else
                        {
                            varNodoActual = atrNodoUltimo;
                            for (varIndice = atrLongitud - 1; varIndice >= prmIndice; varIndice--)//pc
                            {
                                varNodoActual = varNodoActual.darNodoAnterior();
                            }
                        }
                        varNodoActual.ponerElemento(prmNodoModificado.darElemento());
                        atrMensajeUltimoMetodo = "Se ha modificado con exito el nodo ubicado en la posicion " + prmIndice+" de la "+darNombreColeccion();
                        return true;
                    }
                    else
                    {
                        atrMensajeUltimoMetodo = "Imposible modificar: " + atrMensajeUltimoMetodo;
                        return false;
                    }
                }
                else
                {
                    atrMensajeUltimoMetodo = "Imposible modificar: " + atrMensajeUltimoMetodo;
                    return false;
                }
            }else
            {
                atrMensajeUltimoMetodo = "Imposible modificar en la posicion " + prmIndice + ": El nodo es Nulo.";
                return false;
            }
        }

        /// <summary>Modifica el elemento contenido en el nodo doble enlazado que esta ubicado en la cabeza de la coleccion.</summary>
        /// <param name="prmElementoModificado">Elemento que reemplaara al antiguo primer Elemento</param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario.</returns>
        protected override bool ModificarPrimero(Tipo prmElementoModificado)
        {
            clsNodoDobleEnlazado<Tipo> varNodoModificado = new clsNodoDobleEnlazado<Tipo>(prmElementoModificado);
            if (ModificarPrimero(varNodoModificado))
            {
                return true;
            }
            return false;
        }

        /// <summary>Modifica el elemento contenido en el nodo doble enlazado que esta ubicado en la cola de la coleccion.</summary>
        /// <param name="prmElementoModificado">Elemento que reemplaara al antiguo primer Elemento</param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario.</returns>
        protected override bool ModificarUltimo(Tipo prmElementoModificado)
        {
            clsNodoDobleEnlazado<Tipo> varNodoModificado = new clsNodoDobleEnlazado<Tipo>(prmElementoModificado);
            if (ModificarUltimo(varNodoModificado))
            {
                return true;
            }
            return false;
        }

        /// <summary>Modifica el elemento contenido en el nodo doble enlazado que esta ubicado en la posicion "Indice" de la coleccion.</summary>
        /// <param name="prmElementoModificado">Elemento que reemplaara al antiguo primer Elemento</param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario.</returns>
        protected override bool ModificarEn(int prmIndice,Tipo prmElementoModificado)
        {
            clsNodoDobleEnlazado<Tipo> varNodoModificado = new clsNodoDobleEnlazado<Tipo>(prmElementoModificado);
            if (ModificarEn(prmIndice, varNodoModificado))
            {
                return true;
            }
            return false;
        }

        /// <summary>Intercambia el contenido (elementos) de los nodos ubicados en Indice1 y Inidce2</summary>
        /// <param name="prmIndice1">Primer Indice para intercambiar.</param>
        /// <param name="prmIndice2">Segundo Indice para intercambiar.</param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario.</returns>
        protected override bool IntercambiarEntre(int prmIndice1, int prmIndice2)//pc
        {
            if (!EstaVacia())
            {
                if(SonValidos(prmIndice1, prmIndice2))
                {
                    clsNodoDobleEnlazado<Tipo> varNodoActual,varNodoEnIndice1, varNodoEnIndice2;
                    varNodoEnIndice1=null;
                    varNodoEnIndice2=null;
                    int varIndice=0;
                    varNodoActual = atrNodoPrimero;
                    while ((varNodoActual.darNodoSiguiente() != null) || ((varNodoEnIndice1 == null) || (varNodoEnIndice2 == null)))
                    {
                        if (varIndice == prmIndice1)
                        {
                            varNodoEnIndice1 = varNodoActual;
                        }
                        if (varIndice == prmIndice2)
                        {
                            varNodoEnIndice2 = varNodoActual;
                        }
                    }
                    Tipo varElementoTemporal;
                    varElementoTemporal = varNodoEnIndice1.darElemento();
                    varNodoEnIndice1.ponerElemento(varNodoEnIndice2.darElemento());
                    varNodoEnIndice2.ponerElemento(varElementoTemporal);
                    atrMensajeUltimoMetodo = "Se han intercambiado exitosamento los nodos[elementos] "+prmIndice1+" y " +prmIndice2;
                    return true;
                }else
                {
                    atrMensajeUltimoMetodo = "Imposible Intercambiar: " + atrMensajeUltimoMetodo;
                    return false;
                }
            }else
            {
                atrMensajeUltimoMetodo = "Imposible Intercambiar: " + atrMensajeUltimoMetodo;
                return false;
            }
        }
        #endregion
        #region Extractores
        /// <summary> Extrae (elimina y devuelve) el nodo doble enlazado ubicado en la cabeza (primera posición) de la colección. </summary>
        /// <param name="prmNodoExtraido">Nodo que será Extraído. </param>
        /// <returns>True si el nodo fue extraído exitosamente o false de lo contrario. </returns>
        protected bool ExtraerPrimero(ref clsNodoDobleEnlazado<Tipo> prmNodoExtraido)
        {
            if (!EstaVacia())
            {
                if (atrNodoPrimero.Desconectar())
                {
                    prmNodoExtraido = atrNodoPrimero;
                    prmNodoExtraido.ponerNodoAnterior(null);
                    prmNodoExtraido.ponerNodoSiguiente(null);
                    atrNodoPrimero = atrNodoPrimero.darNodoSiguiente();
                    atrLongitud--;
                    atrMensajeUltimoMetodo = "Se extrajo con éxito el primer nodo de la "+darNombreColeccion();
                    return true;
                }
                else
                {
                    atrMensajeUltimoMetodo = "Imposible extraer el primer[elemento]: " + atrNodoPrimero.darMensajeUltimoMetodo();
                    return false;
                }
            }
            else
            {
                atrMensajeUltimoMetodo = "Imposible extraer el primer[elemento]: " + atrMensajeUltimoMetodo;
                return false;
            }
        }

        /// <summary> Extrae (elimina y devuelve) el nodo doble enlazado ubicado en la cola (última posición) de la colección. </summary>
        /// <param name="prmNodoExtraido">Nodo que será Extraído</param>
        /// <returns>True si el elemento fue extraído con exito o false de lo contrario. </returns>
        protected bool ExtraerUltimo(ref clsNodoDobleEnlazado<Tipo> prmNodoExtraido)
        {
            if (!EstaVacia())
            {
                if (atrNodoUltimo.Desconectar())
                {
                    prmNodoExtraido = atrNodoUltimo;
                    prmNodoExtraido.ponerNodoAnterior(null);
                    prmNodoExtraido.ponerNodoSiguiente(null);
                    atrNodoUltimo = atrNodoUltimo.darNodoAnterior();
                    atrLongitud--;
                    atrMensajeUltimoMetodo= "Se extrajo con exito el ultimo nodo de la "+darNombreColeccion()+".";
                    return true;
                }
                else
                {
                    atrMensajeUltimoMetodo = "Imposible extraer el ultimo nodo[elemento]: " + atrNodoUltimo.darMensajeUltimoMetodo();
                    return false;
                }
            }
            else
            {
                atrMensajeUltimoMetodo = "Imposible extraer el ultimo nodo[elemento]: " + atrMensajeUltimoMetodo;
                return false;
            }
        }

        /// <summary> Extrae (elimina y devuelve) el nodo doble enlazado ubicado en la posición indicada por el Indice". </summary>
        /// <param name="prmIndice">Posición donde ocurrirá la extracción. </param>
        /// <param name="prmNodoExtraido">Nodo Extraído</param>
        /// <returns>True si el nuevo nodo doble enlazado fue extraído de la posición indicada o false de lo contrario. </returns>
        protected bool ExtraerEn(int prmIndice, ref clsNodoDobleEnlazado<Tipo> prmNodoExtraido)
        {
            if (!EstaVacia())
            {
                if (EsValido(prmIndice))
                {
                    int varIndice;
                    if (prmIndice <= (atrLongitud - 1) / 2)
                    {
                        prmNodoExtraido = atrNodoPrimero;
                        for (varIndice = 0; varIndice <= prmIndice; varIndice++)
                        {
                            prmNodoExtraido = prmNodoExtraido.darNodoSiguiente();
                        }
                    }else
                    {
                        prmNodoExtraido = atrNodoUltimo;
                        for (varIndice = atrLongitud - 1; varIndice >= prmIndice; varIndice--)
                        {
                            prmNodoExtraido = prmNodoExtraido.darNodoAnterior();
                        }
                    }
                    if (prmNodoExtraido.Desconectar())
                    {
                        prmNodoExtraido.ponerNodoAnterior(null);
                        prmNodoExtraido.ponerNodoSiguiente(null);
                        atrLongitud--;
                        atrMensajeUltimoMetodo = "Se extrajo con éxito el nodo ubicado en la posición " + prmIndice;
                        return true;
                    }else
                    {
                        atrMensajeUltimoMetodo = "Imposible extraer: " + atrMensajeUltimoMetodo;
                        return false;
                    }
                }else
                {
                    atrMensajeUltimoMetodo = "Imposible extraer: " + atrMensajeUltimoMetodo;
                    return false;
                }
            }else
            {
                atrMensajeUltimoMetodo = "Imposible extraer: " + atrMensajeUltimoMetodo;
                return false;
            }
        }

        /// <summary> Extraer (elimina) el nodo doble enlazado ubicado en la cabeza (primera posición) de la colección y además devuelve su elemento a través del parámetro "parElemento". </summary>
        /// <param name="prmElementoExtraido">Elemento devuelto que está contenido en el nodo eliminado. </param>
        /// <returns>True si el nodo doble enlazado fue extraído de la cabeza de la colección con éxito o false de lo contrario. </returns>
        protected override bool ExtraerPrimero(ref Tipo prmElementoExtraido)
        {
            clsNodoDobleEnlazado<Tipo> varNodoExtraido = new clsNodoDobleEnlazado<Tipo>();
            if (ExtraerPrimero(ref varNodoExtraido))
            {
                prmElementoExtraido = varNodoExtraido.darElemento();
                return true;
            }
            return false;
        }

        /// <summary> Extrae(elimina) el nodo doble enlazado ubicado en la cola (ultima posicion de la coleccion y además devuelve su elemento atreves del parámetro "parElemento". </summary>
        /// <param name="prmElementoExtraido">Elemento devuelto que está contenido en el nodo Eliminado. </param>
        /// <returns>True si el nodo doble enlazado fue extraído de la cola de la coleccion con exito o false de lo contrario.</returns>
        protected override bool ExtraerUltimo(ref Tipo prmElementoExtraido)
        {
            clsNodoDobleEnlazado<Tipo> varNodoExtraido = new clsNodoDobleEnlazado<Tipo>();
            if (ExtraerUltimo(ref varNodoExtraido))
            {
                prmElementoExtraido = varNodoExtraido.darElemento();
                return true;
            }
            return false;
        }

        /// <summary> Extrae (elimina) el nodo doble enlazado ubicado en la posición indicada por "parIndice" y al mismo tiempo devuelve su elemento en "parElemento". </summary>
        /// <param name="prmIndice">Posición donde ocurrirá la extracción</param>
        /// <param name="prmElementoExtraido">Elemento contenido en el nodo extraído. </param>
        /// <returns>true si el nodo y su elemento fueron extraídos de la posición indicada o false de lo contrario. </returns>
        protected override bool ExtraerEn(int prmIndice, ref Tipo prmElementoExtraido)
        {
            clsNodoDobleEnlazado<Tipo> varNodoExtraido = new clsNodoDobleEnlazado<Tipo>();
            if (ExtraerEn(prmIndice, ref varNodoExtraido))
            {
                prmElementoExtraido = varNodoExtraido.darElemento();
                return true;
            }
            return false;
        }
        #endregion
        #region Recuperadores
        /// <summary> Devuelve (sin extraer) el nodo doble enlazado ubicado en la cabeza de la colección. </summary>
        /// <param name="prmNodoRecuperado">nodo que será recuperado</param>
        /// <returns>true si el nodo fue recuperado con éxito. False de lo contrario</returns>
        protected bool RecuperarPrimero(ref clsNodoDobleEnlazado<Tipo> prmNodoRecuperado)
        {
            if (!EstaVacia())
            {
                prmNodoRecuperado = atrNodoPrimero;
                atrMensajeUltimoMetodo = "Se recuperó con éxito el primer nodo de la "+darNombreColeccion(); //pc darNombreColeccion 
                return true;
            }
            else
            {
                atrMensajeUltimoMetodo = "Imposible recuperar el primer nodo[elemento]: " + atrMensajeUltimoMetodo;
                return false;
            }
        }

        /// <summary> Devuelve (sin extraer) el nodo doble enlazado ubicado en la cola de la colección. </summary>
        /// <param name="prmNodoRecuperado">nodo que será recuperado</param>
        /// <returns>true si el nodo fue recuperado con exito. False de lo contrario</returns>
        protected bool RecuperarUltimo(ref clsNodoDobleEnlazado<Tipo> prmNodoRecuperado)
        {
            if (!EstaVacia())
            {
                prmNodoRecuperado = atrNodoUltimo;
                atrMensajeUltimoMetodo = "Se recuperó con exito el ultimo nodo de la "+darNombreColeccion();
                return true;
            }
            else
            {
                atrMensajeUltimoMetodo = "Imposible recuperar el primer nodo[elemento]: " + atrMensajeUltimoMetodo;
                return false;
            }
        }

        /// <summary> Devuelve(sin extraer) un nodo doble enlazado ubicado en la posición indicada por "par Índice" de la colección. </summary>
        /// <param name="prmIndice">Índice de base cero que indica el punto de recuperación</param>
        /// <param name="prmNodoRecuperado">Nodo que será recuperado</param>
        /// <returns>True si el nodo fue recuperado desde la posición indicada con exito o false de lo contrario</returns>
        protected bool RecuperarEn(int prmIndice, ref clsNodoDobleEnlazado<Tipo> prmNodoRecuperado)
        {
            if (!EstaVacia())
            {
                if (EsValido(prmIndice))
                {
                    int varIndice;
                    if (prmIndice <= (atrLongitud - 1) / 2)
                    {
                        prmNodoRecuperado = atrNodoPrimero;
                        for (varIndice = 0; varIndice <= prmIndice; varIndice++)
                            prmNodoRecuperado = prmNodoRecuperado.darNodoSiguiente();
                    }
                    else
                    {
                        prmNodoRecuperado = atrNodoUltimo;
                        for (varIndice = atrLongitud - 1; varIndice >= prmIndice; varIndice--)
                            prmNodoRecuperado = prmNodoRecuperado.darNodoAnterior();
                    }
                    atrMensajeUltimoMetodo = "Se ha recuperado con exito el nodo ubicado en la posición " + prmIndice;
                    return true;
                }
                else
                {
                    atrMensajeUltimoMetodo = "Imposible recuperar el primer nodo[elemento]: " + atrMensajeUltimoMetodo;
                    return false;
                }
            }
            else
            {
                atrMensajeUltimoMetodo = "Imposible recuperar el primer nodo[elemento]: " + atrMensajeUltimoMetodo;
                return false;
            }
        }

        /// <summary> Devuelve (sin extraer) el elemento contenido en el nodo doble enlazado ubicado en la cabeza de la colección. </summary>
        /// <param name="prmElementoRecuperado">Elemento que será recuperado</param>
        /// <returns>true si el elemento fue recuperado con exito. False de lo contrario</returns>
        protected override bool RecuperarPrimero(ref Tipo prmElementoRecuperado)
        {
            clsNodoDobleEnlazado<Tipo> varNodoRecuperado = new clsNodoDobleEnlazado<Tipo>();
            if (RecuperarPrimero(ref varNodoRecuperado))
            {
                prmElementoRecuperado = varNodoRecuperado.darElemento();
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary> Devuelve (sin extraer) el elemento contenido en el nodo doble enlazado ubicado en la cola de la colección. </summary>
        /// <param name="prmElementoRecuperado">Elemento que será recuperado</param>
        /// <returns>true si el elemento fue recuperado con exito. False de lo contrario</returns>
        protected override bool RecuperarUltimo(ref Tipo prmElementoRecuperado)
        {
            clsNodoDobleEnlazado<Tipo> varNodoRecuperado = new clsNodoDobleEnlazado<Tipo>();
            if (RecuperarUltimo(ref varNodoRecuperado))
            {
                prmElementoRecuperado = varNodoRecuperado.darElemento();
                return true;
            }
            return false;
        }

        /// <summary>Devuelve (sin extraer) el elemento contenido en el nodo doble enlazado ubicado en la posición indicada por "parIndice" de la colección. </summary>
        /// <param name="prmIndice">Índice de base cero que indica el punto de recuperación</param>
        /// <param name="prmElementoRecuperado">Elemento que será recuperado</param>
        /// <returns>True si el elemento fue recuperado desde la posición indicada con exito o false de lo contrario</returns>
        protected override bool RecuperarEn(int prmIndice, ref Tipo prmElementoRecuperado)
        {
            clsNodoDobleEnlazado<Tipo> varNodoRecuperado = new clsNodoDobleEnlazado<Tipo>();
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
        #endregion
        #endregion
    }
}

