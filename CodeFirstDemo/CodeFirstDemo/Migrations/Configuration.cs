namespace CodeFirstDemo.Migrations
{
    using CodeFirstModels;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirstDemo.CodeFirstModels.CourseCotext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(CodeFirstDemo.CodeFirstModels.CourseCotext context)
        {
            context.Database.ExecuteSqlCommand("delete courses");
            context.Database.ExecuteSqlCommand("delete departments");
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

           
            var c1 = new Course()
            {
                Title = "C#程序设计",
                Credit = 7,
                Department = context.Departments.SingleOrDefault(x => x.Name == "电子信息工程学校")
            };
            var c2 = new Course()
            {
                Title = "MIS开发实战",
                Credit = 7,
                Department = context.Departments.SingleOrDefault(x => x.Name == "电子信息工程学校")
            };
            var c3 = new Course()
            {
                Title = "WEB应用于开发",
                Credit = 17,
                Department = context.Departments.SingleOrDefault(x => x.Name == "电子信息工程学校")
            };
            var c4 = new Course()
            {
                Title = "工业制图",
                Credit = 4,
                Department = context.Departments.SingleOrDefault(x => x.Name == "机电工程学院")
            };
            var c5 = new Course()
            {
                Title = "发动机检测",
                Credit = 6,
                Department = context.Departments.SingleOrDefault(x => x.Name == "汽车工程学校")
            };
            var c6 = new Course()
            {
                Title = "网络营销",
                Credit = 8,
                Department = context.Departments.SingleOrDefault(x => x.Name == "财经物流学校")
            };
            context.Courses.Add(c1);
            context.Courses.Add(c2);
            context.Courses.Add(c3);
            context.Courses.Add(c4);
            context.Courses.Add(c5);
            context.Courses.Add(c6);
            context.SaveChanges();
        }
    }
}
