using System;

namespace CapaServicios.libColecciones
{
    public class clsTAD<Tipo> where Tipo : IComparable, new()
    {
        #region Atributos
        /// <summary> Indica cuantos elementos actualmente están almacenados en la Colección. </summary>
        protected int atrLongitud =0;

        /// <summary> Cadena de texto que especifìca el resultado( éxito o fracaso del último método ejecutado. </summary>
        protected string atrMensajeUltimoMetodo;

        /// <summary>Cadena que indica el nombre de la coleccion seun sea pila, lista o cola de las implementaciones vectorial, simple o doble enlazada. Esta informacion se recoge en el atributo Mensaje Ultimo Metodo para conformar su propia cadena de exito o error.</summary>
        protected string atrNombreColeccion;

        /// <summary> Indica si la colección esta ordenada en sentido Ascendente. </summary>
        protected bool atrEstaOrdenadaAscendente;

        /// <summary> Indica si la colección esta ordenada en sentido Descendente. </summary>
        protected bool atrEstaOrdenadaDescendente;

        /// <summary> Indica cuantas comparaciones ha realizado un determinado Algoritmo de Ordenamiento. </summary>
        protected long atrNumeroComparaciones;

        /// <summary> Indica cuantos Intercambio9s ha realizado un determinado Algoritmo de Ordenamiento. </summary>
        protected long atrNumeroIntercambios;

        /// <summary> Indica cuantos Llamados Recursivos ha realizado un determinado Algoritmo de Ordenamiento. </summary>
        protected long atrNumeroLlamadosRecursivos;

        /// <summary> Indica cuantas Inserciones ha realizado un determinado Algoritmo de Ordenamiento. </summary>
        protected long atrNumeroInserciones;
        #endregion
        #region Métodos
        #region Constructores
        /// <summary> Crea una nueva instancia de TAD para una colección con longitud CERO. </summary>
        public clsTAD() { }
        #endregion
        #region Accesores y Mutadores
        /// <summary>Devuelve el valor del atributo longitud de la colección sin importar su implementación.</summary>
        /// <returns>El atributo Longitud de la colección.</returns>
        public int darLongitud()
        {
            atrMensajeUltimoMetodo = "Se retornó el valor de la Longitud de la Colección.";
            return atrLongitud;
        }

        /// <summary>Devuelve el nombre o categoría a la cual pertenece la colección como una cadena, para insertarse dentro de los mensajes devueltos por el patrón mensajero. Ej.: Pila Vectorial o Simple Enlazada,etc.</summary>
        /// <returns>El nombre de la colección</returns>
        protected virtual string darNombreColeccion()
        {
            atrMensajeUltimoMetodo = "Se retornó el nombre de la categoría o clase al cual pertenece la colección.";
            return atrNombreColeccion;
        }

        /// <summary>Devuelve el mensaje ejecutado por el ultimo metodo de la coleccion.</summary>
        /// <returns></returns>
        public string darMensajeUltimoMetodo()
        {
            return atrMensajeUltimoMetodo;
        }

        /// <summary> Agregar al atributo mensaje ultimo metodo un neuvo mensaje que esta dado por parNuevoMensaje</summary>
        /// <param name="parNuevoMensaje"></param>
        public void ponerMensajeUltimoMetodo(string parNuevoMensaje)
        {
            atrMensajeUltimoMetodo = parNuevoMensaje;
        }

        /// <summary>Devuelve el numero de intercambios realizados en el metodo de ordenamiento</summary>
        /// <returns>Retorna el atributo intercambios</returns>
        public long darNumeroIntercambios()
        {
            return atrNumeroIntercambios;
        }

        /// <summary>Devuelve el numero de comparaciones realizados en el metodo de ordenamiento</summary>
        /// <returns>Retorna el atributo comparaciones</returns>
        public long darNumeroComparaciones()
        {
            return atrNumeroComparaciones;
        }

        /// <summary>Devuelve el numero de inserciones realizados en el metodo de ordenamiento</summary>
        /// <returns>Retorna el atributo inserciones</returns>
        public long darNumeroInserciones()
        {
            return atrNumeroInserciones;
        }

        /// <summary>Devuelve el valor que tiene estaordenadaAscendente realizados en el metodo de ordenamiento</summary>
        /// <returns>Retorna el atributo estaordenadaAscendente</returns>
        public bool darEstaOrdenadaAscendente()
        {
            return atrEstaOrdenadaAscendente;
        }

        /// <summary>Devuelve el valor que tiene estaordenadaDescendente realizados en el metodo de ordenamiento</summary>
        /// <returns>Retorna el atributo estaordenadaDescendente</returns>
        public bool darEstaOrdenadaDescendente()
        {
            return atrEstaOrdenadaDescendente;
        }

        /// <summary>Devuelve el numero de llamados recursivos realizados en el metodo de ordenamiento</summary>
        /// <returns>Retorna el atributo numero de llamados recursivos</returns>
        public long darNumeroLlamadosRecursivos()
        {
            return atrNumeroLlamadosRecursivos;
        }
        #endregion
        #region Iteradores
        #endregion
        #region Crud`s
        #region Insertadores
        /// <summary> Inserta el elemento indicado por "prmElemento", en la primera posición (cabeza) de la colección. 
        /// Este método es virtual y debe sobre escribirse en las clases derivadas de TAD, según sea su implementación vectorial, simple o doble enlazada. </summary>
        /// <param name="prmElemento">Nuevo Elemento que se inserta</param>
        /// <returns>True si la inserción fue exitosa. False de lo contrario. </returns>
        protected virtual bool InsertarPrimero(Tipo prmElemento)
        {
            atrMensajeUltimoMetodo = "Método NO Disponible para esta clase.";
            return false;
        }

        /// <summary> Inserta un elemento en la colección según la posición indicada por "prmIndice".  </summary>
        /// <param name="prmIndice">Índice de base cero donde se realizará la inserción. </param>
        /// <param name="prmNuevoElemento">Nuevo Elemento que se insertara en la colección. </param>
        /// <returns>true si el proceso de inserción fue exitoso. False de lo contrario</returns>
        protected virtual bool InsertarEn(int prmIndice, Tipo prmNuevoElemento)
        {
            atrMensajeUltimoMetodo = "Método NO Disponible para esta Clase.";
            return false;
        }

        /// <summary>Agrega el elemento indicado por "prmElemento”, en la última posición(cola) de la colección. 
        /// Este método es virtual y debe sobre escribirse en las clases derivadas del TAD, según sea su implementación
        /// vectorial, simple o doble enlazada. </summary>
        /// <param name="prmElemento">Nuevo Elemento que se inserta. </param>
        /// <returns>True si la inserción fue exitosa. False de lo contrario. </returns>
        protected virtual bool AgregarUltimo(Tipo prmElemento)
        {
            atrMensajeUltimoMetodo = "Método No Disponible para esta clase.";
            return false;
        }

        #endregion
        #region Modificadores
        /// <summary> Modifica (si existe) el elemento ubicado en la primera posición (cabeza) de la colecciónese método es común a todas las implementaciones: vectorial, simple o doble enlazada y debe redefinirse según sea el caso. </summary>
        /// <param name="prmElementoModificado">Elemento que contiene la modificación</param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario. </returns>
        protected virtual bool ModificarPrimero(Tipo prmElementoModificado)
        {
            atrMensajeUltimoMetodo = "Método No Disponible para esta Clase.";
            return false;
        }

        /// <summary> Modifica (si existe) el elemento de la colección ubicado en la posición indicada. </summary>
        /// <param name="prmIndice">Índice de base cero donde se realizará la modificación. </param>
        /// <param name="prmElementoModificado">Elemento que contiene la modificación. </param>
        /// <returns>true si el proceso fue exitoso. False de lo contrario. </returns>
        protected virtual bool ModificarEn(int prmIndice, Tipo prmElementoModificado)
        {
            atrMensajeUltimoMetodo = "Método No Disponible para esta Clase.";
            return false;
        }

        /// <summary> Modifica (si existe) el elemento ubicado en la última posición (cola) de la colección. Este método es común a todas las implementaciones: vectorial, simple o doble enlazada y debe redefinirse según sea el caso. </summary>
        /// <param name="prmElementoModificado">Elemento que contiene la modificación</param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario. </returns>
        protected virtual bool ModificarUltimo(Tipo prmElementoModificado)
        {
            atrMensajeUltimoMetodo = "Método No Disponible para esta Clase.";
            return false;
        }

        /// <summary>Intercambia el contenido de los elementos ubicados en las posiciones indicadas. Este método es común a todas las implementaciones vectorial, simple o doble enlazada y debe redefinirse según sea el caso. </summary>
        /// <param name="prmIndice1">Primer Índice para intercambiar</param>
        /// <param name="prmIndice2">Segundo Índice para intercambiar</param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario. </returns>
        protected virtual bool IntercambiarEntre(int prmIndice1, int prmIndice2)
        {
            atrMensajeUltimoMetodo = "Método No Disponible para esta Clase.";
            return false;
        }

        #endregion
        #region Extractores
        /// <summary>Extrae (Elimina y Devuelve si existe) el elemento que está ubicado en la primera posición (cabeza) de la colección. Este método es común a todas las implementaciones vectorial, simple o doble enlazada y debe redefinirse según sea el caso. </summary>
        /// <param name="prmElementoExtraido">Elemento extraído de la colección. </param>
        /// <returns>True si el proceso fue Exitoso. False de lo Contrario. </returns>
        protected virtual bool ExtraerPrimero(ref Tipo prmElementoExtraido)
        {
            atrMensajeUltimoMetodo = "Método No Disponible para ésta Clase.";
            return false;
        }

        /// <summary> Extrae (Elimina y Devuelve si existe) el elemento de la colección ubicado en la posición indicada. </summary>
        /// <param name="prmIndice">Índice de base cero donde se realizará la Extracción. </param>
        /// <param name="prmElementoExtraido">Elemento que contiene la Extracción. </param>
        /// <returns>true si el proceso fue exitoso. False de lo contrario. </returns>
        protected virtual bool ExtraerEn(int prmIndice, ref Tipo prmElementoExtraido)
        {
            atrMensajeUltimoMetodo = "Método No Disponible para ésta Clase.";
            return false;
        }

        /// <summary>Extrae (Elimina y Devuelve si existe) el elemento que está ubicado en la Última Posición(Cola) de la colección. Este método es común a todas las implementaciones vectorial, simple o doble enlazada y debe redefinirse según sea el caso. </summary>
        /// <param name="prmElementoExtraido">Elemento extraído de la colección.</param>
        /// <returns>True si el proceso fue Exitoso. False de lo Contrario. </returns>
        protected virtual bool ExtraerUltimo(ref Tipo prmElementoExtraido)
        {
            atrMensajeUltimoMetodo = "Método No Disponible para ésta Clase.";
            return false;
        }

        /// <summary>Extrae si existe el primer elemento coincidente con el elemento ingresado.</summary>
        /// <param name="prmElementoRemovido">Elemento extraido.</param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario.</returns>
        protected virtual bool ExtraerEste(ref Tipo prmElementoRemovido)
        {
            atrMensajeUltimoMetodo = "Método No Disponible para esta Clase.";
            return false;
        }

        /// <summary>Invierte el orden de los elementos de toda la coleccion.El primero pasa a ser el ultimo y el ultimo primero y asi sucesivamente.</summary>
        /// <returns>True si el proceso fue exitoso. False de lo contrario.</returns>
        protected virtual bool Invertir()
        {
            atrMensajeUltimoMetodo = "Método No Disponible para esta Clase.";
            return false;
        }

        #endregion
        #region Recuperadores
        /// <summary>Recupera (devuelve sin extraer si existe) el elemento en la Primera Posición(Cabeza) de la Colección.Este método es común a todas las implementaciones vectorial, simple o doble enlazada y debe redefinirse según sea el caso. </summary>
        /// <param name="prmElementoRecuperado">Elemento recuperado de la Coleccion. </param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario. </returns>
        protected virtual bool RecuperarPrimero(ref Tipo prmElementoRecuperado)
        {
            atrMensajeUltimoMetodo = "Método No Disponible para esta Clase.";
            return false;
        }

        /// <summary>Recupera (devuelve sin extraer si existe) el elemento en la Ultima Posición(Cabeza) de la Colección.Este método es común a todas las implementaciones vectorial, simple o doble enlazada y debe redefinirse según sea el caso. </summary>
        /// <param name="prmElementoRecuperado">Elemento recuperado de la Coleccion. </param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario. </returns>
        protected virtual bool RecuperarUltimo(ref Tipo prmElementoRecuperado)
        {
            atrMensajeUltimoMetodo = "Método No Disponible para esta Clase.";
            return false;
        }

        /// <summary> Recupera (devuelve sin extraer si existe) el elemento de la colección ubicado en la posición indicada. </summary>
        /// <param name="prmIndice">Índice de base cero donde se realizará la Recuperación. </param>
        /// <param name="prmElementoRecuperado">Elemento que contiene la Recuperación. </param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario. </returns>
        protected virtual bool RecuperarEn(int prmIndice, ref Tipo prmElementoRecuperado)
        {
            atrMensajeUltimoMetodo = "Método No Disponible para esta Clase.";
            return false;
        }

        #endregion
        #region Consultores
        /// <summary> Determina si la colección cualquiera que sea su implementación está o no vacía con base en su Longitud. </summary>
        /// <returns>true si la colección está vacía. False de lo contrario. </returns>
        protected bool EstaVacia()
        {
            if (atrLongitud == 0)
            {
                atrMensajeUltimoMetodo = "La "+ atrNombreColeccion+" está vacía.";
                return true;
            }
            atrMensajeUltimoMetodo = "La " + atrNombreColeccion + " NO está vacía.";
            return false;
        }

        /// <summary> Indica si el índice dado esta o no dentro de los límites de la colección. </summary>
        /// <param name="prmIndice">Índice de base cero que será verificado. </param>
        /// <returns>true si el índice está dentro de los limites. False si esta fuera. </returns>
        protected bool EsValido(int prmIndice)
        {
            if (prmIndice >= 0 && prmIndice <= atrLongitud)
            {
                atrMensajeUltimoMetodo = "El índice proporcionado es Valido para la coleccion " + atrNombreColeccion; ;
                return true;
            }
            else
            {
                atrMensajeUltimoMetodo = "El índice " + prmIndice + " es invalido para la " + atrNombreColeccion;
                return false;
            }
        }

        /// <summary>Determina si Indice1 y Indice2 son índices válidos para la colección, este método es usado como delegado en el servicio de intercambio entre elementos, sirve para todas las implementaciones. </summary>
        /// <param name="prmIndice1">Primer índice de base cero. </param>
        /// <param name="prmIndice2">Segundo índice de base cero. </param>
        /// <returns>True si ambos índices son válidos. False de lo contrario. </returns>
        protected bool SonValidos(int prmIndice1, int prmIndice2)
        {
            if (EsValido(prmIndice1))
            {
                if (EsValido(prmIndice2))
                {
                    atrMensajeUltimoMetodo = "Los índices proporcionados son válidos para la "+atrNombreColeccion;
                    return true;
                }
                else
                {
                    atrMensajeUltimoMetodo = "Error: " + atrMensajeUltimoMetodo;
                    return false;
                }
            }
            else
            {
                atrMensajeUltimoMetodo = "Error: " + atrMensajeUltimoMetodo;
                return false;
            }
        }

        #endregion
        #region Pobladores
        #endregion
        #endregion
        #region AuxiliaresDeOrdenamiento
        protected bool IncrementarComparaciones()
        {
            atrNumeroComparaciones=atrNumeroComparaciones++;
            return true;
        }
        /// <summary>Servicio que ajusta el criterio de orden para la colección luego de haberla poblado u ordenado</summary>
        /// <param name="prmCriterio">"Ascendente", "Descendente", "Aleatorio" "Constante"</param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario. </returns>
        public bool AjustarOrdenColeccion(string prmCriterio)
        {
            switch (prmCriterio)
            {
                case "Ascendente":
                    atrEstaOrdenadaAscendente = true;
                    atrEstaOrdenadaDescendente = false;
                    atrMensajeUltimoMetodo = "/r-" + "Se ajustó el orden de la "+darNombreColeccion()+" como ascendente. ";
                    return true;
                case "Descendente":
                    atrEstaOrdenadaAscendente = false;
                    atrEstaOrdenadaDescendente = true;
                    atrMensajeUltimoMetodo = "/r-" + "Se ajustó el orden de la " + darNombreColeccion() + " como descendente. ";
                    return true;
                case "Aleatorio":
                    atrEstaOrdenadaAscendente = false;
                    atrEstaOrdenadaDescendente = false;
                    atrMensajeUltimoMetodo = "/r-" + "Se ajustó el orden de la " + darNombreColeccion() + " como aleatorio. ";
                    return true;
                case "Constante":
                    atrEstaOrdenadaAscendente = true;
                    atrEstaOrdenadaDescendente = true;
                    atrMensajeUltimoMetodo = "Se ajustó el orden de la " + darNombreColeccion() + " como constante. ";
                    return true;
                default:
                    atrMensajeUltimoMetodo = "Error: El criterio proporcionado No es válido para la " + atrNombreColeccion; 
                    return false;
            }
        }

        /// <summary>Indica a priori, si es necesario ordenar la colección antes de aplicar un método de ordenamiento, evitando trabajo innecesario. </summary>
        /// <param name="prmOrdenarPorDescendente">True para ordenar por descendente y False de lo contario</param>
        /// <returns>True si hay necesidad de ordenar. False de lo contrario</returns>
        protected bool DebeOrdenar(bool prmOrdenarPorDescendente)
        {
            if (!EstaVacia())
            {
                switch (prmOrdenarPorDescendente)
                {
                    case (true):
                        {
                            if (atrEstaOrdenadaDescendente == true)
                            {
                                atrMensajeUltimoMetodo = "/r" + "-No debe ordenar, la " + atrNombreColeccion + " ya está ordenada como descendente.";
                                return false;
                            }
                            else
                            {
                                atrMensajeUltimoMetodo = "Debe ordenar la " + atrNombreColeccion + " de forma descendente";
                                return true;
                            }
                        }
                    case (false):
                        {
                            if (atrEstaOrdenadaAscendente == true)
                            {
                                atrMensajeUltimoMetodo = "/r" + "-No debe ordenar, la " + atrNombreColeccion + " ya está ordenada como ascendente.";
                                return false;
                            }
                            else
                            {
                                atrMensajeUltimoMetodo = "Debe ordenar la " + atrNombreColeccion + " de forma ascendente";
                                return true;
                            }
                        }
                    default:
                        atrMensajeUltimoMetodo = "Error: el parametro ingresado no es valido ";
                        return false;
                }
            }
            return false;
        }

        protected bool CriterioOrdenamiento(bool prmOrdenarDescendente, Tipo prmElemento1, Tipo prmElemento2)
        {
            atrNumeroComparaciones=atrNumeroComparaciones+1;
            if (prmOrdenarDescendente == true)
            {
                return prmElemento2.CompareTo(prmElemento1) > 0;
            }else
            {
                return prmElemento1.CompareTo(prmElemento2) > 0;
            }
        }
        #endregion
        #region Ordenamiento
        /// <summary>Método primitivo que se invoca únicamente por la operación ordenar de esta clase, pero que implementa el ordenamiento por el método de burbuja según cada implementación: Vectorial, simple o doble enlazada. </summary>
        /// <param name="prmOrdenarPorDescendente">Si es True ordenara en sentido Descendente. si es False ordenara en sentido Ascendente. </param>
        protected virtual void MetodoBurbujaSimple(bool prmOrdenarPorDescendente)
        {
            atrMensajeUltimoMetodo = "Metodo NO Disponible para esta Clase";
        }

        /// <summary>Método primitivo que se invoca únicamente por la operación ordenar de esta clase, pero que implementa el ordenamiento por el método de Burbuja Mejorado según cada implementación: Vectorial, simple o doble enlazada. </summary>
        /// <param name="prmOrdenarPorDescendente">Si es True ordenara en sentido Descendente. si es False ordenara en sentido Ascendente. </param>
        protected virtual void MetodoBurbujaMejorado(bool prmOrdenarPorDescendente)
        {
            atrMensajeUltimoMetodo = "Metodo NO Disponible para esta Clase";
        }

        /// <summary>Método primitivo que se invoca únicamente por la operación ordenar de esta clase, pero que implementa el ordenamiento por el método de burbuja Bi-Direccional según cada implementación: Vectorial, simple o doble enlazada.</summary>
        /// <param name="prmOrdenarPorDescendente">Si es True ordenara en sentido Descendente. si es False ordenara en sentido Ascendente. </param>
        protected virtual void MetodoBurbujaBiDireccional(bool prmOrdenarPorDescendente)
        {
            atrMensajeUltimoMetodo = "Metodo NO Disponible para esta Clase";
        }

        /// <summary>Método primitivo que se invoca únicamente por la operación ordenar de esta clase, pero que implementa el ordenamiento por el método de Inserción según cada implementación: Vectorial, simple o doble enlazada. </summary>
        /// <param name="prmOrdenarPorDescendente">Si es True ordenara en sentido Descendente. si es False ordenara en sentido Ascendente. </param>
        protected virtual void MetodoInsercion(bool prmOrdenarPorDescendente)
        {
            atrMensajeUltimoMetodo = "Metodo NO Disponible para esta Clase";
        }

        /// <summary>Método primitivo que se invoca únicamente por la operación ordenar de esta clase, pero que implementa el ordenamiento por el método de Selección según cada implementación: Vectorial, simple o doble enlazada. </summary>
        /// <param name="prmOrdenarPorDescendente">Si es True ordenara en sentido Descendente. si es False ordenara en sentido Ascendente. </param>
        protected virtual void MetodoSeleccion(bool prmOrdenarPorDescendente)
        {
            atrMensajeUltimoMetodo = "Metodo NO Disponible para esta Clase";
        }

        /// <summary>Método primitivo que se invoca únicamente por la operación ordenar de esta clase, pero que implementa el ordenamiento por el método de Quick-Short según cada implementación: Vectorial, simple o doble enlazada. </summary>
        /// <param name="prmOrdenarPorDescendente">Si es True ordenara en sentido Descendente. si es False ordenara en sentido Ascendente.</param>
        protected virtual void MetodoQuickSort(bool prmOrdenarPorDescendente, int prmIdxInicial, int prmIdxFinal)
        {
            atrMensajeUltimoMetodo = "Metodo NO Disponible para esta Clase";
        }

        /// <summary>Método plantilla no intocable por el cliente que se asegura de delegar el ordenamiento de la colección según el método de ordenamiento indicado por el parámetro MetodoOrdenamiento. Éste servicio devuelve además estadísticas acerca delas comparaciones, intercambios, inserciones y llamados recursivos realizados por el método de ordenamiento. </summary>
        /// <param name="prmMetodoOrdenamiento">Selector del método de ordenamiento que se usara para ordenar la colección. </param>
        /// <param name="prmOrdenarPorDescendente">Si es True ordenara en sentido Descendente. Si es False ordenara en sentido Ascendente. </param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario. </returns>
        protected bool Ordenar(string prmMetodoOrdenamiento, bool prmOrdenarPorDescendente)
        {
            if (DebeOrdenar(prmOrdenarPorDescendente))
            {
                try
                {
                    switch (prmMetodoOrdenamiento)
                    {
                        case "Burbuja Simple": MetodoBurbujaSimple(prmOrdenarPorDescendente); break;
                        case "Burbuja Mejorado": MetodoBurbujaMejorado(prmOrdenarPorDescendente); break;
                        case "Burbuja Bidireccional": MetodoBurbujaBiDireccional(prmOrdenarPorDescendente); break;
                        case "Insercion": MetodoInsercion(prmOrdenarPorDescendente); break;
                        case "Seleccion": MetodoSeleccion(prmOrdenarPorDescendente); break;
                        case "QuickSort": MetodoQuickSort(prmOrdenarPorDescendente,0,atrLongitud-1); break;//pc parametros 0
                        default:
                            atrMensajeUltimoMetodo = "Imposible ordenar " + atrNombreColeccion + ": El método indicado no está implementado";
                            return false;
                    }
                    if (prmOrdenarPorDescendente)
                    {
                        AjustarOrdenColeccion("Descendente");
                        atrMensajeUltimoMetodo = "/r-" + Mensajero("Exito", "ajustar el orden", darMensajeUltimoMetodo());
                    }
                    else
                    {
                        AjustarOrdenColeccion("Ascendente");
                        atrMensajeUltimoMetodo = "/r-" + Mensajero("Exito", "ajustar el orden", darMensajeUltimoMetodo());
                    }
                    atrMensajeUltimoMetodo = "/r-"+ Mensajero("Exito", "de ordenamiento por " + prmMetodoOrdenamiento, darMensajeUltimoMetodo());
                    atrMensajeUltimoMetodo += "/r" + "-El metodo de ordenamiento Burbuja Simple arrojo los siguientes datos: ";
                    atrMensajeUltimoMetodo += "/r" + "--Numero de Elementos: "+darLongitud()+". ";
                    atrMensajeUltimoMetodo += "/r" + "--Numero de Comparaciones: "+darNumeroComparaciones()+". ";
                    atrMensajeUltimoMetodo += "/r" + "--Numero de Intercambios: "+darNumeroIntercambios()+". ";
                    atrMensajeUltimoMetodo += "/r" + "--Numero de Inserciones: "+darNumeroInserciones()+". ";
                    atrMensajeUltimoMetodo += "/r" + "--Numero de Llamados Recursivos: "+darNumeroLlamadosRecursivos()+ ". ";
                    return true;
                }
                catch (Exception e)
                {
                    atrMensajeUltimoMetodo = "/r-"+Mensajero("Fracaso", "de ordenamiento por " + prmMetodoOrdenamiento, darMensajeUltimoMetodo()+e.Message);
                    return false;
                }
            }
            else
            {
                atrMensajeUltimoMetodo = "/r-"+Mensajero("Fracaso", "de ordenamiento por "+prmMetodoOrdenamiento, darMensajeUltimoMetodo());
                return false;
            }
        }

        /// <summary>Enmascara la invocacion del metodo plantilla de la clase TAD "Ordenar" administrando el parametro que indica el metodo de ordenamiento seleccionado en este caso "Burbuja Simple".</summary>
        /// <param name="prmOrdenarPorDescendente">Si es verdadero ordenara la coleccion por Descendente, si es falso, odenara por Ascendente.</param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario.</returns>
        public bool OrdenarBurbujaSimple(bool prmOrdenarPorDescendente)
        {
            return Ordenar("Burbuja Simple", prmOrdenarPorDescendente);
         
        }

        /// <summary>Enmascara la invocacion del metodo plantilla de la clase TAD "Ordenar" administrando el parametro que indica el metodo de ordenamiento seleccionado en este caso "Burbuja Mejorado".</summary>
        /// <param name="prmOrdenarPorDescendente">Si es verdadero ordenara la coleccion por Descendente, si es falso, odenara por Ascendente.</param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario.</returns>
        public bool OrdenarBurbujaMejorado(bool prmOrdenarPorDescendente)
        {
            return Ordenar("Burbuja Mejorado", prmOrdenarPorDescendente);
        }

        /// <summary>Enmascara la invocacion del metodo plantilla de la clase TAD "Ordenar" administrando el parametro que indica el metodo de ordenamiento seleccionado en este caso "Burbuja BiDireccional".</summary>
        /// <param name="prmOrdenarPorDescendente">Si es verdadero ordenara la coleccion por Descendente, si es falso, odenara por Ascendente.</param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario.</returns>
        public bool OrdenarBurbujaBiDireccional(bool prmOrdenarPorDescendente)
        {
            return Ordenar("Burbuja Bidireccional", prmOrdenarPorDescendente);
        }

        /// <summary>Enmascara la invocacion del metodo plantilla de la clase TAD "Ordenar" administrando el parametro que indica el metodo de ordenamiento seleccionado en este caso "Insercion".</summary>
        /// <param name="prmOrdenarPorDescendente">Si es verdadero ordenara la coleccion por Descendente, si es falso, odenara por Ascendente.</param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario.</returns>
        public bool OrdenarInsercion(bool prmOrdenarPorDescendente)
        {
            return Ordenar("Insercion", prmOrdenarPorDescendente);
        }

        /// <summary>Enmascara la invocacion del metodo plantilla de la clase TAD "Ordenar" administrando el parametro que indica el metodo de ordenamiento seleccionado en este caso "Seleccion".</summary>
        /// <param name="prmOrdenarPorDescendente">Si es verdadero ordenara la coleccion por Descendente, si es falso, odenara por Ascendente.</param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario.</returns>
        public bool OrdenarSeleccion(bool prmOrdenarPorDescendente)
        {
            return Ordenar("Seleccion", prmOrdenarPorDescendente);
        }

        /// <summary>Enmascara la invocacion del metodo plantilla de la clase TAD "Ordenar" administrando el parametro que indica el metodo de ordenamiento seleccionado en este caso "Quick Sort".</summary>
        /// <param name="prmOrdenarPorDescendente">Si es verdadero ordenara la coleccion por Descendente, si es falso, odenara por Ascendente.</param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario.</returns>
        public bool OrdenarQuickSort(bool prmOrdenarPorDescendente)
        {
            return Ordenar("QuickSort", prmOrdenarPorDescendente);
        }
        #endregion
        #region Mensajero
        protected string Mensajero(string prmMetodoTuvo, string prmNombreDelMetodo, string prmDescripcion)
        {
            switch (prmMetodoTuvo)
            {
                case "Exito":
                    return "El metodo " + prmNombreDelMetodo + " de " + darNombreColeccion() + " ha finalizado correctamente. " + prmDescripcion;
                case "Fracaso":
                    return "El metodo " + prmNombreDelMetodo + " de " + darNombreColeccion() + " ha tenido el siguiente problema: " + prmDescripcion;
                default:
                    return "No se ha podido ejecutar el mensajero debido a que el parametro que indica si tuvo exito o fracaso el metodo no esta dentro los conocidos";
            }
        }
        protected string Mensajero(string prmMetodoTuvo, string prmNombreDelMetodo, string prmItem, string prmIndice, string prmDescripcion)
        {
            switch (prmMetodoTuvo)
            {
                case "Exito":
                    return "El metodo " + prmNombreDelMetodo + " el " + prmItem + " ubicado en el indice " + prmIndice + " de " + darNombreColeccion() + " ha finalizado correctamente. " + prmDescripcion;
                case "Fracaso":
                    return "El metodo " + prmNombreDelMetodo + " el " + prmItem + " ubicado en el indice " + prmIndice + " de " + darNombreColeccion() + " ha tenido el siguiente problema: " + prmDescripcion;
                default:
                    return "No se ha podido ejecutar el mensajero debido a que el parametro que indica si tuvo exito o fracaso el metodo no esta dentro los conocidos.";
            }
        }
        protected string Mensajero(string prmMetodoTuvo, string prmNombreDelMetodo, string prmItem, int prmIndice, string prmDescripcion)
        {
            switch (prmMetodoTuvo)
            {
                case "Exito":
                    return "El metodo " + prmNombreDelMetodo + " el " + prmItem + " ubicado en el indice " + prmIndice + " de " + darNombreColeccion() + " ha finalizado correctamente. " + prmDescripcion;
                case "Fracaso":
                    return "El metodo " + prmNombreDelMetodo + " el " + prmItem + " ubicado en el indice " + prmIndice + " de " + darNombreColeccion() + " ha tenido el siguiente problema: " + prmDescripcion;
                default:
                    return "No se ha podido ejecutar el mensajero debido a que el parametro que indica si tuvo exito o fracaso el metodo no esta dentro los conocidos.";
            }
        }

        #endregion
        #endregion
    }
}


