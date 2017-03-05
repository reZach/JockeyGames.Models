using JockeyGames.Models.PingPong;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JockeyGames.Models.DTOs
{
    public class PlayerDTO : Player
    {
                
    }

    public class MatchDTO
    {
        public int Id { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateTime { get; set; }
        public int G1P1Score { get; set; }
        public int G1P2Score { get; set; }
        public int G2P1Score { get; set; }
        public int G2P2Score { get; set; }
        public int G3P1Score { get; set; }
        public int G3P2Score { get; set; }

        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
    }
}
