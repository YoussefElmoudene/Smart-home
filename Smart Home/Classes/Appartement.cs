namespace Smart_Home.Classes
{
    public class Appartement
    {
        private int id;
        private string name;
        private double largeur;
        private double hauteur;
        private double surface;
        private User admin;
        private User technicien;
        private bool allowTechnicien;

        public Appartement(int id, string name, double largeur, double hauteur, User admin, User technicien, bool allowTechnicien, double surface)
        {
            this.Id = id;
            this.Name = name;
            this.Largeur = largeur;
            this.Hauteur = hauteur;
            this.Admin = admin;
            this.Technicien = technicien;
            this.AllowTechnicien = allowTechnicien;
            this.surface = surface;
        }

        public Appartement()
        {
        }

        public override string ToString()
        {
            return "id: " + id + ", name: " + name + ", largeur: " + largeur + ", hauteur: " + hauteur
                + ", admin: {" + admin.ToString() + "}, technicien: { " + technicien.ToString() + "}, allowTechnicien: " + allowTechnicien + ", surface: " + surface;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Largeur { get => largeur; set => largeur = value; }
        public double Hauteur { get => hauteur; set => hauteur = value; }
        public bool AllowTechnicien { get => allowTechnicien; set => allowTechnicien = value; }
        public double Surface { get => surface; set => surface = value; }
        internal User Admin { get => admin; set => admin = value; }
        internal User Technicien { get => technicien; set => technicien = value; }
    }
}
