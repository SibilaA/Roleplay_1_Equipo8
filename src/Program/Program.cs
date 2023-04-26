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

            Item itemCasco = new Item ("Casco", 0, 20, "Defensa");
            Item itemEspada = new Item ("Espada", 60, 0, "Arma");

            Enano enano1 = new Enano("John", 100);

            enano1.AñadirItem(itemCasco);
            enano1.AñadirItem(itemEspada);



        }
    }
}
