using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JockeyGames.Models.DTOs
{
    public class PlayerGameDTO
    {
        public int Score { get; set; }
        public PlayerDTO Player { get; set; }
    }

    public class GameDTO
    {
        public int Id { get; set; }
        public MatchDTO Match { get; set; }
        public ICollection<PlayerGameDTO> PlayerGames { get; set; }
    }

    public class MatchDTO
    {
        public int Id { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime DateTime { get; set; }
        public TournamentDTO Tournament { get; set; }
        public ICollection<GameDTO> Games { get; set; }
    }

    public class TournamentDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<MatchDTO> Matches { get; set; }
    }
}
