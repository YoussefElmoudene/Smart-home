using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Home.Classes
{
    internal class Appartement
    {
        private int id;
        private string name;
        private double largeur;
        private double hauteur;
        private User admin;
        private User technicien;
        private bool allowTechnicien;

        public Appartement(int id, string name, double largeur, double hauteur, User admin, User technicien, bool allowTechnicien)
        {
            this.Id = id;
            this.Name = name;
            this.Largeur = largeur;
            this.Hauteur = hauteur;
            this.Admin = admin;
            this.Technicien = technicien;
            this.AllowTechnicien = allowTechnicien;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Largeur { get => largeur; set => largeur = value; }
        public double Hauteur { get => hauteur; set => hauteur = value; }
        public bool AllowTechnicien { get => allowTechnicien; set => allowTechnicien = value; }
        internal User Admin { get => admin; set => admin = value; }
        internal User Technicien { get => technicien; set => technicien = value; }
    }
}
