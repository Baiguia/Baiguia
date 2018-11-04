using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //            //使用数据上下文进行数据操作，using表示上下文代码的范围，执行完后内存会自动释放
            //            using (var context = new CourseDBEntities())
            //            {
            //                var departments = context.Departments.OrderBy(n => n.SortCode).ToList();
            //                foreach (var d in departments)
            //                    Console.WriteLine("编号:{0},部门名称:{1},说明:{2}", d.SortCode, d.Name, d.Dscn);

            //                //Console.WriteLine("修改记录");
            //                //Console.WriteLine("========================================");
            //                ////修改
            //                //var editDepartment = context.Departments.SingleOrDefault(x => x.Name == "环境与食品检测学院");
            //                //if (editDepartment != null)
            //                //{
            //                //    editDepartment.Name = "环境与食品检测学院";
            //                //    editDepartment.SortCode = "007";
            //                //    context.SaveChanges();
            //                //}
            //                //else
            //                //    Console.WriteLine("未找到该记录，不能修改.");

            //                //Console.WriteLine("删除记录");
            //                //Console.WriteLine("========================================");
            //                ////find--用主键查询实体
            //                //var delDept = context.Departments.Find(Guid.Parse("e6a729b7-7638-40b1-a8e7-ce9e0e666b70"));
            //                ////var id = Guid.Parse("e6a729b7-7638-40b1-a8e7-ce9e0e666b70");
            //                ////var delDept = context.Departments.SingleOrDefault(x => x.ID == id);
            //                //context.Departments.Remove(delDept);
            //                //context.SaveChanges();

            //                Console.WriteLine("添加记录");
            //                Console.WriteLine("========================================");
            //                var newDept = new Departments
            //                {
            //                    ID = Guid.NewGuid(),
            //                    Name = "测试学院",
            //                    Dscn = "不可描述",
            //                    SortCode = "000"
            //                };
            //                context.Departments.Add(newDept);
            //                context.SaveChanges();

            //                var departments1 = context.Departments.OrderBy(n => n.SortCode).ToList();
            //                foreach (var d in departments1)
            //                    Console.WriteLine("编号:{0},部门名称:{1},说明:{2}", d.SortCode, d.Name, d.Dscn);

            //                Console.ReadKey();
            //            }
            //        }
            //    }

            var context = new DBContext();
            var courses = context.Courses.ToList();
            foreach (var c in courses)
                Console.WriteLine("课程名称：{0}  课程学分:{1}  所属学院:{2}", c.Title, c.Credit, c.Departments.Name);

            //Console.WriteLine("==================添加三门课程====================");
            ////添加课程
            //var c1 = new Courses()
            //{
            //    ID = Guid.NewGuid(),
            //    Title = "软件工程项目组织管理",
            //    Credit = 17,
            //    //外键的对象 一定要从同一个上下文中查询
            //    Departments = context.Departments.SingleOrDefault(x => x.Name == "电子信息工程学院")
            //};
            //var c2= new Courses()
            //{
            //    ID = Guid.NewGuid(),
            //    Title = "算法与数据结构",
            //    Credit = 2,
            //    //外键的对象 一定要从同一个上下文中查询
            //    Departments = context.Departments.SingleOrDefault(x => x.Name == "电子信息工程学院")
            //};
            //var c3 = new Courses()
            //{
            //    ID = Guid.NewGuid(),
            //    Title = "C#图像处理",
            //    Credit = 2,
            //    //外键的对象 一定要从同一个上下文中查询
            //    Departments = context.Departments.SingleOrDefault(x => x.Name == "电子信息工程学院")
            //};
            //context.Courses.Add(c1);
            //context.Courses.Add(c2);
            //context.Courses.Add(c3);
            //context.SaveChanges();

            Console.WriteLine("==================修改一门课程====================");
            var obj = context.Courses.SingleOrDefault(x => x.Title == "商务英语");
            if (obj != null)
            {
                obj.Title = "计算机英语";
                obj.Credit = 4;
                obj.Departments = context.Departments.SingleOrDefault(x => x.Name == "电子信息工程学院");
                context.SaveChanges();
            }
            else
                Console.WriteLine("未找该课程，不能修改!");

            foreach (var c in context.Courses.ToList())
                Console.WriteLine("课程名称：{0}  课程学分:{1}  所属学院:{2}", c.Title, c.Credit, c.Departments.Name);

            Console.WriteLine("==================删除一门课程====================");
            var delobj = context.Courses.Find(Guid.Parse("abb77302-f84a-4497-9204-79e3addb84e4"));
            context.Courses.Remove(delobj);
            context.SaveChanges();

            foreach (var c in context.Courses.ToList())
                Console.WriteLine("课程名称：{0}  课程学分:{1}  所属学院:{2}", c.Title, c.Credit, c.Departments.Name);

            Console.ReadLine();
        }
    }
}



