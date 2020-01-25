using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManagerWithBlazor.Models
{
    public class Project
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<ProjectTask> ProjectTasks { get; set; }
    }
}
