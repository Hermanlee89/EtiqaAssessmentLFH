using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace EtiqaAssessmentLFH.Models
{
    public class userModel
    {
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }
                
        [EmailAddress]
        public string Mail { get; set; }
        public string PhoneNo { get; set; }
        public string Skillsets { get; set; }
        public string Hobby { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
