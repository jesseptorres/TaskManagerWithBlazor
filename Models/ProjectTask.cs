using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManagerWithBlazor.Models
{
    public class ProjectTask
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public int ProjectId { get; set; }
    }
}
