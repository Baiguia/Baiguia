using CodeFirstDemo.CodeFirstModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo.Migrations
{
    public class StudentSeed
    {
        public static void Seed(CourseCotext context)
        {
            var stu1 = new Student()
            {
                StudentCode = "0001",
                Name = "翠儿",
                Address = "柳州",
                Birthday = Convert.ToDateTime("2000-01-01"),
                Phone = "13111331133",
                Department = context.Departments.SingleOrDefault(x => x.Name == "电子信息工程学院")
            };
            var stu2 = new Student()
            {
                StudentCode = "0002",
                Name = "翠花",
                Address = "南宁",
                Birthday = Convert.ToDateTime("19998-01-01"),
                Phone = "13666336633",
                Department = context.Departments.SingleOrDefault(x => x.Name == "电子信息工程学院")
            };
            var stu3 = new Student()
            {
                StudentCode = "0003",
                Name = "翠柳",
                Address = "湖南",
                Birthday = Convert.ToDateTime("1999-01-01"),
                Phone = "13222332233",
                Department = context.Departments.SingleOrDefault(x => x.Name == "电子信息工程学院")
            };
            var stu4 = new Student()
            {
                StudentCode = "0004",
                Name = "翠芳",
                Address = "长沙",
                Birthday = Convert.ToDateTime("2002-01-01"),
                Phone = "13888333388",
                Department = context.Departments.SingleOrDefault(x => x.Name == "电子信息工程学院")
            };
            var stu5 = new Student()
            {
                StudentCode = "0005",
                Name = "翠绿",
                Address = "武汉",
                Birthday = Convert.ToDateTime("1997-01-01"),
                Phone = "13555335533",
                Department = context.Departments.SingleOrDefault(x => x.Name == "电子信息工程学院")
            };
            context.Student.Add(stu1);
            context.Student.Add(stu2);
            context.Student.Add(stu3);
            context.Student.Add(stu4);
            context.Student.Add(stu5);
            context.SaveChanges();
        }
    }
}
