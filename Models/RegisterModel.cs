using System;
using MySql.Data.MySqlClient;

namespace Register.Models
{
    public class RegisterModel
    {
        static string connstr = "server=localhost;port=3306;uid=swartbj;pwd=Swart@1974;database=project_pots;charset=utf8;sslmode=none;AllowPublicKeyRetrieval=True";
        
        public int Customer_ID {get; set;}
        public string? First_Name {get; set;}
        public string? Last_Name {get; set;}
        public string? ID {get; set;}
        public string? Gender{get; set;}
        public string? Username{get; set;}
        public string? Email{get; set;}
        public string? Password{get; set;}
        public DateTime Create_Time {get; set;}
        
        public String Insert()
        {

            try
            {
                MySqlConnection connection = new MySqlConnection(connstr);
                using (connection)
                {

                    connection.Open();

                    string Insertstatement = "INSERT INTO project_pots.customer VALUES(";
                    
                    Insertstatement += null;
                    Insertstatement += "','" + First_Name;
                    Insertstatement += "','" + Last_Name;
                    Insertstatement += "','" + ID;
                    Insertstatement += "','" + Gender;
                    Insertstatement += "','" + Username;
                    Insertstatement += "','" + Email;
                    Insertstatement += "','" + Password;
                    Insertstatement += ", CURDATE());";
                    

                    MySqlCommand sqlstatement = new MySqlCommand(Insertstatement, connection);
                    var IActionResult = sqlstatement.ExecuteNonQuery();
                }
                return "Success";
            }
            catch (Exception Error)
            {
                return "Failed";
            }
        }
    }
}