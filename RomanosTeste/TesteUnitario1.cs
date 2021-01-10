using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Romanos;

namespace RomanosTeste {
  [TestClass]
  public class TesteUnitario1 {
    [TestInitialize]
    public void IniciarTeste() {
      
    }
    
    [TestMethod]
    public void TesteMilhar() {
      bool resultado = NumerosRomanos.ConverterParaRomano(1000);
      Assert.IsTrue(resultado, "Algo errado no if do método ConverterParaRomano");
    }

    [TestMethod]
    public void TesteCentena() {
      bool resultado = NumerosRomanos.ConverterParaRomano(100);
      Assert.IsTrue(resultado, "Algo errado no primeiro else if do método ConverterParaRomano");
    }

    [TestMethod]
    public void TesteDezena() {
      bool resultado = NumerosRomanos.ConverterParaRomano(10);
      Assert.IsTrue(resultado, "Algo errado no segundo else if do método ConverterParaRomano");
    }

    [TestMethod]
    public void TesteUnidade() {
      bool resultado = NumerosRomanos.ConverterParaRomano(1);
      Assert.IsTrue(resultado, "Algo errado no ultimo else if do método ConverterParaRomano");
    }

    [TestCleanup]
    public void FinalizarTeste() {
    
    }
  }
}
