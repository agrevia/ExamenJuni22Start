using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JurassicWorld.Domain.Entities
{
    public class Dinosaur
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Location { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public bool IsHerbivore { get; set; }
    }
}
