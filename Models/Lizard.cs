using System;
using System.ComponentModel.DataAnnotations;

namespace LizardPirates.Models
{
    public class Lizard
    {
        [Key]
        public int LizardId {get;set;}

        [Required(ErrorMessage="Name is required")]
        public string Name {get;set;}

        [Required(ErrorMessage="Lizard Type is required")]
        public string LizardType {get;set;}

        [Required(ErrorMessage="Pirate Role is required")]
        public string PirateRole {get;set;}

        [Required(ErrorMessage="Treasure Chests is required")]
        [Range(1,10,ErrorMessage="ARRRRGH YOU CAN ONLY HAVE 1 - 10 CHESTS")]
        public int TreasureChests {get;set; }

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}