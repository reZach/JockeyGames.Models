using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace JockeyGames.Models.PingPong
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Match
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

        public virtual Player PlayerId1 { get; set; }
        public virtual Player PlayerId2 { get; set; }
    }
}
