using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyableDoor : MonoBehaviour
{
    [Header("Door Price")]
    [Tooltip("The cost in points a player must pay to open the door.")]
    public int DoorPrice = 1500;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hello there!");
    }
}
