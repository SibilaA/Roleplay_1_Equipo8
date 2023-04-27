using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Item item1 = new Item ("Bastón Mágico", 52, 0, "Arma");
            Item item2 = new Item ("Capa Mágica", 0 , 48, "Defensa");

            Mago mago1 = new Mago ("Gerardo", 100);

            mago1.AñadirItem(item1);
            mago1.AñadirItem(item2);

            Item itemCasco = new Item ("Casco", 0, 20, "Defensa");
            Item itemEspada = new Item ("Espada", 60, 0, "Arma");

            Enano enano1 = new Enano("John", 100);

            enano1.AñadirItem(itemCasco);
            enano1.AñadirItem(itemEspada);


            Item item_espada = new Item ("Espada", 50 , 0 , "Arma");
            Item item_escudo = new Item ("Escudo", 0 , 45 , "Defensa");
            Elfo elfo1 = new Elfo ("Ramon", 100);
            elfo1.AñadirItem(item_espada);
            elfo1.AñadirItem(item_escudo);

            Item ArcoLargo = new Item ("Arco Largo", 75, 0, "Arma" );
            Item ArmaduraLijera = new Item ("Armadura Lijera", 0, 50, "Defensa" );
            Elfo Legolas = new Elfo ("Legolas", 100);

            Legolas.AñadirItem(ArcoLargo);
            Legolas.AñadirItem(ArmaduraLijera);





            




        }
    }
}
