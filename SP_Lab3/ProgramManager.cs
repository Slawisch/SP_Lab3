using System.Collections.Generic;

namespace SP_Lab3
{
    public class ProgramManager
    {
        public List<UserProgram> Programs = new List<UserProgram>();
        public Dictionary<string, User> Users = new Dictionary<string, User>();
        public OS Os { get; set; } = OS.Windows;
        public int CPUFrequency { get; set; } = 0;
        public int RAM { get; set; } = 0;
        public int HDD { get; set; } = 0;
        
        public ProgramManager(){}

        public ProgramManager(OS os, int cpuFrequency, int ram, int hdd)
        {
            Os = os;
            CPUFrequency = cpuFrequency;
            RAM = ram;
            HDD = hdd;
        }

        public void AddProgram(UserProgram program)
        {
            Programs.Add(program);
        }

        public void ReplaceProgram(UserProgram program, int index)
        {
            Programs[index] = program;
        }

        public void ReplaceUser(User user)
        {
            Users[user.Name + user.Password] = user;
        }

        public void DelProgram(int index)
        {
            Programs.RemoveAt(index);
        }

        public void UpdateProgram(int index, float version)
        {
            Programs[index].UpdateVersion(version);
        }

        public void AddUser(User user)
        {
            var key = user.Name + new string(user.Password);
            if(!Users.ContainsKey(key))
                Users.Add(key, user);
        }

        public void DelUser(User user)
        {
            var key = user.Name + new string(user.Password);
            if(!Users.ContainsKey(key))
                Users.Remove(key);
        }

        public bool CompareUsers(User user1, User user2)
        {
            return user1 == user2;
        }

        public bool ComparePrograms(UserProgram program1, UserProgram program2)
        {
            return program1 > program2;
        }

        public override string ToString()
        {
            return $"OS: {Os} ; CPU Frequency: {CPUFrequency} MHz ; RAM: {RAM} MB ; HDD: {HDD} MB";
        }
    }
}