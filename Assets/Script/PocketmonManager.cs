using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PocketmonManager : Singleton<PocketmonManager>
{
    [SerializeField] GameObject _MetaMongPrafab;
    [SerializeField] GameObject _SeedPrafab;

    Dictionary<string,GameObject> Obj = new Dictionary<string, GameObject>();

    public void AddObj(string key,  Transform parentTransform)
    {
        GameObject prefab = Resources.Load<GameObject>(key);
        if (prefab != null)
        {
            GameObject gobj = Instantiate(prefab, parentTransform);
            Obj.Add(key, gobj);
        }
        else
        {
            Debug.LogWarning($"Prefab with name {key} not found in Resources.");
        }
    }

    public GameObject GetObj(string key)
    {
        if (Obj.ContainsKey(key))
        {
            return Obj[key];
        }
        else
        {
            return null;
        }
    }

}
