using DataModel.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Models
{
    public class UserModel
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public UserModel()
        {

        }

        public UserModel(int? id, string name, string email, string password)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
        }

        public bool ValidateLogin(DatabaseContext context, string email, string password)
        {
            UserModel user = context.Users.FirstOrDefault(x => x.Email == email && x.Password == password);
            return user != null;
        }

        public static List<UserModel> GetUsers(DatabaseContext context)
        {
            return context.Users.ToList();
        }

        public static UserModel GetUser(DatabaseContext context, int id)
        {
            return context.Users.FirstOrDefault(x => x.Id == id);
        }

        public static UserModel CreateOrUpdate(DatabaseContext context, UserModel data)
        {
            if (data.Id != null)
            {
                var result = context.Users.Update(data);
                return result.Entity;
            }
            else
            {
                var result = context.Users.Add(data);
                return result.Entity;
            }
        }
    }
}
