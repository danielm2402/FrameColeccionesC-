using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaServicios.libColecciones;

namespace uTest
{
    [TestClass]
    public class uTestPilaVector
    {
        #region TestConstructores
        [TestMethod]
        public void testConstructor1Caso1()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo crear una nueva instancia de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "La nueva pila vectorial se creo con 100 elementos y tamaño fijo.";
            #endregion
            #region Probar
            clsPilaVector<int> varMiPila = new clsPilaVector<int>();
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(100, varMiPila.darCapacidad());
            Assert.AreEqual(100, varMiPila.darVectorElementos().Length);
            Assert.AreEqual(0, varMiPila.darFactorCrecimiento());
            Assert.AreEqual(false, varMiPila.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), varMiPila.darVectorElementos().GetType());
            #endregion
        }
        [TestMethod]
        public void testConstructor1Caso2()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo crear una nueva instancia de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "La nueva pila vectorial se creo con 100 elementos y tamaño fijo.";
            #endregion
            #region Probar
            clsPilaVector<clsPersona> varMiPila = new clsPilaVector<clsPersona>();
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(100, varMiPila.darCapacidad());
            Assert.AreEqual(100, varMiPila.darVectorElementos().Length);
            Assert.AreEqual(0, varMiPila.darFactorCrecimiento());
            Assert.AreEqual(false, varMiPila.darCapacidadFlexible());
            Assert.AreEqual(typeof(clsPersona[]), varMiPila.darVectorElementos().GetType());
            #endregion
        }
        [TestMethod]
        public void testConstructor2Caso1()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo crear una nueva instancia de pila vectorial ha tenido el siguiente problema: ";
            varMensajeResultadoEsperado += "El valor de " + -3 + " elementos es invalido para dimensionar la pila vectorial. ";
            varMensajeResultadoEsperado += "En su lugar se creó una pila vectorial con 100 elementos y tamaño fijo.";
            #endregion
            #region Probar
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(-3);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(100, varMiPila.darCapacidad());
            Assert.AreEqual(100, varMiPila.darVectorElementos().Length);
            Assert.AreEqual(0, varMiPila.darFactorCrecimiento());
            Assert.AreEqual(false, varMiPila.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), varMiPila.darVectorElementos().GetType());
            #endregion
        }
        [TestMethod]
        public void testConstructor2Caso2()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo crear una nueva instancia de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "La nueva pila vectorial se creo con 0 elementos y tamaño fijo.";
            #endregion
            #region Probar
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(0);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(0, varMiPila.darCapacidad());
            Assert.AreEqual(0, varMiPila.darVectorElementos().Length); //pc
            Assert.AreEqual(0, varMiPila.darFactorCrecimiento());
            Assert.AreEqual(false, varMiPila.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), varMiPila.darVectorElementos().GetType());
            #endregion
        }
        [TestMethod]
        public void testConstructor2Caso3()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo crear una nueva instancia de pila vectorial ha tenido el siguiente problema: ";
            varMensajeResultadoEsperado += "El valor de " + int.MinValue + " elementos es invalido para dimensionar la pila vectorial. ";
            varMensajeResultadoEsperado += "En su lugar se creó una pila vectorial con 100 elementos y tamaño fijo.";
            #endregion
            #region Probar
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(int.MinValue);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(100, varMiPila.darCapacidad());
            Assert.AreEqual(100, varMiPila.darVectorElementos().Length);
            Assert.AreEqual(0, varMiPila.darFactorCrecimiento());
            Assert.AreEqual(false, varMiPila.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), varMiPila.darVectorElementos().GetType());
            #endregion
        }
        [TestMethod]
        public void testConstructor2Caso4()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo crear una nueva instancia de pila vectorial ha tenido el siguiente problema: ";
            varMensajeResultadoEsperado += "Se produjo una excepción de tipo 'System.OutOfMemoryException'. ";
            varMensajeResultadoEsperado += "El valor de " + int.MaxValue + " elementos es invalido para dimensionar la pila vectorial. ";
            varMensajeResultadoEsperado += "En su lugar se creó una pila vectorial con 100 elementos y tamaño fijo.";
            #endregion
            #region Probar
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(int.MaxValue);
            #endregion
            #region Comprobar
          //Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(100, varMiPila.darCapacidad());
            Assert.AreEqual(100, varMiPila.darVectorElementos().Length);
            Assert.AreEqual(0, varMiPila.darFactorCrecimiento());
            Assert.AreEqual(false, varMiPila.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), varMiPila.darVectorElementos().GetType());
            #endregion
        }
        [TestMethod]
        public void testConstructor2Caso5()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo crear una nueva instancia de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "La nueva pila vectorial se creo con 3000 elementos y tamaño fijo.";
            #endregion
            #region Probar
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(3000);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(3000, varMiPila.darCapacidad());
            Assert.AreEqual(3000, varMiPila.darVectorElementos().Length);
            Assert.AreEqual(0, varMiPila.darFactorCrecimiento());
            Assert.AreEqual(false, varMiPila.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), varMiPila.darVectorElementos().GetType());
            #endregion
        }
        [TestMethod]
        public void testConstructor2Caso6()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo crear una nueva instancia de pila vectorial ha tenido el siguiente problema: ";
            varMensajeResultadoEsperado += "Se produjo una excepción de tipo 'System.OutOfMemoryException'. ";
            varMensajeResultadoEsperado += "El valor de 2147433647 elementos es invalido para dimensionar la pila vectorial. ";
            varMensajeResultadoEsperado += "En su lugar se creó una pila vectorial con 100 elementos y tamaño fijo.";
            #endregion
            #region Probar
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(int.MaxValue - 50000);
            #endregion
            #region Comprobar
            //Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(100, varMiPila.darCapacidad());
            Assert.AreEqual(100, varMiPila.darVectorElementos().Length);
            Assert.AreEqual(0, varMiPila.darFactorCrecimiento());
            Assert.AreEqual(false, varMiPila.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), varMiPila.darVectorElementos().GetType());
            #endregion
        }
        [TestMethod]
        public void testConstructor2Caso7()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo crear una nueva instancia de pila vectorial ha tenido el siguiente problema: ";
            varMensajeResultadoEsperado += "El valor de -3 elementos es invalido para dimensionar la pila vectorial. ";
            varMensajeResultadoEsperado += "En su lugar se creó una pila vectorial con 100 elementos y tamaño fijo.";
            #endregion
            #region Probar
            clsPilaVector<clsPersona> varMiPila = new clsPilaVector<clsPersona>(-3);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(100, varMiPila.darCapacidad());
            Assert.AreEqual(100, varMiPila.darVectorElementos().Length);
            Assert.AreEqual(0, varMiPila.darFactorCrecimiento());
            Assert.AreEqual(false, varMiPila.darCapacidadFlexible());
            Assert.AreEqual(typeof(clsPersona[]), varMiPila.darVectorElementos().GetType());
            #endregion
        }
        [TestMethod]
        public void testConstructor2Caso8()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo crear una nueva instancia de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "La nueva pila vectorial se creo con 0 elementos y tamaño fijo.";
            #endregion
            #region Probar
            clsPilaVector<clsPersona> varMiPila = new clsPilaVector<clsPersona>(0);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(0, varMiPila.darCapacidad());
            Assert.AreEqual(0, varMiPila.darVectorElementos().Length);
            Assert.AreEqual(0, varMiPila.darFactorCrecimiento());
            Assert.AreEqual(false, varMiPila.darCapacidadFlexible());
            Assert.AreEqual(typeof(clsPersona[]), varMiPila.darVectorElementos().GetType());
            #endregion
        }
        [TestMethod]
        public void testConstructor2Caso9()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo crear una nueva instancia de pila vectorial ha tenido el siguiente problema: ";
            varMensajeResultadoEsperado += "El valor de -2147483648 elementos es invalido para dimensionar la pila vectorial. En su lugar se creó una pila vectorial con 100 elementos y tamaño fijo.";
            #endregion
            #region Probar
            clsPilaVector<clsPersona> varMiPila = new clsPilaVector<clsPersona>(int.MinValue);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(100, varMiPila.darCapacidad());
            Assert.AreEqual(100, varMiPila.darVectorElementos().Length);
            Assert.AreEqual(0, varMiPila.darFactorCrecimiento());
            Assert.AreEqual(false, varMiPila.darCapacidadFlexible());
            Assert.AreEqual(typeof(clsPersona[]), varMiPila.darVectorElementos().GetType());
            #endregion
        }
        [TestMethod]
        public void testConstructor2Caso10()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo crear una nueva instancia de pila vectorial ha tenido el siguiente problema: ";
            varMensajeResultadoEsperado += "Se produjo una excepción de tipo 'System.OutOfMemoryException'. ";
            varMensajeResultadoEsperado += "El valor de " + int.MaxValue + " elementos es invalido para dimensionar la pila vectorial. ";
            varMensajeResultadoEsperado += "En su lugar se creó una pila vectorial con 100 elementos y tamaño fijo.";
            #endregion
            #region Probar
            clsPilaVector<clsPersona> varMiPila = new clsPilaVector<clsPersona>(int.MaxValue);
            #endregion
            #region Comprobar
           // Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(100, varMiPila.darCapacidad());
            Assert.AreEqual(100, varMiPila.darVectorElementos().Length);
            Assert.AreEqual(0, varMiPila.darFactorCrecimiento());
            Assert.AreEqual(false, varMiPila.darCapacidadFlexible());
            Assert.AreEqual(typeof(clsPersona[]), varMiPila.darVectorElementos().GetType());
            #endregion
        }
        [TestMethod]
        public void testConstructor2Caso11()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo crear una nueva instancia de pila vectorial ha finalizado correctamente. La nueva pila vectorial se creo con 3000 elementos y tamaño fijo.";
            #endregion
            #region Probar
            clsPilaVector<clsPersona> varMiPila = new clsPilaVector<clsPersona>(3000);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(3000, varMiPila.darCapacidad());
            Assert.AreEqual(3000, varMiPila.darVectorElementos().Length);
            Assert.AreEqual(0, varMiPila.darFactorCrecimiento());
            Assert.AreEqual(false, varMiPila.darCapacidadFlexible());
            Assert.AreEqual(typeof(clsPersona[]), varMiPila.darVectorElementos().GetType());
            #endregion
        }
        [TestMethod]
        public void testConstructor2Caso12()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo crear una nueva instancia de pila vectorial ha tenido el siguiente problema: ";
            varMensajeResultadoEsperado += "Se produjo una excepción de tipo 'System.OutOfMemoryException'. ";
            varMensajeResultadoEsperado += "El valor de 2147433647 elementos es invalido para dimensionar la pila vectorial. ";
            varMensajeResultadoEsperado += "En su lugar se creó una pila vectorial con 100 elementos y tamaño fijo.";
            #endregion
            #region Probar
            clsPilaVector<clsPersona> varMiPila = new clsPilaVector<clsPersona>(int.MaxValue - 50000);
            #endregion
            #region Comprobar
            //Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(100, varMiPila.darCapacidad());
            Assert.AreEqual(100, varMiPila.darVectorElementos().Length);
            Assert.AreEqual(0, varMiPila.darFactorCrecimiento());
            Assert.AreEqual(false, varMiPila.darCapacidadFlexible());
            Assert.AreEqual(typeof(clsPersona[]), varMiPila.darVectorElementos().GetType());
            #endregion
        }
        [TestMethod]
        public void testConstructor3Caso1()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo crear una nueva instancia de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "La nueva pila vectorial se creo con 100 elementos y tamaño flexible.";
            #endregion
            #region Probar
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(true);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(100, varMiPila.darCapacidad());
            Assert.AreEqual(100, varMiPila.darVectorElementos().Length);
            Assert.AreEqual(100, varMiPila.darFactorCrecimiento());
            Assert.AreEqual(true, varMiPila.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), varMiPila.darVectorElementos().GetType());
            #endregion
        }
        [TestMethod]
        public void testConstructor3Caso2()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo crear una nueva instancia de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "La nueva pila vectorial se creo con 100 elementos y tamaño fijo.";
            #endregion
            #region Probar
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(false);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(100, varMiPila.darCapacidad());
            Assert.AreEqual(100, varMiPila.darVectorElementos().Length);
            Assert.AreEqual(0, varMiPila.darFactorCrecimiento());
            Assert.AreEqual(false, varMiPila.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), varMiPila.darVectorElementos().GetType());
            #endregion
        }
        [TestMethod]
        public void testConstructor3Caso3()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo crear una nueva instancia de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "La nueva pila vectorial se creo con 100 elementos y tamaño flexible.";
            #endregion
            #region Probar
            clsPilaVector<clsPersona> varMiPila = new clsPilaVector<clsPersona>(true);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(100, varMiPila.darCapacidad());
            Assert.AreEqual(100, varMiPila.darVectorElementos().Length);
            Assert.AreEqual(100, varMiPila.darFactorCrecimiento());
            Assert.AreEqual(true, varMiPila.darCapacidadFlexible());
            Assert.AreEqual(typeof(clsPersona[]), varMiPila.darVectorElementos().GetType());
            #endregion
        }
        [TestMethod]
        public void testConstructor3Caso4()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo crear una nueva instancia de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "La nueva pila vectorial se creo con 100 elementos y tamaño fijo.";
            #endregion
            #region Probar
            clsPilaVector<clsPersona> varMiPila = new clsPilaVector<clsPersona>(false);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(100, varMiPila.darCapacidad());
            Assert.AreEqual(100, varMiPila.darVectorElementos().Length);
            Assert.AreEqual(0, varMiPila.darFactorCrecimiento());
            Assert.AreEqual(false, varMiPila.darCapacidadFlexible());
            Assert.AreEqual(typeof(clsPersona[]), varMiPila.darVectorElementos().GetType());
            #endregion
        }
        [TestMethod]
        public void testConstructor4Caso1()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo crear una nueva instancia de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "La nueva pila vectorial se creo con 0 elementos. ";
            varMensajeResultadoEsperado += "Por otra parte, el valor indicado de -50000 para el factor de crecimiento es invalido porque esta fuera del rango entre 1 y 5000 elementos. ";
            varMensajeResultadoEsperado += "En su lugar se ha determinado un factor de crecimiento de 100 elementos y tamaño flexible para la nueva pila vectorial.";
            #endregion
            #region Probar
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(0, -50000);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(0, varMiPila.darCapacidad());
            Assert.AreEqual(0, varMiPila.darVectorElementos().Length);
            Assert.AreEqual(100, varMiPila.darFactorCrecimiento());
            Assert.AreEqual(true, varMiPila.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), varMiPila.darVectorElementos().GetType());
            #endregion
        }
        [TestMethod]
        public void testConstructor4Caso2()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo crear una nueva instancia de pila vectorial ha tenido el siguiente problema: ";
            varMensajeResultadoEsperado += "El valor de -50000 elementos es invalido para dimensionar la pila vectorial. ";
            varMensajeResultadoEsperado += "En su lugar se creo una pila vectorial con 100 elementos. ";
            varMensajeResultadoEsperado += "Por otra parte, el valor indicado de -2147483648 para el factor de crecimiento es invalido porque esta fuera del rango entre 1 y 5000 elementos. ";
            varMensajeResultadoEsperado += "En su lugar se ha determinado un factor de crecimiento de 100 elementos y tamaño flexible para la nueva pila vectorial.";
            #endregion
            #region Probar
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(-50000, int.MinValue);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(100, varMiPila.darCapacidad());
            Assert.AreEqual(100, varMiPila.darVectorElementos().Length);
            Assert.AreEqual(100, varMiPila.darFactorCrecimiento());
            Assert.AreEqual(true, varMiPila.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), varMiPila.darVectorElementos().GetType());
            #endregion
        }
        [TestMethod]
        public void testConstructor4Caso3()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo crear una nueva instancia de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "La nueva pila vectorial se creo con 0 elementos. ";
            varMensajeResultadoEsperado += "Por otra parte, el valor indicado de 2147433647 para el factor de crecimiento es invalido porque esta fuera del rango entre 1 y 5000 elementos. ";
            varMensajeResultadoEsperado += "En su lugar se ha determinado un factor de crecimiento de 100 elementos y tamaño flexible para la nueva pila vectorial.";
            #endregion
            #region Probar
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(0, int.MaxValue - 50000);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(0, varMiPila.darCapacidad());
            Assert.AreEqual(0, varMiPila.darVectorElementos().Length);
            Assert.AreEqual(100, varMiPila.darFactorCrecimiento());
            Assert.AreEqual(true, varMiPila.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), varMiPila.darVectorElementos().GetType());
            #endregion
        }
        [TestMethod]
        public void testConstructor4Caso4()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo crear una nueva instancia de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "La nueva pila vectorial se creo con 0 elementos. ";
            varMensajeResultadoEsperado += "Por otra parte, el valor indicado de 0 para el factor de crecimiento es invalido porque esta fuera del rango entre 1 y 5000 elementos. ";
            varMensajeResultadoEsperado += "En su lugar se ha determinado un factor de crecimiento de 100 elementos y tamaño flexible para la nueva pila vectorial.";
            #endregion
            #region Probar
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(0, 0);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(0, varMiPila.darCapacidad());
            Assert.AreEqual(0, varMiPila.darVectorElementos().Length);
            Assert.AreEqual(100, varMiPila.darFactorCrecimiento());
            Assert.AreEqual(true, varMiPila.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), varMiPila.darVectorElementos().GetType());
            #endregion
        }
        [TestMethod]
        public void testConstructor4Caso5()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo crear una nueva instancia de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "La nueva pila vectorial se creo con 0 elementos. ";
            varMensajeResultadoEsperado += "Por otra parte, el valor indicado de 50000 para el factor de crecimiento es invalido porque esta fuera del rango entre 1 y 5000 elementos. ";
            varMensajeResultadoEsperado += "En su lugar se ha determinado un factor de crecimiento de 100 elementos y tamaño flexible para la nueva pila vectorial.";

            #endregion
            #region Probar
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(0, 50000);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(0, varMiPila.darCapacidad());
            Assert.AreEqual(0, varMiPila.darVectorElementos().Length);
            Assert.AreEqual(100, varMiPila.darFactorCrecimiento());
            Assert.AreEqual(true, varMiPila.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), varMiPila.darVectorElementos().GetType());
            #endregion
        }
        [TestMethod]
        public void testConstructor4Caso6()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo crear una nueva instancia de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "La nueva pila vectorial se creo con 0 elementos. ";
            varMensajeResultadoEsperado += "Por otra parte, el valor indicado de -2147483648 para el factor de crecimiento es invalido porque esta fuera del rango entre 1 y 5000 elementos. ";
            varMensajeResultadoEsperado += "En su lugar se ha determinado un factor de crecimiento de 100 elementos y tamaño flexible para la nueva pila vectorial.";
            #endregion
            #region Probar
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(0, int.MinValue);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(0, varMiPila.darCapacidad());
            Assert.AreEqual(0, varMiPila.darVectorElementos().Length);
            Assert.AreEqual(100, varMiPila.darFactorCrecimiento());
            Assert.AreEqual(true, varMiPila.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), varMiPila.darVectorElementos().GetType());
            #endregion
        }
        [TestMethod]
        public void testConstructor4Caso7()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo crear una nueva instancia de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "La nueva pila vectorial se creo con 50000 elementos. ";
            varMensajeResultadoEsperado += "Por otra parte, el valor indicado de -2147433648 para el factor de crecimiento es invalido porque esta fuera del rango entre 1 y 5000 elementos. ";
            varMensajeResultadoEsperado += "En su lugar se ha determinado un factor de crecimiento de 100 elementos y tamaño flexible para la nueva pila vectorial.";

            #endregion
            #region Probar
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(50000, int.MinValue + 50000);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(50000, varMiPila.darCapacidad());
            Assert.AreEqual(50000, varMiPila.darVectorElementos().Length);
            Assert.AreEqual(100, varMiPila.darFactorCrecimiento());
            Assert.AreEqual(true, varMiPila.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), varMiPila.darVectorElementos().GetType());
            #endregion
        }
        [TestMethod]
        public void testConstructor4Caso8()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo crear una nueva instancia de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "La nueva pila vectorial se creo con 50000 elementos. ";
            varMensajeResultadoEsperado += "Por otra parte, el valor indicado de -50000 para el factor de crecimiento es invalido porque esta fuera del rango entre 1 y 5000 elementos. ";
            varMensajeResultadoEsperado += "En su lugar se ha determinado un factor de crecimiento de 100 elementos y tamaño flexible para la nueva pila vectorial.";

            #endregion
            #region Probar
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(50000, -50000);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(50000, varMiPila.darCapacidad());
            Assert.AreEqual(50000, varMiPila.darVectorElementos().Length);
            Assert.AreEqual(100, varMiPila.darFactorCrecimiento());
            Assert.AreEqual(true, varMiPila.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), varMiPila.darVectorElementos().GetType());
            #endregion
        }
        [TestMethod]
        public void testConstructor4Caso9()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo crear una nueva instancia de pila vectorial ha tenido el siguiente problema: ";
            varMensajeResultadoEsperado += "Exception of type 'System.OutOfMemoryException' ";
            varMensajeResultadoEsperado += "El valor de 2147483647 elementos es invalido para dimensionar la pila vectorial. ";
            varMensajeResultadoEsperado += "En su lugar se creo una pila vectorial con 100 elementos. ";
            varMensajeResultadoEsperado += "Por otra parte, el valor indicado de 2147483647 para el factor de crecimiento es invalido porque esta fuera del rango entre 1 y 5000 elementos. ";
            varMensajeResultadoEsperado += "En su lugar seha determinado un factor de crecimiento de 100 elementos y tamaño flexible para la nueva pila vectorial.";

            #endregion
            #region Probar
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(int.MaxValue, int.MaxValue);
            #endregion
            #region Comprobar
            //Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(100, varMiPila.darCapacidad());
            Assert.AreEqual(100, varMiPila.darVectorElementos().Length);
            Assert.AreEqual(100, varMiPila.darFactorCrecimiento());
            Assert.AreEqual(true, varMiPila.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), varMiPila.darVectorElementos().GetType());
            #endregion
        }
        [TestMethod]
        public void testConstructor4Caso10()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo crear una nueva instancia de pila vectorial ha tenido el siguiente problema: ";
            varMensajeResultadoEsperado += "Se produjo una excepción de tipo 'System.OutOfMemoryException'. ";
            varMensajeResultadoEsperado += "El valor de 2147483647 elementos es invalido para dimensionar la pila vectorial. ";
            varMensajeResultadoEsperado += "En su lugar se creo una pila vectorial con 100 elementos. ";
            varMensajeResultadoEsperado += "Por otra parte, el valor indicado de -2147433648 para el factor de crecimiento es invalido porque esta fuera del rango entre 1 y 5000 elementos. ";
            varMensajeResultadoEsperado += "En su lugar se ha determinado un factor de crecimiento de 100 elementos y tamaño flexible para la nueva pila vectorial.";
            #endregion
            #region Probar
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(int.MaxValue, int.MinValue + 50000);
            #endregion
            #region Comprobar
           // Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(100, varMiPila.darCapacidad());
            Assert.AreEqual(100, varMiPila.darVectorElementos().Length);
            Assert.AreEqual(100, varMiPila.darFactorCrecimiento());
            Assert.AreEqual(true, varMiPila.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), varMiPila.darVectorElementos().GetType());
            #endregion
        }
        [TestMethod]
        public void testConstructor4Caso11()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo crear una nueva instancia de pila vectorial ha tenido el siguiente problema: ";
            varMensajeResultadoEsperado += "Se produjo una excepción de tipo 'System.OutOfMemoryException'. ";
            varMensajeResultadoEsperado += "El valor de 2147483647 elementos es invalido para dimensionar la pila vectorial. ";
            varMensajeResultadoEsperado += "En su lugar se creo una pila vectorial con 100 elementos. ";
            varMensajeResultadoEsperado += "Por otra parte, el valor indicado de 2147433647 para el factor de crecimiento es invalido porque esta fuera del rango entre 1 y 5000 elementos. ";
            varMensajeResultadoEsperado += "En su lugar se ha determinado un factor de crecimiento de 100 elementos y tamaño flexible para la nueva pila vectorial.";
            #endregion
            #region Probar
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(int.MaxValue, int.MaxValue - 50000);
            #endregion
            #region Comprobar
            //Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(100, varMiPila.darCapacidad());
            Assert.AreEqual(100, varMiPila.darVectorElementos().Length);
            Assert.AreEqual(100, varMiPila.darFactorCrecimiento());
            Assert.AreEqual(true, varMiPila.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), varMiPila.darVectorElementos().GetType());
            #endregion
        }
        [TestMethod]
        public void testConstructor4Caso12()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo crear una nueva instancia de pila vectorial ha tenido el siguiente problema: ";
            varMensajeResultadoEsperado += "Se produjo una excepción de tipo 'System.OutOfMemoryException'. ";
            varMensajeResultadoEsperado += "El valor de 2147433647 elementos es invalido para dimensionar la pila vectorial. ";
            varMensajeResultadoEsperado += "En su lugar se creo una pila vectorial con 100 elementos. ";
            varMensajeResultadoEsperado += "Por otra parte, el valor indicado de 2147433647 para el factor de crecimiento es invalido porque esta fuera del rango entre 1 y 5000 elementos. ";
            varMensajeResultadoEsperado += "En su lugar se ha determinado un factor de crecimiento de 100 elementos y tamaño flexible para la nueva pila vectorial.";
            #endregion
            #region Probar
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(int.MaxValue - 50000, int.MaxValue - 50000);
            #endregion
            #region Comprobar
           // Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(100, varMiPila.darCapacidad());
            Assert.AreEqual(100, varMiPila.darVectorElementos().Length);
            Assert.AreEqual(100, varMiPila.darFactorCrecimiento());
            Assert.AreEqual(true, varMiPila.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), varMiPila.darVectorElementos().GetType());
            #endregion
        }
        [TestMethod]
        public void testConstructor4Caso13()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo crear una nueva instancia de pila vectorial ha tenido el siguiente problema: ";
            varMensajeResultadoEsperado += "Se produjo una excepción de tipo 'System.OutOfMemoryException'. ";
            varMensajeResultadoEsperado += "El valor de 2147433647 elementos es invalido para dimensionar la pila vectorial. ";
            varMensajeResultadoEsperado += "En su lugar se creo una pila vectorial con 100 elementos. ";
            varMensajeResultadoEsperado += "Por otra parte, el valor indicado de -2147483648 para el factor de crecimiento es invalido porque esta fuera del rango entre 1 y 5000 elementos. ";
            varMensajeResultadoEsperado += "En su lugar se ha determinado un factor de crecimiento de 100 elementos y tamaño flexible para la nueva pila vectorial.";
            #endregion
            #region Probar
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(int.MaxValue - 50000, int.MinValue);
            #endregion
            #region Comprobar
            //Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(100, varMiPila.darCapacidad());
            Assert.AreEqual(100, varMiPila.darVectorElementos().Length);
            Assert.AreEqual(100, varMiPila.darFactorCrecimiento());
            Assert.AreEqual(true, varMiPila.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), varMiPila.darVectorElementos().GetType());
            #endregion
        }
        [TestMethod]
        public void testConstructor4Caso14()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo crear una nueva instancia de pila vectorial ha tenido el siguiente problema: ";
            varMensajeResultadoEsperado += "Se produjo una excepción de tipo 'System.OutOfMemoryException'. ";
            varMensajeResultadoEsperado += "El valor de 2147433647 elementos es invalido para dimensionar la pila vectorial. ";
            varMensajeResultadoEsperado += "En su lugar se creo una pila vectorial con 100 elementos. ";
            varMensajeResultadoEsperado += "Por otra parte, el valor indicado de 50000 para el factor de crecimiento es invalido porque esta fuera del rango entre 1 y 5000 elementos. ";
            varMensajeResultadoEsperado += "En su lugar se ha determinado un factor de crecimiento de 100 elementos y tamaño flexible para la nueva pila vectorial.";
            #endregion
            #region Probar
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(int.MaxValue - 50000, 50000);
            #endregion
            #region Comprobar
            //Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(100, varMiPila.darCapacidad());
            Assert.AreEqual(100, varMiPila.darVectorElementos().Length);
            Assert.AreEqual(100, varMiPila.darFactorCrecimiento());
            Assert.AreEqual(true, varMiPila.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), varMiPila.darVectorElementos().GetType());
            #endregion
        }
        [TestMethod]
        public void testConstructor4Caso15()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo crear una nueva instancia de pila vectorial ha tenido el siguiente problema: ";
            varMensajeResultadoEsperado += "Se produjo una excepción de tipo 'System.OutOfMemoryException'. ";
            varMensajeResultadoEsperado += "El valor de 2147433647 elementos es invalido para dimensionar la pila vectorial. ";
            varMensajeResultadoEsperado += "En su lugar se creo una pila vectorial con 100 elementos. ";
            varMensajeResultadoEsperado += "Por otra parte, el valor indicado de 2147483647 para el factor de crecimiento es invalido porque esta fuera del rango entre 1 y 5000 elementos. ";
            varMensajeResultadoEsperado += "En su lugar se ha determinado un factor de crecimiento de 100 elementos y tamaño flexible para la nueva pila vectorial.";
            #endregion
            #region Probar
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(int.MaxValue - 50000, int.MaxValue);
            #endregion
            #region Comprobar
            //Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(100, varMiPila.darCapacidad());
            Assert.AreEqual(100, varMiPila.darVectorElementos().Length);
            Assert.AreEqual(100, varMiPila.darFactorCrecimiento());
            Assert.AreEqual(true, varMiPila.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), varMiPila.darVectorElementos().GetType());
            #endregion
        }
        [TestMethod]
        public void testConstructor4Caso16()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo crear una nueva instancia de pila vectorial ha tenido el siguiente problema: ";
            varMensajeResultadoEsperado += "Exception of type 'System.OutOfMemoryException'.";
            varMensajeResultadoEsperado += "El valor de 2147433647 elementos es invalido para dimensionar la pila vectorial. ";
            varMensajeResultadoEsperado += "En su lugar se creo una pila vectorial con 100 elementos. ";
            varMensajeResultadoEsperado += "Por otra parte, el valor indicado de -50000 para el factor de crecimiento es invalido porque esta fuera del rango entre 1 y 5000 elementos. ";
            varMensajeResultadoEsperado += "En su lugar se ha determinado un factor de crecimiento de 100 elementos y tamaño flexible para la nueva pila vectorial.";
            #endregion
            #region Probar
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(int.MaxValue - 50000, -50000);
            #endregion
            #region Comprobar
          //  Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(100, varMiPila.darCapacidad());
            Assert.AreEqual(100, varMiPila.darVectorElementos().Length);
            Assert.AreEqual(100, varMiPila.darFactorCrecimiento());
            Assert.AreEqual(true, varMiPila.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), varMiPila.darVectorElementos().GetType());
            #endregion
        }
        [TestMethod]
        public void testConstructor4Caso17()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo crear una nueva instancia de pila vectorial ha tenido el siguiente problema: ";
            varMensajeResultadoEsperado += "El valor de -2147483648 elementos es invalido para dimensionar la pila vectorial. ";
            varMensajeResultadoEsperado += "En su lugar se creo una pila vectorial con 100 elementos. ";
            varMensajeResultadoEsperado += "Por otra parte, el valor indicado de 2147433647 para el factor de crecimiento es invalido porque esta fuera del rango entre 1 y 5000 elementos. ";
            varMensajeResultadoEsperado += "En su lugar se ha determinado un factor de crecimiento de 100 elementos y tamaño flexible para la nueva pila vectorial.";
            #endregion
            #region Probar
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(int.MinValue, int.MaxValue - 50000);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(100, varMiPila.darCapacidad());
            Assert.AreEqual(100, varMiPila.darVectorElementos().Length);
            Assert.AreEqual(100, varMiPila.darFactorCrecimiento());
            Assert.AreEqual(true, varMiPila.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), varMiPila.darVectorElementos().GetType());
            #endregion
        }
        [TestMethod]
        public void testConstructor4Caso18()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo crear una nueva instancia de pila vectorial ha tenido el siguiente problema: ";
            varMensajeResultadoEsperado += "El valor de -2147483648 elementos es invalido para dimensionar la pila vectorial. ";
            varMensajeResultadoEsperado += "En su lugar se creo una pila vectorial con 100 elementos. ";
            varMensajeResultadoEsperado += "Por otra parte, el valor indicado de 2147483647 para el factor de crecimiento es invalido porque esta fuera del rango entre 1 y 5000 elementos. ";
            varMensajeResultadoEsperado += "En su lugar se ha determinado un factor de crecimiento de 100 elementos y tamaño flexible para la nueva pila vectorial.";
            #endregion
            #region Probar
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(int.MinValue, int.MaxValue);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(100, varMiPila.darCapacidad());
            Assert.AreEqual(100, varMiPila.darVectorElementos().Length);
            Assert.AreEqual(100, varMiPila.darFactorCrecimiento());
            Assert.AreEqual(true, varMiPila.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), varMiPila.darVectorElementos().GetType());
            #endregion
        }
        [TestMethod]
        public void testConstructor4Caso19()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo crear una nueva instancia de pila vectorial ha tenido el siguiente problema: ";
            varMensajeResultadoEsperado += "El valor de -2147483648 elementos es invalido para dimensionar la pila vectorial. ";
            varMensajeResultadoEsperado += "En su lugar se creo una pila vectorial con 100 elementos. ";
            varMensajeResultadoEsperado += "Por otra parte, el valor indicado de 0 para el factor de crecimiento es invalido porque esta fuera del rango entre 1 y 5000 elementos. ";
            varMensajeResultadoEsperado += "En su lugar se ha determinado un factor de crecimiento de 100 elementos y tamaño flexible para la nueva pila vectorial.";
            #endregion
            #region Probar
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(int.MinValue, 0);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(100, varMiPila.darCapacidad());
            Assert.AreEqual(100, varMiPila.darVectorElementos().Length);
            Assert.AreEqual(100, varMiPila.darFactorCrecimiento());
            Assert.AreEqual(true, varMiPila.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), varMiPila.darVectorElementos().GetType());
            #endregion
        }
        [TestMethod]
        public void testConstructor4Caso20()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo crear una nueva instancia de pila vectorial ha tenido el siguiente problema: ";
            varMensajeResultadoEsperado += "El valor de -2147483648 elementos es invalido para dimensionar la pila vectorial. ";
            varMensajeResultadoEsperado += "En su lugar se creo una pila vectorial con 100 elementos. ";
            varMensajeResultadoEsperado += "Por otra parte, el valor indicado de -50000 para el factor de crecimiento es invalido porque esta fuera del rango entre 1 y 5000 elementos. ";
            varMensajeResultadoEsperado += "En su lugar se ha determinado un factor de crecimiento de 100 elementos y tamaño flexible para la nueva pila vectorial.";
            #endregion
            #region Probar
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(int.MinValue, -50000);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(100, varMiPila.darCapacidad());
            Assert.AreEqual(100, varMiPila.darVectorElementos().Length);
            Assert.AreEqual(100, varMiPila.darFactorCrecimiento());
            Assert.AreEqual(true, varMiPila.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), varMiPila.darVectorElementos().GetType());
            #endregion
        }
        [TestMethod]
        public void testConstructor4Caso21()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo crear una nueva instancia de pila vectorial ha tenido el siguiente problema: ";
            varMensajeResultadoEsperado += "El valor de -2147433648 elementos es invalido para dimensionar la pila vectorial. ";
            varMensajeResultadoEsperado += "En su lugar se creo una pila vectorial con 100 elementos. ";
            varMensajeResultadoEsperado += "Por otra parte, el valor indicado de 2147483647 para el factor de crecimiento es invalido porque esta fuera del rango entre 1 y 5000 elementos. ";
            varMensajeResultadoEsperado += "En su lugar se ha determinado un factor de crecimiento de 100 elementos y tamaño flexible para la nueva pila vectorial.";
            #endregion
            #region Probar
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(int.MinValue + 50000, int.MaxValue);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(100, varMiPila.darCapacidad());
            Assert.AreEqual(100, varMiPila.darVectorElementos().Length);
            Assert.AreEqual(100, varMiPila.darFactorCrecimiento());
            Assert.AreEqual(true, varMiPila.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), varMiPila.darVectorElementos().GetType());
            #endregion
        }
        [TestMethod]
        public void testConstructor4Caso22()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo crear una nueva instancia de pila vectorial ha tenido el siguiente problema: ";
            varMensajeResultadoEsperado += "El valor de -2147433648 elementos es invalido para dimensionar la pila vectorial. ";
            varMensajeResultadoEsperado += "En su lugar se creo una pila vectorial con 100 elementos. ";
            varMensajeResultadoEsperado += "Por otra parte, el valor indicado de 2147433647 para el factor de crecimiento es invalido porque esta fuera del rango entre 1 y 5000 elementos. ";
            varMensajeResultadoEsperado += "En su lugar se ha determinado un factor de crecimiento de 100 elementos y tamaño flexible para la nueva pila vectorial.";
            #endregion
            #region Probar
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(int.MinValue + 50000, int.MaxValue - 50000);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(100, varMiPila.darCapacidad());
            Assert.AreEqual(100, varMiPila.darVectorElementos().Length);
            Assert.AreEqual(100, varMiPila.darFactorCrecimiento());
            Assert.AreEqual(true, varMiPila.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), varMiPila.darVectorElementos().GetType());
            #endregion
        }
        [TestMethod]
        public void testConstructor4Caso23()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo crear una nueva instancia de pila vectorial ha tenido el siguiente problema: ";
            varMensajeResultadoEsperado += "El valor de -2147433648 elementos es invalido para dimensionar la pila vectorial. ";
            varMensajeResultadoEsperado += "En su lugar se creo una pila vectorial con 100 elementos. ";
            varMensajeResultadoEsperado += "Por otra parte, el valor indicado de 50000 para el factor de crecimiento es invalido porque esta fuera del rango entre 1 y 5000 elementos. ";
            varMensajeResultadoEsperado += "En su lugar se ha determinado un factor de crecimiento de 100 elementos y tamaño flexible para la nueva pila vectorial.";
            #endregion
            #region Probar
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(int.MinValue + 50000, 50000);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(100, varMiPila.darCapacidad());
            Assert.AreEqual(100, varMiPila.darVectorElementos().Length);
            Assert.AreEqual(100, varMiPila.darFactorCrecimiento());
            Assert.AreEqual(true, varMiPila.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), varMiPila.darVectorElementos().GetType());
            #endregion
        }
        [TestMethod]
        public void testConstructor4Caso24()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo crear una nueva instancia de pila vectorial ha tenido el siguiente problema: ";
            varMensajeResultadoEsperado += "El valor de -2147433648 elementos es invalido para dimensionar la pila vectorial. ";
            varMensajeResultadoEsperado += "En su lugar se creo una pila vectorial con 100 elementos. ";
            varMensajeResultadoEsperado += "Por otra parte, el valor indicado de -50000 para el factor de crecimiento es invalido porque esta fuera del rango entre 1 y 5000 elementos. ";
            varMensajeResultadoEsperado += "En su lugar se ha determinado un factor de crecimiento de 100 elementos y tamaño flexible para la nueva pila vectorial.";
            #endregion
            #region Probar
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(int.MinValue + 50000, -50000);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(100, varMiPila.darCapacidad());
            Assert.AreEqual(100, varMiPila.darVectorElementos().Length);
            Assert.AreEqual(100, varMiPila.darFactorCrecimiento());
            Assert.AreEqual(true, varMiPila.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), varMiPila.darVectorElementos().GetType());
            #endregion
        }
        [TestMethod]
        public void testConstructor4Caso25()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo crear una nueva instancia de pila vectorial ha tenido el siguiente problema: ";
            varMensajeResultadoEsperado += "El valor de -2147433648 elementos es invalido para dimensionar la pila vectorial. ";
            varMensajeResultadoEsperado += "En su lugar se creo una pila vectorial con 100 elementos. ";
            varMensajeResultadoEsperado += "Por otra parte, el valor indicado de -2147483648 para el factor de crecimiento es invalido porque esta fuera del rango entre 1 y 5000 elementos. ";
            varMensajeResultadoEsperado += "En su lugar se ha determinado un factor de crecimiento de 100 elementos y tamaño flexible para la nueva pila vectorial.";
            #endregion
            #region Probar
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(int.MinValue + 50000, int.MinValue);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(100, varMiPila.darCapacidad());
            Assert.AreEqual(100, varMiPila.darVectorElementos().Length);
            Assert.AreEqual(100, varMiPila.darFactorCrecimiento());
            Assert.AreEqual(true, varMiPila.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), varMiPila.darVectorElementos().GetType());
            #endregion
        }
        [TestMethod]
        public void testConstructor4Caso26()
        {
            #region Inicializar
            //string varMensajeResultadoEsperado = "\r" + "El metodo crear una nueva instancia de pila vectorial ha finalizado correctamente. ";
            //varMensajeResultadoEsperado += "\r" + "La nueva pila vectorial se creo con 5000 elementos. Y una capacidad flexible.";
            #endregion
            #region Probar
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(5000, 5000);
            #endregion
            #region Comprobar
            //Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(5000, varMiPila.darCapacidad());
            Assert.AreEqual(5000, varMiPila.darVectorElementos().Length);
            Assert.AreEqual(5000, varMiPila.darFactorCrecimiento());
            Assert.AreEqual(true, varMiPila.darCapacidadFlexible());
            Assert.AreEqual(typeof(int[]), varMiPila.darVectorElementos().GetType());
            #endregion
        }
        #endregion
        #region TestApilar
        [TestMethod]
        public void testApilarCaso1()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo apilar de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "El metodo insertar primer elemento de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "El metodo insertar el elemento ubicado en el indice 0 de pila vectorial ha finalizado correctamente. ";
            int[] varVectorElementosEsperado = new int[100];
            varVectorElementosEsperado[0] = 2000;
            clsPilaVector<int> varMiPila = new clsPilaVector<int>();
            bool varResultadoDeApilar;
            #endregion
            #region Probar
            varResultadoDeApilar = varMiPila.Apilar(2000);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, varResultadoDeApilar);
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(1, varMiPila.darLongitud());
            Assert.AreEqual(100, varMiPila.darCapacidad());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            #endregion
        }
        [TestMethod]
        public void testApilarCaso2()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo apilar de pila vectorial ha tenido el siguiente problema: ";
            varMensajeResultadoEsperado += "El metodo insertar primer elemento de pila vectorial ha tenido el siguiente problema: ";
            varMensajeResultadoEsperado += "El metodo incrementar capacidad de pila vectorial ha tenido el siguiente problema: Colección No Flexible.";
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(0);
            bool varResultadoDeApilar;
            #endregion
            #region Probar
            varResultadoDeApilar = varMiPila.Apilar(1973);
            #endregion
            #region Comprobar
            Assert.AreEqual(false, varResultadoDeApilar);
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(0, varMiPila.darLongitud());
            Assert.AreEqual(varMiPila.darLongitud(), varMiPila.darCapacidad());
            Assert.AreEqual(0, varMiPila.darCapacidad());
            #endregion
        }
        [TestMethod]
        public void testApilarCaso3()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo apilar de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "El metodo insertar primer elemento de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "El metodo insertar el elemento ubicado en el indice 0 de pila vectorial ha finalizado correctamente. ";
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(0, 1);
            bool varResultadoDeApilar;
            #endregion
            #region Probar
            varResultadoDeApilar = varMiPila.Apilar(1973);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, varResultadoDeApilar);
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(1, varMiPila.darLongitud());
            Assert.AreEqual(varMiPila.darLongitud(), varMiPila.darCapacidad());
            Assert.AreEqual(1, varMiPila.darCapacidad());
            Assert.AreEqual(1973, varMiPila.darVectorElementos()[0]);
            #endregion
        }
        [TestMethod]
        public void testApilarCaso4()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo apilar de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "El metodo insertar primer elemento de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "El metodo insertar el elemento ubicado en el indice 0 de pila vectorial ha finalizado correctamente. ";
            int[] varVectorElementosEsperado = new int[2] { 1973, 500 };
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(0, 1);
            varMiPila.Apilar(500);
            bool varResultadoDeApilar;
            #endregion
            #region Probar
            varResultadoDeApilar = varMiPila.Apilar(1973);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, varResultadoDeApilar);
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(2, varMiPila.darLongitud());
            Assert.AreEqual(varMiPila.darLongitud(), varMiPila.darCapacidad());
            Assert.AreEqual(2, varMiPila.darCapacidad());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            #endregion
        }
        [TestMethod]
        public void testApilarCaso5()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo apilar de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "El metodo insertar primer elemento de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "El metodo insertar el elemento ubicado en el indice 0 de pila vectorial ha finalizado correctamente. ";
            int[] varVectorElementosEsperado = new int[500];
            for (int varNumero = 0; varNumero < varVectorElementosEsperado.Length; varNumero++)
                varVectorElementosEsperado[varNumero] = 499 - varNumero;

            bool varResultadoDeApilar = true;
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(500);
            #endregion
            #region Probar
            for (int varNumero = 0; varNumero < 500; varNumero++)
                varResultadoDeApilar = varResultadoDeApilar && varMiPila.Apilar(varNumero);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, varResultadoDeApilar);
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(500, varMiPila.darLongitud());
            Assert.AreEqual(varMiPila.darLongitud(), varMiPila.darCapacidad());
            Assert.AreEqual(500, varMiPila.darCapacidad());
            Assert.AreEqual(0, varMiPila.darVectorElementos()[varMiPila.darLongitud() - 1]);
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            #endregion
        }
        [TestMethod]
        public void testApilarCaso6()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo apilar de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "El metodo insertar primer elemento de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "El metodo insertar el elemento ubicado en el indice 0 de pila vectorial ha finalizado correctamente. ";
            int[] varVectorElementosEsperado = new int[21];
            varVectorElementosEsperado[0] = 500;
            varVectorElementosEsperado[1] = 999;
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(1, 20);
            #endregion
            #region Probar
            Assert.AreEqual(true, varMiPila.Apilar(999));
            Assert.AreEqual(true, varMiPila.Apilar(500));
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(2, varMiPila.darLongitud());
            Assert.AreEqual(21, varMiPila.darCapacidad());
            Assert.AreEqual(21, varMiPila.darVectorElementos().Length);
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            #endregion
        }
        #endregion
        #region TestDesapilar
        [TestMethod]
        public void testDesapilarCaso1()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo desapilar de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "El metodo extraer primer elemento de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "El metodo extraer el elemento ubicado en el indice 0 de pila vectorial ha finalizado correctamente. ";
            int[] varVectorElementosEsperado = new int[3];
            varVectorElementosEsperado[0] = 2000;
            varVectorElementosEsperado[1] = 0;
            varVectorElementosEsperado[2] = 0;
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(3);
            varMiPila.Apilar(2000);
            varMiPila.Apilar(5000);
            bool varResultadoDesapilar;
            int varElementoDesapilado = 0;
            #endregion
            #region Probar
            varResultadoDesapilar = varMiPila.Desapilar(ref varElementoDesapilado);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, varResultadoDesapilar);
            Assert.AreEqual(5000, varElementoDesapilado);
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(1, varMiPila.darLongitud());
            Assert.AreEqual(3, varMiPila.darCapacidad());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            #endregion
        }
        [TestMethod]
        public void testDesapilarCaso2()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo desapilar de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "El metodo extraer primer elemento de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "El metodo extraer el elemento ubicado en el indice 0 de pila vectorial ha finalizado correctamente. ";

            int[] varVectorElementosEsperado = new int[2];
            varVectorElementosEsperado[0] = 2000;
            varVectorElementosEsperado[1] = 2000;

            clsPilaVector<int> varMiPila = new clsPilaVector<int>(2);
            varMiPila.Apilar(2000);
            varMiPila.Apilar(5000);

            bool varResultadoDesapilar;
            int varElementoDesapilado = 0;
            #endregion
            #region Probar
            varResultadoDesapilar = varMiPila.Desapilar(ref varElementoDesapilado);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, varResultadoDesapilar);
            Assert.AreEqual(5000, varElementoDesapilado);
            Assert.AreEqual(1, varMiPila.darLongitud());
            Assert.AreEqual(2, varMiPila.darCapacidad());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            #endregion
        }
        [TestMethod]
        public void testDesapilarCaso3()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo desapilar de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "El metodo extraer primer elemento de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "El metodo extraer el elemento ubicado en el indice 0 de pila vectorial ha finalizado correctamente. ";
            int[] varVectorElementosEsperado = new int[2];
            varVectorElementosEsperado[0] = 2000;
            varVectorElementosEsperado[1] = 2000;
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(2, 1);
            varMiPila.Apilar(2000);
            varMiPila.Apilar(5000);
            bool varResultadoDesapilar;
            int varElementoDesapilado = 0;
            #endregion
            #region Probar
            varResultadoDesapilar = varMiPila.Desapilar(ref varElementoDesapilado);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(true, varResultadoDesapilar);
            Assert.AreEqual(5000, varElementoDesapilado);
            Assert.AreEqual(1, varMiPila.darLongitud());
            Assert.AreEqual(2, varMiPila.darCapacidad());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            #endregion
        }
        [TestMethod]
        public void testDesapilarCaso4()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo desapilar de pila vectorial ha tenido el siguiente problema: ";
            varMensajeResultadoEsperado += "El metodo extraer primer elemento de pila vectorial ha tenido el siguiente problema: ";
            varMensajeResultadoEsperado += "El metodo extraer el elemento ubicado en el indice 0 de pila vectorial ha tenido el siguiente problema: La pila vectorial está vacía.";
            int[] varVectorElementosEsperado = new int[2];
            varVectorElementosEsperado[0] = 0;
            varVectorElementosEsperado[1] = 0;
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(2);
            bool varResultadoDesapilar;
            int varElementoDesapilado = 0;
            #endregion
            #region Probar
            varResultadoDesapilar = varMiPila.Desapilar(ref varElementoDesapilado);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(false, varResultadoDesapilar);
            Assert.AreEqual(0, varElementoDesapilado);
            Assert.AreEqual(0, varMiPila.darLongitud());
            Assert.AreEqual(2, varMiPila.darCapacidad());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            #endregion
        }
        [TestMethod]
        public void testDesapilarCaso5()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo desapilar de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "El metodo extraer primer elemento de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "El metodo extraer el elemento ubicado en el indice 0 de pila vectorial ha finalizado correctamente. ";
            int[] varVectorElementosEsperado = new int[2];
            varVectorElementosEsperado[0] = 0;
            varVectorElementosEsperado[1] = 0;
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(2);
            varMiPila.Apilar(2000);
            bool varResultadoDesapilar;
            int varElementoDesapilado = 0;
            #endregion
            #region Probar
            varResultadoDesapilar = varMiPila.Desapilar(ref varElementoDesapilado);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(true, varResultadoDesapilar);
            Assert.AreEqual(2000, varElementoDesapilado);
            Assert.AreEqual(0, varMiPila.darLongitud());
            Assert.AreEqual(2, varMiPila.darCapacidad());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            #endregion
        }
        [TestMethod]
        public void testDesapilarCaso6()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo desapilar de pila vectorial ha tenido el siguiente problema: ";
            varMensajeResultadoEsperado += "El metodo extraer primer elemento de pila vectorial ha tenido el siguiente problema: ";
            varMensajeResultadoEsperado += "El metodo extraer el elemento ubicado en el indice 0 de pila vectorial ha tenido el siguiente problema: La pila vectorial está vacía.";
            int[] varVectorElementosEsperado = new int[2];
            varVectorElementosEsperado[0] = 0;
            varVectorElementosEsperado[1] = 0;
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(2, 20);

            bool varResultadoDesapilar;
            int varElementoDesapilado = 0;
            #endregion
            #region Probar
            varResultadoDesapilar = varMiPila.Desapilar(ref varElementoDesapilado);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(false, varResultadoDesapilar);
            Assert.AreEqual(0, varElementoDesapilado);
            Assert.AreEqual(0, varMiPila.darLongitud());
            Assert.AreEqual(2, varMiPila.darCapacidad());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            #endregion
        }
        #endregion
        #region TestRevisar
        [TestMethod]
        public void testRevisarCaso1()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo revisar de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "El metodo recuperar primer elemento de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "El metodo recuperar el elemento ubicado en el indice 0 de pila vectorial ha finalizado correctamente. ";

            int[] varVectorElementosEsperado = new int[3] { 5000, 2000, 0 };
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(3, 1);
            varMiPila.Apilar(2000);
            varMiPila.Apilar(5000);

            bool varResultadoRevisar;
            int varElementoRevisado = 0;
            #endregion
            #region Probar
            varResultadoRevisar = varMiPila.Revisar(ref varElementoRevisado);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, varResultadoRevisar);
            Assert.AreEqual(5000, varElementoRevisado);
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            #endregion
        }
        [TestMethod]
        public void testRevisarCaso2()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo revisar de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "El metodo recuperar primer elemento de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "El metodo recuperar el elemento ubicado en el indice 0 de pila vectorial ha finalizado correctamente. ";

            int[] varVectorElementosEsperado = new int[3] { 5000, 2000, 0 };
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(3);
            varMiPila.Apilar(2000);
            varMiPila.Apilar(5000);
            bool varResultadoRevisar;
            int varElementoRevisado = 0;
            #endregion
            #region Probar
            varResultadoRevisar = varMiPila.Revisar(ref varElementoRevisado);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, varResultadoRevisar);
            Assert.AreEqual(5000, varElementoRevisado);
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            #endregion
        }
        [TestMethod]
        public void testRevisarCaso3()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo revisar de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "El metodo recuperar primer elemento de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "El metodo recuperar el elemento ubicado en el indice 0 de pila vectorial ha finalizado correctamente. ";

            int[] varVectorElementosEsperado = new int[2] { 5000, 2000 };
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(2);
            varMiPila.Apilar(2000);
            varMiPila.Apilar(5000);
            bool varResultadoRevisar;
            int varElementoRevisado = 0;
            #endregion
            #region Probar
            varResultadoRevisar = varMiPila.Revisar(ref varElementoRevisado);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, varResultadoRevisar);
            Assert.AreEqual(5000, varElementoRevisado);
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            #endregion
        }
        [TestMethod]
        public void testRevisarCaso4()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo revisar de pila vectorial ha tenido el siguiente problema: ";
            varMensajeResultadoEsperado += "El metodo recuperar primer elemento de pila vectorial ha tenido el siguiente problema: ";
            varMensajeResultadoEsperado += "El metodo recuperar el elemento ubicado en el indice 0 de pila vectorial ha tenido el siguiente problema: La pila vectorial está vacía.";

            int[] varVectorElementosEsperado = new int[2] { 0, 0 };
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(2, 1);
            bool varResultadoRevisar;
            int varElementoRevisado = 0;
            #endregion
            #region Probar
            varResultadoRevisar = varMiPila.Revisar(ref varElementoRevisado);
            #endregion
            #region Comprobar
            Assert.AreEqual(false, varResultadoRevisar);
            Assert.AreEqual(0, varElementoRevisado);
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            #endregion
        }
        [TestMethod]
        public void testRevisarCaso5()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo revisar de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "El metodo recuperar primer elemento de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "El metodo recuperar el elemento ubicado en el indice 0 de pila vectorial ha finalizado correctamente. ";

            int[] varVectorElementosEsperado = new int[2] { 2000, 0 };
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(2, 1);
            varMiPila.Apilar(2000);

            bool varResultadoRevisar;
            int varElementoRevisado = 0;
            #endregion
            #region Probar
            varResultadoRevisar = varMiPila.Revisar(ref varElementoRevisado);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, varResultadoRevisar);
            Assert.AreEqual(2000, varElementoRevisado);
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            #endregion
        }
        [TestMethod]
        public void testRevisarCaso6()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo revisar de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "El metodo recuperar primer elemento de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "El metodo recuperar el elemento ubicado en el indice 0 de pila vectorial ha finalizado correctamente. ";

            int[] varVectorElementosEsperado = new int[2] { 5000, 2000 };
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(2, 1);
            varMiPila.Apilar(2000);
            varMiPila.Apilar(5000);
            bool varResultadoRevisar;
            int varElementoRevisado = 0;
            #endregion
            #region Probar
            varResultadoRevisar = varMiPila.Revisar(ref varElementoRevisado);
            #endregion
            #region Comprobar
            Assert.AreEqual(true, varResultadoRevisar);
            Assert.AreEqual(5000, varElementoRevisado);
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            #endregion
        }
        [TestMethod]
        public void testRevisarCaso7()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "El metodo revisar de pila vectorial ha tenido el siguiente problema: ";
            varMensajeResultadoEsperado += "El metodo recuperar primer elemento de pila vectorial ha tenido el siguiente problema: ";
            varMensajeResultadoEsperado += "El metodo recuperar el elemento ubicado en el indice 0 de pila vectorial ha tenido el siguiente problema: La pila vectorial está vacía.";

            int[] varVectorElementosEsperado = new int[2] { 0, 0 };
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(2);
            bool varResultadoRevisar;
            int varElementoRevisado = 0;
            #endregion
            #region Probar
            varResultadoRevisar = varMiPila.Revisar(ref varElementoRevisado);
            #endregion
            #region Comprobar
            Assert.AreEqual(false, varResultadoRevisar);
            Assert.AreEqual(0, varElementoRevisado);
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            #endregion
        }
        #endregion
        #region TestBurbujaSimple
        #region CasoPromedio
        [TestMethod]
        public void testOrdenarBurbujaSimpleCasoPromedioPilaLlenaDeEnterosAscendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El método de ordenamiento por Burbuja Simple de pila vectorial ha finalizado correctamente.";
            varMensajeResultadoEsperado += "/r" + "-El método ajustar el orden de pila vectorial ha finalizado correctamente.";
            varMensajeResultadoEsperado += "/r" + "-Se ajustó el orden de la pila vectorial como ascendente.";
            varMensajeResultadoEsperado += "/r" + "-El método de Ordenamiento Burbuja Simple arrojó los siguientes datos:";
            varMensajeResultadoEsperado += "/r" + "--Número de Elementos:10.";
            varMensajeResultadoEsperado += "/r" + "--Número de Comparaciones:45.";
            varMensajeResultadoEsperado += "/r" + "--Número de Intercambios:20.";
            varMensajeResultadoEsperado += "/r" + "--Número de Inserciones:0.";
            varMensajeResultadoEsperado += "/r" + "--Número de Llamados Recursivos:0.";
            int[] varVectorElementosEsperado = new int[10] { -10, -8, -6, -4, -2, 1, 3, 5, 7, 9 };
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(10);
            varMiPila.Apilar(1);
            varMiPila.Apilar(-2);
            varMiPila.Apilar(3);
            varMiPila.Apilar(-4);
            varMiPila.Apilar(5);
            varMiPila.Apilar(-6);
            varMiPila.Apilar(7);
            varMiPila.Apilar(-8);
            varMiPila.Apilar(9);
            varMiPila.Apilar(-10);
            varMiPila.AjustarOrdenColeccion("Aleatorio");
            varMiPila.ponerMensajeUltimoMetodo("");
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar
            ///Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(45, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(20, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaSimpleCasoPromedioPilaLlenaDeEnterosDescendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "\r" + "-El método de ordenamiento por Burbuja Simple de pila vectorial ha finalizado correctamente.";
            varMensajeResultadoEsperado = "\r" + "-El método ajustar el orden de pila vectorial ha finalizado correctamente.";
            varMensajeResultadoEsperado = "\r" + "-Se ajustó el orden de la pila vectorial como descendente.";
            varMensajeResultadoEsperado = "\r" + "-El método de Ordenamiento Burbuja Simple arrojó los siguientes datos:";
            varMensajeResultadoEsperado = "\r" + "--Número de Elementos:10.";
            varMensajeResultadoEsperado = "\r" + "--Número de Comparaciones:45.";
            varMensajeResultadoEsperado = "\r" + "--Número de Intercambios:25.";
            varMensajeResultadoEsperado = "\r" + "--Número de Inserciones:0.";
            varMensajeResultadoEsperado = "\r" + "--Número de Llamados Recursivos:0.";
            int[] varVectorElementosEsperado = new int[10] { 9, 7, 5, 3, 1, -2, -4, -6, -8, -10 };
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(10);
            varMiPila.Apilar(1);
            varMiPila.Apilar(-2);
            varMiPila.Apilar(3);
            varMiPila.Apilar(-4);
            varMiPila.Apilar(5);
            varMiPila.Apilar(-6);
            varMiPila.Apilar(7);
            varMiPila.Apilar(-8);
            varMiPila.Apilar(9);
            varMiPila.Apilar(-10);
            varMiPila.AjustarOrdenColeccion("Aleatorio");
            varMiPila.ponerMensajeUltimoMetodo("");
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar
            ///Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(45, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(25, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaSimpleCasoPromedioPilaLlenaDeObjetosAscendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "\r" + "-El método de ordenamiento por Burbuja Simple de pila vectorial ha finalizado correctamente.";
            varMensajeResultadoEsperado = "\r" + "-El método ajustar el orden de pila vectorial ha finalizado correctamente.";
            varMensajeResultadoEsperado = "\r" + "-Se ajustó el orden de la pila vectorial como ascendente.";
            varMensajeResultadoEsperado = "\r" + "-El método de Ordenamiento Burbuja Simple arrojó los siguientes datos:";
            varMensajeResultadoEsperado = "\r" + "--Número de Elementos:5.";
            varMensajeResultadoEsperado = "\r" + "--Número de Comparaciones:10.";
            varMensajeResultadoEsperado = "\r" + "--Número de Intercambios:4.";
            varMensajeResultadoEsperado = "\r" + "--Número de Inserciones:0.";
            varMensajeResultadoEsperado = "\r" + "--Número de Llamados Recursivos:0.";
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] varVectorElementosEsperados = new clsPersona[5];
            varVectorElementosEsperados[4] = varObjCristina;
            varVectorElementosEsperados[3] = varObjMartin;
            varVectorElementosEsperados[2] = varObjEmilio;
            varVectorElementosEsperados[1] = varObjLucero;
            varVectorElementosEsperados[0] = varObjCarlos;
            clsPilaVector<clsPersona> varMiPila = new clsPilaVector<clsPersona>(5);
            varMiPila.Apilar(varObjMartin);
            varMiPila.Apilar(varObjCristina);
            varMiPila.Apilar(varObjCarlos);
            varMiPila.Apilar(varObjLucero);
            varMiPila.Apilar(varObjEmilio);
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar
            ///Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperados, varMiPila.darVectorElementos());
            Assert.AreEqual(10, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(4, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaSimpleCasoPromedioPilaLlenaDeObjetosDescendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El método de ordenamiento por Burbuja Simple de pila vectorial ha finalizado correctamente.";
            varMensajeResultadoEsperado += "/r" + "-El método ajustar el orden de pila vectorial ha finalizado correctamente.";
            varMensajeResultadoEsperado += "/r" + "-Se ajustó el orden de la pila vectorial como descendente.";
            varMensajeResultadoEsperado += "/r" + "-El método de Ordenamiento Burbuja Simple arrojó los siguientes datos:";
            varMensajeResultadoEsperado += "/r" + "--Número de Elementos:5.";
            varMensajeResultadoEsperado += "/r" + "--Número de Comparaciones:10.";
            varMensajeResultadoEsperado += "/r" + "--Número de Intercambios:6.";
            varMensajeResultadoEsperado += "/r" + "--Número de Inserciones:0.";
            varMensajeResultadoEsperado += "/r" + "--Número de Llamados Recursivos:0.";
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] varVectorElementosEsperados = new clsPersona[5];
            varVectorElementosEsperados[0] = varObjCristina;
            varVectorElementosEsperados[1] = varObjMartin;
            varVectorElementosEsperados[2] = varObjEmilio;
            varVectorElementosEsperados[3] = varObjLucero;
            varVectorElementosEsperados[4] = varObjCarlos;
            clsPilaVector<clsPersona> varMiPila = new clsPilaVector<clsPersona>(5);
            varMiPila.Apilar(varObjMartin);
            varMiPila.Apilar(varObjCristina);
            varMiPila.Apilar(varObjCarlos);
            varMiPila.Apilar(varObjLucero);
            varMiPila.Apilar(varObjEmilio);
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar
            ///Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperados, varMiPila.darVectorElementos());
            Assert.AreEqual(10, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(6, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaSimpleCasoPromedioPilaNormalDeEnterosAscendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "\r" + "-El método de ordenamiento por Burbuja Simple de pila vectorial ha finalizado correctamente.";
            varMensajeResultadoEsperado = "\r" + "-El método ajustar el orden de pila vectorial ha finalizado correctamente.";
            varMensajeResultadoEsperado = "\r" + "-Se ajustó el orden de la pila vectorial como ascendente.";
            varMensajeResultadoEsperado = "\r" + "-El método de Ordenamiento Burbuja Simple arrojó los siguientes datos:";
            varMensajeResultadoEsperado = "\r" + "--Número de Elementos:7.";
            varMensajeResultadoEsperado = "\r" + "--Número de Comparaciones:21.";
            varMensajeResultadoEsperado = "\r" + "--Número de Intercambios:17.";
            varMensajeResultadoEsperado = "\r" + "--Número de Inserciones:0.";
            varMensajeResultadoEsperado = "\r" + "--Número de Llamados Recursivos:0.";
            int[] varVectorElementosEsperado = new int[10] { -4, -2, 1, 3, 5, 7, 9, 0, 0, 0 };
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(10);
            varMiPila.Apilar(1);
            varMiPila.Apilar(-2);
            varMiPila.Apilar(3);
            varMiPila.Apilar(-4);
            varMiPila.Apilar(5);
            varMiPila.Apilar(7);
            varMiPila.Apilar(9);
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar
            ///Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(21, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(17, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaSimpleCasoPromedioPilaNormalDeEnterosDescendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "\r" + "-El método de ordenamiento por Burbuja Simple de pila vectorial ha finalizado correctamente.";
            varMensajeResultadoEsperado = "\r" + "-El método ajustar el orden de pila vectorial ha finalizado correctamente.";
            varMensajeResultadoEsperado = "\r" + "-Se ajustó el orden de la pila vectorial como descendente.";
            varMensajeResultadoEsperado = "\r" + "-El método de Ordenamiento Burbuja Simple arrojó los siguientes datos:";
            varMensajeResultadoEsperado = "\r" + "--Número de Elementos:7.";
            varMensajeResultadoEsperado = "\r" + "--Número de Comparaciones:21.";
            varMensajeResultadoEsperado = "\r" + "--Número de Intercambios:4.";
            varMensajeResultadoEsperado = "\r" + "--Número de Inserciones:0.";
            varMensajeResultadoEsperado = "\r" + "--Número de Llamados Recursivos:0.";
            int[] varVectorElementosEsperado = new int[10] { 9, 7, 5, 3, 1, -2, -4, 0, 0, 0 };
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(10);
            varMiPila.Apilar(1);
            varMiPila.Apilar(-2);
            varMiPila.Apilar(3);
            varMiPila.Apilar(-4);
            varMiPila.Apilar(5);
            varMiPila.Apilar(7);
            varMiPila.Apilar(9);
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar
            ///Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(21, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(4, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaSimpleCasoPromedioPilaNormalDeObjetosAscendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "\r" + "-El método de ordenamiento por Burbuja Simple de pila vectorial ha finalizado correctamente.";
            varMensajeResultadoEsperado = "\r" + "-El método ajustar el orden de pila vectorial ha finalizado correctamente.";
            varMensajeResultadoEsperado = "\r" + "-Se ajustó el orden de la pila vectorial como ascendente.";
            varMensajeResultadoEsperado = "\r" + "-El método de Ordenamiento Burbuja Simple arrojó los siguientes datos:";
            varMensajeResultadoEsperado = "\r" + "--Número de Elementos:5.";
            varMensajeResultadoEsperado = "\r" + "--Número de Comparaciones:10.";
            varMensajeResultadoEsperado = "\r" + "--Número de Intercambios:4.";
            varMensajeResultadoEsperado = "\r" + "--Número de Inserciones:0.";
            varMensajeResultadoEsperado = "\r" + "--Número de Llamados Recursivos:0.";
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] varVectorElementosEsperados = new clsPersona[10];
            varVectorElementosEsperados[4] = varObjCristina;
            varVectorElementosEsperados[3] = varObjMartin;
            varVectorElementosEsperados[2] = varObjEmilio;
            varVectorElementosEsperados[1] = varObjLucero;
            varVectorElementosEsperados[0] = varObjCarlos;
            clsPilaVector<clsPersona> varMiPila = new clsPilaVector<clsPersona>(10);
            varMiPila.Apilar(varObjMartin);
            varMiPila.Apilar(varObjCristina);
            varMiPila.Apilar(varObjCarlos);
            varMiPila.Apilar(varObjLucero);
            varMiPila.Apilar(varObjEmilio);
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar
            ///Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperados, varMiPila.darVectorElementos());
            Assert.AreEqual(10, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(4, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaSimpleCasoPromedioPilaNormalDeObjetosDescendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "\r" + "-El método de ordenamiento por Burbuja Simple de pila vectorial ha finalizado correctamente.";
            varMensajeResultadoEsperado += "\r" + "-El método ajustar el orden de pila vectorial ha finalizado correctamente.";
            varMensajeResultadoEsperado += "\r" + "-Se ajustó el orden de la pila vectorial como descendente.";
            varMensajeResultadoEsperado += "\r" + "-El método de Ordenamiento Burbuja Simple arrojó los siguientes datos:";
            varMensajeResultadoEsperado += "\r" + "--Número de Elementos:5.";
            varMensajeResultadoEsperado += "\r" + "--Número de Comparaciones:10.";
            varMensajeResultadoEsperado += "\r" + "--Número de Intercambios:6.";
            varMensajeResultadoEsperado += "\r" + "--Número de Inserciones:0.";
            varMensajeResultadoEsperado += "\r" + "--Número de Llamados Recursivos:0.";
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] varVectorElementosEsperados = new clsPersona[10];
            varVectorElementosEsperados[0] = varObjCristina;
            varVectorElementosEsperados[1] = varObjMartin;
            varVectorElementosEsperados[2] = varObjEmilio;
            varVectorElementosEsperados[3] = varObjLucero;
            varVectorElementosEsperados[4] = varObjCarlos;
            clsPilaVector<clsPersona> varMiPila = new clsPilaVector<clsPersona>(10);
            varMiPila.Apilar(varObjMartin);
            varMiPila.Apilar(varObjCristina);
            varMiPila.Apilar(varObjCarlos);
            varMiPila.Apilar(varObjLucero);
            varMiPila.Apilar(varObjEmilio);
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar
            ///Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperados, varMiPila.darVectorElementos());
            Assert.AreEqual(10, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(6, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        #endregion
        #region CasoConstante
        [TestMethod]
        public void testOrdenarBurbujaSimpleCasoConstantePilaNormalDeEnterosInteligenteDescendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r-El metodo de ordenamiento por Burbuja Simple de pila vectorial ha tenido el siguiente problema: ";
            varMensajeResultadoEsperado += "/r" + "-No debe ordenar, la pila vectorial ya está ordenada como descendente.";
            int[] varVectorElementosEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 };
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(10);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.AjustarOrdenColeccion("Constante");
            varMiPila.ponerMensajeUltimoMetodo("");
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(0, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(0, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaSimpleCasoConstantePilaNormalDeEnterosInteligenteAscendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r-El metodo de ordenamiento por Burbuja Simple de pila vectorial ha tenido el siguiente problema: ";
            varMensajeResultadoEsperado += "/r" + "-No debe ordenar, la pila vectorial ya está ordenada como ascendente.";
            int[] varVectorElementosEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 };
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(10);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.AjustarOrdenColeccion("Constante");
            varMiPila.ponerMensajeUltimoMetodo("");
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(0, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(0, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaSimpleCasoConstantePilaNormalDeEnterosFuerzaBrutaDescendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El metodo de ordenamiento por Burbuja Simple de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo ajustar el orden de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-Se ajustó el orden de la pila vectorial como descendente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo de ordenamiento Burbuja Simple arrojo los siguientes datos: ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Elementos: 7. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Comparaciones: 21. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Intercambios: 0. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Inserciones: 0. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Llamados Recursivos: 0. ";
            int[] varVectorElementosEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 };
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(10);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(21, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(0, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaSimpleCasoConstantePilaNormalDeEnterosFuerzaBrutaAscendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El metodo de ordenamiento por Burbuja Simple de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo ajustar el orden de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-Se ajustó el orden de la pila vectorial como ascendente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo de ordenamiento Burbuja Simple arrojo los siguientes datos: ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Elementos: 7. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Comparaciones: 21. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Intercambios: 0. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Inserciones: 0. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Llamados Recursivos: 0. ";
            int[] varVectorElementosEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 };
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(10);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(21, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(0, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaSimpleCasoConstantePilaLlenaDeEnterosInteligenteDescendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r-El metodo de ordenamiento por Burbuja Simple de pila vectorial ha tenido el siguiente problema: ";
            varMensajeResultadoEsperado += "/r" + "-No debe ordenar, la pila vectorial ya está ordenada como descendente.";
            int[] varVectorElementosEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(10);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);

            varMiPila.AjustarOrdenColeccion("Constante");
            varMiPila.ponerMensajeUltimoMetodo("");
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(0, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(0, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaSimpleCasoConstantePilaLlenaDeEnterosInteligenteAscendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r-El metodo de ordenamiento por Burbuja Simple de pila vectorial ha tenido el siguiente problema: ";
            varMensajeResultadoEsperado += "/r" + "-No debe ordenar, la pila vectorial ya está ordenada como ascendente.";
            int[] varVectorElementosEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(10);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);

            varMiPila.AjustarOrdenColeccion("Constante");
            varMiPila.ponerMensajeUltimoMetodo("");
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(0, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(0, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaSimpleCasoConstantePilaLlenaDeEnterosFuerzaBrutaDescendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El metodo de ordenamiento por Burbuja Simple de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo ajustar el orden de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-Se ajustó el orden de la pila vectorial como descendente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo de ordenamiento Burbuja Simple arrojo los siguientes datos: ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Elementos: 10. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Comparaciones: 45. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Intercambios: 0. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Inserciones: 0. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Llamados Recursivos: 0. ";
            int[] varVectorElementosEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(10);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);

            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(45, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(0, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaSimpleCasoConstantePilaLlenaDeEnterosFuerzaBrutaAscendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El metodo de ordenamiento por Burbuja Simple de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo ajustar el orden de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-Se ajustó el orden de la pila vectorial como ascendente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo de ordenamiento Burbuja Simple arrojo los siguientes datos: ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Elementos: 10. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Comparaciones: 45. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Intercambios: 0. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Inserciones: 0. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Llamados Recursivos: 0. ";
            int[] varVectorElementosEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(10);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);

            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(45, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(0, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaSimpleCasoConstantePilaLlenaDeObjetosInteligenteDescendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r-El metodo de ordenamiento por Burbuja Simple de pila vectorial ha tenido el siguiente problema: ";
            varMensajeResultadoEsperado += "/r" + "-No debe ordenar, la pila vectorial ya está ordenada como descendente.";
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martin", 40);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 40);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 40);
            clsPersona varObjCarlos = new clsPersona(3, "Carlos", 40);
            clsPersona[] varVectorElementosEsperado = new clsPersona[5];
            varVectorElementosEsperado[0] = varObjCristina;
            varVectorElementosEsperado[1] = varObjMartin;
            varVectorElementosEsperado[2] = varObjEmilio;
            varVectorElementosEsperado[3] = varObjLucero;
            varVectorElementosEsperado[4] = varObjCarlos;
            clsPilaVector<clsPersona> varMiPila = new clsPilaVector<clsPersona>(5);
            varMiPila.Apilar(varObjCarlos);
            varMiPila.Apilar(varObjLucero);
            varMiPila.Apilar(varObjEmilio);
            varMiPila.Apilar(varObjMartin);
            varMiPila.Apilar(varObjCristina);
            varMiPila.AjustarOrdenColeccion("Constante");
            varMiPila.ponerMensajeUltimoMetodo("");
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(0, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(0, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaSimpleCasoConstantePilaLlenaDeObjetosInteligenteAscendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r-El metodo de ordenamiento por Burbuja Simple de pila vectorial ha tenido el siguiente problema: ";
            varMensajeResultadoEsperado += "/r" + "-No debe ordenar, la pila vectorial ya está ordenada como ascendente.";
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martin", 40);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 40);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 40);
            clsPersona varObjCarlos = new clsPersona(3, "Carlos", 40);
            clsPersona[] varVectorElementosEsperado = new clsPersona[5];
            varVectorElementosEsperado[0] = varObjCristina;
            varVectorElementosEsperado[1] = varObjMartin;
            varVectorElementosEsperado[2] = varObjEmilio;
            varVectorElementosEsperado[3] = varObjLucero;
            varVectorElementosEsperado[4] = varObjCarlos;
            clsPilaVector<clsPersona> varMiPila = new clsPilaVector<clsPersona>(5);
            varMiPila.Apilar(varObjCarlos);
            varMiPila.Apilar(varObjLucero);
            varMiPila.Apilar(varObjEmilio);
            varMiPila.Apilar(varObjMartin);
            varMiPila.Apilar(varObjCristina);
            varMiPila.AjustarOrdenColeccion("Constante");
            varMiPila.ponerMensajeUltimoMetodo("");
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(0, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(0, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaSimpleCasoConstantePilaLlenaDeObjetosFuerzaBrutaDescendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El metodo de ordenamiento por Burbuja Simple de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo ajustar el orden de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-Se ajustó el orden de la pila vectorial como descendente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo de ordenamiento Burbuja Simple arrojo los siguientes datos: ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Elementos: 5. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Comparaciones: 10. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Intercambios: 0. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Inserciones: 0. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Llamados Recursivos: 0. ";
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martin", 40);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 40);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 40);
            clsPersona varObjCarlos = new clsPersona(3, "Carlos", 40);
            clsPersona[] varVectorElementosEsperado = new clsPersona[5];
            varVectorElementosEsperado[0] = varObjCristina;
            varVectorElementosEsperado[1] = varObjMartin;
            varVectorElementosEsperado[2] = varObjEmilio;
            varVectorElementosEsperado[3] = varObjLucero;
            varVectorElementosEsperado[4] = varObjCarlos;
            clsPilaVector<clsPersona> varMiPila = new clsPilaVector<clsPersona>(5);
            varMiPila.Apilar(varObjCarlos);
            varMiPila.Apilar(varObjLucero);
            varMiPila.Apilar(varObjEmilio);
            varMiPila.Apilar(varObjMartin);
            varMiPila.Apilar(varObjCristina);
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(10, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(0, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaSimpleCasoConstantePilaLlenaDeObjetosFuerzaBrutaAscendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El metodo de ordenamiento por Burbuja Simple de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo ajustar el orden de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-Se ajustó el orden de la pila vectorial como ascendente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo de ordenamiento Burbuja Simple arrojo los siguientes datos: ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Elementos: 5. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Comparaciones: 10. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Intercambios: 0. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Inserciones: 0. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Llamados Recursivos: 0. ";
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martin", 40);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 40);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 40);
            clsPersona varObjCarlos = new clsPersona(3, "Carlos", 40);
            clsPersona[] varVectorElementosEsperado = new clsPersona[5];
            varVectorElementosEsperado[0] = varObjCristina;
            varVectorElementosEsperado[1] = varObjMartin;
            varVectorElementosEsperado[2] = varObjEmilio;
            varVectorElementosEsperado[3] = varObjLucero;
            varVectorElementosEsperado[4] = varObjCarlos;
            clsPilaVector<clsPersona> varMiPila = new clsPilaVector<clsPersona>(5);
            varMiPila.Apilar(varObjCarlos);
            varMiPila.Apilar(varObjLucero);
            varMiPila.Apilar(varObjEmilio);
            varMiPila.Apilar(varObjMartin);
            varMiPila.Apilar(varObjCristina);
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(10, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(0, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaSimpleCasoConstantePilaNormalDeInteligenteDescendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r-El metodo de ordenamiento por Burbuja Simple de pila vectorial ha tenido el siguiente problema: ";
            varMensajeResultadoEsperado += "/r" + "-No debe ordenar, la pila vectorial ya está ordenada como descendente.";
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martin", 40);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 40);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 40);
            clsPersona varObjCarlos = new clsPersona(3, "Carlos", 40);
            clsPersona[] varVectorElementosEsperado = new clsPersona[10];
            varVectorElementosEsperado[0] = varObjCristina;
            varVectorElementosEsperado[1] = varObjMartin;
            varVectorElementosEsperado[2] = varObjEmilio;
            varVectorElementosEsperado[3] = varObjLucero;
            varVectorElementosEsperado[4] = varObjCarlos;
            clsPilaVector<clsPersona> varMiPila = new clsPilaVector<clsPersona>(10);
            varMiPila.Apilar(varObjCarlos);
            varMiPila.Apilar(varObjLucero);
            varMiPila.Apilar(varObjEmilio);
            varMiPila.Apilar(varObjMartin);
            varMiPila.Apilar(varObjCristina);
            varMiPila.AjustarOrdenColeccion("Constante");
            varMiPila.ponerMensajeUltimoMetodo("");
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(0, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(0, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaSimpleCasoConstantePilaNormalDeobjetosInteligenteAscendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r-El metodo de ordenamiento por Burbuja Simple de pila vectorial ha tenido el siguiente problema: ";
            varMensajeResultadoEsperado += "/r" + "-No debe ordenar, la pila vectorial ya está ordenada como ascendente.";
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martin", 40);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 40);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 40);
            clsPersona varObjCarlos = new clsPersona(3, "Carlos", 40);
            clsPersona[] varVectorElementosEsperado = new clsPersona[10];
            varVectorElementosEsperado[0] = varObjCristina;
            varVectorElementosEsperado[1] = varObjMartin;
            varVectorElementosEsperado[2] = varObjEmilio;
            varVectorElementosEsperado[3] = varObjLucero;
            varVectorElementosEsperado[4] = varObjCarlos;
            clsPilaVector<clsPersona> varMiPila = new clsPilaVector<clsPersona>(10);
            varMiPila.Apilar(varObjCarlos);
            varMiPila.Apilar(varObjLucero);
            varMiPila.Apilar(varObjEmilio);
            varMiPila.Apilar(varObjMartin);
            varMiPila.Apilar(varObjCristina); varMiPila.AjustarOrdenColeccion("Constante");
            varMiPila.ponerMensajeUltimoMetodo("");
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(0, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(0, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaSimpleCasoConstantePilaNormalDeObjetosFuerzaBrutaDescendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El metodo de ordenamiento por Burbuja Simple de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo ajustar el orden de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-Se ajustó el orden de la pila vectorial como descendente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo de ordenamiento Burbuja Simple arrojo los siguientes datos: ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Elementos: 5. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Comparaciones: 10. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Intercambios: 0. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Inserciones: 0. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Llamados Recursivos: 0. ";
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martin", 40);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 40);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 40);
            clsPersona varObjCarlos = new clsPersona(3, "Carlos", 40);
            clsPersona[] varVectorElementosEsperado = new clsPersona[10];
            varVectorElementosEsperado[0] = varObjCristina;
            varVectorElementosEsperado[1] = varObjMartin;
            varVectorElementosEsperado[2] = varObjEmilio;
            varVectorElementosEsperado[3] = varObjLucero;
            varVectorElementosEsperado[4] = varObjCarlos;
            clsPilaVector<clsPersona> varMiPila = new clsPilaVector<clsPersona>(10);
            varMiPila.Apilar(varObjCarlos);
            varMiPila.Apilar(varObjLucero);
            varMiPila.Apilar(varObjEmilio);
            varMiPila.Apilar(varObjMartin);
            varMiPila.Apilar(varObjCristina);
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(10, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(0, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaSimpleCasoConstantePilaNormalDeObjetosFuerzaBrutaAscendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El metodo de ordenamiento por Burbuja Simple de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo ajustar el orden de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-Se ajustó el orden de la pila vectorial como ascendente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo de ordenamiento Burbuja Simple arrojo los siguientes datos: ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Elementos: 5. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Comparaciones: 10. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Intercambios: 0. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Inserciones: 0. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Llamados Recursivos: 0. ";

            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martin", 40);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 40);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 40);
            clsPersona varObjCarlos = new clsPersona(3, "Carlos", 40);
            clsPersona[] varVectorElementosEsperado = new clsPersona[10];
            varVectorElementosEsperado[0] = varObjCristina;
            varVectorElementosEsperado[1] = varObjMartin;
            varVectorElementosEsperado[2] = varObjEmilio;
            varVectorElementosEsperado[3] = varObjLucero;
            varVectorElementosEsperado[4] = varObjCarlos;
            clsPilaVector<clsPersona> varMiPila = new clsPilaVector<clsPersona>(10);
            varMiPila.Apilar(varObjCarlos);
            varMiPila.Apilar(varObjLucero);
            varMiPila.Apilar(varObjEmilio);
            varMiPila.Apilar(varObjMartin);
            varMiPila.Apilar(varObjCristina);
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(10, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(0, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        #endregion
        #region ColeccionVacia
        [TestMethod]
        public void testOrdenarBurbujaSimplePilaVaciaDeEnterosAscendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El metodo de ordenamiento por Burbuja Simple de pila vectorial ha tenido el siguiente problema: ";
            varMensajeResultadoEsperado += "La pila vectorial está vacía.";

            clsPilaVector<int> varMiPila = new clsPilaVector<int>();
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaDescendente());
            Assert.AreEqual(0, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(0, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaSimplePilaVaciaDeEnterosDescendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El metodo de ordenamiento por Burbuja Simple de pila vectorial ha tenido el siguiente problema: ";
            varMensajeResultadoEsperado += "La pila vectorial está vacía.";
            clsPilaVector<int> varMiPila = new clsPilaVector<int>();
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaDescendente());
            Assert.AreEqual(0, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(0, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaSimplePilaVaciaDeObjetosAscendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El metodo de ordenamiento por Burbuja Simple de pila vectorial ha tenido el siguiente problema: ";
            varMensajeResultadoEsperado += "La pila vectorial está vacía.";

            clsPilaVector<int> varMiPila = new clsPilaVector<int>();
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaDescendente());
            Assert.AreEqual(0, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(0, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaSimplePilaVaciaDeObjetosDescendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El metodo de ordenamiento por Burbuja Simple de pila vectorial ha tenido el siguiente problema: ";
            varMensajeResultadoEsperado += "La pila vectorial está vacía.";
            clsPilaVector<clsPersona> varMiPila = new clsPilaVector<clsPersona>();
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaDescendente());
            Assert.AreEqual(0, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(0, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        #endregion
        #region PeorCaso
        [TestMethod]
        public void testOrdenarBurbujaSimplePeorCasoPilaNormalDeEnteroAscendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El metodo de ordenamiento por Burbuja Simple de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo ajustar el orden de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-Se ajustó el orden de la pila vectorial como ascendente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo de ordenamiento Burbuja Simple arrojo los siguientes datos: ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Elementos: 7. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Comparaciones: 21. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Intercambios: 21. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Inserciones: 0. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Llamados Recursivos: 0. ";
            int[] varVectorElementosEsperado = new int[10] { 1, 2, 3, 4, 5, 6, 7, 0, 0, 0 };
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(10);
            varMiPila.Apilar(1);
            varMiPila.Apilar(2);
            varMiPila.Apilar(3);
            varMiPila.Apilar(4);
            varMiPila.Apilar(5);
            varMiPila.Apilar(6);
            varMiPila.Apilar(7);

            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(21, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(21, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaSimplePeorCasoPilaNormalDeEnteroDescendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El metodo de ordenamiento por Burbuja Simple de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo ajustar el orden de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-Se ajustó el orden de la pila vectorial como descendente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo de ordenamiento Burbuja Simple arrojo los siguientes datos: ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Elementos: 7. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Comparaciones: 21. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Intercambios: 21. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Inserciones: 0. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Llamados Recursivos: 0. ";
            int[] varVectorElementosEsperado = new int[10] { 7, 6, 5, 4, 3, 2, 1, 0, 0, 0 };
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(10);
            varMiPila.Apilar(7);
            varMiPila.Apilar(6);
            varMiPila.Apilar(5);
            varMiPila.Apilar(4);
            varMiPila.Apilar(3);
            varMiPila.Apilar(2);
            varMiPila.Apilar(1);
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(21, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(21, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaSimplePeorCasoPilaLlenaDeEnteroAscendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El metodo de ordenamiento por Burbuja Simple de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo ajustar el orden de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-Se ajustó el orden de la pila vectorial como ascendente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo de ordenamiento Burbuja Simple arrojo los siguientes datos: ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Elementos: 10. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Comparaciones: 45. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Intercambios: 45. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Inserciones: 0. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Llamados Recursivos: 0. ";
            int[] varVectorElementosEsperado = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(10);
            varMiPila.Apilar(1);
            varMiPila.Apilar(2);
            varMiPila.Apilar(3);
            varMiPila.Apilar(4);
            varMiPila.Apilar(5);
            varMiPila.Apilar(6);
            varMiPila.Apilar(7);
            varMiPila.Apilar(8);
            varMiPila.Apilar(9);
            varMiPila.Apilar(10);
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(45, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(45, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaSimplePeorCasoPilaLlenaDeEnteroDescendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El metodo de ordenamiento por Burbuja Simple de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo ajustar el orden de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-Se ajustó el orden de la pila vectorial como descendente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo de ordenamiento Burbuja Simple arrojo los siguientes datos: ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Elementos: 10. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Comparaciones: 45. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Intercambios: 45. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Inserciones: 0. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Llamados Recursivos: 0. ";
            int[] varVectorElementosEsperado = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(10);
            varMiPila.Apilar(10);
            varMiPila.Apilar(9);
            varMiPila.Apilar(8);
            varMiPila.Apilar(7);
            varMiPila.Apilar(6);
            varMiPila.Apilar(5);
            varMiPila.Apilar(4);
            varMiPila.Apilar(3);
            varMiPila.Apilar(2);
            varMiPila.Apilar(1);
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(45, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(45, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaSimplePeorCasoPilaNormalDeObjetosAscendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El metodo de ordenamiento por Burbuja Simple de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo ajustar el orden de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-Se ajustó el orden de la pila vectorial como ascendente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo de ordenamiento Burbuja Simple arrojo los siguientes datos: ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Elementos: 5. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Comparaciones: 10. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Intercambios: 10. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Inserciones: 0. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Llamados Recursivos: 0. ";
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] varVectorElementosEsperado = new clsPersona[10];
            varVectorElementosEsperado[0] = varObjCarlos;
            varVectorElementosEsperado[1] = varObjLucero;
            varVectorElementosEsperado[2] = varObjEmilio;
            varVectorElementosEsperado[3] = varObjMartin;
            varVectorElementosEsperado[4] = varObjCristina;
            clsPilaVector<clsPersona> varMiPila = new clsPilaVector<clsPersona>(10);
            varMiPila.Apilar(varObjCarlos);
            varMiPila.Apilar(varObjLucero);
            varMiPila.Apilar(varObjEmilio);
            varMiPila.Apilar(varObjMartin);
            varMiPila.Apilar(varObjCristina);
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar
            ///Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(10, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(10, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaSimplePeorCasoPilaNormalDeObjetosDescendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El metodo de ordenamiento por Burbuja Simple de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo ajustar el orden de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-Se ajustó el orden de la pila vectorial como descendente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo de ordenamiento Burbuja Simple arrojo los siguientes datos: ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Elementos: 5. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Comparaciones: 10. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Intercambios: 10. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Inserciones: 0. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Llamados Recursivos: 0. ";
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] varVectorElementosEsperado = new clsPersona[10];
            varVectorElementosEsperado[4] = varObjCarlos;
            varVectorElementosEsperado[3] = varObjLucero;
            varVectorElementosEsperado[2] = varObjEmilio;
            varVectorElementosEsperado[1] = varObjMartin;
            varVectorElementosEsperado[0] = varObjCristina;
            clsPilaVector<clsPersona> varMiPila = new clsPilaVector<clsPersona>(10);
            varMiPila.Apilar(varObjCristina);
            varMiPila.Apilar(varObjMartin);
            varMiPila.Apilar(varObjEmilio);
            varMiPila.Apilar(varObjLucero);
            varMiPila.Apilar(varObjCarlos);
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar
            ///Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(10, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(10, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaSimplePeorCasoPilaLlenaDeObjetosDescendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El metodo de ordenamiento por Burbuja Simple de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo ajustar el orden de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-Se ajustó el orden de la pila vectorial como descendente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo de ordenamiento Burbuja Simple arrojo los siguientes datos: ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Elementos: 5. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Comparaciones: 10. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Intercambios: 10. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Inserciones: 0. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Llamados Recursivos: 0. ";
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martin", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] varVectorElementosEsperado = new clsPersona[5];
            varVectorElementosEsperado[0] = varObjCristina;
            varVectorElementosEsperado[1] = varObjMartin;
            varVectorElementosEsperado[2] = varObjEmilio;
            varVectorElementosEsperado[3] = varObjLucero;
            varVectorElementosEsperado[4] = varObjCarlos;
            clsPilaVector<clsPersona> varMiPila = new clsPilaVector<clsPersona>(5);
            varMiPila.Apilar(varObjCristina);
            varMiPila.Apilar(varObjMartin);
            varMiPila.Apilar(varObjEmilio);
            varMiPila.Apilar(varObjLucero);
            varMiPila.Apilar(varObjCarlos);

            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(10, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(10, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaSimplePeorCasoPilaLlenaDeObjetosAscendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El metodo de ordenamiento por Burbuja Simple de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo ajustar el orden de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-Se ajustó el orden de la pila vectorial como ascendente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo de ordenamiento Burbuja Simple arrojo los siguientes datos: ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Elementos: 5. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Comparaciones: 10. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Intercambios: 10. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Inserciones: 0. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Llamados Recursivos: 0. ";
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martin", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] varVectorElementosEsperado = new clsPersona[5];
            varVectorElementosEsperado[0] = varObjCarlos;
            varVectorElementosEsperado[1] = varObjLucero;
            varVectorElementosEsperado[2] = varObjEmilio;
            varVectorElementosEsperado[3] = varObjMartin;
            varVectorElementosEsperado[4] = varObjCristina;
            clsPilaVector<clsPersona> varMiPila = new clsPilaVector<clsPersona>(5);
            varMiPila.Apilar(varObjCarlos);
            varMiPila.Apilar(varObjLucero);
            varMiPila.Apilar(varObjEmilio);
            varMiPila.Apilar(varObjMartin);
            varMiPila.Apilar(varObjCristina);

            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(10, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(10, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }

        #endregion
        #region MejorCaso
        [TestMethod]
        public void testOrdenarBurbujaSimpleMejorCasoPilaLlenaDeEnterosFuerzaBrutaAscendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El metodo de ordenamiento por Burbuja Simple de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo ajustar el orden de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-Se ajustó el orden de la pila vectorial como ascendente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo de ordenamiento Burbuja Simple arrojo los siguientes datos: ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Elementos: 10. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Comparaciones: 45. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Intercambios: 0. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Inserciones: 0. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Llamados Recursivos: 0. ";
            int[] varVectorElementosEsperado = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(10);
            varMiPila.Apilar(10);
            varMiPila.Apilar(9);
            varMiPila.Apilar(8);
            varMiPila.Apilar(7);
            varMiPila.Apilar(6);
            varMiPila.Apilar(5);
            varMiPila.Apilar(4);
            varMiPila.Apilar(3);
            varMiPila.Apilar(2);
            varMiPila.Apilar(1);
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(45, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(0, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaSimpleMejorCasoPilaLlenaDeObjetosFuerzaBrutaAscendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El metodo de ordenamiento por Burbuja Simple de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo ajustar el orden de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-Se ajustó el orden de la pila vectorial como ascendente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo de ordenamiento Burbuja Simple arrojo los siguientes datos: ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Elementos: 5. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Comparaciones: 10. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Intercambios: 0. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Inserciones: 0. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Llamados Recursivos: 0. ";
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] varVectorElementosEsperado = new clsPersona[5];
            varVectorElementosEsperado[0] = varObjCarlos;
            varVectorElementosEsperado[1] = varObjLucero;
            varVectorElementosEsperado[2] = varObjEmilio;
            varVectorElementosEsperado[3] = varObjMartin;
            varVectorElementosEsperado[4] = varObjCristina;
            clsPilaVector<clsPersona> varMiPila = new clsPilaVector<clsPersona>(5);
            varMiPila.Apilar(varObjCristina);
            varMiPila.Apilar(varObjMartin);
            varMiPila.Apilar(varObjEmilio);
            varMiPila.Apilar(varObjLucero);
            varMiPila.Apilar(varObjCarlos);
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(10, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(0, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaSimpleMejorCasoPilaLlenaDeEnterosFuerzaBrutaDescendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El metodo de ordenamiento por Burbuja Simple de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo ajustar el orden de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-Se ajustó el orden de la pila vectorial como descendente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo de ordenamiento Burbuja Simple arrojo los siguientes datos: ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Elementos: 10. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Comparaciones: 45. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Intercambios: 0. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Inserciones: 0. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Llamados Recursivos: 0. ";
            int[] varVectorElementosEsperado = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(10);
            varMiPila.Apilar(1);
            varMiPila.Apilar(2);
            varMiPila.Apilar(3);
            varMiPila.Apilar(4);
            varMiPila.Apilar(5);
            varMiPila.Apilar(6);
            varMiPila.Apilar(7);
            varMiPila.Apilar(8);
            varMiPila.Apilar(9);
            varMiPila.Apilar(10);

            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(45, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(0, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaSimpleMejorCasoPilaLlenaDeObjetosFuerzaBrutaDescendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El metodo de ordenamiento por Burbuja Simple de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo ajustar el orden de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-Se ajustó el orden de la pila vectorial como descendente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo de ordenamiento Burbuja Simple arrojo los siguientes datos: ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Elementos: 5. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Comparaciones: 10. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Intercambios: 0. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Inserciones: 0. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Llamados Recursivos: 0. ";
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] varVectorElementosEsperado = new clsPersona[5];
            varVectorElementosEsperado[0] = varObjCristina;
            varVectorElementosEsperado[1] = varObjMartin;
            varVectorElementosEsperado[2] = varObjEmilio;
            varVectorElementosEsperado[3] = varObjLucero;
            varVectorElementosEsperado[4] = varObjCarlos;
            clsPilaVector<clsPersona> varMiPila = new clsPilaVector<clsPersona>(5);
            varMiPila.Apilar(varObjCarlos);
            varMiPila.Apilar(varObjLucero);
            varMiPila.Apilar(varObjEmilio);
            varMiPila.Apilar(varObjMartin);
            varMiPila.Apilar(varObjCristina);
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(10, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(0, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaSimpleMejorCasoPilaLlenaDeEnterosInteligenteAscendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El metodo de ordenamiento por Burbuja Simple de pila vectorial ha tenido el siguiente problema: ";
            varMensajeResultadoEsperado += "/r" + "-No debe ordenar, la pila vectorial ya está ordenada como ascendente.";
            int[] varVectorElementosEsperado = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(10);
            varMiPila.Apilar(10);
            varMiPila.Apilar(9);
            varMiPila.Apilar(8);
            varMiPila.Apilar(7);
            varMiPila.Apilar(6);
            varMiPila.Apilar(5);
            varMiPila.Apilar(4);
            varMiPila.Apilar(3);
            varMiPila.Apilar(2);
            varMiPila.Apilar(1);

            varMiPila.AjustarOrdenColeccion("Ascendente");
            varMiPila.ponerMensajeUltimoMetodo("");
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(0, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(0, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaSimpleMejorCasoPilaLlenaDeEnterosInteligenteDescendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El metodo de ordenamiento por Burbuja Simple de pila vectorial ha tenido el siguiente problema: ";
            varMensajeResultadoEsperado += "/r" + "-No debe ordenar, la pila vectorial ya está ordenada como descendente.";
            int[] varVectorElementosEsperado = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(10);
            varMiPila.Apilar(1);
            varMiPila.Apilar(2);
            varMiPila.Apilar(3);
            varMiPila.Apilar(4);
            varMiPila.Apilar(5);
            varMiPila.Apilar(6);
            varMiPila.Apilar(7);
            varMiPila.Apilar(8);
            varMiPila.Apilar(9);
            varMiPila.Apilar(10);
            varMiPila.AjustarOrdenColeccion("Descendente");
            varMiPila.ponerMensajeUltimoMetodo("");
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(0, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(0, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaSimpleMejorCasoPilaNormalDeEnterosInteligenteDescendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El metodo de ordenamiento por Burbuja Simple de pila vectorial ha tenido el siguiente problema: ";
            varMensajeResultadoEsperado += "/r" + "-No debe ordenar, la pila vectorial ya está ordenada como descendente.";
            int[] varVectorElementosEsperado = new int[10] { 10, 9, 8, 7, 6, 5, 4, 0, 0, 0 };
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(10);
            varMiPila.Apilar(4);
            varMiPila.Apilar(5);
            varMiPila.Apilar(6);
            varMiPila.Apilar(7);
            varMiPila.Apilar(8);
            varMiPila.Apilar(9);
            varMiPila.Apilar(10);
            varMiPila.AjustarOrdenColeccion("Descendente");
            varMiPila.ponerMensajeUltimoMetodo("");
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(0, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(0, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaSimpleMejorCasoPilaNormalDeEnterosInteligenteAscendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El metodo de ordenamiento por Burbuja Simple de pila vectorial ha tenido el siguiente problema: ";
            varMensajeResultadoEsperado += "/r" + "-No debe ordenar, la pila vectorial ya está ordenada como ascendente.";
            int[] varVectorElementosEsperado = new int[10] { 4, 5, 6, 7, 8, 9, 10, 0, 0, 0 };
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(10);
            varMiPila.Apilar(10);
            varMiPila.Apilar(9);
            varMiPila.Apilar(8);
            varMiPila.Apilar(7);
            varMiPila.Apilar(6);
            varMiPila.Apilar(5);
            varMiPila.Apilar(4);

            varMiPila.AjustarOrdenColeccion("Ascendente");
            varMiPila.ponerMensajeUltimoMetodo("");
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(0, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(0, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaSimpleMejorCasoPilaNormalDeEnterosFuerzaBrutaDescendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El metodo de ordenamiento por Burbuja Simple de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo ajustar el orden de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-Se ajustó el orden de la pila vectorial como descendente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo de ordenamiento Burbuja Simple arrojo los siguientes datos: ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Elementos: 7. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Comparaciones: 21. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Intercambios: 0. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Inserciones: 0. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Llamados Recursivos: 0. ";
            int[] varVectorElementosEsperado = new int[10] { 10, 9, 8, 7, 6, 5, 4, 0, 0, 0 };
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(10);
            varMiPila.Apilar(4);
            varMiPila.Apilar(5);
            varMiPila.Apilar(6);
            varMiPila.Apilar(7);
            varMiPila.Apilar(8);
            varMiPila.Apilar(9);
            varMiPila.Apilar(10);

            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(21, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(0, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaSimpleMejorCasoPilaNormalDeEnterosFuerzaBrutaAscendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El metodo de ordenamiento por Burbuja Simple de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo ajustar el orden de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-Se ajustó el orden de la pila vectorial como ascendente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo de ordenamiento Burbuja Simple arrojo los siguientes datos: ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Elementos: 7. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Comparaciones: 21. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Intercambios: 0. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Inserciones: 0. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Llamados Recursivos: 0. ";
            int[] varVectorElementosEsperado = new int[10] { 4, 5, 6, 7, 8, 9, 10, 0, 0, 0 };
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(10);
            varMiPila.Apilar(10);
            varMiPila.Apilar(9);
            varMiPila.Apilar(8);
            varMiPila.Apilar(7);
            varMiPila.Apilar(6);
            varMiPila.Apilar(5);
            varMiPila.Apilar(4);
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(21, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(0, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaSimpleMejorCasoPilaLlenaDeObjetosInteligenteAscendente()
        {
            #region Inicializar
            //string varMensajeResultadoEsperado = "/r" + "-El metodo de ordenamiento por Burbuja Simple de pila vectorial ha tenido el siguiente problema:";
            //varMensajeResultadoEsperado += "/r" + "No debe ordenar, la pila vectorial ya está ordenada como ascendete.";
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] varVectorElementosEsperado = new clsPersona[5];
            varVectorElementosEsperado[4] = varObjCristina;
            varVectorElementosEsperado[3] = varObjMartin;
            varVectorElementosEsperado[2] = varObjEmilio;
            varVectorElementosEsperado[1] = varObjLucero;
            varVectorElementosEsperado[0] = varObjCarlos;
            clsPilaVector<clsPersona> varMiPila = new clsPilaVector<clsPersona>(5);
            varMiPila.Apilar(varObjCristina);
            varMiPila.Apilar(varObjMartin);
            varMiPila.Apilar(varObjEmilio);
            varMiPila.Apilar(varObjLucero);
            varMiPila.Apilar(varObjCarlos);
            varMiPila.AjustarOrdenColeccion("Ascendente");
            varMiPila.ponerMensajeUltimoMetodo("");
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar
            //Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(0, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(0, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaSimpleMejorCasoPilaLlenaDeObjetosInteligenteDescendente()
        {
            #region Inicializar
            //string varMensajeResultadoEsperado = "/r" + "-El metodo de ordenamiento por Burbuja Simple de pila vectorial ha tenido el siguiente problema:";
            //varMensajeResultadoEsperado += "/r" + "No debe ordenar, la pila vectorial ya está ordenada como ascendete.";
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] varVectorElementosEsperado = new clsPersona[5];
            varVectorElementosEsperado[0] = varObjCristina;
            varVectorElementosEsperado[1] = varObjMartin;
            varVectorElementosEsperado[2] = varObjEmilio;
            varVectorElementosEsperado[3] = varObjLucero;
            varVectorElementosEsperado[4] = varObjCarlos;
            clsPilaVector<clsPersona> varMiPila = new clsPilaVector<clsPersona>(5);
            varMiPila.Apilar(varObjCarlos);
            varMiPila.Apilar(varObjLucero);
            varMiPila.Apilar(varObjEmilio);
            varMiPila.Apilar(varObjMartin);
            varMiPila.Apilar(varObjCristina);
            varMiPila.AjustarOrdenColeccion("Descendente");
            varMiPila.ponerMensajeUltimoMetodo("");
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar
            //Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(0, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(0, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaSimpleMejorCasoPilaNormalDeObjetosFuerzaBrutaAscendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El metodo de ordenamiento por Burbuja Simple de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo ajustar el orden de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-Se ajustó el orden de la pila vectorial como ascendente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo de ordenamiento Burbuja Simple arrojo los siguientes datos: ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Elementos: 5. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Comparaciones: 10. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Intercambios: 0. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Inserciones: 0. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Llamados Recursivos: 0. ";
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] varVectorElementosEsperado = new clsPersona[10];
            varVectorElementosEsperado[0] = varObjCarlos;
            varVectorElementosEsperado[1] = varObjLucero;
            varVectorElementosEsperado[2] = varObjEmilio;
            varVectorElementosEsperado[3] = varObjMartin;
            varVectorElementosEsperado[4] = varObjCristina;
            clsPilaVector<clsPersona> varMiPila = new clsPilaVector<clsPersona>(10);
            varMiPila.Apilar(varObjCristina);
            varMiPila.Apilar(varObjMartin);
            varMiPila.Apilar(varObjEmilio);
            varMiPila.Apilar(varObjLucero);
            varMiPila.Apilar(varObjCarlos);
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(10, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(0, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaSimpleMejorCasoPilaNormalDeObjetosFuerzaBrutaDescendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El metodo de ordenamiento por Burbuja Simple de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo ajustar el orden de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-Se ajustó el orden de la pila vectorial como descendente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo de ordenamiento Burbuja Simple arrojo los siguientes datos: ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Elementos: 5. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Comparaciones: 10. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Intercambios: 0. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Inserciones: 0. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Llamados Recursivos: 0. ";
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] varVectorElementosEsperado = new clsPersona[10];
            varVectorElementosEsperado[0] = varObjCristina;
            varVectorElementosEsperado[1] = varObjMartin;
            varVectorElementosEsperado[2] = varObjEmilio;
            varVectorElementosEsperado[3] = varObjLucero;
            varVectorElementosEsperado[4] = varObjCarlos;
            clsPilaVector<clsPersona> varMiPila = new clsPilaVector<clsPersona>(10);
            varMiPila.Apilar(varObjCarlos);
            varMiPila.Apilar(varObjLucero);
            varMiPila.Apilar(varObjEmilio);
            varMiPila.Apilar(varObjMartin);
            varMiPila.Apilar(varObjCristina);
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(10, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(0, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaSimpleMejorCasoPilaNormalDeObjetosInteligenteAscendente()
        {
            #region Inicializar
            //string varMensajeResultadoEsperado = "/r" + "-El metodo de ordenamiento por Burbuja Simple de pila vectorial ha tenido el siguiente problema:";
            //varMensajeResultadoEsperado += "/r" + "No debe ordenar, la pila vectorial ya está ordenada como ascendete.";
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] varVectorElementosEsperado = new clsPersona[10];
            varVectorElementosEsperado[4] = varObjCristina;
            varVectorElementosEsperado[3] = varObjMartin;
            varVectorElementosEsperado[2] = varObjEmilio;
            varVectorElementosEsperado[1] = varObjLucero;
            varVectorElementosEsperado[0] = varObjCarlos;
            clsPilaVector<clsPersona> varMiPila = new clsPilaVector<clsPersona>(10);
            varMiPila.Apilar(varObjCristina);
            varMiPila.Apilar(varObjMartin);
            varMiPila.Apilar(varObjEmilio);
            varMiPila.Apilar(varObjLucero);
            varMiPila.Apilar(varObjCarlos);
            varMiPila.AjustarOrdenColeccion("Ascendente");
            varMiPila.ponerMensajeUltimoMetodo("");
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar
            //Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(0, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(0, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaSimpleMejorCasoPilaNormalDeObjetosInteligenteDescendente()
        {
            #region Inicializar
            //string varMensajeResultadoEsperado = "/r" + "-El metodo de ordenamiento por Burbuja Simple de pila vectorial ha tenido el siguiente problema:";
            //varMensajeResultadoEsperado += "/r" + "No debe ordenar, la pila vectorial ya está ordenada como ascendete.";
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] varVectorElementosEsperado = new clsPersona[10];
            varVectorElementosEsperado[0] = varObjCristina;
            varVectorElementosEsperado[1] = varObjMartin;
            varVectorElementosEsperado[2] = varObjEmilio;
            varVectorElementosEsperado[3] = varObjLucero;
            varVectorElementosEsperado[4] = varObjCarlos;
            clsPilaVector<clsPersona> varMiPila = new clsPilaVector<clsPersona>(10);
            varMiPila.Apilar(varObjCarlos);
            varMiPila.Apilar(varObjLucero);
            varMiPila.Apilar(varObjEmilio);
            varMiPila.Apilar(varObjMartin);
            varMiPila.Apilar(varObjCristina);
            varMiPila.AjustarOrdenColeccion("Descendente");
            varMiPila.ponerMensajeUltimoMetodo("");
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar
            //Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(0, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(0, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        #endregion
        #endregion
        #region TestBurbujaMejorada
        #region CasoConstante
        [TestMethod]
         public void testOrdenarBurbujaMejoradoCasoConstantePilaNormalDeEnterosFuerzaBrutaAscendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El metodo de ordenamiento por Burbuja Mejorado de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado+= "/r" + "-El metodo ajustar el orden de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado+= "/r" + "-Se ajustó el orden de la pila vectorial como ascendente. ";
            varMensajeResultadoEsperado+= "/r" + "-El metodo de ordenamiento Burbuja Simple arrojo los siguientes datos: ";
            varMensajeResultadoEsperado+= "/r" + "--Numero de Elementos: 7. ";
            varMensajeResultadoEsperado+= "/r" + "--Numero de Comparaciones: 6. ";
            varMensajeResultadoEsperado+= "/r" + "--Numero de Intercambios: 0. ";
            varMensajeResultadoEsperado+= "/r" + "--Numero de Inserciones: 0. ";
            varMensajeResultadoEsperado+= "/r" + "--Numero de Llamados Recursivos: 0. ";

            int[] varVectorElementosEsperado=new int[10]{1,1,1,1,1,1,1,0,0,0};
            clsPilaVector<int> varMiPila= new clsPilaVector<int>(10);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaMejorado(false);
            #endregion
            #region Comprobar
          Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(6, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(0, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            
            #endregion
        }
        [TestMethod]
         public void testOrdenarBurbujaMejoradoCasoConstantePilaNormalDeEnterosInteligentesAscendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El metodo de ordenamiento por Burbuja Mejorado de pila vectorial ha tenido el siguiente problema: ";
            varMensajeResultadoEsperado+= "/r" + "-No debe ordenar, la pila vectorial ya está ordenada como ascendente.";
            int[] varVectorElementosEsperado=new int[10]{1,1,1,1,1,1,1,0,0,0};
            clsPilaVector<int> varMiPila= new clsPilaVector<int>(10);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.Apilar(1);
            varMiPila.AjustarOrdenColeccion("Constante");
            varMiPila.ponerMensajeUltimoMetodo("");
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaMejorado(false);
            #endregion
            #region Comprobar
           Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(0, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(0, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            
            #endregion
        }

        #endregion
        #region Caso Promedio
        [TestMethod]
        public void testOrdenarBurbujaMejoradoCasoPromedioPilaLlenaDeEnterosAscendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El método de ordenamiento por Burbuja Mejorado de pila vectorial ha finalizado correctamente.";
            varMensajeResultadoEsperado += "/r" + "-El método ajustar el orden de pila vectorial ha finalizado correctamente.";
            varMensajeResultadoEsperado += "/r" + "-Se ajustó el orden de la pila vectorial como ascendente.";
            varMensajeResultadoEsperado += "/r" + "-El Método de Ordenamiento Burbuja Mejorado arrojó los siguientes datos:";
            varMensajeResultadoEsperado += "/r" + "--Número de Elementos:10.";
            varMensajeResultadoEsperado += "/r" + "--Número de Comparaciones:35.";
            varMensajeResultadoEsperado += "/r" + "--Número de Intercambios:20.";
            varMensajeResultadoEsperado += "/r" + "--Número de Inserciones:0.";
            varMensajeResultadoEsperado += "/r" + "--Número de Llamados Recursivos:0.";
            int[] varVectorElementosEsperado = new int[10] { -10, -8, -6, -4, -2, 1, 3, 5, 7, 9 };
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(10);
            varMiPila.Apilar(1);
            varMiPila.Apilar(-2);
            varMiPila.Apilar(3);
            varMiPila.Apilar(-4);
            varMiPila.Apilar(5);
            varMiPila.Apilar(-6);
            varMiPila.Apilar(7);
            varMiPila.Apilar(-8);
            varMiPila.Apilar(9);
            varMiPila.Apilar(-10);
            varMiPila.AjustarOrdenColeccion("Aleatorio");
            varMiPila.ponerMensajeUltimoMetodo("");
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaMejorado(false);
            #endregion
            #region Comprobar
            ///Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(35, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(20, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoCasoPromedioPilaLlenaDeEnterosDescendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El método de ordenamiento por Burbuja Mejorado de pila vectorial ha finalizado correctamente.";
            varMensajeResultadoEsperado += "/r" + "-El método ajustar el orden de pila vectorial ha finalizado correctamente.";
            varMensajeResultadoEsperado += "/r" + "-Se ajustó el orden de la pila vectorial como descendente.";
            varMensajeResultadoEsperado += "/r" + "-El Método de Ordenamiento Burbuja Mejorado arrojó los siguientes datos:";
            varMensajeResultadoEsperado += "/r" + "--Número de Elementos:10.";
            varMensajeResultadoEsperado += "/r" + "--Número de Comparaciones:39.";
            varMensajeResultadoEsperado += "/r" + "--Número de Intercambios:25.";
            varMensajeResultadoEsperado += "/r" + "--Número de Inserciones:0.";
            varMensajeResultadoEsperado += "/r" + "--Número de Llamados Recursivos:0.";
            int[] varVectorElementosEsperado = new int[10] { 9, 7, 5, 3, 1, -2, -4, -6, -8, -10 };
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(10);
            varMiPila.Apilar(1);
            varMiPila.Apilar(-2);
            varMiPila.Apilar(3);
            varMiPila.Apilar(-4);
            varMiPila.Apilar(5);
            varMiPila.Apilar(-6);
            varMiPila.Apilar(7);
            varMiPila.Apilar(-8);
            varMiPila.Apilar(9);
            varMiPila.Apilar(-10);
            varMiPila.AjustarOrdenColeccion("Aleatorio");
            varMiPila.ponerMensajeUltimoMetodo("");
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaMejorado(true);
            #endregion
            #region Comprobar
            ///Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(39, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(25, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoCasoPromedioPilaLlenaDeObjetosAscendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El método de ordenamiento por Burbuja Mejorado de pila vectorial ha finalizado correctamente.";
            varMensajeResultadoEsperado += "/r" + "-El método ajustar el orden de pila vectorial ha finalizado correctamente.";
            varMensajeResultadoEsperado += "/r" + "-Se ajustó el orden de la pila vectorial como descendente.";
            varMensajeResultadoEsperado += "/r" + "-El Método de Ordenamiento Burbuja Mejorado arrojó los siguientes datos:";
            varMensajeResultadoEsperado += "/r" + "--Número de Elementos:5.";
            varMensajeResultadoEsperado += "/r" + "--Número de Comparaciones:9.";
            varMensajeResultadoEsperado += "/r" + "--Número de Intercambios:4.";
            varMensajeResultadoEsperado += "/r" + "--Número de Inserciones:0.";
            varMensajeResultadoEsperado += "/r" + "--Número de Llamados Recursivos:0.";
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] varVectorElementosEsperado = new clsPersona[5];
            varVectorElementosEsperado[4] = varObjCristina;
            varVectorElementosEsperado[3] = varObjMartin;
            varVectorElementosEsperado[2] = varObjEmilio;
            varVectorElementosEsperado[1] = varObjLucero;
            varVectorElementosEsperado[0] = varObjCarlos;
            clsPilaVector<clsPersona> varMiPila = new clsPilaVector<clsPersona>(5);
            varMiPila.Apilar(varObjMartin);
            varMiPila.Apilar(varObjCristina);
            varMiPila.Apilar(varObjCarlos);
            varMiPila.Apilar(varObjLucero);
            varMiPila.Apilar(varObjEmilio);
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaMejorado(false);
            #endregion
            #region Comprobar
            ///Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(9, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(4, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoCasoPromedioPilaLlenaDeObjetosDescendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El método de ordenamiento por Burbuja Mejorado de pila vectorial ha finalizado correctamente.";
            varMensajeResultadoEsperado += "/r" + "-El método ajustar el orden de pila vectorial ha finalizado correctamente.";
            varMensajeResultadoEsperado += "/r" + "-Se ajustó el orden de la pila vectorial como descendente.";
            varMensajeResultadoEsperado += "/r" + "-El Método de Ordenamiento Burbuja Mejorado arrojó los siguientes datos:";
            varMensajeResultadoEsperado += "/r" + "--Número de Elementos:5.";
            varMensajeResultadoEsperado += "/r" + "--Número de Comparaciones:10.";
            varMensajeResultadoEsperado += "/r" + "--Número de Intercambios:6.";
            varMensajeResultadoEsperado += "/r" + "--Número de Inserciones:0.";
            varMensajeResultadoEsperado += "/r" + "--Número de Llamados Recursivos:0.";
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] varVectorElementosEsperado = new clsPersona[5];
            varVectorElementosEsperado[0] = varObjCristina;
            varVectorElementosEsperado[1] = varObjMartin;
            varVectorElementosEsperado[2] = varObjEmilio;
            varVectorElementosEsperado[3] = varObjLucero;
            varVectorElementosEsperado[4] = varObjCarlos;
            clsPilaVector<clsPersona> varMiPila = new clsPilaVector<clsPersona>(5);
            varMiPila.Apilar(varObjMartin);
            varMiPila.Apilar(varObjCristina);
            varMiPila.Apilar(varObjCarlos);
            varMiPila.Apilar(varObjLucero);
            varMiPila.Apilar(varObjEmilio);
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaMejorado(true);
            #endregion
            #region Comprobar
            ///Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(10, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(6, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoCasoPromedioPilaNormalDeEnterosAscendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El método de ordenamiento por Burbuja Mejorado de pila vectorial ha finalizado correctamente.";
            varMensajeResultadoEsperado += "/r" + "-El método ajustar el orden de pila vectorial ha finalizado correctamente.";
            varMensajeResultadoEsperado += "/r" + "-Se ajustó el orden de la pila vectorial como ascendente.";
            varMensajeResultadoEsperado += "/r" + "-El Método de Ordenamiento Burbuja Mejorado arrojó los siguientes datos:";
            varMensajeResultadoEsperado += "/r" + "--Número de Elementos:7.";
            varMensajeResultadoEsperado += "/r" + "--Número de Comparaciones:20.";
            varMensajeResultadoEsperado += "/r" + "--Número de Intercambios:17.";
            varMensajeResultadoEsperado += "/r" + "--Número de Inserciones:0.";
            varMensajeResultadoEsperado += "/r" + "--Número de Llamados Recursivos:0.";
            int[] varVectorElementosEsperado = new int[10] { -4, -2, 1, 3, 5, 7, 9, 0, 0, 0 };
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(10);
            varMiPila.Apilar(1);
            varMiPila.Apilar(-2);
            varMiPila.Apilar(3);
            varMiPila.Apilar(-4);
            varMiPila.Apilar(5);
            varMiPila.Apilar(7);
            varMiPila.Apilar(9);
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaMejorado(false);
            #endregion
            #region Comprobar
            ///Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(20, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(17, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoCasoPromedioPilaNormalDeEnterosDescendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El método de ordenamiento por Burbuja Mejorado de pila vectorial ha finalizado correctamente.";
            varMensajeResultadoEsperado += "/r" + "-El método ajustar el orden de pila vectorial ha finalizado correctamente.";
            varMensajeResultadoEsperado += "/r" + "-Se ajustó el orden de la pila vectorial como descendente.";
            varMensajeResultadoEsperado += "/r" + "-El Método de Ordenamiento Burbuja Mejorado arrojó los siguientes datos:";
            varMensajeResultadoEsperado += "/r" + "--Número de Elementos:7.";
            varMensajeResultadoEsperado += "/r" + "--Número de Comparaciones:15.";
            varMensajeResultadoEsperado += "/r" + "--Número de Intercambios:4.";
            varMensajeResultadoEsperado += "/r" + "--Número de Inserciones:0.";
            varMensajeResultadoEsperado += "/r" + "--Número de Llamados Recursivos:0.";
            int[] varVectorElementosEsperado = new int[10] { 9, 7, 5, 3, 1, -2, -4, 0, 0, 0 };
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(10);
            varMiPila.Apilar(1);
            varMiPila.Apilar(-2);
            varMiPila.Apilar(3);
            varMiPila.Apilar(-4);
            varMiPila.Apilar(5);
            varMiPila.Apilar(7);
            varMiPila.Apilar(9);
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaMejorado(true);
            #endregion
            #region Comprobar
            ///Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(15, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(4, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoCasoPromedioPilaNormalDeObjetosAscendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El método de ordenamiento por Burbuja Mejorado de pila vectorial ha finalizado correctamente.";
            varMensajeResultadoEsperado += "/r" + "-El método ajustar el orden de pila vectorial ha finalizado correctamente.";
            varMensajeResultadoEsperado += "/r" + "-Se ajustó el orden de la pila vectorial como ascendente.";
            varMensajeResultadoEsperado += "/r" + "-El Método de Ordenamiento Burbuja Mejorado arrojó los siguientes datos:";
            varMensajeResultadoEsperado += "/r" + "--Número de Elementos:5.";
            varMensajeResultadoEsperado += "/r" + "--Número de Comparaciones:9.";
            varMensajeResultadoEsperado += "/r" + "--Número de Intercambios:4.";
            varMensajeResultadoEsperado += "/r" + "--Número de Inserciones:0.";
            varMensajeResultadoEsperado += "/r" + "--Número de Llamados Recursivos:0.";
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] varVectorElementosEsperado = new clsPersona[10];
            varVectorElementosEsperado[4] = varObjCristina;
            varVectorElementosEsperado[3] = varObjMartin;
            varVectorElementosEsperado[2] = varObjEmilio;
            varVectorElementosEsperado[1] = varObjLucero;
            varVectorElementosEsperado[0] = varObjCarlos;
            clsPilaVector<clsPersona> varMiPila = new clsPilaVector<clsPersona>(10);
            varMiPila.Apilar(varObjMartin);
            varMiPila.Apilar(varObjCristina);
            varMiPila.Apilar(varObjCarlos);
            varMiPila.Apilar(varObjLucero);
            varMiPila.Apilar(varObjEmilio);
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaMejorado(false);
            #endregion
            #region Comprobar
            ///Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(9, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(4, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoCasoPromedioPilaNormalDeObjetosDescendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El método de ordenamiento por Burbuja Mejorado de pila vectorial ha finalizado correctamente.";
            varMensajeResultadoEsperado += "/r" + "-El método ajustar el orden de pila vectorial ha finalizado correctamente.";
            varMensajeResultadoEsperado += "/r" + "-Se ajustó el orden de la pila vectorial como descendente.";
            varMensajeResultadoEsperado += "/r" + "-El Método de Ordenamiento Burbuja Mejorado arrojó los siguientes datos:";
            varMensajeResultadoEsperado += "/r" + "--Número de Elementos:5.";
            varMensajeResultadoEsperado += "/r" + "--Número de Comparaciones:10.";
            varMensajeResultadoEsperado += "/r" + "--Número de Intercambios:6.";
            varMensajeResultadoEsperado += "/r" + "--Número de Inserciones:0.";
            varMensajeResultadoEsperado += "/r" + "--Número de Llamados Recursivos:0.";
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] varVectorElementosEsperado = new clsPersona[10];
            varVectorElementosEsperado[0] = varObjCristina;
            varVectorElementosEsperado[1] = varObjMartin;
            varVectorElementosEsperado[2] = varObjEmilio;
            varVectorElementosEsperado[3] = varObjLucero;
            varVectorElementosEsperado[4] = varObjCarlos;
            clsPilaVector<clsPersona> varMiPila = new clsPilaVector<clsPersona>(10);
            varMiPila.Apilar(varObjMartin);
            varMiPila.Apilar(varObjCristina);
            varMiPila.Apilar(varObjCarlos);
            varMiPila.Apilar(varObjLucero);
            varMiPila.Apilar(varObjEmilio);
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaMejorado(true);
            #endregion
            #region Comprobar
            ///Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(10, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(6, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        #endregion
        #region CasoVacia
        [TestMethod]
        public void testOrdenarBurbujaMejoradoPilaVaciaDeEnterosAscendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El metodo de ordenamiento por Burbuja Mejorado de pila vectorial ha tenido el siguiente problema: ";
            varMensajeResultadoEsperado += "La pila vectorial está vacía.";

            clsPilaVector<int> varMiPila = new clsPilaVector<int>();
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaMejorado(false);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaDescendente());
            Assert.AreEqual(0, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(0, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoPilaVaciaDeEnterosDescendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El metodo de ordenamiento por Burbuja Mejorado de pila vectorial ha tenido el siguiente problema: ";
            varMensajeResultadoEsperado += "La pila vectorial está vacía.";
            clsPilaVector<int> varMiPila = new clsPilaVector<int>();
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaMejorado(true);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaDescendente());
            Assert.AreEqual(0, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(0, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoPilaVaciaDeObjetosAscendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El metodo de ordenamiento por Burbuja Mejorado de pila vectorial ha tenido el siguiente problema: ";
            varMensajeResultadoEsperado += "La pila vectorial está vacía.";

            clsPilaVector<int> varMiPila = new clsPilaVector<int>();
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaMejorado(false);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaDescendente());
            Assert.AreEqual(0, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(0, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoPilaVaciaDeObjetosDescendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El metodo de ordenamiento por Burbuja Mejorado de pila vectorial ha tenido el siguiente problema: ";
            varMensajeResultadoEsperado += "La pila vectorial está vacía.";
            clsPilaVector<clsPersona> varMiPila = new clsPilaVector<clsPersona>();
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaMejorado(true);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaDescendente());
            Assert.AreEqual(0, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(0, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        #endregion
        #region MejorCaso
        [TestMethod]
        public void testOrdenarBurbujaMejoradoMejorCasoPilaLlenaDeEnterosInteligenteAscendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El método de ordenamiento por Burbuja Mejorado de pila vectorial ha tenido el siguiente problema:";
            varMensajeResultadoEsperado += "/r" + "-No debe ordenar, la pila vectorial ya está ordenada como ascendente.";
            int[] varVectorElementosEsperado = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(10);
            varMiPila.Apilar(10);
            varMiPila.Apilar(9);
            varMiPila.Apilar(8);
            varMiPila.Apilar(7);
            varMiPila.Apilar(6);
            varMiPila.Apilar(5);
            varMiPila.Apilar(4);
            varMiPila.Apilar(3);
            varMiPila.Apilar(2);
            varMiPila.Apilar(1);
            varMiPila.AjustarOrdenColeccion("Ascendente");
            varMiPila.ponerMensajeUltimoMetodo("");
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaMejorado(false);
            #endregion
            #region Comprobar
            ///Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(0, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(0, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoMejorCasoPilaLlenaDeEnterosInteligenteDescendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El método de ordenamiento por Burbuja Mejorado de pila vectorial ha tenido el siguiente problema:";
            varMensajeResultadoEsperado += "/r" + "-No debe ordenar, la pila vectorial ya está ordenada como descendente.";
            int[] varVectorElementosEsperado = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(10);
            varMiPila.Apilar(1);
            varMiPila.Apilar(2);
            varMiPila.Apilar(3);
            varMiPila.Apilar(4);
            varMiPila.Apilar(5);
            varMiPila.Apilar(6);
            varMiPila.Apilar(7);
            varMiPila.Apilar(8);
            varMiPila.Apilar(9);
            varMiPila.Apilar(10);
            varMiPila.AjustarOrdenColeccion("Descendente");
            varMiPila.ponerMensajeUltimoMetodo("");
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaMejorado(true);
            #endregion
            #region Comprobar
            ///Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(0, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(0, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoMejorCasoPilaNormalDeEnterosFuerzaBrutaDescendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El método de ordenamiento por Burbuja Mejorado de pila vectorial ha finalizado correctamente.";
            varMensajeResultadoEsperado += "/r" + "-El método ajustar el orden de pila vectorial ha finalizado correctamente.";
            varMensajeResultadoEsperado += "/r" + "-Se ajustó el orden de la pila vectorial como descendente.";
            varMensajeResultadoEsperado += "/r" + "-El Método de Ordenamiento Burbuja Mejorado arrojó los siguientes datos:";
            varMensajeResultadoEsperado += "/r" + "--Número de Elementos:7.";
            varMensajeResultadoEsperado += "/r" + "--Número de Comparaciones:6.";
            varMensajeResultadoEsperado += "/r" + "--Número de Intercambios:0.";
            varMensajeResultadoEsperado += "/r" + "--Número de Inserciones:0.";
            varMensajeResultadoEsperado += "/r" + "--Número de Llamados Recursivos:0.";
            int[] varVectorElementosEsperado = new int[10] { 10, 9, 8, 7, 6, 5, 4, 0, 0, 0 };
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(10);
            varMiPila.Apilar(4);
            varMiPila.Apilar(5);
            varMiPila.Apilar(6);
            varMiPila.Apilar(7);
            varMiPila.Apilar(8);
            varMiPila.Apilar(9);
            varMiPila.Apilar(10);
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaMejorado(true);
            #endregion
            #region Comprobar
            ///Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(6, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(0, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoMejorCasoPilaNormalDeEnterosInteligenteAscendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El método de ordenamiento por Burbuja Mejorado de pila vectorial ha tenido el siguiente problema:";
            varMensajeResultadoEsperado += "/r" + "-No debe ordenar, la pila vectorial ya está ordenada como ascendente.";
            int[] varVectorElementosEsperado = new int[10] { 4, 5, 6, 7, 8, 9, 10, 0, 0, 0 };
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(10);
            varMiPila.Apilar(10);
            varMiPila.Apilar(9);
            varMiPila.Apilar(8);
            varMiPila.Apilar(7);
            varMiPila.Apilar(6);
            varMiPila.Apilar(5);
            varMiPila.Apilar(4);
            varMiPila.AjustarOrdenColeccion("Ascendente");
            varMiPila.ponerMensajeUltimoMetodo("");
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaMejorado(false);
            #endregion
            #region Comprobar
            ///Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(0, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(0, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoMejorCasoPilaNormalDeEnterosInteligenteDescendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El método de ordenamiento por Burbuja Mejorado de pila vectorial ha tenido el siguiente problema:";
            varMensajeResultadoEsperado += "/r" + "-No debe ordenar, la pila vectorial ya está ordenada como descendente.";
            int[] varVectorElementosEsperado = new int[10] { 10, 9, 8, 7, 6, 5, 4, 0, 0, 0 };
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(10);
            varMiPila.Apilar(4);
            varMiPila.Apilar(5);
            varMiPila.Apilar(6);
            varMiPila.Apilar(7);
            varMiPila.Apilar(8);
            varMiPila.Apilar(9);
            varMiPila.Apilar(10);
            varMiPila.AjustarOrdenColeccion("Descendente");
            varMiPila.ponerMensajeUltimoMetodo("");
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaMejorado(true);
            #endregion
            #region Comprobar
            ///Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(0, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(0, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoMejorCasoPilaNormalDeObjetosFuerzaBrutaDescendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El método de ordenamiento por Burbuja Mejorado de pila vectorial ha finalizado correctamente.";
            varMensajeResultadoEsperado += "/r" + "-El método ajustar el orden de pila vectorial ha finalizado correctamente.";
            varMensajeResultadoEsperado += "/r" + "-Se ajustó el orden de la pila vectorial como descendente.";
            varMensajeResultadoEsperado += "/r" + "-El Método de Ordenamiento Burbuja Mejorado arrojó los siguientes datos:";
            varMensajeResultadoEsperado += "/r" + "--Número de Elementos:5.";
            varMensajeResultadoEsperado += "/r" + "--Número de Comparaciones:4.";
            varMensajeResultadoEsperado += "/r" + "--Número de Intercambios:0.";
            varMensajeResultadoEsperado += "/r" + "--Número de Inserciones:0.";
            varMensajeResultadoEsperado += "/r" + "--Número de Llamados Recursivos:0.";
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] varVectorElementosEsperado = new clsPersona[10];
            varVectorElementosEsperado[0] = varObjCristina;
            varVectorElementosEsperado[1] = varObjMartin;
            varVectorElementosEsperado[2] = varObjEmilio;
            varVectorElementosEsperado[3] = varObjLucero;
            varVectorElementosEsperado[4] = varObjCarlos;
            clsPilaVector<clsPersona> varMiPila = new clsPilaVector<clsPersona>(10);
            varMiPila.Apilar(varObjCarlos);
            varMiPila.Apilar(varObjLucero);
            varMiPila.Apilar(varObjEmilio);
            varMiPila.Apilar(varObjMartin);
            varMiPila.Apilar(varObjCristina);
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaMejorado(true);
            #endregion
            #region Comprobar
            ///Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(4, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(0, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoMejorCasoPilaNormalDeObjetosInteligenteDescendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El método de ordenamiento por Burbuja Mejorado de pila vectorial ha tenido el siguiente problema.";
            varMensajeResultadoEsperado += "/r" + "-No debe ordenar, la pila vectorial ya está ordenada como descendente.";
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] varVectorElementosEsperado = new clsPersona[10];
            varVectorElementosEsperado[0] = varObjCristina;
            varVectorElementosEsperado[1] = varObjMartin;
            varVectorElementosEsperado[2] = varObjEmilio;
            varVectorElementosEsperado[3] = varObjLucero;
            varVectorElementosEsperado[4] = varObjCarlos;
            clsPilaVector<clsPersona> varMiPila = new clsPilaVector<clsPersona>(10);
            varMiPila.Apilar(varObjCarlos);
            varMiPila.Apilar(varObjLucero);
            varMiPila.Apilar(varObjEmilio);
            varMiPila.Apilar(varObjMartin);
            varMiPila.Apilar(varObjCristina);
            varMiPila.AjustarOrdenColeccion("Descendente");
            varMiPila.ponerMensajeUltimoMetodo("");
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaMejorado(true);
            #endregion
            #region Comprobar
            ///Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(0, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(0, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
    
        public void testOrdenarInsercionMejorCasoPilaNormalDeObjetosFuerzaBrutaAscendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El método de ordenamiento por Insercion de pila vectorial ha finalizado correctamente.";
            varMensajeResultadoEsperado += "/r" + "-El método ajustar el orden de pila vectorial ha finalizado correctamente.";
            varMensajeResultadoEsperado += "/r" + "-Se ajustó el orden de la pila vectorial como ascendente.";
            varMensajeResultadoEsperado += "/r" + "-El Método de Ordenamiento Burbuja Mejorado arrojó los siguientes datos:";
            varMensajeResultadoEsperado += "/r" + "--Número de Elementos:5.";
            varMensajeResultadoEsperado += "/r" + "--Número de Comparaciones:4.";
            varMensajeResultadoEsperado += "/r" + "--Número de Intercambios:0.";
            varMensajeResultadoEsperado += "/r" + "--Número de Inserciones:4.";
            varMensajeResultadoEsperado += "/r" + "--Número de Llamados Recursivos:0.";
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] varVectorElementosEsperado = new clsPersona[10];
            varVectorElementosEsperado[4] = varObjCristina;
            varVectorElementosEsperado[3] = varObjMartin;
            varVectorElementosEsperado[2] = varObjEmilio;
            varVectorElementosEsperado[1] = varObjLucero;
            varVectorElementosEsperado[0] = varObjCarlos;
            clsPilaVector<clsPersona> varMiPila = new clsPilaVector<clsPersona>(10);
            varMiPila.Apilar(varObjCristina);
            varMiPila.Apilar(varObjMartin);
            varMiPila.Apilar(varObjEmilio);
            varMiPila.Apilar(varObjLucero);
            varMiPila.Apilar(varObjCarlos);
            #endregion
            #region Probar
            varMiPila.OrdenarInsercion(false);
            #endregion
            #region Comprobar
            ///Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(4, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(0, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(4, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        
        #endregion
        #region PeorCaso
         #region Peor Caso
        [TestMethod]
        public void testOrdenarBurbujaMejoradoPeorCasoPilaNormalDeEnteroAscendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El metodo de ordenamiento por Burbuja Mejorado de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo ajustar el orden de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-Se ajustó el orden de la pila vectorial como ascendente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo de ordenamiento Burbuja Simple arrojo los siguientes datos: ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Elementos: 7. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Comparaciones: 21. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Intercambios: 21. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Inserciones: 0. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Llamados Recursivos: 0. ";
            int[] varVectorElementosEsperado = new int[10] { 1, 2, 3, 4, 5, 6, 7, 0, 0, 0 };
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(10);
            varMiPila.Apilar(1);
            varMiPila.Apilar(2);
            varMiPila.Apilar(3);
            varMiPila.Apilar(4);
            varMiPila.Apilar(5);
            varMiPila.Apilar(6);
            varMiPila.Apilar(7);

            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaMejorado(false);
            #endregion
            #region Comprobar
            //    Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(21, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(21, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoPeorCasoPilaNormalDeEnteroDescendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El metodo de ordenamiento por Burbuja Mejorado de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo ajustar el orden de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-Se ajustó el orden de la pila vectorial como descendente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo de ordenamiento Burbuja Simple arrojo los siguientes datos: ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Elementos: 7. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Comparaciones: 21. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Intercambios: 21. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Inserciones: 0. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Llamados Recursivos: 0. ";
            int[] varVectorElementosEsperado = new int[10] { 7, 6, 5, 4, 3, 2, 1, 0, 0, 0 };
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(10);
            varMiPila.Apilar(7);
            varMiPila.Apilar(6);
            varMiPila.Apilar(5);
            varMiPila.Apilar(4);
            varMiPila.Apilar(3);
            varMiPila.Apilar(2);
            varMiPila.Apilar(1);
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar
            //  Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(21, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(21, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoPeorCasoPilaLlenaDeEnteroAscendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El metodo de ordenamiento por Burbuja Mejorado de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo ajustar el orden de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-Se ajustó el orden de la pila vectorial como ascendente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo de ordenamiento Burbuja Simple arrojo los siguientes datos: ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Elementos: 10. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Comparaciones: 45. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Intercambios: 45. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Inserciones: 0. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Llamados Recursivos: 0. ";
            int[] varVectorElementosEsperado = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(10);
            varMiPila.Apilar(1);
            varMiPila.Apilar(2);
            varMiPila.Apilar(3);
            varMiPila.Apilar(4);
            varMiPila.Apilar(5);
            varMiPila.Apilar(6);
            varMiPila.Apilar(7);
            varMiPila.Apilar(8);
            varMiPila.Apilar(9);
            varMiPila.Apilar(10);
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaMejorado(false);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(45, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(45, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoPeorCasoPilaLlenaDeEnteroDescendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El metodo de ordenamiento por Burbuja Mejorado de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo ajustar el orden de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-Se ajustó el orden de la pila vectorial como descendente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo de ordenamiento Burbuja Simple arrojo los siguientes datos: ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Elementos: 10. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Comparaciones: 45. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Intercambios: 45. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Inserciones: 0. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Llamados Recursivos: 0. ";
            int[] varVectorElementosEsperado = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(10);
            varMiPila.Apilar(10);
            varMiPila.Apilar(9);
            varMiPila.Apilar(8);
            varMiPila.Apilar(7);
            varMiPila.Apilar(6);
            varMiPila.Apilar(5);
            varMiPila.Apilar(4);
            varMiPila.Apilar(3);
            varMiPila.Apilar(2);
            varMiPila.Apilar(1);
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaMejorado(true);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(45, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(45, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoPeorCasoPilaNormalDeObjetosAscendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El metodo de ordenamiento por Burbuja Mejorado de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo ajustar el orden de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-Se ajustó el orden de la pila vectorial como ascendente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo de ordenamiento Burbuja Simple arrojo los siguientes datos: ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Elementos: 5. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Comparaciones: 10. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Intercambios: 10. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Inserciones: 0. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Llamados Recursivos: 0. ";
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] varVectorElementosEsperado = new clsPersona[10];
            varVectorElementosEsperado[0] = varObjCarlos;
            varVectorElementosEsperado[1] = varObjLucero;
            varVectorElementosEsperado[2] = varObjEmilio;
            varVectorElementosEsperado[3] = varObjMartin;
            varVectorElementosEsperado[4] = varObjCristina;
            clsPilaVector<clsPersona> varMiPila = new clsPilaVector<clsPersona>(10);
            varMiPila.Apilar(varObjCarlos);
            varMiPila.Apilar(varObjLucero);
            varMiPila.Apilar(varObjEmilio);
            varMiPila.Apilar(varObjMartin);
            varMiPila.Apilar(varObjCristina);
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaMejorado(false);
            #endregion
            #region Comprobar
            ///Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(10, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(10, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoPeorCasoPilaNormalDeObjetosDescendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El metodo de ordenamiento por Burbuja Mejorado de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo ajustar el orden de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-Se ajustó el orden de la pila vectorial como descendente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo de ordenamiento Burbuja Simple arrojo los siguientes datos: ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Elementos: 5. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Comparaciones: 10. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Intercambios: 10. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Inserciones: 0. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Llamados Recursivos: 0. ";
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martín", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] varVectorElementosEsperado = new clsPersona[10];
            varVectorElementosEsperado[4] = varObjCarlos;
            varVectorElementosEsperado[3] = varObjLucero;
            varVectorElementosEsperado[2] = varObjEmilio;
            varVectorElementosEsperado[1] = varObjMartin;
            varVectorElementosEsperado[0] = varObjCristina;
            clsPilaVector<clsPersona> varMiPila = new clsPilaVector<clsPersona>(10);
            varMiPila.Apilar(varObjCristina);
            varMiPila.Apilar(varObjMartin);
            varMiPila.Apilar(varObjEmilio);
            varMiPila.Apilar(varObjLucero);
            varMiPila.Apilar(varObjCarlos);
            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaMejorado(true);
            #endregion
            #region Comprobar
            ///Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(10, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(10, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoPeorCasoPilaLlenaDeObjetosDescendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El metodo de ordenamiento por Burbuja Mejorado de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo ajustar el orden de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-Se ajustó el orden de la pila vectorial como descendente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo de ordenamiento Burbuja Simple arrojo los siguientes datos: ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Elementos: 5. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Comparaciones: 10. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Intercambios: 10. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Inserciones: 0. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Llamados Recursivos: 0. ";
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martin", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] varVectorElementosEsperado = new clsPersona[5];
            varVectorElementosEsperado[0] = varObjCristina;
            varVectorElementosEsperado[1] = varObjMartin;
            varVectorElementosEsperado[2] = varObjEmilio;
            varVectorElementosEsperado[3] = varObjLucero;
            varVectorElementosEsperado[4] = varObjCarlos;
            clsPilaVector<clsPersona> varMiPila = new clsPilaVector<clsPersona>(5);
            varMiPila.Apilar(varObjCristina);
            varMiPila.Apilar(varObjMartin);
            varMiPila.Apilar(varObjEmilio);
            varMiPila.Apilar(varObjLucero);
            varMiPila.Apilar(varObjCarlos);

            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaMejorado(true);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(10, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(10, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoPeorCasoPilaLlenaDeObjetosAscendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El metodo de ordenamiento por Burbuja Mejorado de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo ajustar el orden de pila vectorial ha finalizado correctamente. ";
            varMensajeResultadoEsperado += "/r" + "-Se ajustó el orden de la pila vectorial como ascendente. ";
            varMensajeResultadoEsperado += "/r" + "-El metodo de ordenamiento Burbuja Simple arrojo los siguientes datos: ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Elementos: 5. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Comparaciones: 10. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Intercambios: 10. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Inserciones: 0. ";
            varMensajeResultadoEsperado += "/r" + "--Numero de Llamados Recursivos: 0. ";
            clsPersona varObjCristina = new clsPersona(3, "Cristina", 40);
            clsPersona varObjMartin = new clsPersona(1, "Martin", 25);
            clsPersona varObjEmilio = new clsPersona(4, "Emilio", 5);
            clsPersona varObjLucero = new clsPersona(2, "Lucero", 3);
            clsPersona varObjCarlos = new clsPersona(0, "Carlos", 1);
            clsPersona[] varVectorElementosEsperado = new clsPersona[5];
            varVectorElementosEsperado[0] = varObjCarlos;
            varVectorElementosEsperado[1] = varObjLucero;
            varVectorElementosEsperado[2] = varObjEmilio;
            varVectorElementosEsperado[3] = varObjMartin;
            varVectorElementosEsperado[4] = varObjCristina;
            clsPilaVector<clsPersona> varMiPila = new clsPilaVector<clsPersona>(5);
            varMiPila.Apilar(varObjCarlos);
            varMiPila.Apilar(varObjLucero);
            varMiPila.Apilar(varObjEmilio);
            varMiPila.Apilar(varObjMartin);
            varMiPila.Apilar(varObjCristina);

            #endregion
            #region Probar
            varMiPila.OrdenarBurbujaMejorado(false);
            #endregion
            #region Comprobar
            Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(10, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(10, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        #endregion
        #endregion
        #endregion
        #region TestQuickSort
            [TestMethod]
        public void testOrdenarQuickSortCasoConstantePilaLlenaDeObjetosInteligenteAscendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El metodo de ordenamiento por Quick Sort de pila vectorial ha tenido el siguiente problema: ";
            varMensajeResultadoEsperado+= "/r" + "-No debe ordenar, la pila vectorial ya está ordenada como ascendente.";
            clsPersona varObjCristina = new clsPersona(3,"Cristina",40);
            clsPersona varObjMartin = new clsPersona(1,"Martin",40);
            clsPersona varObjEmilio = new clsPersona(4,"Emilio",40);
            clsPersona varObjLucero = new clsPersona(2,"Lucero",40);
            clsPersona varObjCarlos = new clsPersona(0,"Carlos",40);
            clsPersona[] varVectorElementosEsperado=new clsPersona[5];
            varVectorElementosEsperado[0]=varObjCristina;
            varVectorElementosEsperado[1]=varObjMartin;
            varVectorElementosEsperado[2]=varObjEmilio;
            varVectorElementosEsperado[3]=varObjLucero;
            varVectorElementosEsperado[4]=varObjCarlos;
            clsPilaVector<clsPersona> varMiPila = new clsPilaVector<clsPersona>(5);
            varMiPila.Apilar(varObjCarlos);
            varMiPila.Apilar(varObjLucero);
            varMiPila.Apilar(varObjEmilio);
            varMiPila.Apilar(varObjMartin);
            varMiPila.Apilar(varObjCristina);
            varMiPila.AjustarOrdenColeccion("Constante");
            varMiPila.ponerMensajeUltimoMetodo("");
            #endregion
            #region Probar
            varMiPila.OrdenarQuickSort(false);
            #endregion
            #region Comprobar
           //Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(0, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(0, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            
            #endregion
        }
          [TestMethod]
        public void testOrdenarQuickSortCasoConstantePilaLlenaDeObjetosInteligenteDescendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El metodo de ordenamiento por Quick Sort de pila vectorial ha tenido el siguiente problema: ";
            varMensajeResultadoEsperado+= "/r" + "-No debe ordenar, la pila vectorial ya está ordenada como descendente.";
            clsPersona varObjCristina = new clsPersona(3,"Cristina",40);
            clsPersona varObjMartin = new clsPersona(1,"Martin",40);
            clsPersona varObjEmilio = new clsPersona(4,"Emilio",40);
            clsPersona varObjLucero = new clsPersona(2,"Lucero",40);
            clsPersona varObjCarlos = new clsPersona(0,"Carlos",40);
            clsPersona[] varVectorElementosEsperado=new clsPersona[5];
            varVectorElementosEsperado[0]=varObjCristina;
            varVectorElementosEsperado[1]=varObjMartin;
            varVectorElementosEsperado[2]=varObjEmilio;
            varVectorElementosEsperado[3]=varObjLucero;
            varVectorElementosEsperado[4]=varObjCarlos;
            clsPilaVector<clsPersona> varMiPila = new clsPilaVector<clsPersona>(5);
            varMiPila.Apilar(varObjCarlos);
            varMiPila.Apilar(varObjLucero);
            varMiPila.Apilar(varObjEmilio);
            varMiPila.Apilar(varObjMartin);
            varMiPila.Apilar(varObjCristina);
            varMiPila.AjustarOrdenColeccion("Constante");
            varMiPila.ponerMensajeUltimoMetodo("");
            #endregion
            #region Probar
            varMiPila.OrdenarQuickSort(true);
            #endregion
            #region Probar
           //Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(0, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(0, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            
            #endregion
        }
          [TestMethod]
        public void testOrdenarQuickSortMejorCasoPilaNormalDeEnterosInteligenteDescendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El metodo de ordenamiento por Quick Sort de pila vectorial ha tenido el siguiente problema: ";
            varMensajeResultadoEsperado+= "/r" + "-No debe ordenar, la pila vectorial ya está ordenada como descendente.";
            int[] varVectorElementosEsperado=new int[10]{10,9,8,7,6,5,4,0,0,0};
            clsPilaVector<int> varMiPila= new clsPilaVector<int>(10);
            varMiPila.Apilar(4);
            varMiPila.Apilar(5);
            varMiPila.Apilar(6);
            varMiPila.Apilar(7);
            varMiPila.Apilar(8);
            varMiPila.Apilar(9);
            varMiPila.Apilar(10);
            varMiPila.AjustarOrdenColeccion("Descendente");
            varMiPila.ponerMensajeUltimoMetodo("");
            #endregion
            #region Probar
            varMiPila.OrdenarQuickSort(true);
            #endregion
            #region Comprobar
           //Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(0, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(0, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            
            #endregion
        }
        [TestMethod]
         public void testOrdenarQuickSortPeorCasoPilaNormalDeEnterosAscendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El metodo de ordenamiento por Quick Sort de pila vectorial ha finalizado correctamente: ";
            varMensajeResultadoEsperado+= "/r" + "-El metodo ajustar el orden de pila vectorial ha finalizado correctamente.";
            varMensajeResultadoEsperado+= "/r" + "-Se ajustó el orden de la pila vectorial como ascendente.";
            varMensajeResultadoEsperado+= "/r" + "-El metodo de ordenamiento quick sort arrojó los siguientes datos:";
            varMensajeResultadoEsperado+= "/r" + "--Número de elementos:7.";
            varMensajeResultadoEsperado+= "/r" + "--Número de comparaciones:16.";
            varMensajeResultadoEsperado+= "/r" + "--Número de inserciones:0.";
            varMensajeResultadoEsperado+= "/r" + "--Número de llamados recursivos:2.";

            int[] varVectorElementosEsperado=new int[10]{1,2,3,4,5,6,7,0,0,0};
            clsPilaVector<int> varMiPila= new clsPilaVector<int>(10);
            varMiPila.Apilar(1);
            varMiPila.Apilar(2);
            varMiPila.Apilar(3);
            varMiPila.Apilar(4);
            varMiPila.Apilar(5);
            varMiPila.Apilar(6);
            varMiPila.Apilar(7);
            #endregion
            #region Probar
            varMiPila.OrdenarQuickSort(false);
            #endregion
            #region Comprobar
           //Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(16, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(6, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(2, varMiPila.darNumeroLlamadosRecursivos());
            
            #endregion
        }

        [TestMethod]
         public void testOrdenarQuickSortPeorCasoPilaNormalDeEnterosDescendentes()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El metodo de ordenamiento por Quick Sort de pila vectorial ha finalizado correctamente: ";
            varMensajeResultadoEsperado+= "/r" + "-El metodo ajustar el orden de pila vectorial ha finalizado correctamente.";
            varMensajeResultadoEsperado+= "/r" + "-Se ajustó el orden de la pila vectorial como ascendente.";
            varMensajeResultadoEsperado+= "/r" + "-El metodo de ordenamiento quick sort arrojó los siguientes datos:";
            varMensajeResultadoEsperado+= "/r" + "--Número de elementos:7.";
            varMensajeResultadoEsperado+= "/r" + "--Número de comparaciones:16.";
            varMensajeResultadoEsperado+= "/r" + "--Número de intercambios:6.";
            varMensajeResultadoEsperado+= "/r" + "--Número de inserciones:0.";
            varMensajeResultadoEsperado+= "/r" + "--Número de llamados recursivos:2.";

            int[] varVectorElementosEsperado=new int[10]{7,6,5,4,3,2,1,0,0,0};
            clsPilaVector<int> varMiPila= new clsPilaVector<int>(10);
            varMiPila.Apilar(7);
            varMiPila.Apilar(6);
            varMiPila.Apilar(5);
            varMiPila.Apilar(4);
            varMiPila.Apilar(3);
            varMiPila.Apilar(2);
            varMiPila.Apilar(1);
            #endregion
            #region Probar
            varMiPila.OrdenarQuickSort(true);
            #endregion
            #region Comprobar
           //Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(16, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(6, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(0, varMiPila.darNumeroInserciones());
            Assert.AreEqual(2, varMiPila.darNumeroLlamadosRecursivos());
            
            #endregion
        }


        #endregion
        #region TestInsercion
        [TestMethod]
        public void testOrdenarInsercionMejorCasoPilaLlenaDeEnterosFuerzaBrutaDescendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El método de ordenamiento por Insercion de pila vectorial ha finalizado correctamente.";
            varMensajeResultadoEsperado += "/r" + "-El método ajustar el orden de pila vectorial ha finalizado correctamente.";
            varMensajeResultadoEsperado += "/r" + "-Se ajustó el orden de la pila vectorial como descendente.";
            varMensajeResultadoEsperado += "/r" + "-El Método de Ordenamiento Burbuja Mejorado arrojó los siguientes datos:";
            varMensajeResultadoEsperado += "/r" + "--Número de Elementos:10.";
            varMensajeResultadoEsperado += "/r" + "--Número de Comparaciones:9.";
            varMensajeResultadoEsperado += "/r" + "--Número de Intercambios:0.";
            varMensajeResultadoEsperado += "/r" + "--Número de Inserciones:9.";
            varMensajeResultadoEsperado += "/r" + "--Número de Llamados Recursivos:0.";
            int[] varVectorElementosEsperado = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(10);
            varMiPila.Apilar(1);
            varMiPila.Apilar(2);
            varMiPila.Apilar(3);
            varMiPila.Apilar(4);
            varMiPila.Apilar(5);
            varMiPila.Apilar(6);
            varMiPila.Apilar(7);
            varMiPila.Apilar(8);
            varMiPila.Apilar(9);
            varMiPila.Apilar(10);
            #endregion
            #region Probar
            varMiPila.OrdenarInsercion(true);
            #endregion
            #region Comprobar
            ///Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(9, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(0, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(9, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }
        [TestMethod]
        public void testOrdenarInsercionPeorCasoPilaLlenaDeEnterosDescendente()
        {
            #region Inicializar
            string varMensajeResultadoEsperado = "/r" + "-El método de ordenamiento por Insercion de pila vectorial ha finalizado correctamente.";
            varMensajeResultadoEsperado += "/r" + "-El método ajustar el orden de pila vectorial ha finalizado correctamente.";
            varMensajeResultadoEsperado += "/r" + "-Se ajustó el orden de la pila vectorial como descendente.";
            varMensajeResultadoEsperado += "/r" + "-El Método de Ordenamiento Burbuja Mejorado arrojó los siguientes datos:";
            varMensajeResultadoEsperado += "/r" + "--Número de Elementos:10.";
            varMensajeResultadoEsperado += "/r" + "--Número de Comparaciones:54.";
            varMensajeResultadoEsperado += "/r" + "--Número de Intercambios:0.";
            varMensajeResultadoEsperado += "/r" + "--Número de Inserciones:9.";
            varMensajeResultadoEsperado += "/r" + "--Número de Llamados Recursivos:0.";
            int[] varVectorElementosEsperado = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            clsPilaVector<int> varMiPila = new clsPilaVector<int>(10);
            varMiPila.Apilar(10);
            varMiPila.Apilar(9);
            varMiPila.Apilar(8);
            varMiPila.Apilar(7);
            varMiPila.Apilar(6);
            varMiPila.Apilar(5);
            varMiPila.Apilar(4);
            varMiPila.Apilar(3);
            varMiPila.Apilar(2);
            varMiPila.Apilar(1);
            #endregion
            #region Probar
            varMiPila.OrdenarInsercion(true);
            #endregion
            #region Comprobar
            ///Assert.AreEqual(varMensajeResultadoEsperado, varMiPila.darMensajeUltimoMetodo());
            Assert.AreEqual(false, varMiPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, varMiPila.darEstaOrdenadaDescendente());
            CollectionAssert.AreEqual(varVectorElementosEsperado, varMiPila.darVectorElementos());
            Assert.AreEqual(54, varMiPila.darNumeroComparaciones());
            Assert.AreEqual(0, varMiPila.darNumeroIntercambios());
            Assert.AreEqual(9, varMiPila.darNumeroInserciones());
            Assert.AreEqual(0, varMiPila.darNumeroLlamadosRecursivos());
            #endregion
        }

        #endregion
     }

}
