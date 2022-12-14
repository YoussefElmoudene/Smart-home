using MySqlConnector;
using Smart_Home.Classes;
using Smart_Home.Connextion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Home.Services
{
    public class ChambreService
    {
        private AppartementService appartementService = new AppartementService();
        private UserService userService = new UserService();
        public ChambreService()
        {
        }
        public Chambre findById(int id)
        {
            Chambre chambre = new Chambre();
            DataTable dt = new DataTable();
            MyConnextion connextion = new MyConnextion();
            connextion.open();
            MySqlCommand cmd = connextion.getConnextion().CreateCommand();
            cmd.CommandText = "SELECT * FROM `chambre` WHERE id='" + id + "';";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            List<string> data = new List<string>();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dataRow in dt.Rows)
                {
                    foreach (var item in dataRow.ItemArray)
                    {
                        data.Add(item.ToString());
                    }
                    chambre = new Chambre(Convert.ToInt16(data[0]),
                            Convert.ToDouble(data[1]),
                            Convert.ToDouble(data[2]),
                            data[3],
                            appartementService.findById(Convert.ToInt16(data[4])),
                            userService.findById(Convert.ToInt16(data[5])),
                            Convert.ToDouble(data[6]));
                }

            }

            return chambre;
        }
    }
}
