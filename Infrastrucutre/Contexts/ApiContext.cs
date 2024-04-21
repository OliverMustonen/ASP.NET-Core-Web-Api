using Infrastrucutre.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastrucutre.Contexts;

public class ApiContext(DbContextOptions<ApiContext> options) : DbContext(options)
{
    public DbSet<SubscribersEntity> Subscribers { get; set; }
    public DbSet<CourseEntity> Courses { get; set; }
}
