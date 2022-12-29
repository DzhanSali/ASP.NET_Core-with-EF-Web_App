﻿using Azure;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web2Project.Entities
{
    public class GeneralUser
    {
        [Key]
        public int UserId {get;set;}
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; } 
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; } 

        public List<Skills> Skills { get; set; }
        public ICollection<Jobs> Job { get; set; }

        
    }
}
