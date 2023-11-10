using UnityEngine;

public class Anemometer : MonoBehaviour
{
    public Transform pointer;
    private const float targetAngle = 290f;
    private const float tolerance = .5f; // Tolérance de 5 degrés

    void Update()
    {
        // Normalise l'angle entre 0 et 360 degrés
        float currentAngle = pointer.transform.eulerAngles.y % 360;

        // Vérifie si l'angle est dans la plage de tolérance
        if (Mathf.Abs(currentAngle - targetAngle) > tolerance)
        {
            pointer.transform.Rotate(0.0f, 20.0f * Time.deltaTime, 0.0f);
        }
    }
}