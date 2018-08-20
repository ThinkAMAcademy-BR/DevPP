using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;

namespace DevPP {

    [Table("AppStatus")]
    public class Status : FullAuditedEntity<Guid>
    {
        public const int MaxNameLength = 80;

        [Required]
        [StringLength(MaxNameLength)]
        public string Name { get; set; }
        
        protected Status()
        {
        }
    }
}