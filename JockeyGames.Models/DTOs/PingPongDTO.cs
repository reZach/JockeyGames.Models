using JockeyGames.Models.PingPong;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JockeyGames.Models.DTOs
{
    public class PlayerDTO
    {
        public int Id { get; set; }            
        public string Name { get; set; }
    }

    public class MatchDTO
    {
        public int Id { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateTime { get; set; }
        [Display(Name = "Game 1 | P1")]
        [Range(0, 21)]
        public int G1P1Score { get; set; }
        [Display(Name = "Game 1 | P2")]
        [Range(0, 21)]
        public int G1P2Score { get; set; }
        [Display(Name = "Game 2 | P1")]
        [Range(0, 21)]
        public int G2P1Score { get; set; }
        [Display(Name = "Game 2 | P2")]
        [Range(0, 21)]
        public int G2P2Score { get; set; }
        [Display(Name = "Game 3 | P1")]
        [Range(0, 21)]
        public int G3P1Score { get; set; }
        [Display(Name = "Game 3 | P2")]
        [Range(0, 21)]
        public int G3P2Score { get; set; }

        public int PlayerId1 { get; set; }
        public int PlayerId2 { get; set; }
    }
}
