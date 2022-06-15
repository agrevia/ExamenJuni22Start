using JurassicWorld.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JurassicWorld.Domain.Repositories
{
    public class AttractionRepository
    {
        public IEnumerable<Attraction> Attractions { get; set; }

        public AttractionRepository()
        {
            Attractions = new List<Attraction> {
                new Attraction{ Id = 1, Name = "Gentle Giants petting zoo", Image="GentleGiants.jpg", Description="Both petting farms and dinosaurs have long been popular with toddlers, so it's no surprise that one of Jurassic World's main attractions combines the two. The Gentle Giant Petting Zoo is situated nearby to the Innovation Center and allows its smaller guests to feed, pet, and even ride some of the park's youngest dinosaurs." },
                new Attraction{ Id = 2, Name = "Hammond Creation Lab", Image="HammondCreationlab.jpg", Description="It's hard to deny that the genetic creation of Jurassic World's dinosaurs is an impressive feat. Visitors to the theme park are treated to a glimpse of this awe-inspiring scientific achievement at the Hammond Creation Lab. Under the supervision of Doctor Henry Wu, the lab is responsible for the birth of over 200 dinosaurs." },
                new Attraction{ Id = 3, Name = "Jurassic Jeeps", Image="JurassicJeeps.jpg", Description="Featured in the first Jurassic Park movie, the Jurassic Jeeps are arguably one of the theme park's most iconic attractions. These automated ride vehicles transport visitors on a tour through the entertainment venue, where they can experience the dinosaurs inside of their enclosures from the safety of their vehicle." },
                new Attraction{ Id = 4, Name = "Jurassic World Aviary", Image="JurassicWorldAviary.jpg", Description="The prospect of wandering into an enclosure full of winged dinosaurs may seem a scary thought for many individuals, but Jurassic World's aviary finds a way to make it safe. The park's attraction allows visitors to observe the Pterosaur species in a gigantic dome, whilst the creatures fly overhead." },
                new Attraction{ Id = 5, Name = "Monorail", Image="Monorail.jpg", Description="Wandering around a theme park can sometimes prove tiring, which is why transportation can be useful. Thankfully, Jurassic World possesses its own form of transport, in its extensive monorail system. The Jurassic World Monorail is comprised of twelve stations dotted throughout the park, with a vehicle available for boarding every twenty minutes." },
                new Attraction{ Id = 6, Name = "The Gyrospheres", Image="TheGyrospheres.jpg", Description="One of the most popular attractions at Jurassic World, the Gyrospheres allow the public to experience the dinosaurs close-up. The spherical vehicles can be operated manually by the park visitors, and contain a built-in monitor, which informs its riders about the prehistoric species they may encounter." }
            };
        }
    }
}
