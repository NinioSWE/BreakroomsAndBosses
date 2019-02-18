using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour {

    public bool isInteracting = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Interactable")
        {
            Debug.Log("Interaction Hover over " + collision.name);
            collision.SendMessage("Hover");            
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (isInteracting)
        {
            Debug.Log("Interacting with " + collision.name);
            if (collision.tag == "Interactable")
            {
                collision.SendMessage("Interact");
                isInteracting = false;

            }
        }
    }
}
