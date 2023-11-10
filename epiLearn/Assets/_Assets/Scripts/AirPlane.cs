using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirPlane : MonoBehaviour
{

    public static AirPlane Instance;
    public float vitesse = 1.0f;

    private Vector3 positionInitiale;
    private Vector3 positionFinale;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        positionInitiale = transform.localPosition;
        positionFinale = new Vector3(positionInitiale.x, positionInitiale.y, -0.2f);
    }

    private void Update()
    {
        transform.localPosition = Vector3.Lerp(transform.localPosition, positionFinale, vitesse * Time.deltaTime);

        if (Vector3.Distance(transform.localPosition, positionFinale) < -0.2f)
        {
            Destroy(this);
        }
    }
}
