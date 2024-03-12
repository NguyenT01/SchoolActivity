namespace SchoolActivity
{
    /*
    public class RepositoryContextFactory : IDesignTimeDbContextFactory<RepositoryContext>
    {
        public RepositoryContext CreateDbContext(string[] args)
        {
            var conf = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<RepositoryContext>()
                .UseSqlServer(conf.GetConnectionString("Default"),
                    b => b.MigrationsAssembly("SchoolActivity"));
            return new RepositoryContext(builder.Options);
        }
    }
    */
}
