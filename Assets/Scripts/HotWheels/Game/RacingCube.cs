using UnityEngine;
using PathCreation;

public class RacingCube : IRacingCube
{
    private GameObject _racingCube;
    private PathCreator _pathCreator;

    private float _speed;
    private float _distanceTravelled;

    public RacingCube(PathCreator pathCreator, HotWheelsSettings hotWheelsSettings, GameObject racingCube)
    {
        _racingCube = racingCube;
        _pathCreator = pathCreator;
        _speed = hotWheelsSettings.Speed;
    }

    public void RacingCubeMovement()
    {
        _distanceTravelled += Time.deltaTime * _speed;

        _racingCube.transform.position = _pathCreator.path.GetPointAtDistance(_distanceTravelled);
        _racingCube.transform.rotation = _pathCreator.path.GetRotationAtDistance(_distanceTravelled);
    }
}
