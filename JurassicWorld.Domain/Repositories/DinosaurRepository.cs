using JurassicWorld.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JurassicWorld.Domain.Repositories
{
    public class DinosaurRepository
    {
        public IEnumerable<Dinosaur> Dinosaurs { get; set; }

        public DinosaurRepository()
        {
            Dinosaurs = new List<Dinosaur> {
                new Dinosaur{ Id = 1, Name = "Giganotosaurus", Image="gigantosaurus.jpg", Height=12, Weight = 55, Location="Argentina", IsHerbivore = false},
                new Dinosaur{ Id = 2, Name = "Indominus rex", Image="indominus.jpg", Height=8, Weight = 44, Location="Belgium", IsHerbivore = true},
                new Dinosaur{ Id = 3, Name = "Therizinosaurus", Image="therizinosaurus.jpg", Height=13, Weight = 58, Location="Spain", IsHerbivore = false},
                new Dinosaur{ Id = 4, Name = "Scorpios rex", Image="scorpios.jpg", Height=7, Weight = 36, Location="Isla Nublar", IsHerbivore = true},
                new Dinosaur{ Id = 5, Name = "Atrociraptor", Image="atrociraptor.jpg", Height=18, Weight = 69, Location="Isla Nublar", IsHerbivore = false},
                new Dinosaur{ Id = 6, Name = "Spinosaurus", Image="spinosaurus.jpg", Height=6, Weight = 42, Location="Italy", IsHerbivore = true}
            };
        }
    }
}
