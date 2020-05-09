using UnityEngine;

public class ObstaclesCreater : IObstaclesCreater
{
    private IPool _pool;

    private ObstaclesController _obstacles;
    private PrefabsID _prefabsID;

    public ObstaclesCreater(ObstaclesController obstacles, PrefabsID prefabsID, IPool pool)
    {
        _obstacles = obstacles;
        _prefabsID = prefabsID;
        _pool = pool;
    }

    public void CreateObstacles(Vector3 coordinates)
    {
        var randId = Random.Range(_prefabsID.Obst1_ID, _prefabsID.Obst2_ID + 1);

        var newObst = _pool.Pull(randId);
        newObst.transform.position = coordinates;
        newObst.transform.SetParent(_obstacles.transform);
    }
}
