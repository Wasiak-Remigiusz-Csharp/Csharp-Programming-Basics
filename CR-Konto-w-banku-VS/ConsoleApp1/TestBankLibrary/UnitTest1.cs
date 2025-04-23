using BankLibrary;

namespace TestBankLibrary
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Konstruktor_poprawne_dane()
        {
            // AAA - Arrange
            var nazwa = "molenda";
            decimal saldoPoczatkowe = 1000;

            // AAA - Act
            var km = new Konto(nazwa, saldoPoczatkowe);

            // AAA - Assert
            Assert.AreEqual(nazwa, km.Nazwa);
            Assert.AreEqual(saldoPoczatkowe, km.Saldo);
            Assert.IsFalse(km.JestZablokowane);

        }
    }
}