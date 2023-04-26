using NUnit.Framework;

namespace Program
{
    public class ExampleTest
    {
        [Test]
        public void RemoverItem()
        {

            Item item1 = new Item ("Bastón Mágico", 52, 0, "Arma");
            Item item2 = new Item ("Capa Mágica", 52, 0, "Defensa");

            Mago mago1 = new Mago ("Gerardo", 100);
            mago1.RemoverItem(item1);

            bool contiene = mago1.Items.ContainsValue(item1);
            Assert.IsFalse(contiene);


        }
    }
}