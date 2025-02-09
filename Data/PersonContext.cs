using Microsoft.EntityFrameworkCore;

public class PersonContext : DbContext {
    public DbSet<PersonModel> People {get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        optionsBuilder.UseSqlite("Data Source=person.sqLite");
        base.OnConfiguring(optionsBuilder);
    }

}