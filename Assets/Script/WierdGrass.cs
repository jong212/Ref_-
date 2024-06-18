using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WierdGrass : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject MetaObj = PocketmonManager.Instance.GetObj("Metamong");
            if (MetaObj != null)
            {
                MetaObj.GetComponent<Metamong>().MetaMeta();
            }
        }
    }
}
