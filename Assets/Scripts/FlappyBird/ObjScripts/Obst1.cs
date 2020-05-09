using Zenject;

public class Obst1 : Obstacle
{
    [Inject]
    public void Construct(PrefabsID prefabsID)
    {
        id = prefabsID.Obst1_ID;
    }

    public class Factory : PlaceholderFactory<Obst1>
    {

    }
}
