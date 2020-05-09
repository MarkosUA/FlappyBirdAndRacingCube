using UnityEngine;
using Zenject;

public class ObstaclesController : MonoBehaviour
{
    private ICreationManager _creationManager;

    private LocationSettings _locationSettings;

    private float _speed;
    private float _position;
    private bool _canMove;

    public bool CanMove
    {
        set { _canMove = value; }
    }

    [Inject]
    public void Construct(LocationSettings locationSettings, ICreationManager creationManager)
    {
        _locationSettings = locationSettings;
        _creationManager = creationManager;
        _position = transform.position.x;
    }

    private void Update()
    {
        if (_canMove)
            ObstaclesMovement();
    }

    private void ObstaclesMovement()
    {
        transform.position = new Vector3(transform.position.x - Time.deltaTime * _locationSettings.Speed,
            transform.position.y, transform.position.z);

        if (_position - transform.position.x >= _locationSettings.DistanceBetweenObst * 2)
        {
            _creationManager.CreateObstacle();
            _position = transform.position.x;
        }
    }
}
