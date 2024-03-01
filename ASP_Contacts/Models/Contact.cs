using System.ComponentModel.DataAnnotations;

namespace RazorPagesContact.Models;

    public class Contact
    {
    public int id { get; set; }
    public string name { get; set; }
    public string surname { get; set; }
    public string email { get; set; }
    public string password { get; set; }
    public string category { get; set; }
    public string sub_category { get; set; }
    public int number { get; set; }
    public DateTime birthdate { get; set; }
    }

