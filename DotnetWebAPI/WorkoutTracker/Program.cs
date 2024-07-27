
using WorkoutTracker.Services.Exercise;
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
                builder.Services.AddTransient<IExerciseService, ExerciseService>();
            }
            
            var app = builder.Build();
            {
                app.UseExceptionHandler("/error");
                app.UseHttpsRedirection();
                app.MapControllers();
                app.Run();
            }
        }
    }
}
