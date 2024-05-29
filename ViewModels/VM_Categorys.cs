using ManagingTasksCategoriesBugrina.Classes;
using ManagingTasksCategoriesBugrina.Context;
using ManagingTasksCategoriesBugrina.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ManagingTasksCategoriesBugrina.ViewModels
{
    public class VM_Categorys : Notification
    {
        public CategorysContext categorysContext = new CategorysContext();
        public ObservableCollection<Categorys> Categorys { get; set; }
        public VM_Categorys() => Categorys = new ObservableCollection<Categorys>(categorysContext.Categorys);
        public RealyCommand OnAddCategorys
        {
            get
            {
                return new RealyCommand(obj =>
                {
                    Categorys newCategorys = new Categorys();
                    Categorys.Add(newCategorys);
                    categorysContext.Categorys.Add(newCategorys);
                    categorysContext.SaveChanges();
                });
            }
        }
    }
}
