using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dojo.CaixaEletronico;
using System.Diagnostics;

namespace Dojo.TesteDoCaixa
{ 
    [TestClass]
    public class TestesDeCedulas
    {
        private quantidadeDeNotas notas;

        [TestInitialize]
        public void IniciaTesteCaixaBancario()
        {
            notas = new quantidadeDeNotas();
        }

        [TestCleanup]
        public void FinalizaTesteCaixaBancario()
        {
            Debug.WriteLine("fim teste");
        }

        [TestMethod]
        public void entrega_valor_10()
        {
            notas.ContabilizaCedulas(10);
            Assert.AreEqual(1, notas.Dez);
        }
        
        [TestMethod]
        public void entrega_valor_20()
        {
            notas.ContabilizaCedulas(20);
            Assert.AreEqual(1, notas.Vinte);
        }

        [TestMethod]
        public void entrega_valor_50()
        {
            notas.ContabilizaCedulas(50);
            Assert.AreEqual(1,notas.cinquenta);
        }

        [TestMethod]
        public void entrega_valor_100()
        {
            notas.ContabilizaCedulas(100);
            Assert.AreEqual(1,notas.Cem);
        }

        [TestMethod]
        public void entrega_valor_140()
        {
            notas.ContabilizaCedulas(140);
            Assert.AreEqual(1,notas.Cem);
            Assert.AreEqual(2,notas.Vinte);
            
        }
        
        [TestMethod]
        public void entrega_valor_180()
        {
            notas.ContabilizaCedulas(180);
            Assert.AreEqual(1,notas.Cem);
            Assert.AreEqual(1,notas.cinquenta);
            Assert.AreEqual(1,notas.Vinte);
            Assert.AreEqual(1,notas.Dez);

        }

        [TestMethod]
        public void entrega_valor_230()
        {
            notas.ContabilizaCedulas(230);
            Assert.AreEqual(2,notas.Cem);
            Assert.AreEqual(1,notas.Vinte);
            Assert.AreEqual(1, notas.Dez);

        }

        [TestMethod]
        public void entrega_valor_650()
        {
            notas.ContabilizaCedulas(650);
            Assert.AreEqual(6,notas.Cem);
            Assert.AreEqual(1,notas.cinquenta);

        }

        [TestMethod]
        public void entrega_valor_1890()
        {
            notas.ContabilizaCedulas(1890);
            Assert.AreEqual(18, notas.Cem);
            Assert.AreEqual(1, notas.cinquenta);
            Assert.AreEqual(2, notas.Vinte);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void testar_caso_nao_seja_passado_nenhum_valor()
        {
            notas.ContabilizaCedulas(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void testar_caso_cedula_nao_possua_no_caixa()
        {
            notas.ContabilizaCedulas(25);
         
        }
    }
}
