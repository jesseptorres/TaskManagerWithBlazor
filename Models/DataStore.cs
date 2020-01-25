using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManagerWithBlazor.Models
{
    public static class DataStore
    {
        private static List<Project> Projects = new List<Project>();

        private static List<ProjectTask> ProjectTasks = new List<ProjectTask>();

        public static List<Project> GetAllProjects() 
        {
            var projects = new List<Project>();

            foreach (var project in Projects) 
            {
                project.ProjectTasks = GetProjectTasks(project.Id);

                projects.Add(project);
            }

            return Projects;
        }

        public static Project GetProject(int id) 
        {
            var project = Projects.FirstOrDefault(x => x.Id == id);

            if (project != null) 
            {
                project.ProjectTasks = GetProjectTasks(project.Id);
            }

            return project;
        }

        public static void AddProject(string name) 
        {
            var id = Projects.Any() ? Projects.Max(x => x.Id) + 1 : 1;

            var newProject = new Project
            {
                Id = id,
                Name = name
            };

            Projects.Add(newProject);
        }

        public static void DeleteProject(int id) 
        {
            var projectToDelete = Projects.FirstOrDefault(x => x.Id == id);

            if (projectToDelete != null) 
            {
                Projects.Remove(projectToDelete);
            }            
        }

        public static List<ProjectTask> GetProjectTasks(int projectId) 
        {
            return ProjectTasks.Where(x => x.ProjectId == projectId).ToList();
        }

        public static void AddProjectTask(int projectId, string description) 
        {
            var id = ProjectTasks.Any() ? ProjectTasks.Max(x => x.Id) + 1 : 1;

            var newProjectTask = new ProjectTask
            {
                Id = id,
                Description = description,
                ProjectId = projectId
            };

            ProjectTasks.Add(newProjectTask);            
        }

        public static void DeleteProjectTask(int id) 
        {
            var projectTaskToDelete = ProjectTasks.FirstOrDefault(x => x.Id == id);

            if (projectTaskToDelete != null) 
            {
                ProjectTasks.Remove(projectTaskToDelete);
            }
        }
    }
}
