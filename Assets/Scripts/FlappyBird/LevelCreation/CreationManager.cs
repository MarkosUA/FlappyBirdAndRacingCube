using UnityEngine;

public class CreationManager : ICreationManager
{
    private IObstaclesCreater _obstaclesCreater;

    private Bird.Factory _birdFactory;
    private Bird _bird;
    private LocationSettings _locationSettings;

    public Bird NewBird
    {
        get { return _bird; }
    }

    public CreationManager(Bird.Factory birdFactory, LocationSettings locationSettings, IObstaclesCreater obstaclesCreater)
    {
        _birdFactory = birdFactory;
        _obstaclesCreater = obstaclesCreater;
        _locationSettings = locationSettings;
    }

    public void CreateLevel()
    {
        CreateBird();
        CreateObstacle();
    }

    public void CreateObstacle()
    {
        var distance = _locationSettings.DistanceBetweenObst;

        for (int i = 0; i < 2; i++)
        {
            var randY = Random.Range(_locationSettings.MinHeight, _locationSettings.MaxHeight);
            var coord = new Vector3(distance, randY, 0);
            _obstaclesCreater.CreateObstacles(coord);
            distance += distance;
        }
    }

    private void CreateBird()
    {
        _bird = _birdFactory.Create();

        _bird.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionY;

        _bird.transform.position = Vector3.zero;
    }
}
