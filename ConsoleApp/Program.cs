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
            //创建数据的上下文，所有的表的实体都会在此上下文中

            //.where .orderby .tolist()注意调用的顺序
            var context = new CourseDBEntities();
            
            var departments = context.Departments.OrderBy(x => x.SortCode).ToList();
            foreach (var d in departments)
                Console.WriteLine("编号{0},部门名称{1},说明{2}", d.SortCode, d.Name, d.Dscn);

            //添加一条记录
            //var newDepartment = new Departments
            //{
            //    ID = Guid.NewGuid(),
            //    Name = "环境食品学院",
            //    Dscn = "环境食品",
            //    SortCode="007"
            //};
            ////把新的对象添加到上下文中
            //context.Departments.Add(newDepartment);
            ////更新上下文 把新的实体保存扫数据库中
            //context.SaveChanges();

            ////显示新的记录
            //var departments1 = context.Departments.OrderBy(x => x.SortCode).ToList();
            //foreach (var d in departments)
            //    Console.WriteLine("编号{0},部门名称{1},说明{2}", d.SortCode, d.Name, d.Dscn);

            Console.WriteLine("修改记录");
            Console.WriteLine("===============================");
            //修改
            var editDepartment = context.Departments.SingleOrDefault(x => x.Name == "环境食品学院");
            editDepartment.Name = "环境食品";
            editDepartment.SortCode = "007";
            context.SaveChanges();
        

            else
            Console.WriteLine("未找到该数据，不能修改");

            var departments1 = context.Departments.OrderBy(x => x.SortCode).ToList();
            foreach (var d in departments)
                Console.WriteLine("编号{0},部门名称{1},说明{2}", d.SortCode, d.Name, d.Dscn);
            Console.ReadKey();

        }
    }
}
