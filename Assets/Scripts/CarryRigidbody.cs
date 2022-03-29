using System.Collections.Generic;
using UnityEngine;

public class CarryRigidbody : MonoBehaviour
{
    [SerializeField]
    Transform grabLocation;

    ChestInteract chest;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.GetComponent<ChestInteract>() != null)
        {
            collision.gameObject.GetComponent<BoxCollider>().enabled = false;
            collision.gameObject.GetComponent<Rigidbody>().useGravity = false;
            collision.gameObject.transform.position = grabLocation.position;
            collision.gameObject.transform.parent = transform;
            collision.gameObject.transform.rotation = transform.rotation;
            chest = collision.gameObject.GetComponent<ChestInteract>();
        }

        if (collision.gameObject.GetComponent<ShipInteractScript>())
        {
            if (chest != null)
            {
                chest.resetPos();
                chest = null;
            }
        }
    }
        

    private void FixedUpdate()
    {
        if (chest != null)
        {
            chest.gameObject.transform.position = grabLocation.position;
            chest.gameObject.transform.rotation = transform.rotation;
            
        }
    }

}
