using System;
namespace CapaServicios.libColecciones
{
    public static class clsBrokerOrdenamiento
    {
        /// <summary> Implementa el ordenamiento por el metodo de la Burbuja Simple Original segun el criterio Ascendente. Se implementa este metodo
        /// como referencia para comparar su desempeño contra los servicios de ordenamiento de la libreria ofrecidos por la clase TAD y TAD
        /// Vectorial, que gestionan excepciones.Mensajeria y criterio de ordenamiento. </summary>
        /// <param name="prmVector">Vector a ordenar</param>
        public static void MetodoBurbujaSimple(ref int[] prmVector)
        {
            int varIdxExterior, varIdxInterior, varElementoTemporal;
            for(varIdxExterior=1; varIdxExterior<prmVector.Length; varIdxExterior++)
            {
                for(varIdxInterior=0; varIdxInterior<prmVector.Length - varIdxExterior; varIdxInterior++)
                {
                    if (prmVector[varIdxInterior] > prmVector[varIdxInterior + 1])
                    {
                        varElementoTemporal = prmVector[varIdxInterior];
                        prmVector[varIdxInterior] = prmVector[varIdxInterior + 1];
                        prmVector[varIdxInterior + 1]= varElementoTemporal;
                    }
                }
            }
        }
        
        /// <summary> implementa el ordenamiento por el metodo de la burbuja mejorado orignial segun criterio Ascendente. funciona si la coleccion se ha creado con datos enteror. Se implementa este metodo como referencia para comparar su desempeño contra los servicios de ordenamiento de la libreria ofrecidos por la clase TAD y TADVectorial, que si gestionan excepciones, mensajeria y criterio de ordenamiento. </summary>
        /// <param name="prmVector">Vector a ordenar</param>
        public static void MetodoBurbujaMejorado(ref  int[] prmVector)
        {
            int varIdxExterior, varIdxInterior, varElementoTemporal;
            bool varHubointercambio;
            varIdxExterior = 1;
            varHubointercambio = true;
            while ((varIdxExterior < prmVector.Length) && (varHubointercambio == true))
            {
                varIdxExterior++;
                varHubointercambio = false;
                for(varIdxInterior = 0; varIdxInterior <= (prmVector.Length - varIdxInterior); varIdxInterior++)
                {
                    if (prmVector[varIdxInterior] > prmVector[varIdxInterior + 1])
                    {
                        varElementoTemporal = prmVector[varIdxInterior];
                        prmVector[varIdxInterior] = prmVector[varIdxInterior + 1];
                        prmVector[varIdxInterior + 1] = varElementoTemporal;
                        varHubointercambio = true;
                    }
                }
            }
        }

        /// <summary>Implementa el ordenamiento por el metodo de la burbuja bidireccional original segun criterio Ascendente. Se implementa este metodo como referencia para comparar su desempeño contra los servicios de ordenamiento de la libreria ofrecidos por la clase TAD y TAD vectorial, que si gestionan excepciones, mesnajeria y criterio de ordenamiento.</summary>
        /// <param name="prmVector">Vector a ordenar</param>
        public static void MetodoBurbujaBiDireccional(ref int[] prmVector)
        {
            bool varHuboIntercambios;
            int varIdx, varElementoTemporal;
            do
            {
                varHuboIntercambios = false;
                {
                    for (varIdx = 0; varIdx < prmVector.Length - 1; varIdx++)
                    {
                        if (prmVector[varIdx] > prmVector[varIdx + 1])
                        {
                            varElementoTemporal = prmVector[varIdx];
                            prmVector[varIdx] = prmVector[varIdx + 1];
                            prmVector[varIdx + 1] = varElementoTemporal;
                            varHuboIntercambios = true;
                        }
                    }
                }
            if (varHuboIntercambios == false)
            {
            break;
            }
                varHuboIntercambios = false;
            for (varIdx = prmVector.Length - 2; varIdx >= 0; varIdx--)
            {
                if (prmVector[varIdx] > prmVector[varIdx + 1])
                {
                    varElementoTemporal = prmVector[varIdx + 1];
                    prmVector[varIdx] = prmVector[varIdx + 1];
                    prmVector[varIdx + 1] = varElementoTemporal;
                    varHuboIntercambios = true;
                }
            }

            } while (varHuboIntercambios == false);
        }

        /// <summary>Implementa el ordenamiento por el metodo de Insercion original segun criterio Ascendente. Se implementa este metodo como referencia para comparar su desempeño contra los servicios de ordenamiento de la libreria ofrecidos por la clase TAD y TAD vectorial, que si gestionan excepciones, mesnajeria y criterio de ordenamiento.</summary>
        /// <param name="prmVector">Vector a ordenar</param>
        public static void MetodoInsercion(ref int[] prmVector)
        {
            int varIdxExterior, varIdxInterior, varElementoInsertado;
            for(varIdxExterior=1; varIdxExterior<prmVector.Length; varIdxExterior++)
            {
                varElementoInsertado = prmVector[varIdxExterior];
                varIdxInterior = varIdxExterior - 1;
                while ((varIdxInterior >= 0)&&(prmVector[varIdxInterior]!= varElementoInsertado) && (prmVector[varIdxInterior] > varElementoInsertado))
                {
                    prmVector[varIdxInterior + 1] = prmVector[varIdxInterior];
                    varIdxInterior--;
                }
                prmVector[varIdxInterior + 1] = varElementoInsertado;
            }
        }

        /// <summary> Implementa el ordenamiento por el metodo de Seleccion original segun criterio Ascendente. Se implementa este metodo como referencia para comparar su desempeño contra los servicios de ordenamiento de la libreria ofrecidos por la clase TAD y TAD vectorial, que si gestionan excepciones, mesnajeria y criterio de ordenamiento. </summary>
        /// <param name="prmVector">Vector a ordenar</param>
        public static void MetodoSeleccion( ref int[] prmVector)
        {
            int varIdxExterior, varIdxInterior, varIdxDelMinimo, varElementoTemporal;
            for(varIdxExterior=0; varIdxExterior<prmVector.Length; varIdxExterior++)
            {
                varIdxDelMinimo = varIdxExterior;
                for(varIdxInterior=varIdxExterior+1; varIdxInterior <prmVector.Length; varIdxInterior++)
                {
                    if (prmVector[varIdxInterior] < prmVector[varIdxDelMinimo])
                    {
                        varIdxDelMinimo = varIdxInterior;
                    }
                }
                if (varIdxDelMinimo != varIdxExterior)
                {
                    varElementoTemporal = prmVector[varIdxDelMinimo];
                    prmVector[varIdxDelMinimo] = prmVector[varIdxExterior];
                    prmVector[varIdxExterior] = varElementoTemporal;
                }
            }
        }

        /// <summary> Implementa el ordenamiento por el metodo de Quick-Sort original segun criterio Ascendente. Se implementa este metodo como referencia para comparar su desempeño contra los servicios de ordenamiento de la libreria ofrecidos por la clase TAD y TAD vectorial, que si gestionan excepciones, mesnajeria y criterio de ordenamiento. </summary>
        /// <param name="prmVector">Vector a ordenar</param>
        /// <param name="prmIdxDelPrimero">Primer indice del vector a ordenar</param>
        /// <param name="prmIdxDelUltimo">Ultimo Indice del vector a ordenar</param>
        public static void MetodoQuickSort( ref int[] prmVector, int prmIdxDelPrimero, int prmIdxDelUltimo)
        {
            int varIdxIzquierdo, varIdxDerecho, varElementoPivote, varElementoTemporal;
            varElementoPivote = prmVector[(prmIdxDelPrimero + prmIdxDelUltimo) / 2];
            varIdxIzquierdo = prmIdxDelPrimero;
            varIdxDerecho = prmIdxDelUltimo;
            while(varIdxIzquierdo<=varIdxDerecho &&(prmIdxDelUltimo- prmIdxDelPrimero) > 0)
            {
                while (prmVector[varIdxIzquierdo] < varElementoPivote)
                {
                    varIdxIzquierdo++;
                }
                while (prmVector[varIdxDerecho] > varElementoPivote)
                {
                    varIdxDerecho--;
                }
                if(varIdxIzquierdo<= varIdxDerecho)
                {
                    varElementoTemporal = prmVector[varIdxIzquierdo];
                    prmVector[varIdxIzquierdo] = prmVector[varIdxDerecho];
                    prmVector[varIdxDerecho] = varElementoTemporal;
                    varIdxIzquierdo++;
                    varIdxDerecho--;
                }
            }
            if (prmIdxDelPrimero < varIdxDerecho)
            {
                MetodoQuickSort(ref prmVector, prmIdxDelPrimero, varIdxDerecho);
            }
            if (varIdxIzquierdo < prmIdxDelUltimo)
            {
                MetodoQuickSort(ref prmVector, varIdxIzquierdo, prmIdxDelUltimo);
            }
        }
    }
}
