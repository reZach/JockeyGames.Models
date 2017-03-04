using JockeyGames.Models.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JockeyGames.Models.PingPong
{
    public class PlayerGame
    {
        // Foreign keys
        [Key, Column(Order = 0)]
        public int GameId { get; set; }
        [Key, Column(Order = 1)]
        public int PlayerId { get; set; }

        // Navigation properties
        [Required]
        public virtual Game Game { get; set; }
        [Required]
        public virtual Player Player { get; set; }

        // Additional properties
        public int Score { get; set; }
    }

    public class Game
    {
        public int Id { get; set; }

        public virtual Match Match { get; set; }
        public virtual ICollection<PlayerGame> PlayerGames { get; set; }
    }

    public class Match
    {
        public int Id { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime DateTime { get; set; }

        public virtual Tournament Tournament { get; set; }
        public virtual ICollection<Game> Games { get; set; }
    }

    public class Tournament
    {
        public int Id { get; set; }
        public string Title { get; set; }    
            
        public virtual ICollection<Match> Matches { get; set; }
    }
}
