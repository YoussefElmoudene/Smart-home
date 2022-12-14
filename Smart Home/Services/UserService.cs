using Guna.UI2.WinForms;
using MySqlConnector;
using Smart_Home.Classes;
using Smart_Home.Connextion;
using Smart_Home.forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Smart_Home.Services
{
    public class UserService
    {
        public UserService()
        {
        }

        public User findById(int id)
        {
            User user = new User();
            DataTable dt = new DataTable();
            MyConnextion connextion = new MyConnextion();
            connextion.open();
            MySqlCommand cmd = connextion.getConnextion().CreateCommand();
            cmd.CommandText = "SELECT *  FROM user WHERE id='" + id +  "';";
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
                }

                 user = new User(Convert.ToInt32(data[0]), data[1], data[2], data[3], data[4], Convert.ToInt32(data[5]), data[6]);
            }

            return user;
        }
    }
}
