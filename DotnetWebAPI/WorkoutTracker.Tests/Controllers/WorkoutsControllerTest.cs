using WorkoutTracker.Controllers;
using WorkoutTracker.Services.Workout;

namespace WorkoutTracker.Tests.Controllers;

public class WorkoutsControllerTest
{
    private readonly IWorkoutService _mockWorkoutService;
    private readonly WorkoutsController _workoutsController;
    WorkoutsControllerTest()
    {
        _mockWorkoutService = A.Fake<IWorkoutService>();

        // SUT
        _workoutsController = new WorkoutsController(_mockWorkoutService);
    }
    
    [Fact]
    public void WorkoutsController_CreateWorkout_ReturnsCreatedAt()
    {
        
        // TODO: 
        // _workoutsController.CreateWorkout();
    }

    //[Theory]
    //[InlineData()] // Mock up http request?
    //public void WorkoutsController_UpsertWorkout_ReturnsOK()
    //{

    //}


}
