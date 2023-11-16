using UnityEngine;

public class DeplacementSphere : MonoBehaviour
{
    private void Start()
    {
        //position d'origine
        Debug.Log("Rotation initiale : " + transform.rotation.eulerAngles.x);
        transform.rotation = Quaternion.Euler(-50f, 0f, 0f);
    }

    private void Update()
    {
        Debug.Log("Update appel�");
        float vitesseDeplacement = 1f; // La vitesse � laquelle la sph�re se d�place.

        // D�placement de la sph�re sur l'axe X de la rotation.
        transform.Rotate(new Vector3(vitesseDeplacement, 0f, 0f) * Time.deltaTime);

        // Arr�ter la rotation � la position finale.
        if (transform.rotation.eulerAngles.x >= 50f)
        {
      
        }
    }
}
