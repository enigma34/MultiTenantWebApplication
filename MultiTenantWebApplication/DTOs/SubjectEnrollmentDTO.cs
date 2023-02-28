namespace MultiTenantWebApplication.DTOs
{
    public class SubjectEnrollmentDTO
    {
        public int Id { get; set; }
        public string Subjects { get; set; }
        public int StudentId { get; set;}
        public string tenantId { get; set;}
    }
}
