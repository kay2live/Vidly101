namespace Vidly101.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Movies(Name,GenreId, DateAdded,ReleaseDate,NumberinStock) values('Hangover',1,'2017-06-01','2015-01-01',10)");
            Sql("Insert into Movies(Name,GenreId, DateAdded,ReleaseDate,NumberinStock) values('Die Hard',2,'2017-06-02','2013-01-01',12)");
            Sql("Insert into Movies(Name,GenreId, DateAdded,ReleaseDate,NumberinStock) values('The Terminator',2,'2017-05-01','2012-01-01',2)");
            Sql("Insert into Movies(Name,GenreId, DateAdded,ReleaseDate,NumberinStock) values('Toy Story',3,'2017-03-01','2010-01-01',3)");
            Sql("Insert into Movies(Name,GenreId, DateAdded,ReleaseDate,NumberinStock) values('Titanic',4,'2017-06-11','1990-01-01',5)");
        }
        
        public override void Down()
        {
        }
    }
}
