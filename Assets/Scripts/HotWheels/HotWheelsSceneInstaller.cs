using UnityEngine;
using Zenject;
using PathCreation;

public class HotWheelsSceneInstaller : MonoInstaller
{
    [SerializeField]
    private PathCreator _pathCreator;
    [SerializeField]
    private GameObject _racingCube;

    public override void InstallBindings()
    {
        Container.Bind<PathCreator>().FromInstance(_pathCreator).AsSingle();
        Container.Bind<GameObject>().FromInstance(_racingCube).AsSingle();

        Container.Bind<IRacingCube>().To<RacingCube>().AsSingle();
    }
}
