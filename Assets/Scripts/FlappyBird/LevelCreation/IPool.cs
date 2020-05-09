using UnityEngine;

public interface IPool
{
    void Push(GameObject gameObject, int id);
    GameObject Pull(int id);
}
