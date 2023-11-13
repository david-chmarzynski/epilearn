using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedLine : MonoBehaviour
{
    public TrailRenderer trailRenderer;
    public float speedMultiplier = 0.1f;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (rb != null)
        {
            float speed = rb.velocity.magnitude * speedMultiplier;
            if (trailRenderer != null)
            {
                trailRenderer.startWidth = Mathf.Clamp(speed, 0.1f, 1.0f);
                trailRenderer.endWidth = Mathf.Clamp(speed, 0.1f, 0.5f);
            }
        }
            
    }
}
