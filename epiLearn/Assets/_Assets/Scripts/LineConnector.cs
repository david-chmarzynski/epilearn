using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineConnector : MonoBehaviour
{
    public GameObject[] _objs;

    private LineRenderer line;

    private void Start()
    {
        line = this.gameObject.GetComponent<LineRenderer>();
    }

    private void Update()
    {
        for(int i = 0; i < _objs.Length; i++)
        {
            line.SetPosition(i, _objs[i].transform.position);
        }
    }
}
