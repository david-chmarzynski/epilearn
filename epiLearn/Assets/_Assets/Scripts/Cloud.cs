using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    private Vector3 positionInitiale;
    private Vector3 positionFinale;

    private ParticleSystem.MainModule main;
    private ParticleSystem ps;




    private void Start()
    {
        
        positionInitiale = AirPlane.Instance.transform.localPosition;
        positionFinale = new Vector3(AirPlane.Instance.transform.localPosition.x, AirPlane.Instance.transform.localPosition.y, -0.2f);
        ps = GetComponent<ParticleSystem>();
        main = ps.main;
    }

    private void Update()
    {

        if (Vector3.Distance(AirPlane.Instance.transform.localPosition, positionFinale) < 0.2f)
        {
            ps.Stop();
        }
    }
}
