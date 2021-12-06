using CaixaDesktop.Controle;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Teste
{
    [TestClass]
    public class Teste
    {

        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
        "C:\\Users\\Cliente\\Desktop\\engenharia\\CaixaDesktop\\Teste\\Dataset\\testes.csv", "testes#csv",
        DataAccessMethod.Sequential), DeploymentItem("testes.csv"), TestMethod]
        public void TesteIntegrado()
        {
            bool retorno = false;
            string linha = TestContext.DataRow[0].ToString();
            string[] dados = linha.Split(';');
            TesteModel model = new TesteModel(dados[0], dados[1], Convert.ToDouble(dados[2]), dados[3]);
            Controladora ctr = new Controladora();
            if(model.StatusCaixa == "Aberto")
            {
                if(model.Valor > 0)
                {
                    if(model.Motivo != "")
                    {
                        if(model.Tipo == "Entrada")
                        {
                            retorno = ctr.Gravar(model.Valor, model.Motivo, 'E', new DateTime());
                        }
                        else if(model.Tipo == "Saida")
                        {
                            retorno = ctr.Gravar(model.Valor, model.Motivo, 'S', new DateTime());
                        }
                    }
                }
            }
            Assert.IsTrue(retorno);
        }
    }
}
