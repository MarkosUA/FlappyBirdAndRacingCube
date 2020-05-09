using Zenject;

public class Obst2 : Obstacle
{
    [Inject]
    public void Construct(PrefabsID prefabsID)
    {
        id = prefabsID.Obst2_ID;
    }

    public class Factory : PlaceholderFactory<Obst2>
    {

    }
}
