using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform player;

    public bool thirdPerson = true;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
  

    // Update is called once per frame
    void Update()
    {
        if (thirdPerson == true) { 
        transform.rotation = player.transform.rotation;
        transform.position = player.transform.position;
        transform.Translate(Vector3.back * 3);
        transform.Translate(Vector3.up);
        }
    }
}
