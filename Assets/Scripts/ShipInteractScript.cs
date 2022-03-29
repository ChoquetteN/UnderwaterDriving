using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipInteractScript : MonoBehaviour, Interact
{
    public Vector3 getPosition()
    {
        return this.gameObject.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
     if (other.GetComponent<Submarine>() != null)
        {
          other.GetComponent<Submarine>().targetChest();
        }
    }
}
