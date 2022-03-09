using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystem.Models
{
    public class Title
    {
        public Title(int id, string name, DateTime release)
        {
            Id = id;
            Name = name;
            Release = release;
        }
        public int Id { get; init; }
        public string Name { get; init; }
        public DateTime Release { get; init; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Release: {Release.ToString("d")}";
        }

    }
}
