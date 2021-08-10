using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskOrganizorDBSeeder.Models
{
    [Table("task")]
    public class Task: BaseModel
    {
        public long Id { get; set; }
        
        public string PKey { get; set; }
        
        public long TaskNum { get; set; }
        
        public long ProjectId { get; set; }
        
        public string ReporterName { get; set; }
        
        public string ActorName { get; set; }
        
        public string CreatorName { get; set; }
        
        public string Name { get; set; }
        
        public string Description { get; set; }
        
        public string Environment { get; set; }
        
        public string Priority { get; set; }
        
        public string Progress { get; set; }
        
        public DateTime DueDate { get; set; }
        
        public DateTime CompletionTime { get; set; }

    }
}