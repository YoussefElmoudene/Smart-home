using MySqlConnector;
using Smart_Home.Classes;
using Smart_Home.Connextion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Home.Services
{
    public class FurnitureService
    {
        private ChambreService chambreService = new ChambreService();
        public FurnitureService()
        {
        }

        public List<Furniture> findByChambreId(int id)
        {
            List<Furniture> list = new List<Furniture>();
            DataTable dt = new DataTable();
            MyConnextion connextion = new MyConnextion();
            connextion.open();
            MySqlCommand cmd = connextion.getConnextion().CreateCommand();
            cmd.CommandText = "SELECT * FROM `furniture` WHERE chambreId='" + id + "';";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dataRow in dt.Rows)
                {
                    List<string> data = new List<string>();
                    foreach (var item in dataRow.ItemArray)
                    {
                        data.Add(item.ToString());
                    }
                    Furniture furniture = new Furniture(Convert.ToInt16(data[0]),
                        data[1],
                        Convert.ToBoolean(data[2]),
                        this.chambreService.findById(Convert.ToInt16(data[3]))
                        );
                    

                    list.Add(furniture);
                }

            }
            
            return list;
        }

        public bool changeStatus(bool status, int id)
        {
            MyConnextion connextion = new MyConnextion();
            connextion.open();
            MySqlCommand cmd = connextion.getConnextion().CreateCommand();

            cmd.CommandText = "UPDATE `furniture` SET `active`=@active WHERE id=" + id + ";";
            cmd.Parameters.AddWithValue("@active", status);
            if (cmd.ExecuteNonQuery() > 0) return true;
            else return false;
        }

        internal bool addObjet(string type, int objetId, Chambre chambre)
        {
            MyConnextion connextion = new MyConnextion();
            connextion.open();
            MySqlCommand cmd = connextion.getConnextion().CreateCommand();

            cmd.CommandText = "INSERT INTO `furniture`(`id`, `type`, `active`, `chambreId`, `objetId`) " +
                "VALUES(@id, @type ,false ,@chambreId ,@objetId)";
            cmd.Parameters.AddWithValue("@id", null);
            cmd.Parameters.AddWithValue("@type", type);
            cmd.Parameters.AddWithValue("@chambreId", chambre.Id);
            cmd.Parameters.AddWithValue("@objetId", objetId);
            if (cmd.ExecuteNonQuery() > 0) return true;
            else return false;
        }
    }
}
