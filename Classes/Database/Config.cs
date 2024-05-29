using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagingTasksCategoriesBugrina.Classes.Database
{
    public class Config
    {
        public static readonly string connection = "server=;uid=;pwd=;database=TasksCategorys;";
        public static readonly MySqlServerVersion version = new MySqlServerVersion(new Version(8, 0, 11));
    }
}
