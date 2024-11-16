using System.Data.Entity;

namespace Welcome_login_and_sign_up
{
    class TaskContext : DbContext
    {
    //Test
        public DbSet<User> Users{ get; set; }

    }
}
