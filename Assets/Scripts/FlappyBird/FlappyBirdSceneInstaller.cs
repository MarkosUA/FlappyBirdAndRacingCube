using UnityEngine;
using Zenject;

public class FlappyBirdSceneInstaller : MonoInstaller
{
    [SerializeField]
    private Obst1 _obst1;
    [SerializeField]
    private Obst2 _obst2;
    [SerializeField]
    private Bird _bird;
    [SerializeField]
    private ObstaclesController _obstacles;
    [SerializeField]
    private PlayerController _playerController;
    [SerializeField]
    private Scores _scores;
    [SerializeField]
    private FinalPopup _finalPopup;
    [SerializeField]
    private StartText _startText;

    public override void InstallBindings()
    {
        BindAllInterfaces();
        BindAllFabrics();
        BindFromInstance();
    }

    private void BindAllInterfaces()
    {
        Container.Bind<IFlappyBirdGameController>().To<FlappyBirdGameController>().AsSingle();
        Container.Bind<IPool>().To<Pool>().AsSingle();
        Container.Bind<ICreationManager>().To<CreationManager>().AsSingle();
        Container.Bind<IObstaclesCreater>().To<ObstaclesCreater>().AsSingle();
    }

    private void BindAllFabrics()
    {
        Container.BindFactory<Obst1, Obst1.Factory>().FromComponentInNewPrefab(_obst1).AsSingle();
        Container.BindFactory<Obst2, Obst2.Factory>().FromComponentInNewPrefab(_obst2).AsSingle();
        Container.BindFactory<Bird, Bird.Factory>().FromComponentInNewPrefab(_bird).AsSingle();
    }

    private void BindFromInstance()
    {
        Container.Bind<Bird>().FromInstance(_bird).AsSingle();
        Container.Bind<ObstaclesController>().FromInstance(_obstacles).AsSingle();
        Container.Bind<PlayerController>().FromInstance(_playerController).AsSingle();
        Container.Bind<Scores>().FromInstance(_scores).AsSingle();
        Container.Bind<FinalPopup>().FromInstance(_finalPopup).AsSingle();
        Container.Bind<StartText>().FromInstance(_startText).AsSingle();
    }
}
