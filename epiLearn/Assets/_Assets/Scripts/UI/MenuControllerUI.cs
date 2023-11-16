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
        Debug.Log("Update appelé");
        float vitesseDeplacement = 1f; // La vitesse à laquelle la sphère se déplace.

        // Déplacement de la sphère sur l'axe X de la rotation.
        transform.Rotate(new Vector3(vitesseDeplacement, 0f, 0f) * Time.deltaTime);

        // Arrêter la rotation à la position finale.
        if (transform.rotation.eulerAngles.x >= 50f)
        {
      
        }
    }
}
