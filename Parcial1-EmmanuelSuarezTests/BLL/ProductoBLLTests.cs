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
            Productos produto = new Productos() { Descripcion = "ColcaCola", Costo = 500, Existencia = 5 };
            Assert.IsTrue(ProductoBLL.Guardar(produto));
        }
    }
}