using Bank;
using static System.Net.Mime.MediaTypeNames;

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
            //decimal saldoPoczatkowe = 0;

            // AAA - Act
            var km = new Account(nazwa);

            // AAA - Assert
            Assert.AreEqual(nazwa, km.Name);
            //Assert.AreEqual(saldoPoczatkowe, km.Balance);
            Assert.IsFalse(km.IsBlocked);
        }
    }
}