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
            var context = new CourseDBEntities();
            var departments = context.Departments.OrderBy(x => x.SortCode).ToList();

            foreach (var d in departments)
                Console.WriteLine("编号{0},部门名称{1},说明{2}", d.SortCode, d.Name, d.Dscn);

            Console.ReadKey();
        }
    }
}
