namespace MP2_FinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TaskViewModels", "Title", c => c.String(maxLength: 60));
            AlterColumn("dbo.TaskViewModels", "Description", c => c.String(maxLength: 160));
            AlterColumn("dbo.TaskViewModels", "Importance", c => c.String(maxLength: 20));
            AlterColumn("dbo.TaskViewModels", "Status", c => c.String(maxLength: 20));
            AlterColumn("dbo.TaskViewModels", "Employee", c => c.String(maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TaskViewModels", "Employee", c => c.String());
            AlterColumn("dbo.TaskViewModels", "Status", c => c.String());
            AlterColumn("dbo.TaskViewModels", "Importance", c => c.String());
            AlterColumn("dbo.TaskViewModels", "Description", c => c.String());
            AlterColumn("dbo.TaskViewModels", "Title", c => c.String());
        }
    }
}
