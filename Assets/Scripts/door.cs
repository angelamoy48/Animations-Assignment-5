using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class door : MonoBehaviour {
	GameObject thedoor;
    public int collect;
    public Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        collect = GameObject.FindGameObjectWithTag("Player").GetComponent<SimpleCharacterControl>().points;
        if (collect >= 3)
        {
            /*thedoor = GameObject.FindWithTag("SF_Door");
            thedoor.GetComponent<Animation>().Play("DoorOpen");*/
            anim.SetBool("Open", true);

        }
        else
        {
            anim.SetBool("Open", false);
        }
    }
}
