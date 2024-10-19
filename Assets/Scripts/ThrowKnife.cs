using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowKnife : MonoBehaviour
{
    public GameObject knife1;
    public GameObject knife2;
    public Transform knifeOrigin1;
    public Transform knifeOrigin2;
    public Transform camera;

    public KeyCode throwKey = KeyCode.Q;
    public float throwForce;
    public float throwUpwardForce;
    public float throwCooldown;
  


    bool readytoThrow;


    // Start is called before the first frame update
    void Start()
    {
        readytoThrow = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(throwKey) && readytoThrow)
        {
            Throw();
        }
    }

    private void Throw()
    {
        readytoThrow = false;

        //spawn knife
        GameObject clone1 = Instantiate(knife1, knifeOrigin1.position, knife1.transform.rotation);
        GameObject clone2 = Instantiate(knife2, knifeOrigin2.position, knife2.transform.rotation);

        clone1.GetComponent<Rigidbody>().AddForce(transform.forward * throwForce);
        clone2.GetComponent<Rigidbody>().AddForce(transform.forward * throwForce);

        Destroy(clone1, 5);
        Destroy(clone2, 5);




        // add force
        Vector3 forceToAdd = camera.transform.forward * throwForce; //+ transform.up * throwUpwardForce;
       

        //cooldown
        Invoke(nameof(ThrowReset), throwCooldown);

        
    }
    private void ThrowReset()
    {
        readytoThrow = true;
    }
}
