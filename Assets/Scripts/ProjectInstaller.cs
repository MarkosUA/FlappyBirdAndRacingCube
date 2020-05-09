using UnityEngine;
using Zenject;

public class ProjectInstaller : MonoInstaller
{
    [SerializeField]
    private PrefabsID _prefabsID;
    [SerializeField]
    private LocationSettings _locationSettings;
    [SerializeField]
    private HotWheelsSettings _hotWheelsSettings;

    public override void InstallBindings()
    {
        BindAllSO();
    }

    private void BindAllSO()
    {
        Container.Bind<PrefabsID>().FromInstance(_prefabsID).AsSingle();
        Container.Bind<LocationSettings>().FromInstance(_locationSettings).AsSingle();
        Container.Bind<HotWheelsSettings>().FromInstance(_hotWheelsSettings).AsSingle();
    }
}
