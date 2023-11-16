using UnityEngine;

public class GearShiftMovement : MonoBehaviour
{
    private const float targetAngle = 50f; //angle vis� max
    private const float tolerance = 1f; // tol�rance d'angle 
    private const float vitesseDeplacement = 20f; // La vitesse � laquelle la sph�re se d�place.

    private void Update()
    {

        if (Mathf.Abs(transform.rotation.eulerAngles.x - targetAngle) > tolerance) 
        {
            transform.Rotate(new Vector3(vitesseDeplacement, 0f, 0f) * Time.deltaTime);

        }
    }
}
