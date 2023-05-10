using System.Collections.Generic;

namespace Program
{
    public class Enano : IPersonaje
    {    
        private string nombre;
        private int vida;
        private Dictionary<string, Item> items;

        public int Vida
        {
            get
            {
                return this.vida;
            }

            set
            {
                if (value < 0)
                {
                    this.vida = 0; 
                }
                else
                {
                    this.vida = value;
                }
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }

            set
            {
                this.nombre = value;
            }
        }
        public Dictionary<string, Item> Items
        {
            get
            {
                return this.items;
            }

            set
            {
                this.items = value;
            }
        }

        public Enano (string nombre, int vida)
        {
            this.nombre = nombre;
            this.vida = vida;
            this.items = new Dictionary<string, Item>();
        }

        public void Atacar (IPersonaje enemigo)
        {       
            if (enemigo.CalculoDefensa() < CalculoAtaque())
            {
                enemigo.Vida -= CalculoAtaque() - enemigo.CalculoDefensa();
            }
        }

        public void AñadirItem (Item item)
        {
            this.Items[item.Type] = item;
        }

        public void RemoverItem (Item item)
        {
            this.Items.Remove(item.Type);
        }

        public int CalculoDefensa ()
        {
            int defensaTotal = 0;
            foreach (string item in Items.Keys)
            {
                if (item.Contains("defensa"))
                {
                    defensaTotal += Items[item].Defence;
                }
            }
            return defensaTotal;
        }

        public int CalculoAtaque ()
        {
            int ataqueTotal = 0;
            foreach (string item in Items.Keys)
            {
                if (item.Contains("arma"))
                {
                    ataqueTotal += Items[item].Damage;
                }
            }
            return ataqueTotal;
        }
    }
}