using System;

namespace CapaServicios.libColecciones
{
    /// <summary> Encapsula el abanico completo de operaciones que seran fundamentales a la hora de manipular completamente cualquier estructura de datos lineal basada en nodos doble enlazados. Las operaciones se agruparan en las siguientes familias: Constructores, Propiedades, INteradores, Cruds(insertadores, modificadores, extractores, consultroes, pobladores) y de ordenamiento.</summary>
    /// <typeparam name="Tipo"></typeparam>
    public class clsTADVectorial<Tipo> : clsTAD<Tipo> where Tipo : IComparable, new()
    {
        #region Atributos
        /// <summary> Arreglo que almacena los elementos de la colección. </summary>
        protected Tipo[] atrVectorElementos ;

        /// <summary> Indica cuantos elementos máximo puede contener la colección en el momento de su Dimensionamiento. </summary>
        protected int atrCapacidad = 100;

        /// <summary> Indica si la colección tendrá un tamaño variable o constante </summary>
        protected bool atrCapacidadFlexible = false;

        /// <summary> Indica en cuantas posiciones crecerá la colección cada vez que sea necesario. </summary>
        protected int atrFactorCrecimiento = 0;
        #endregion
        #region Metodos
        #region Constructores
        /// <summary> Crea una nueva coleccion cuyo tamaño esta determinada por la capacidad por defecto de 100 elementos. 
        /// El factor de crecimiento de la coleccion estara ajustado a CERO y su tamaño sera fijo.
        public clsTADVectorial()
        {
            atrVectorElementos = new Tipo[atrCapacidad];
            atrMensajeUltimoMetodo = Mensajero("Exito", "crear una nueva instancia", "La nueva " + darNombreColeccion() + " se creo con " + darCapacidad() + " elementos y tamaño fijo.");
        }

        /// <summary> Crea una nueva instancia de TADVectorial para una coleccion cuyo tamaño inicial estara determinado por el valor
        /// del parametro "prmcapacidad" si este es mayor que CERO; en caso contrario se asumira la capacidad por defecto.
        /// El factor de crecimiento de la coleccion esta ajustado a CERO  y la coleccion tendra un tamaño fijo</summary>
        /// <param name="prmCapacidad">Valor numerico que indica el numero de posiciones iniciales que la coleccion tendra disponibles para almacenar Elementos</param>
        public clsTADVectorial(int prmCapacidad)
        {
            if (prmCapacidad >= 0)
            {
                atrCapacidad = prmCapacidad;
                atrMensajeUltimoMetodo = Mensajero("Exito", "crear una nueva instancia", "La nueva " + darNombreColeccion() + " se creo con " + darCapacidad() + " elementos y tamaño fijo.");
            }
            else
            {
                atrMensajeUltimoMetodo = Mensajero("Fracaso", "crear una nueva instancia","El valor de " + prmCapacidad + " elementos es invalido para dimensionar la " + darNombreColeccion() + ". "+ "En su lugar se creó una " + darNombreColeccion() + " con " + atrCapacidad + " elementos y tamaño fijo.");
            }
            try
            {
                atrVectorElementos = new Tipo[atrCapacidad];
            }
            catch (Exception e)
            {
                atrCapacidad = 100;
                atrVectorElementos = new Tipo[atrCapacidad];
                atrMensajeUltimoMetodo = Mensajero("Fracaso", "crear una nueva instancia",e.Message+ " El valor de " + prmCapacidad + " elementos es invalido para dimensionar la " + darNombreColeccion() + ". " + "En su lugar se creó una " + darNombreColeccion() + " con " + atrCapacidad + " elementos y tamaño fijo.");
            }
        }

        /// <summary> Crea una nueva coleccion cuyo tamaño es la capacidad po0r defecto de 100 elementos. El factor de crecimiento 
        /// esta ajustado a 20 elementos por defecto si prmCapacidadFlexible es true de lo contrario sera CERO. </summary>
        /// <param name="prmCapacidadFlexible">True para una capacidad Flexible . False de lo contrario.</param>
        public clsTADVectorial(bool prmCapacidadFlexible)
        {
            string varComodin = "fijo";
            if (prmCapacidadFlexible == true)
            {
                atrCapacidadFlexible = prmCapacidadFlexible;
                atrFactorCrecimiento = 100;
                varComodin = "flexible";
            }
            atrVectorElementos = new Tipo[atrCapacidad];
            atrMensajeUltimoMetodo = Mensajero("Exito", "crear una nueva instancia", "La nueva " + darNombreColeccion() + " se creo con " + darCapacidad() + " elementos y tamaño "+varComodin+".");
        }

        /// <summary> Crea una nueva instancia de TADVectorial para una coleccion cuyo factor de crecimiento iniciales, estarán determinados
        /// por los parametros prmCapacidad y prmFactor de Crecimiento.La coleccion tendra una capacidad flexible por defecto. </summary>
        /// <param name="prmCapacidad">Numero  inicial de Posiciones que tendra la coleccion .</param>
        /// <param name="prmFactorCrecimiento">Numero de Posiciones en el que se incrementara la coleccion cada vez que sea posible.</param>
        public clsTADVectorial(int prmCapacidad, int prmFactorCrecimiento)
        {
            if (prmCapacidad >= 0)
            {
                atrCapacidad = prmCapacidad;
                atrMensajeUltimoMetodo = Mensajero("Exito", "crear una nueva instancia", "La nueva " + darNombreColeccion() + " se creo con " + darCapacidad() + " elementos. ");
            }
            else
            {
                atrMensajeUltimoMetodo = Mensajero("Fracaso", "crear una nueva instancia", "El valor de " + prmCapacidad + " elementos es invalido para dimensionar la " + darNombreColeccion() + "." + " En su lugar se creo una " + darNombreColeccion() + " con " + atrCapacidad + " elementos. ");
            }
            try
            {
                atrVectorElementos = new Tipo[atrCapacidad];
            }
            catch (Exception e)
            {
                atrCapacidad = 100;
                atrVectorElementos = new Tipo[atrCapacidad];
                atrMensajeUltimoMetodo = Mensajero("Fracaso", "crear una nueva instancia", e.Message + " El valor de " + prmCapacidad + " elementos es invalido para dimensionar la " + darNombreColeccion() + "." + " En su lugar se creo una " + darNombreColeccion() + " con " + atrCapacidad + " elementos. ");
            }
            if (prmFactorCrecimiento >0 && prmFactorCrecimiento<=5000)//entre 1 y 5000
            {
                    atrFactorCrecimiento = prmFactorCrecimiento;
                    atrCapacidadFlexible = true;
                    atrMensajeUltimoMetodo += "Y una capacidad flexible.";
            }else
            {
                atrFactorCrecimiento = 100;
                atrCapacidadFlexible = true;
                atrMensajeUltimoMetodo += "Por otra parte, el valor indicado de "+prmFactorCrecimiento+" para el factor de crecimiento es invalido porque esta fuera del rango entre 1 y 5000 elementos. ";
                atrMensajeUltimoMetodo += "En su lugar se ha determinado un factor de crecimiento de 100 elementos y tamaño flexible para la nueva "+darNombreColeccion()+".";
            }

        }
        #endregion
        #region Accesores y Mutadores
        /// <summary>Devuelve el valor del atributo capacidad para una coleccion con implementacion vectorial.</summary>
        /// <returns>El atributo capacidad</returns>
        public int darCapacidad()
        {
            atrMensajeUltimoMetodo = "Se retorno el valor de la capacidad para la " + atrNombreColeccion;
            return atrCapacidad;
        }

        /// <summary>Devuelve el vector de elementos para una coleccion con implementacion vectorial.</summary>
        /// <returns>El atributo capacidad</returns>
        public Tipo[] darVectorElementos()
        {
            atrMensajeUltimoMetodo = "Se retorno el vector de elementos de la " + atrNombreColeccion;
            return atrVectorElementos;
        }

        /// <summary>Devuelve el valor de la capacidad flexible</summary>
        /// <returns>Capacidad Flexible</returns>
        public bool darCapacidadFlexible()
        {
            atrMensajeUltimoMetodo = "Se a retornado correctamente el atributo capacidad flexible.";
            return atrCapacidadFlexible;
        }

        /// <summary>Devuelve el valor de la capacidad flexible.</summary>
        /// <returns></returns>
        public int darFactorCrecimiento()
        {
            atrMensajeUltimoMetodo = "Se ha retornado el atributo factor crecimiento";
            return atrFactorCrecimiento;
        }
        #endregion
        #region Iteradores
        #endregion
        #region Crud`s
        #region Insertadores
        /// <summary> Insertar un elemento en la colección según la posición indicada. </summary>
        /// <param name="prmIndice">Índice de base cero donde se realizará la inserción. </param>
        /// <param name="prmNuevoElemento">Nuevo elemento que se insertara en la colección. </param>
        /// <returns>True si el proceso de inserción fue exitoso. False de lo contrario. </returns>
        protected override bool InsertarEn(int prmIndice, Tipo prmNuevoElemento)
        {
            if ((EsValido(prmIndice) || prmIndice == atrLongitud))
            {
                if (EstaLlena())
                {
                    if (IncrementarCapacidad())
                    {
                        if (DesplazarElementos(false, prmIndice)||(prmIndice ==atrLongitud))
                        {
                            atrVectorElementos[prmIndice] = prmNuevoElemento;
                            atrLongitud ++;
                            atrMensajeUltimoMetodo = Mensajero("Exito", "insertar", "elemento", prmIndice,"");
                            return true;
                        }
                        else
                        {
                            atrMensajeUltimoMetodo = Mensajero("Fracaso", "desplazar elementos", darMensajeUltimoMetodo());
                            return false;
                        }
                    }
                    else
                    {
                        atrMensajeUltimoMetodo = Mensajero("Fracaso", "incrementar capacidad", darMensajeUltimoMetodo());
                        return false;
                    }
                }
                else
                {
                    if (DesplazarElementos(false, prmIndice)||(prmIndice ==atrLongitud))
                    {
                        atrVectorElementos[prmIndice] = prmNuevoElemento;
                        atrLongitud ++;
                        atrMensajeUltimoMetodo = Mensajero("Exito", "insertar", "elemento", prmIndice, "");
                        return true;
                    }
                    else
                    {
                        atrMensajeUltimoMetodo = Mensajero("Fracaso", "desplazar elementos", darMensajeUltimoMetodo());
                        return false;
                    }
                }
            }
            else
            {
                atrMensajeUltimoMetodo = Mensajero("Fracaso", "insertar", darMensajeUltimoMetodo());
                return false;
            }
        }

        /// <summary> Inserta el elemento indicado por "prmElemento", en la primera posición (cabeza) de la colección. este método sobre escribe el método de la clase TAD. </summary>
        /// <param name="prmElemento"> Nuevo elemento que se inserta. </param>
        /// <returns>True si la inserción fue exitosa. False de lo contrario. </returns>
        protected override bool InsertarPrimero(Tipo prmElemento)
        {
            if (InsertarEn(0, prmElemento))
            {
                atrMensajeUltimoMetodo = Mensajero("Exito", "insertar primer elemento", darMensajeUltimoMetodo());
                return true;
            }else
            {
                atrMensajeUltimoMetodo = Mensajero("Fracaso", "insertar primer elemento", darMensajeUltimoMetodo());
                return false;
            }
        }

        /// <summary> Agrega el elemento indicado por "prmElemento", en la última posición (cola) de la colección. Este método sobre escribe el método de la clase TAD.  </summary>
        /// <param name="prmElemento"> Nuevo elemento que se inserta. </param>
        /// <returns>True si la inserción fue exitosa. False de lo contrario. </returns>
        protected override bool AgregarUltimo(Tipo prmElemento)
        {
            if (InsertarEn(atrLongitud - 1, prmElemento))
            {
                atrMensajeUltimoMetodo = Mensajero("Exito", "agregar ultimo", darMensajeUltimoMetodo());
                return true;
            }
            else
            {
                atrMensajeUltimoMetodo = Mensajero("Exito", "agregar ultimo", darMensajeUltimoMetodo());
                return false;
            }

        }
        #endregion
        #region Modificadores
        /// <summary>Modifica (si existe) el elemento de la colección ubicado en la posición indicada. </summary>
        /// <param name="prmIndice">Índice de base 0 donde se realizará la modificación. </param>
        /// <param name="prmElementoModificado">Elemento que contiene la modificación. </param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario. </returns>
        protected override bool ModificarEn(int prmIndice, Tipo prmElementoModificado)
        {
            if (!EstaVacia())
            {
                if (EsValido(prmIndice))
                {
                    atrVectorElementos[prmIndice] = prmElementoModificado;
                    atrMensajeUltimoMetodo = Mensajero("Exito", "modificar", "elemento", prmIndice, "");
                    return true;
                }
                else
                {
                    atrMensajeUltimoMetodo = Mensajero("Fracaso","modificar","elemento",prmIndice,darMensajeUltimoMetodo());
                    return false;
                }
            }
            atrMensajeUltimoMetodo = Mensajero("Fracaso", "modificar", "elemento", prmIndice, darMensajeUltimoMetodo());
            return false;
        }

        /// <summary>Modifica (si existe) el elemento de la colección ubicado en la primera posición(cabeza) de la colección. </summary>
        /// <param name="prmElementoModificado">Elemento que contiene la modificación. </param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario. </returns>
        protected override bool ModificarPrimero(Tipo prmElementoModificado)
        {
            if (ModificarEn(0, prmElementoModificado))
            {
                atrMensajeUltimoMetodo = Mensajero("Exito", "modificar primer elemento", darMensajeUltimoMetodo());
                return true;
            }
            else
            {
                atrMensajeUltimoMetodo = Mensajero("Fracaso", "modificar primer elemento", darMensajeUltimoMetodo());
                return false;
            }
        }

        /// <summary>Modifica (si existe) el elemento de la colección ubicado en la última posición(cola) de la colección. </summary>
        /// <param name="prmElementoModificado">Elemento que contiene la modificación. </param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario. </returns>
        protected override bool ModificarUltimo(Tipo prmElementoModificado)
        {
            if (ModificarEn(atrLongitud - 1, prmElementoModificado))
            {
                atrMensajeUltimoMetodo = Mensajero("Exito", "modificar ultimo elemento", darMensajeUltimoMetodo());
                return true;
            }
            else
            {
                atrMensajeUltimoMetodo = Mensajero("Fracaso", "modificar ultimo elemento", darMensajeUltimoMetodo());
                return false;
            }
        }

        /// <summary>Intercambia el contenido de los elementos ubicados en Indice1 y Indice2</summary>
        /// <param name="prmIndice1">Primer Índice para Intercambiar</param>
        /// <param name="prmIndice2">Segundo Índice para Intercambiar</param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario. </returns>
        protected override bool IntercambiarEntre(int prmIndice1, int prmIndice2)
        {
            if (!EstaVacia())
            {
                if (SonValidos(prmIndice1, prmIndice2))
                {
                    Tipo varElementoTemporal = atrVectorElementos[prmIndice1];
                    atrVectorElementos[prmIndice1] = atrVectorElementos[prmIndice2];
                    atrVectorElementos[prmIndice2] = varElementoTemporal;
                    atrMensajeUltimoMetodo = Mensajero("Exito", "intercambiar", "elementos", prmIndice1 + " y " + prmIndice2, "");
                    return true;
                }
                else
                {
                    atrMensajeUltimoMetodo = Mensajero("Fracaso","intercambiar elementos",darMensajeUltimoMetodo());
                    return false;
                }
            }
            else
            {
                atrMensajeUltimoMetodo = Mensajero("Fracaso", "intercambiar elementos", darMensajeUltimoMetodo());
                return false;
            }
        }
        #endregion
        #region Extractores
        /// <summary> Extrae (Elimina y devuelve si existe) el elemento de la colección ubicado en la posición indicada por "parIndice". </summary>
        /// <param name="prmIndice">Índice de base cero donde se realizará la extracción. </param>
        /// <param name="prmElementoExtraido">Elemento extraído de la Colección. </param>
        /// <returns>Verdadero si el proceso de Extracción fue Exitoso, Falso de lo contrario. </returns>
        protected override bool ExtraerEn(int prmIndice, ref Tipo prmElementoExtraido)
        {
            if (!EstaVacia())
            {
                if (EsValido(prmIndice))
                {
                    prmElementoExtraido = atrVectorElementos[prmIndice];
                    if (DesplazarElementos(true, prmIndice))
                    {
                        atrLongitud--;
                        atrMensajeUltimoMetodo = Mensajero("Exito", "extraer", "elemento", prmIndice, "");
                        return true;
                    }
                    else
                    {
                        prmElementoExtraido = default(Tipo);
                        atrMensajeUltimoMetodo = Mensajero("Fracaso", "desplazar elementos", darMensajeUltimoMetodo());
                        return false;
                    }
                }
                else
                {
                    prmElementoExtraido = default(Tipo);
                    atrMensajeUltimoMetodo = Mensajero("Fracaso", "extraer","elemento", prmIndice, darMensajeUltimoMetodo());
                    return false;
                }
            }
            else
            {
                prmElementoExtraido = default(Tipo);
                atrMensajeUltimoMetodo = Mensajero("Fracaso", "extraer", "elemento", prmIndice, darMensajeUltimoMetodo());
                return false;
            }
        }

        /// <summary> Extrae (Elimina y devuelve si existe) el Elemento ubicado en la primera posición de la Colección y lo regresa en parElemento.
        /// Este Método sobre-escribe el método de la clase TAD. </summary>
        /// <param name="prmElementoExtraido">Elemento que se extrae. </param>
        /// <returns>True si la Extracción fue exitosa. False de lo contrario. </returns>
        protected override bool ExtraerPrimero(ref Tipo prmElementoExtraido)
        {
           if (ExtraerEn(0, ref prmElementoExtraido))
            {
                atrMensajeUltimoMetodo = Mensajero("Exito", "extraer primer elemento", darMensajeUltimoMetodo());
                return true;
            }
            else
            {
                atrMensajeUltimoMetodo = Mensajero("Fracaso", "extraer primer elemento", darMensajeUltimoMetodo());
                return false;
            }
        }

        /// <summary> Extrae (Elimina y Devuelve si existe) el Elemento ubicado en la última posición de la Colección y regresa en "parElemento". </summary>
        /// <param name="prmElementoExtraido">Elemento que se extrae. </param>
        /// <returns>True si la extracción fue Exitosa, False de lo contrario. </returns>
        protected override bool ExtraerUltimo(ref Tipo prmElementoExtraido)
        {
            if (ExtraerEn(atrLongitud - 1, ref prmElementoExtraido))
            {
                atrMensajeUltimoMetodo = Mensajero("Exito", "extraer ultimo elemento", darMensajeUltimoMetodo());
                return true;
            }
            else
            {
                atrMensajeUltimoMetodo = Mensajero("Fracaso", "extraer ultimo elemento", darMensajeUltimoMetodo());
                return false;
            }
        } 

        /// <summary>Extrae si existe el primer elemento coincidente con el elemento ingresado.</summary>
        /// <param name="prmElementoRemovido">Elemento extraido.</param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario.</returns>
        protected override bool ExtraerEste(ref Tipo prmElementoRemovido)
        {
            if (!EstaVacia())
            {
                for (int varIndice = 0; varIndice < atrLongitud - 1; varIndice++)
                {
                    if (prmElementoRemovido.CompareTo(atrVectorElementos[varIndice])==0)
                    {
                        if (ExtraerEn(varIndice, ref prmElementoRemovido))
                        {
                            atrMensajeUltimoMetodo = "Se ha removido correctamente el elemento.";
                            return true;
                        }
                        else
                        {
                            atrMensajeUltimoMetodo = "Imposible extraer elemento: No se ha podido extraer el elemento de la " + darNombreColeccion() + " debido a: " + atrMensajeUltimoMetodo;
                            return false;
                        }
                    }
                }
                atrMensajeUltimoMetodo = "Imposible extraer elemento: No se ha encontrado un elemento igual al ingresado";
                return false;
            }
            atrMensajeUltimoMetodo = "Imposible extaer elemento: La " + darNombreColeccion() + " esta vacia";
            return false;
        }

        /// <summary>Invierte el orden de los elementos de toda la coleccion.El primero pasa a ser el ultimo y el ultimo primero y asi sucesivamente.</summary>
        /// <returns>True si el proceso fue exitoso. False de lo contrario.</returns>
        protected override bool Invertir() 
        {
            Tipo varAuxiliar;
            if (!EstaVacia())
            {
                for (int varIndice = 0; varIndice < atrLongitud / 2; varIndice++)
                {
                    varAuxiliar = atrVectorElementos[varIndice];
                    atrVectorElementos[varIndice] = atrVectorElementos[atrLongitud - 1 - varIndice];
                    atrVectorElementos[atrLongitud - 1 - varIndice] = varAuxiliar;
                }
                atrMensajeUltimoMetodo = Mensajero("Exito", "invertir", darMensajeUltimoMetodo());
                return true;
            }
            else
            {
                atrMensajeUltimoMetodo = Mensajero("Fracaso", "invertir", darMensajeUltimoMetodo());
                return false;
            }
        }
        #endregion
        #region Recuperadores
        /// <summary> Recupera (devuelve sin extraer si existe) el elemento de la colección ubicado en la posición indicada por "parIndice". </summary>
        /// <param name="prmIndice">índice de base cero donde se realizará la recuperación. </param>
        /// <param name="prmElementoRecuperado">Elemento recuperado de la colección</param>
        /// <returns>True si el proceso de recuperación fue exitoso. False de lo contrario</returns>
        protected override bool RecuperarEn(int prmIndice, ref Tipo prmElementoRecuperado)
        {
            if (!EstaVacia())
            {
                if (EsValido(prmIndice))
                {
                    prmElementoRecuperado = atrVectorElementos[prmIndice];
                    atrMensajeUltimoMetodo = Mensajero("Exito", "recuperar", "elemento", prmIndice, "");
                    return true;
                }
                else
                {
                    prmElementoRecuperado = default(Tipo);
                    atrMensajeUltimoMetodo = Mensajero("Fracaso", "recuperar", "elemento", prmIndice, darMensajeUltimoMetodo());
                    return false;
                }
            }
            else
            {
                prmElementoRecuperado = default(Tipo);
                atrMensajeUltimoMetodo = Mensajero("Fracaso", "recuperar", "elemento", prmIndice, darMensajeUltimoMetodo());
                return false;
            }
        }

        /// <summary> Recupera (devuelve sin extraer si existe) el elemento ubicado en la primera posición(cabeza) de la colección. </summary>
        /// <param name="prmElementoRecuperado">Elemento recuperado de la colección</param>
        /// <returns>True si el proceso de recuperación fue exitoso. False de lo contrario</returns>
        protected override bool RecuperarPrimero(ref Tipo prmElementoRecuperado)
        {
            if(RecuperarEn(0, ref prmElementoRecuperado))
            {
                atrMensajeUltimoMetodo = Mensajero("Exito", "recuperar primer elemento", darMensajeUltimoMetodo());
                return true;
            }
            else
            {
                atrMensajeUltimoMetodo = Mensajero("Fracaso", "recuperar primer elemento", darMensajeUltimoMetodo());
                return false;
            }
        }

        /// <summary> Recupera (devuelve sin extraer si existe) el elemento ubicado en la última posición (cola) de la colección). </summary>
        /// <param name="prmElementoRecuperado">Elemento recuperado de la colección</param>
        /// <returns>True si el proceso de recuperación fue exitoso. False de lo contrario</returns>
        protected override bool RecuperarUltimo(ref Tipo prmElementoRecuperado)
        {
            if(RecuperarEn(atrLongitud -1, ref prmElementoRecuperado))
            {
                atrMensajeUltimoMetodo = Mensajero("Exito", "recuperar ultimo elemento", darMensajeUltimoMetodo());
                return true;
            }else
            {
                atrMensajeUltimoMetodo = Mensajero("Fracaso", "recuperar ultimo elemento", darMensajeUltimoMetodo());
                return false;
            }
        }
        #endregion
        #region Consultores
        /// <summary> Indica si la capacidad de la colección se agotó. </summary>
        /// <returns>True si la colección está llena, false de lo contrario. </returns>
        protected bool EstaLlena()
        {
            if (atrCapacidad == atrLongitud)
            {
                atrMensajeUltimoMetodo = "La colección está llena";
                return true;
            }
            else
            {
                atrMensajeUltimoMetodo ="La colección No está llena";
                return false;
            }
        }
        #endregion
        #region Pobladores
        #endregion
        #region Auxiliares
        /// <summary> Incrementa la capacidad de la colección en una cantidad de nuevas posiciones según el atributo FactordeCrecimiento. </summary>
        /// <returns>true si el tamaño de la colección fue incrementado exitosamente o false de lo contrario. </returns>
        protected bool IncrementarCapacidad()
        {
            if (atrCapacidadFlexible == true)
            {
                try
                {
                    Tipo[] varVectorTemporal = new Tipo[atrCapacidad + atrFactorCrecimiento];
                    for (int varIndice = 0; varIndice < atrLongitud; varIndice++)
                        varVectorTemporal[varIndice] = atrVectorElementos[varIndice];
                    atrVectorElementos = varVectorTemporal;
                    atrCapacidad += atrFactorCrecimiento;
                    atrMensajeUltimoMetodo = "Se incrementó la Capacidad de la "+atrNombreColeccion+" con Éxito.";
                    return true;
                }
                catch (Exception e)
                {
                    atrMensajeUltimoMetodo = "imposible Incrementar Capacidad de la " + atrNombreColeccion+" debido a: " + e.Message;
                    return false;
                }
            }
            else
            {
                atrMensajeUltimoMetodo = "Colección No Flexible.";
                return false;
            }
        }

        /// <summary> Desplaza todos los elementos del vector una posición hacia la izquierda o derecha a partir de una ubicación determinada por "prmIndice". </summary>
        /// <param name="prmHaciaIzquierda">indica si los elementos serán desplazados hacia la izquierda (true) o derecha (false). </param>
        /// <param name="prmIndice">Posición a partir desde la cual serán desplazados los elementos. </param>
        /// <returns>Devuelve true si el desplazamiento ocurrió exitosamente o false de lo contrario. </returns>
        protected bool DesplazarElementos(bool prmHaciaIzquierda, int prmIndice)
        {
            if (EsValido(prmIndice))
            {
                try
                {
                    if ((prmHaciaIzquierda == true) && (prmIndice - 1 >= -1))
                    {
                        for (int varIndice = prmIndice; varIndice < atrLongitud; varIndice++)
                            if (varIndice+1 < atrCapacidad)
                            {
                                atrVectorElementos[varIndice] = atrVectorElementos[varIndice + 1];
                            }
                    }
                    if ((prmHaciaIzquierda == false) && (atrLongitud + 1 <= atrCapacidad))
                    {
                        for (int varIndice = prmIndice; varIndice < atrLongitud; varIndice++)
                        {
                           atrVectorElementos[atrLongitud - (varIndice - prmIndice)] = atrVectorElementos[atrLongitud - ((varIndice - prmIndice) + 1)];
                        }
                    }
                    atrMensajeUltimoMetodo = "Los elementos fueron desplazados exitosamente";
                    return true;
                }
                catch (Exception e)
                {
                    atrMensajeUltimoMetodo = "Imposible desplazar elementos: " + e.Message;
                    return false;
                }
            }
            else
            {
                atrMensajeUltimoMetodo = "Imposible desplazar elementos: " + atrMensajeUltimoMetodo;
                return false;
            }
        }
        #endregion
        #endregion
        #region Ordenamiento
        /// <summary>Enmascara la invocación del método plantilla de la clase TAD "ordenar" administrando el parámetro que indica el método de ordenamiento seleccionado en este caso "Burbuja Simple"</summary>
        /// <param name="prmOrdenarPorDescendente">Si es True, ordenara la colección por Descendente, si es false, ordenara Ascendente. </param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario. </returns>
        protected override void MetodoBurbujaSimple(bool prmOrdenarPorDescendente)
        {
            int varIdxExterior, varIdxInterior, varComparacion;
            Tipo varElementoTemporal;
            for (varIdxExterior = 1; varIdxExterior < atrLongitud; varIdxExterior++)
            {
                for (varIdxInterior = 0; varIdxInterior < atrLongitud - varIdxExterior; varIdxInterior++)
                {
                    atrNumeroComparaciones++;
                    varComparacion = this.atrVectorElementos[varIdxInterior].CompareTo(this.atrVectorElementos[varIdxInterior + 1]);
                    if ((varComparacion!=0) &&(prmOrdenarPorDescendente^varComparacion>0))
                    {
                        varElementoTemporal = atrVectorElementos[varIdxInterior];
                        atrVectorElementos[varIdxInterior] = atrVectorElementos[varIdxInterior + 1];
                        atrVectorElementos[varIdxInterior + 1] = varElementoTemporal;
                        atrNumeroIntercambios++;
                    }
                }
            }
        }

        /// <summary>Enmascara la invocación del método plantilla de la clase TAD "ordenar" administrando el parámetro que indica el método de ordenamiento seleccionado en este caso "Burbuja Mejorado"</summary>
        /// <param name="prmOrdenarPorDescendente">Si es True, ordenara la colección por Descendente, si es false, ordenara Ascendente. </param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario. </returns>
        protected override void MetodoBurbujaMejorado(bool prmOrdenarPorDescendente)
        {
            int varIdxExterior, varIdxInterior,varComparacion;
            Tipo varElementoTemporal;
            bool varHubointercambio;
            varIdxExterior = 1;
            varHubointercambio = true;
            while ((varIdxExterior < atrLongitud) && (varHubointercambio == true))
            {
                
                varHubointercambio = false;
                for (varIdxInterior = 0; varIdxInterior <(atrLongitud - varIdxExterior); varIdxInterior++)
                {
                    atrNumeroComparaciones++;
                    varComparacion = atrVectorElementos[varIdxInterior].CompareTo(atrVectorElementos[varIdxInterior + 1]);
                    if ((varComparacion != 0) && (prmOrdenarPorDescendente ^ varComparacion > 0))
                    {
                        varElementoTemporal = atrVectorElementos[varIdxInterior];
                        atrVectorElementos[varIdxInterior] = atrVectorElementos[varIdxInterior + 1];
                        atrVectorElementos[varIdxInterior + 1] = varElementoTemporal;
                        atrNumeroIntercambios++;
                        varHubointercambio = true;
                    }
                }
                varIdxExterior++;
            }

        }

        /// <summary>Enmascara la invocación del método plantilla de la clase TAD "ordenar" administrando el parámetro que indica el método de ordenamiento seleccionado en este caso "Burbuja BiDireccional"</summary>
        /// <param name="prmOrdenarPorDescendente">Si es True, ordenara la colección por Descendente, si es false, ordenara Ascendente. </param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario. </returns>
        protected override void MetodoBurbujaBiDireccional(bool prmOrdenarPorDescendente)
        {
            bool varHuboIntercambios;
            int varIdx, varComparacion;
            Tipo varElementoTemporal;
            do
            {
                varHuboIntercambios = false;
                {
                    for (varIdx = 0; varIdx < atrLongitud - 1; varIdx++)
                    {
                        atrNumeroComparaciones++;
                        varComparacion = atrVectorElementos[varIdx].CompareTo(atrVectorElementos[varIdx + 1]);
                        if (varComparacion != 0 && (prmOrdenarPorDescendente ^ varComparacion > 0))
                        {
                            varElementoTemporal = atrVectorElementos[varIdx];
                            atrVectorElementos[varIdx] = atrVectorElementos[varIdx + 1];
                            atrVectorElementos[varIdx + 1] = varElementoTemporal;
                            varHuboIntercambios = true;
                            atrNumeroComparaciones++;
                            atrNumeroIntercambios++;
                        }
                    }
                }
                if (varHuboIntercambios == false)
                {
                    break;
                }
                varHuboIntercambios = false;
                for (varIdx =atrLongitud - 2; varIdx >= 0; varIdx--)
                {
                    atrNumeroComparaciones++;
                    varComparacion = atrVectorElementos[varIdx].CompareTo(atrVectorElementos[varIdx + 1]);
                    if (varComparacion != 0 && (prmOrdenarPorDescendente ^ varComparacion > 0))
                    {
                        varElementoTemporal = atrVectorElementos[varIdx];
                        atrVectorElementos[varIdx] = atrVectorElementos[varIdx + 1];
                        atrVectorElementos[varIdx + 1] = varElementoTemporal;
                        varHuboIntercambios = true;
                        atrNumeroComparaciones++;
                        atrNumeroIntercambios++; 
                    }
                }
            } while (varHuboIntercambios == false);
        }

        /// <summary>Enmascara la invocación del método plantilla de la clase TAD "ordenar" administrando el parámetro que indica el método de ordenamiento seleccionado en este caso "Insercion"</summary>
        /// <param name="prmOrdenarPorDescendente">Si es True, ordenara la colección por Descendente, si es false, ordenara Ascendente. </param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario. </returns>
        protected override void MetodoInsercion(bool prmOrdenarPorDescendente)
        {
            int varIdxExterior, varIdxInterior;
            Tipo varElementoInsertado;
            for (varIdxExterior = 1; varIdxExterior < atrLongitud; varIdxExterior++)
            {
                varElementoInsertado = atrVectorElementos[varIdxExterior];
                varIdxInterior = varIdxExterior - 1;
                atrNumeroComparaciones++;
                
                while ((IncrementarComparaciones()&& varIdxInterior>=0)&&(atrVectorElementos[varIdxInterior].CompareTo(varElementoInsertado)!=0)&&(prmOrdenarPorDescendente^atrVectorElementos[varIdxInterior].CompareTo(varElementoInsertado)>0))
                {
                    atrNumeroComparaciones++;
                    atrVectorElementos[varIdxInterior+1]=atrVectorElementos[varIdxInterior];
                    varIdxInterior=varIdxInterior-1;
                   
                }
                atrNumeroInserciones++;
                
                atrVectorElementos[varIdxInterior + 1] = varElementoInsertado;
            }
        }

        /// <summary>Enmascara la invocación del método plantilla de la clase TAD "ordenar" administrando el parámetro que indica el método de ordenamiento seleccionado en este caso "Seleccion"</summary>
        /// <param name="prmOrdenarPorDescendente">Si es True, ordenara la colección por Descendente, si es false, ordenara Ascendente. </param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario. </returns>
        protected override void MetodoSeleccion(bool prmOrdenarPorDescendente)
        {
                int varIdxExterior, varIdxInterior, varComparacion, varIdxDelMinimo;
                Tipo varElementoTemporal;
                for (varIdxExterior = 0; varIdxExterior < atrVectorElementos.Length; varIdxExterior++)
                {
                    varIdxDelMinimo = varIdxExterior;
                    for (varIdxInterior = varIdxExterior + 1; varIdxInterior < atrLongitud; varIdxInterior++)
                    {
                        atrNumeroComparaciones++;
                        varComparacion = atrVectorElementos[varIdxInterior].CompareTo(atrVectorElementos[varIdxDelMinimo]);
                        if (prmOrdenarPorDescendente^varComparacion<0)
                        {
                            varIdxDelMinimo = varIdxInterior;
                        }
                    }
                    if (varIdxDelMinimo != varIdxExterior)
                    {
                        varElementoTemporal = atrVectorElementos[varIdxDelMinimo];
                        atrVectorElementos[varIdxDelMinimo] = atrVectorElementos[varIdxExterior];
                        atrVectorElementos[varIdxExterior] = varElementoTemporal;
                        atrNumeroIntercambios++;
                    }
                }
            }

        /// <summary>Enmascara la invocación del método plantilla de la clase TAD "ordenar" administrando el parámetro que indica el método de ordenamiento seleccionado en este caso "Quick Sort"</summary>
        /// <param name="prmOrdenarPorDescendente">Si es True, ordenara la colección por Descendente, si es false, ordenara Ascendente. </param>
        /// <returns>True si el proceso fue exitoso. False de lo contrario. </returns>
        protected override void MetodoQuickSort(bool prmOrdenarPorDescendente, int prmIdxInicial, int prmIdxFinal)
        {
            int varIdxIzquierdo, varIdxDerecho;
            Tipo varElementoPivote, varElementoTemporal;
            varElementoPivote = atrVectorElementos[(prmIdxInicial+prmIdxFinal) / 2];
            varIdxIzquierdo = prmIdxInicial;
            varIdxDerecho = prmIdxFinal;
            while (varIdxIzquierdo <= varIdxDerecho && (prmIdxFinal - prmIdxInicial) > 0)
            {
                while (CriterioOrdenamiento(prmOrdenarPorDescendente,varElementoPivote,atrVectorElementos[varIdxIzquierdo]))
                {
                    varIdxIzquierdo++;
                }
                while (CriterioOrdenamiento(prmOrdenarPorDescendente,atrVectorElementos[varIdxDerecho],varElementoPivote))
                {
                    varIdxDerecho--;
                }
                if (varIdxIzquierdo <= varIdxDerecho)
                {
                    varElementoTemporal = atrVectorElementos[varIdxIzquierdo];
                    atrVectorElementos[varIdxIzquierdo] = atrVectorElementos[varIdxDerecho];
                    atrVectorElementos[varIdxDerecho] = varElementoTemporal;
                    varIdxIzquierdo++;
                    varIdxDerecho--;
                    atrNumeroIntercambios++;
                }
            }
            if (prmIdxInicial < varIdxDerecho)
            {
                MetodoQuickSort(prmOrdenarPorDescendente, prmIdxInicial,varIdxDerecho);
                atrNumeroLlamadosRecursivos++;
            }
            if (varIdxIzquierdo < prmIdxFinal)
            {
                MetodoQuickSort(prmOrdenarPorDescendente, varIdxIzquierdo,prmIdxFinal);
                atrNumeroLlamadosRecursivos++;
            }
        }
        #endregion
        #endregion
    }
}