using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;
using DevPP.Authorization.Users;

namespace DevPP.Presentation
{
    [Table("AppPresentation")]
    public class Presentation : FullAuditedEntity<Guid>
    {
        public const int MaxNameLength = 128;
        public const int MaxDescriptionLength = 2048;

        [Required]
        [StringLength(MaxNameLength)]
        public string Title { get; set; }

        [Required]
        [StringLength(MaxDescriptionLength)]
        public string Description { get; set; }

        public string Slide { get; set; }

        public string Code { get; set; }

        public string Video { get; set; }

        [Required]
        public bool isActive { get; set; }

        public long SpeakerId { get; set; }

        [ForeignKey("SpeakerId")]        
        public User Speaker { get; set; }

        public Presentation(){
            
        }

    }

}