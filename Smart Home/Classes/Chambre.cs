using Smart_Home.forms;
using System.Xml.Linq;

namespace Smart_Home.Classes
{
    public class Chambre
    {
        private int id;
        private double largeur;
        private double hauteur;
        private double surface;
        private string type;
        private Appartement appartement;
        private User user;

        public Chambre(int id, double largeur, double hauteur, string type, Appartement appartement, User user, double surface)
        {
            this.Id = id;
            this.Largeur = largeur;
            this.Hauteur = hauteur;
            this.Type = type;
            this.Appartement = appartement;
            this.User = user;
            this.surface = surface;
        }

        public Chambre()
        {
        }

        public override string ToString()
        {
            return "id: " + id  + ", largeur: " + largeur + ", hauteur: " + hauteur
                + ", type: " + type + ", Appartement: { " + Appartement.ToString() + ", user: {" + user.ToString() + "}, surface: " + surface;
        }

        public int Id { get => id; set => id = value; }
        public double Largeur { get => largeur; set => largeur = value; }
        public double Hauteur { get => hauteur; set => hauteur = value; }
        public double Surface { get => surface; set => surface = value; }
        public string Type { get => type; set => type = value; }
        internal Appartement Appartement { get => appartement; set => appartement = value; }
        internal User User { get => user; set => user = value; }
    }
}
