using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Home.Classes
{
    internal class Furniture
    {
        private int id;
        private string type;
        private string img;
        private bool active;
        private Chambre chambre;

        public Furniture(int id, string type, string img, bool active, Chambre chambre)
        {
            this.Id = id;
            this.Type = type;
            this.Img = img;
            this.Active = active;
            this.Chambre = chambre;
        }

        public int Id { get => id; set => id = value; }
        public string Type { get => type; set => type = value; }
        public string Img { get => img; set => img = value; }
        public bool Active { get => active; set => active = value; }
        internal Chambre Chambre { get => chambre; set => chambre = value; }
    }
}
