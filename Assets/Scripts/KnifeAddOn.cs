using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeAddOn : MonoBehaviour
{
    private Rigidbody rb;

    private bool targetHit;
    private bool activated;
    public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
  
    }

    private void Update()
    {
        if (activated)
        {
            transform.localEulerAngles += transform.forward * rotationSpeed * Time.deltaTime;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (targetHit)
            return;
        else
        {
            targetHit = true;
            activated = false;

            rb.isKinematic = true; // object sticks to surface
            transform.SetParent(collision.transform);
        }
    }
}
