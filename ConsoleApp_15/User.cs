using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp_15
{
    internal class User
    {
        private string _username;
        private string _email;
        private int _age;

        public User(string username, string email, int age)
        {
            Username = username;
            Email = email;
            Age = age;
        }
        public string Username
        {
            get => _username;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Trim().Length < 3)
                {
                    throw new ArgumentException("Username must be at least 3 character long!");
                }
                _username = value;
            }
        }


        public string Email
        {
            get => _email;
            set
            {
                string emailRegex = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
                if (string.IsNullOrWhiteSpace(value) || !Regex.IsMatch(value, emailRegex))
                {
                    throw new ArgumentException("Invalid email format!");
                }
                _email = value;
            }
        }      
        public int Age
        {
            get => _age;
            set
            {
                if (value < 18 || value > 120)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Age must be between 18 and 120!");
                }
                _age = value;
            }
        }
    }
}
