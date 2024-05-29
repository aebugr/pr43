﻿using ManagingTasksCategoriesBugrina.Classes;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagingTasksCategoriesBugrina.ViewModels
{
    public class VM_Pages : Notification
    {
        public VM_Tasks vm_tasks = new VM_Tasks();
        public VM_Categorys vm_categorys = new VM_Categorys();
        public VM_Pages() => MainWindow.init.frame.Navigate(new View.Tasks.Main(vm_tasks));
        public RealyCommand OpenTasks
        {
            get => new RealyCommand(obj => MainWindow.init.frame.Navigate(new View.Tasks.Main(vm_tasks)));
        }
        public RealyCommand OpenCategorys
        {
            get => new RealyCommand(obj => MainWindow.init.frame.Navigate(new View.Categorys.Main(vm_categorys)));
        }
    }
}
