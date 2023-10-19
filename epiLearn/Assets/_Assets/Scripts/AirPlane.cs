using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirPlane : MonoBehaviour
{
    public float vitesse = 1.0f; // Vitesse de d?placement (modifiable dans l'?diteur Unity)

    private Vector3 positionInitiale; // Position de d?part
    private Vector3 positionFinale;   // Position cible (Z=0)

    private void Start()
    {
        // Sauvegarde de la position initiale du GameObject
        positionInitiale = transform.localPosition;
        // D?finition de la position cible en utilisant la position actuelle avec Z=0
        positionFinale = new Vector3(positionInitiale.x, positionInitiale.y, -0.2f);
    }

    private void Update()
    {
        // Interpolation lin?aire de la position actuelle vers la position cible
        transform.localPosition = Vector3.Lerp(transform.localPosition, positionFinale, vitesse * Time.deltaTime);

        // Si le GameObject est suffisamment proche de la position cible, vous pouvez arr?ter le d?placement
        //if (Vector3.Distance(transform.position, positionFinale) < -0.2f)
        //{
        //    // Optionnel : Vous pouvez effectuer des actions ou arr?ter le d?placement ici
        //    // Exemple : d?truire le script, d?sactiver le GameObject, etc.
        //    Destroy(this);
        //}
    }
}
