namespace EA.TMS.Common.Entities
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Core;

    [Description("To store Service Requests submitted by Tenants")]
    [Table("ServiceRequest")]
    public class ServiceRequest : BaseEntity
    {
        [Key]
        public long Id { get; set; }
        public long TenantId { get; set; }
        [ForeignKey("TenantId")]
        public virtual Tenant Tenant { get; set; }
        [MaxLength(1000)]
        public string Description { get; set; }
        [MaxLength(300)]
        public string EmployeeComments { get; set; }
        public int StatusId { get; set; }
        [ForeignKey("StatusId")]
        public virtual Status Status { get; set; }
    }

}