using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_29._04
{
    public class Website
    {
        public string Name = "";
        public string Path = "";
        public string Description = "";
        public string IpAddress = "";

        public Website(string name, string path, string description, string ipAddress)
        {
            Name = name;
            Path = path;
            Description = description;
            IpAddress = ipAddress;
        }
        public void Print()
        {
            Console.WriteLine($"Name: {Name}\nPath: {Path}\nDescription: {Description}\nIpAddress: {IpAddress}");
        }

        public void SetName(string name) { Name = name; }
        public void SetPath(string path) { Path = path; }
        public void SetDescription(string description) { Description = description; }
        public void SetIpAddress(string ipAddress) { IpAddress = ipAddress; }

        public string GetName() { return Name; }
        public string GetPath() { return Path; }
        public string GetDescription() { return Description; }
        public string GetIpAddress() { return IpAddress; }

    }
}
