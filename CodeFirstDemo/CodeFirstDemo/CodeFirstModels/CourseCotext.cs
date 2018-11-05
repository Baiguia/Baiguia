using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo.CodeFirstModels
{
    /// <summary>
    /// 数据上下文 映射到DB 
    /// </summary>
    public class CourseCotext:DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Student { get; set; }

        
    }
    ////每次运行时都生成一个新的数据库
    //public class CourseInitialize:DropCreateDatabaseIfModelChanges<CourseCotext>
    //{

    //}
}
