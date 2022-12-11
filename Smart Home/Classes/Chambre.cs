using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Home.Classes
{
    internal class Chambre
    {
        private int id;
        private double largeur;
        private double hauteur;
        private string urlimg;
        private string type;
        private Appartement appartement;
        private User user;

        public Chambre(int id, double largeur, double hauteur, string urlimg, string type, Appartement appartement, User user)
        {
            this.Id = id;
            this.Largeur = largeur;
            this.Hauteur = hauteur;
            this.Urlimg = urlimg;
            this.Type = type;
            this.Appartement = appartement;
            this.User = user;
        }

        public int Id { get => id; set => id = value; }
        public double Largeur { get => largeur; set => largeur = value; }
        public double Hauteur { get => hauteur; set => hauteur = value; }
        public string Urlimg { get => urlimg; set => urlimg = value; }
        public string Type { get => type; set => type = value; }
        internal Appartement Appartement { get => appartement; set => appartement = value; }
        internal User User { get => user; set => user = value; }
    }
}
