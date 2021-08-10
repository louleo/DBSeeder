using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskOrganizorDBSeeder.Models
{
    public abstract class BaseModel
    {
        [Column("created")]
        public DateTime Created;

        [Column("updated")]
        public DateTime Updated;
    }
}