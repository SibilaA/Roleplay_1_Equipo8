using System.Collections.Generic;


namespace Program
{
    public interface IPersonaje
    {
        string Nombre {get; set;}
        int Vida {get; set;}
        Dictionary<string,Item> Items {get; set;}

        void Atacar(IPersonaje enemigo) {}
        void AñadirItem(Item item) {}

        void RemoverItem(string tipoItem) {}

        int CalculoDefensa() {return new int();}

        int CalculoAtaque() {return new int();}
    }
}