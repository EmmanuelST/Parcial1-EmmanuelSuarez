using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parcial1_EmmanuelSuarez.BLL;
using Parcial1_EmmanuelSuarez.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_EmmanuelSuarez.BLL.Tests
{
    [TestClass()]
    public class ProductoBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Productos produto = new Productos() { Descripcion = "ColcaCola2", Costo = 500, Existencia = 5 };
            Assert.IsTrue(ProductosBLL.Guardar(produto));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Productos produto = new Productos() {ProductoId = 4, Descripcion = "ColcaCola5", Costo = 500, Existencia = 5 };
            Assert.IsTrue(ProductosBLL.Modificar(produto));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.IsNotNull(ProductosBLL.Buscar(3));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.IsTrue(ProductosBLL.Eliminar(3));
        }
    }
}