using UnityEngine;
using Zenject;

public class Bird : MonoBehaviour
{
    private Scores _scores;
    private FinalPopup _finalPopup;
    private PlayerController _playerController;
    private ObstaclesController _obstaclesController;

    private int _playerScores;

    [Inject]
    public void Construct(Scores scores, FinalPopup finalPopup, PlayerController playerController, 
        ObstaclesController obstaclesController)
    {
        _scores = scores;
        _finalPopup = finalPopup;
        _playerController = playerController;
        _obstaclesController = obstaclesController;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _scores.UpdateScores(++_playerScores);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _playerController.Die = true;
        _obstaclesController.CanMove = false;
        _finalPopup.ActivateFinalPopup();
    }

    public class Factory : PlaceholderFactory<Bird>
    {

    }
}
