namespace DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class addinginitialmenuoptionforsysadmins : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO [dbo].[MenuOptions] ([Title],[Link],[Icon],[Description],[allowedType]) VALUES('Opciones de Menu','','fa fa-gear','Administraci�n de opciones del men�','2')");
        }

        public override void Down()
        {
        }
    }
}
