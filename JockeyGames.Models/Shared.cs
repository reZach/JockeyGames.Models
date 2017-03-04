﻿using JockeyGames.Models.PingPong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JockeyGames.Models.Shared
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<PlayerGame> PlayerGames { get; set; }
    }
}
