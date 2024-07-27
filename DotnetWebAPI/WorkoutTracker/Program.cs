
using WorkoutTracker.Services.Workout;

namespace WorkoutTracker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            {
                builder.Services.AddControllers();
                builder.Services.AddTransient<IWorkoutService, WorkoutService>();
            }
            
            var app = builder.Build();
            {
                app.UseHttpsRedirection();
                app.MapControllers();
                app.Run();
            }
        }
    }
}
