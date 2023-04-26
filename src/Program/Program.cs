using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Item item1 = new Item ("Bastón Mágico", 52, 0, "Arma");
            Item item2 = new Item ("Capa Mágica", 52, 0, "Defensa");

            Mago mago1 = new Mago ("Gerardo", 100);

            mago1.AñadirItem(item1);
            mago1.AñadirItem(item2);



        }
    }
}
