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
            //��ʼ��ѧԺ����
            var d1 = new Department()
            {
                Name = "������Ϣ����ѧԺ",
                SortCode = "01",
                Descirption = "��һ��ѧԺ"
            };
            var d2 = new Department()
            {
                Name = "���繤��ѧԺ",
                SortCode = "02",
                Descirption = "�ڶ���ѧԺ"
            };
            var d3 = new Department()
            {
                Name = "��������ѧԺ",
                SortCode = "03",
                Descirption = "������ѧԺ"
            };
            var d4 = new Department()
            {
                Name = "�ƾ�����ѧԺ",
                SortCode = "04",
                Descirption = "���Ĵ�ѧԺ"
            };
            context.Departments.Add(d1);
            context.Departments.Add(d2);
            context.Departments.Add(d3);
            context.Departments.Add(d4);
            context.SaveChanges();

           
            var c1 = new Course()
            {
                Title = "C#�������",
                Credit = 7,
                Department = context.Departments.SingleOrDefault(x => x.Name == "������Ϣ����ѧУ")
            };
            var c2 = new Course()
            {
                Title = "MIS����ʵս",
                Credit = 7,
                Department = context.Departments.SingleOrDefault(x => x.Name == "������Ϣ����ѧУ")
            };
            var c3 = new Course()
            {
                Title = "WEBӦ���ڿ���",
                Credit = 17,
                Department = context.Departments.SingleOrDefault(x => x.Name == "������Ϣ����ѧУ")
            };
            var c4 = new Course()
            {
                Title = "��ҵ��ͼ",
                Credit = 4,
                Department = context.Departments.SingleOrDefault(x => x.Name == "���繤��ѧԺ")
            };
            var c5 = new Course()
            {
                Title = "���������",
                Credit = 6,
                Department = context.Departments.SingleOrDefault(x => x.Name == "��������ѧУ")
            };
            var c6 = new Course()
            {
                Title = "����Ӫ��",
                Credit = 8,
                Department = context.Departments.SingleOrDefault(x => x.Name == "�ƾ�����ѧУ")
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
