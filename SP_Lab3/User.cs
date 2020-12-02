using System;
using System.Collections.Generic;

namespace SP_Lab3
{
    public class User
    {
        public string Name { get; set; } = String.Empty;
        public char[] Password { get; private set; }
        public List<UserProgram> AvailablePrograms { get; private set; } = new List<UserProgram>();

        public User(){}

        public User(string name, char[] password)
        {
            Name = name;
            Password = new char[password.Length];
            Array.Copy(password, Password, password.Length);
        }

        public override string ToString()
        {
            return $"Name : {Name} ; Pass: {new string(Password)} ; Progs: {AvailablePrograms.Count}";
        }

        public static bool operator ==(User user1, User user2)
        {
            return user1.AvailablePrograms.Count == user2.AvailablePrograms.Count;
        }
        
        public static bool operator !=(User user1, User user2)
        {
            return user1.AvailablePrograms.Count != user2.AvailablePrograms.Count;
        }
    }
}