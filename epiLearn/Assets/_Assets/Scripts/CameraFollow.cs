using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    private Vector3 offset = new Vector3(10, 0, 0);

    void Update()
    {
        if (target != null)
        {
            // Suivre la position du target, ajuster selon les besoins
            transform.position = target.position + offset;
            Vector3 cameraPosition = target.position + offset;

            // Optionnel : pour faire pivoter la caméra vers le target
            transform.LookAt(cameraPosition);
        }
    }
}
