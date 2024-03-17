using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.Models
{
    public class AccountDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }

        public int Role {  get; set; }

        public AccountDTO() { }

        public AccountDTO(int id, string name, string phone, string username, string password, int role)
        {
            Id = id;
            Name = name;
            Phone = phone;
            Username = username;
            Password = password;
            Role = role;
        }

        public AccountDTO(int id, string name, string phone, string username, string password)
        {
            Id = id;
            Name = name;
            Phone = phone;
            Username = username;
            Password = password;
        }
    }
}
