using System;

namespace SP_Lab3
{
    public class UserProgram
    {
        public string Name { get; private set; } = String.Empty;
        public OS _os { get; private set; } = OS.Windows;
        public string Company { get; private set; } = String.Empty;
        public DateTime Installed { get; private set; } = DateTime.Now;
        public float Version { get; private set; } = 0.0f;
        public int RAMRequire { get; private set; } = 0;
        public int CPUFrequency { get; private set; } = 0;
        public int HDDStore { get; private set; } = 0;

        public UserProgram(){}

        public UserProgram(string name, OS os, string company, DateTime installed, float version, int ramRequire, int cpuFrequency, int hddStore)
        {
            Name = name;
            _os = os;
            Company = company;
            Installed = installed;
            Version = version;
            RAMRequire = ramRequire;
            CPUFrequency = cpuFrequency;
            HDDStore = hddStore;
        }

        public void UpdateVersion(float newVersion)
        {
            if(newVersion > Version)
                Version = newVersion;
            Random rand = new Random();
            RAMRequire += (int) (RAMRequire * rand.NextDouble());
            CPUFrequency += (int) (CPUFrequency * rand.NextDouble());
            HDDStore += (int) (HDDStore * rand.NextDouble());
        }
        
        public static bool operator >(UserProgram program1, UserProgram program2)
        {
            return (program1.CPUFrequency > program2.CPUFrequency);
        }
        
        public static bool operator <(UserProgram program1, UserProgram program2)
        {
            return (program1.CPUFrequency < program2.CPUFrequency);
        }

        public override string ToString()
        {
            return $"Name: {Name} ; Version: {Version}";
        }
    }
}