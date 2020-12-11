using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Korelskiy.LegendaryGamesProject.Enums;

namespace Korelskiy.LegendaryGamesProject.Models
{
    public class Game
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string MainDeveloper { get; set; }
        public Countries Country { get; set; }
        public float KirillsPoints { get; set; }
        public Platforms Platform { get; set; }
    }
}
