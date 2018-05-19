namespace Videoteka.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSQLUpdate : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE TipClanstvas SET Naziv = 'Direktno pla�anje' WHERE Id = 1");
            Sql("UPDATE TipClanstvas SET Naziv = 'Mjese�no' WHERE Id = 2");
            Sql("UPDATE TipClanstvas SET Naziv = 'Tromjese�no' WHERE Id = 3");
            Sql("UPDATE TipClanstvas SET Naziv = 'Godi�nje' WHERE Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}