namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('Fight Club', 'Thriller', 01/01/1995, 05/12/16, 5)");
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('Momento', 'Thriller', 01/01/2000, 05/12/16, 5)");
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('V For Vendetta', 'Thriller', 01/01/2007, 05/12/16, 5)");
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('The Shawshank Redemption', 'Drama', 01/01/1994, 05/12/16, 5)");
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('Scott Pilgrim vs The World', 'Comedy', 01/01/2010, 05/12/16, 5)");

            
        }
        
        public override void Down()
        {
        }
    }
}
