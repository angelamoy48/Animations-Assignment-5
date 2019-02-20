using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class door2 : MonoBehaviour{
    GameObject thedoor2;
    public int collect2;
    public Animator anim2;

    void Start()
    {
        anim2 = GetComponent<Animator>();
    }

    void Update()
    {
        collect2 = GameObject.FindGameObjectWithTag("Player").GetComponent<SimpleCharacterControl>().points;
        if (collect2 >= 6)
        {
            /*thedoor = GameObject.FindWithTag("SF_Door");
            thedoor.GetComponent<Animation>().Play("DoorOpen");*/
            anim2.SetBool("Open2", true);

        }
        else
        {
            anim2.SetBool("Open2", false);
        }
    }
}

