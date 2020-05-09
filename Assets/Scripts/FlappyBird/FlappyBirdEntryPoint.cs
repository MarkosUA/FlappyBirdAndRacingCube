using UnityEngine;
using Zenject;

public class FlappyBirdEntryPoint : MonoBehaviour
{
    private IFlappyBirdGameController _gameController;

    [Inject]
    private void Construct(IFlappyBirdGameController gameController)
    {
        _gameController = gameController;
    }

    private void Awake()
    {
        _gameController.StartGame();
    }
}
