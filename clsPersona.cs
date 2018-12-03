using System;

namespace uTest
{
    public class clsPersona: IComparable
    { 
        private int atrOID=0;
        private string atrNombre;
        private int atrEdad=0;

        public clsPersona() { }

        public clsPersona(int prmOID, string prmNombre, int prmEdad)
        {
            atrOID = prmOID;
            atrNombre = prmNombre;
            atrEdad = prmEdad;
        }
        public int CompareTo(object Objeto)
        {
            clsPersona varObjeto = (clsPersona)Objeto;
            if (this.atrEdad > varObjeto.atrEdad)
            {
                return 1;
            }
            if(this.atrEdad< varObjeto.atrEdad)
            {
                return -1;
            }
            return 0;
        }

    }
}