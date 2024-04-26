using Microsoft.EntityFrameworkCore;


namespace ODataProject.Data
{
    public class MyAppDbContext : DbContext
    {
        public MyAppDbContext(DbContextOptions<MyAppDbContext> options) : base(options) { }
    }

}
