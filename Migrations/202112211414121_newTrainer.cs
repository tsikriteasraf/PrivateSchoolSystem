using System.Data.Entity.Migrations;

namespace PrivateSchoolSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newTrainer : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Trainers (First_Name,Last_Name,Subject) values ('Raf','tsikriteas','sql')");
        }
        
        public override void Down()
        {
        }
    }
}
