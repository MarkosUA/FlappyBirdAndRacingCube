using UnityEngine;
using Zenject;

public class PlayerController : MonoBehaviour
{
    private ICreationManager _creationManager;

    private ObstaclesController _obstaclesController;
    private FinalPopup _finalPopup;
    private StartText _startText;

    private Bird _bird;

    private float _jumpForce;
    private bool _firstTap;
    private bool _die;

    public bool Die
    {
        set { _die = value; }
    }

    [Inject]
    public void Construct(ObstaclesController obstaclesController, LocationSettings locationSettings, FinalPopup finalPopup,
        StartText startText, ICreationManager creationManager)
    {
        _obstaclesController = obstaclesController;
        _finalPopup = finalPopup;
        _startText = startText;
        _creationManager = creationManager;
        _jumpForce = locationSettings.JumpForce;
        _firstTap = true;
    }

    private void Start()
    {
        _bird = _creationManager.NewBird;
    }

    private void Update()
    {
        BirdControl();

        if (_bird.transform.position.y >= 5 || _bird.transform.position.y <= -5)
        {
            _die = true;
            _obstaclesController.CanMove = false;
            _finalPopup.ActivateFinalPopup();
        }
    }

    private void BirdControl()
    {
        if (Input.GetMouseButtonDown(0) && !_die)
        {
            if (_firstTap)
            {
                _bird.gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
                _firstTap = false;
                _obstaclesController.CanMove = true;
                _startText.DisactiveStartText();
                _bird.GetComponent<Rigidbody2D>().AddForce(Vector2.up);
            }
            else
            {
                BirdJump();
            }
        }
    }

    private void BirdJump()
    {
        _bird.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        _bird.GetComponent<Rigidbody2D>().AddForce(Vector2.up * _jumpForce);
    }
}
