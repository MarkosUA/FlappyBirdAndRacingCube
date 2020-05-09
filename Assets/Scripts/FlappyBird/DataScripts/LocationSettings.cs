using UnityEngine;

[CreateAssetMenu(fileName = "LocationSettings", menuName = "Data/FlappyBirdData/LocationSettings")]
public class LocationSettings : ScriptableObject
{
    public float MaxHeight;
    public float MinHeight;
    public float DistanceBetweenObst;
    public float Speed;
    public float JumpForce;
}
