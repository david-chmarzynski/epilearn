using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deformation : MonoBehaviour
{
    public float deformationForce = 10.0f;

    private void OnTriggerEnter(Collider other)
    {
        Rigidbody otherRigidbody = other.GetComponent<Rigidbody>();
        Debug.Log(otherRigidbody);
        if (otherRigidbody != null)
        {
            // Appliquer une force pour simuler la déformation
            otherRigidbody.AddForce(transform.forward * deformationForce, ForceMode.Force);
        }
    }
}
