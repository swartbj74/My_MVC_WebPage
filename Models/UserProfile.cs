using System;
using MySql.Data.MySqlClient;

namespace Profile.Models
{
public class ProfileModel
  {

    private string constr = "server=localhost;port=3306;uid=swartbj;pwd=Swart@1974;database=project_pots;charset=utf8;sslmode=none;AllowPublicKeyRetrieval=True";
    public int CustomerID {get; set;}
    public string? First_Name {get; set;}
    public string? Last_Name {get; set;}
    public string? Username {get; set;}
    public string? Email {get; set;}


public string RetrieveFullName(){

            return First_Name + " " + Last_Name;
}

   public void GetCustomerInfo(int CustomerID){

            MySqlConnection connection = new MySqlConnection(constr);
            using(connection){
                connection.Open();
            MySqlCommand sqlstatement = new MySqlCommand("SELECT * FROM projects_pots.customer where customer_id=" + CustomerID + ";",connection);

            using(var results = sqlstatement.ExecuteReader()){

            results.Read();
                    CustomerID = Convert.ToInt32(results["Customer_ID"]);
                    First_Name = Convert.ToString(results["First_Name"]);
                    Last_Name = Convert.ToString(results["Last_Name"]);
                    Email = Convert.ToString(results["Email"]);


           }
        }
      }
  }
}
