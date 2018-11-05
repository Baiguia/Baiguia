using CodeFirstDemo.CodeFirstModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo.Migrations
{
    public  class DepartmentSeed
    {
        public static void Seed(CourseCotext context)
        {
            //context.Database.ExecuteSqlCommand("delete courses");
            //context.Database.ExecuteSqlCommand("delete departments");
            //初始化学院数据
            var d1 = new Department()
            {
                Name = "电子信息工程学院",
                SortCode = "01",
                Descirption = "第一大学院"
            };
            var d2 = new Department()
            {
                Name = "机电工程学院",
                SortCode = "02",
                Descirption = "第二大学院"
            };
            var d3 = new Department()
            {
                Name = "汽车工程学院",
                SortCode = "03",
                Descirption = "第三大学院"
            };
            var d4 = new Department()
            {
                Name = "财经物流学院",
                SortCode = "04",
                Descirption = "第四大学院"
            };
            context.Departments.Add(d1);
            context.Departments.Add(d2);
            context.Departments.Add(d3);
            context.Departments.Add(d4);
            context.SaveChanges();

        }
    }
    
}
