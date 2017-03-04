using JockeyGames.Models.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JockeyGames.Models.PingPong
{
    public class PlayerGame
    {
        public int Id { get; set; }
        public int Score { get; set; }

        public virtual Player PlayerId { get; set; }
    }

    public class Game
    {
        public int Id { get; set; }

        public virtual PlayerGame PlayerGameId1 { get; set; }
        public virtual PlayerGame PlayerGameId2 { get; set; }
    }

    public class Match
    {
        public int Id { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime DateTime { get; set; }

        public virtual Player PlayerId1 { get; set; }
        public virtual Player PlayerId2 { get; set; }
        public ICollection<Game> Games { get; set; }
    }

    public class Tournament
    {
        public int Id { get; set; }
        public string Title { get; set; }    
            
        public virtual ICollection<Match> Matches { get; set; }
    }
}
