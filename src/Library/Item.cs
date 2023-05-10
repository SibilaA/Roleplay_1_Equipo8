namespace Program{
    public class Item{

        public string Nombre{get;set;}
        public int Damage{get;set;}
        public int Defence{get;set;}
        public string Type{get;set;}
        public Item(string nombre,int damage,int defence,string type){

            this.Nombre = nombre;
            this.Damage = damage;
            this.Defence = defence;
            this.Type = type;

        }
    }
}