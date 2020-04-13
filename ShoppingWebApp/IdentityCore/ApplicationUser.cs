using System;
using AspNetCore.Identity.MongoDbCore.Models;
using Microsoft.AspNetCore.Identity;
using MongoDB.Bson;
using ShoppingWebApp.Models;

namespace ShoppingWebApp.IdentityCore
{
   
        public class ApplicationUser : MongoIdentityUser
        {
            public string Name { get; set; }
            public string SurName { get; set; }
    }
}
