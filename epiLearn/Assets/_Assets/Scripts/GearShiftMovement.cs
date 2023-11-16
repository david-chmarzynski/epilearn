using UnityEngine;

public class GearShiftMovement : MonoBehaviour
{
    private const float targetAngle = 50f; //angle visé max
    private const float tolerance = 1f; // tolérance d'angle 
    private const float vitesseDeplacement = 20f; // La vitesse à laquelle la sphère se déplace.

    private void Update()
    {

        if (Mathf.Abs(transform.rotation.eulerAngles.x - targetAngle) > tolerance) 
        {
            transform.Rotate(new Vector3(vitesseDeplacement, 0f, 0f) * Time.deltaTime);

        }
    }
}
