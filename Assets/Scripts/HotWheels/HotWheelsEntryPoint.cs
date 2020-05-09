using UnityEngine;
using Zenject;

public class HotWheelsEntryPoint : MonoBehaviour
{
    private IRacingCube _racingCube;

    [Inject]
    public void Construct(IRacingCube racingCube)
    {
        _racingCube = racingCube;
    }

    private void Update()
    {
        _racingCube.RacingCubeMovement();
    }
}
