using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pet : MonoBehaviour
{
    public Transform target;
    public Transform myTransform;
    public bool Move = true;
    // Update is called once per frame
    void Update()
    {
        if (Move == true)
        {
            transform.LookAt(target);
            transform.Translate(Vector3.forward * 3 * Time.deltaTime);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            transform.Translate(Vector3.forward * 0 * 0);
            Move = false;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Move = true;
        }
    }
}
