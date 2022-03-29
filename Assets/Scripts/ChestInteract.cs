using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestInteract : MonoBehaviour, Interact
{

    [SerializeField]
    ChestSpawnManager chestSpawnManager;

    private void Start()
    {
        resetPos();
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<Submarine>() != null)
        {
            other.GetComponent<Submarine>().targetShip();
        }
    }

    public void resetPos()
    {
        gameObject.GetComponent<BoxCollider>().enabled = true;
        gameObject.GetComponent<Rigidbody>().useGravity = true;
        this.transform.parent = null;
        this.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0); 
        this.transform.position = chestSpawnManager.getNewChestLocation();
    }

    public Vector3 getPosition()
    {
        return this.gameObject.transform.position;
    }
}
