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
        //种子方法
        protected override void Seed(CodeFirstDemo.CodeFirstModels.CourseCotext context)
        {
            //context.Database.ExecuteSqlCommand("delete courses");
            //context.Database.ExecuteSqlCommand("delete departments");
            //context.Database.ExecuteSqlCommand("delete students");

            //DepartmentSeed.Seed(context);
            //CourseCotext.Seed(context);
            //StudentSeed.Seed(context);
        }
    }
}
