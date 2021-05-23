using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : MonoBehaviour
{
    private bool triggered = false;
    private bool triggered2 = false;
    public GameObject Player;
    private Animator anim;
 void Start()
    {
        anim = GetComponent<Animator>();
        // Changes the position to x:1, y:1, z:0
        transform.position = new Vector3(238, 4, 283);
        // It is also possible to set the position with a Vector2
        // Moving object on a single axis
        Vector3 newPosition = transform.position; // We store the current position
        newPosition.y = 3; // We set a axis, in this case the y axis
        transform.position = newPosition; // We pass it back
    }
    private void Update()
    {
        if (triggered == false)
        {
            transform.position += new Vector3(-1 * Time.deltaTime, 0, 0);
        }

        else if (triggered == true && triggered2 == false)
        {
            transform.position += new Vector3(0, 0, 1 * Time.deltaTime);
        }
        else if (triggered2 == true)
        {
            transform.position += new Vector3(0, 0, 0);
        }
            



        
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "trigger")
        {
            triggered = true;
            transform.Rotate(0, 90, 0);
        }

        if (other.gameObject.tag == "trigger2")
        {
            triggered2 = true;
            transform.Rotate(0, -90, 0);
            anim.SetBool("isSitting", true);
        }
    }
}