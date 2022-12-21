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
    public class AppartementService
    {
        private UserService userService = new UserService();
        public AppartementService()
        {
        }

        public Appartement updateSurface(double surface, int id)
        {
            MyConnextion connextion = new MyConnextion();
            connextion.open();
            MySqlCommand cmd = connextion.getConnextion().CreateCommand();

            cmd.CommandText = "UPDATE `appartement` SET `surface`=@surface WHERE id=" + id + ";";
            cmd.Parameters.AddWithValue("@surface", surface);
            cmd.ExecuteNonQuery();
            return this.findById(id);
        }

        public Appartement findById(int id)
        {
            Appartement app = new Appartement();
            DataTable dt = new DataTable();
            MyConnextion connextion = new MyConnextion();
            connextion.open();
            MySqlCommand cmd = connextion.getConnextion().CreateCommand();
            cmd.CommandText = "SELECT *  FROM appartement WHERE id='" + id + "';";
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

                app = new Appartement(Convert.ToInt32(data[0]), data[1],Convert.ToDouble(data[2]),
                    Convert.ToDouble(data[3]),
                    this.userService.findById(Convert.ToInt16(data[4])),
                    this.userService.findById(Convert.ToInt16(data[5])),
                    Convert.ToBoolean(data[6]),
                    Convert.ToDouble(data[7]));
            }

            return app;
        }

        public Appartement findByAdminId(int id)
        {
            Appartement app = new Appartement();
            DataTable dt = new DataTable();
            MyConnextion connextion = new MyConnextion();
            connextion.open();
            MySqlCommand cmd = connextion.getConnextion().CreateCommand();
            cmd.CommandText = "SELECT *  FROM appartement WHERE adminId='" + id + "';";
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

                app = new Appartement(Convert.ToInt32(data[0]), data[1], Convert.ToDouble(data[2]),
                    Convert.ToDouble(data[3]),
                    this.userService.findById(Convert.ToInt16(data[4])),
                    this.userService.findById(Convert.ToInt16(data[5])),
                    Convert.ToBoolean(data[6]),
                    Convert.ToDouble(data[7]));
            }
            return app;
        }

        public void allowTechnicien(bool block, int id)
        {
            MyConnextion connextion = new MyConnextion();
            connextion.open();
            MySqlCommand cmd = connextion.getConnextion().CreateCommand();

            cmd.CommandText = "UPDATE `appartement` SET `allowTechnicien`=@allowTechnicien WHERE id=" + id + ";";
            cmd.Parameters.AddWithValue("@allowTechnicien", block);
            cmd.ExecuteNonQuery();
        }

    }
    //UPDATE `appartement` SET `surface`= WHERE id= 

}
