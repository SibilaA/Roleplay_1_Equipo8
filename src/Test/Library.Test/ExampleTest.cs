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
            mago1.AñadirItem(item1);
            mago1.RemoverItem(item1);

            bool contiene = mago1.Items.ContainsValue(item1);
            Assert.IsFalse(contiene);


        }
        [Test]
        public void AñadirItem()
        {
            Item item_espada = new Item ("Espada", 50 , 0 , "Arma");
            Item item_escudo = new Item ("Escudo", 0 , 45 , "Defensa");
            Elfo elfo1 = new Elfo ("Ramon", 100);
            elfo1.AñadirItem(item_espada);

            bool contiene = elfo1.Items.ContainsValue(item_espada);
            Assert.IsFalse(contiene);



        }

        

    }
}