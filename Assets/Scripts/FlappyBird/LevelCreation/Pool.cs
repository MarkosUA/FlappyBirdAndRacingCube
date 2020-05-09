using UnityEngine;
using System.Collections.Generic;

public class Pool : IPool
{
    private PrefabsID _prefabsID;
    private Obst1.Factory _obst1Factory;
    private Obst2.Factory _obst2Factory;

    private Dictionary<int, Stack<GameObject>> _pool = new Dictionary<int, Stack<GameObject>>();

    public Pool(PrefabsID prefabsID, Obst1.Factory obst1Factory, Obst2.Factory obst2Factory)
    {
        _prefabsID = prefabsID;
        _obst1Factory = obst1Factory;
        _obst2Factory = obst2Factory;
    }

    public void Push(GameObject gameObject, int id)
    {
        gameObject.SetActive(false);

        if (_pool.ContainsKey(id))
        {
            var stack = _pool[id];
            stack.Push(gameObject);
        }
        else
        {
            var stack = new Stack<GameObject>();
            stack.Push(gameObject);
            _pool.Add(id, stack);
        }
    }

    public GameObject Pull(int id)
    {
        if (_pool.ContainsKey(id))
        {
            var stack = _pool[id];

            if (stack.Count > 0)
            {
                var obj = stack.Pop();
                obj.SetActive(true);
                return obj;
            }
        }
        return Create(id);
    }

    private GameObject Create(int id)
    {
        if (id == _prefabsID.Obst1_ID)
        {
            return _obst1Factory.Create().gameObject;
        }
        else
        {
            return _obst2Factory.Create().gameObject;
        }
    }
}
