namespace la_mia_pizzeria.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string image { get; set; }
        public int prezzo { get; set; }
        public List<string> Ingredienti { get; set; } 

        public Pizza()
        {

        }

        public Pizza(int id, string name, string desctiption,int prezzo , string image , List<string> ingredienti)
        {
            this.Id=id;
            this.Name=name;
            this.Description=desctiption;
            this.prezzo=prezzo;
            this.image=image;
            this.Ingredienti = ingredienti;
        }
    }
}
