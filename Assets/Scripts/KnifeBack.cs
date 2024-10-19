using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeBack : MonoBehaviour
{
    public GameObject clone1;
    public GameObject clone2;
    public GameObject player;

    public float speed;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            clone1.transform.position = Vector3.MoveTowards(clone1.transform.position, player.transform.position, speed);
            clone2.transform.position = Vector3.MoveTowards(clone2.transform.position, player.transform.position, speed);
        }
    }
}
