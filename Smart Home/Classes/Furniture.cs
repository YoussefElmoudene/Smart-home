namespace Smart_Home.Classes
{
    public class Furniture
    {
        private int id;
        private string type;
        private bool active;
        private Chambre chambre;

        public Furniture(int id, string type,  bool active, Chambre chambre)
        {
            this.Id = id;
            this.Type = type;
            this.Active = active;
            this.Chambre = chambre;
        }

        public Furniture()
        {
        }

        public int Id { get => id; set => id = value; }
        public string Type { get => type; set => type = value; }
        public bool Active { get => active; set => active = value; }
        internal Chambre Chambre { get => chambre; set => chambre = value; }
    }
}
