using ManagingTasksCategoriesBugrina.Classes;
using ManagingTasksCategoriesBugrina.Context;
using ManagingTasksCategoriesBugrina.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ManagingTasksCategoriesBugrina.ViewModels
{
    public class VM_Tasks : Notification
    {
        public TasksContext tasksContext = new TasksContext();
        public ObservableCollection<Tasks> Tasks { get; set; }
        public VM_Tasks() => Tasks = new ObservableCollection<Tasks>(tasksContext.Tasks);
        public RealyCommand OnAddTasks
        {
            get
            {
                return new RealyCommand(obj =>
                {
                    Tasks newTasks = new Tasks();
                    Tasks.Add(newTasks);
                    tasksContext.Tasks.Add(newTasks);
                    tasksContext.SaveChanges();
                });
            }
        }
    }
}
