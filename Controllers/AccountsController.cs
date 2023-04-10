using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using My_MVC_WebPage.Models;
using Register.Models;

namespace My_MVC_WebPage.Controllers;
public class AccountsController : Controller
{
    private readonly ILogger<AccountsController> _logger;
    public AccountsController(ILogger<AccountsController> logger)
    {
        _logger = logger;
    }
    
    [HttpPost]
    public IActionResult Register(int Customer_ID, string First_Name, string Last_Name, string ID, string Gender, string Username, string Email, string Password, DateTime Create_Time){
        
        RegisterModel newuser = new RegisterModel();

                    newuser.Customer_ID = Customer_ID;
                    newuser.First_Name = First_Name;
                    newuser.Last_Name = Last_Name;
                    newuser.ID = ID;
                    newuser.Gender = Gender;
                    newuser.Username = Username;
                    newuser.Email = Email;
                    newuser.Password = Password;
                    newuser.Create_Time = Create_Time;
        
         string status = newuser.Insert();

         if(status.Equals("success")){
            return View("~/Views/Accounts/Login.cshtml");
         }
         else
         {
            return View("~/Views/Accounts/Register.cshtml");
         }
                  
        }

     public IActionResult Register(){
       
       return View();
    }

     public IActionResult Login(){
       
       return View();
    }

     public IActionResult PasswordReset()
    {
        return View();
    }

      public IActionResult Profile(){

        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}