using System.ComponentModel.DataAnnotations;
using System;

namespace CSharpBelt.Models
{
    public class Association
    {
        [Key]
        public int AssocationId { get; set; }
        public User User {get; set;}
        public Party Party {get; set;}
        public int UserId {get; set;}
        public int PartyId {get; set;}
    }
}
    