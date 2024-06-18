using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] string _key;

    private void Awake()
    {
        //this._key == _key
        PocketmonManager.Instance.AddObj(_key,this.transform);
    }
}
