
public class FlappyBirdGameController : IFlappyBirdGameController
{
    private ICreationManager _creationManager;

    public FlappyBirdGameController(ICreationManager creationManager)
    {
        _creationManager = creationManager;
    }

    public void StartGame()
    {
        _creationManager.CreateLevel();
    }

    public void GameProcess()
    {

    }
}
