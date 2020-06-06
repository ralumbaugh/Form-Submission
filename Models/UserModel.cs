using System;
using System.ComponentModel.DataAnnotations;


namespace FormSubmission.Models
{
    public class User
    {
        [Required (ErrorMessage = "First name is required")]
        [MinLength(4, ErrorMessage = "First name must be at least 4 characters")]
        [Display(Name = "First Name: ")]
        public string FirstName {get; set;}
        [Required (ErrorMessage = "Last name is required")]
        [MinLength(4, ErrorMessage = "Last name must be at least 4 characters")]
        [Display(Name = "Last Name: ")]
        public string LastName {get; set;}
        [Required (ErrorMessage = "Age is required")]
        [Range(0,double.PositiveInfinity, ErrorMessage="Age must be a positive Number")]
        [Display(Name = "Age: ")]
        public int? Age {get; set;}
        [Required (ErrorMessage = "Email is required")]
        [EmailAddress (ErrorMessage = "Please input a valid Email Address")]
        [Display(Name = "Email: ")]
        public string Email {get; set;}
        [Required (ErrorMessage = "Password is required")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters long")]
        [DataType(DataType.Password)]
        [Display(Name = "Password: ")]
        public string Password {get; set;}
        [Required (ErrorMessage = "Password confirmation is required")]
        [Compare("Password", ErrorMessage="Password must match confirmed password")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password: ")]
        public string ConfirmPassword {get; set;}

        public User()
        {}
        public User(string first, string last, int age, string email, string password, string confirmpassword)
        {
            FirstName=first;
            LastName=last;
            Age=age;
            Email=email;
            Password=password;
            ConfirmPassword=confirmpassword;
        }
    }
}