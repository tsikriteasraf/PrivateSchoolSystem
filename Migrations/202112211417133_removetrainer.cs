namespace PrivateSchoolSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removetrainer : DbMigration
    {
        public override void Up()
        {
            Sql("Delete from Trainers where id=9");
        }
        
        public override void Down()
        {
        }
    }
}
