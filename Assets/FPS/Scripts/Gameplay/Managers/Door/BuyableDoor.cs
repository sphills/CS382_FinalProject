using System.Collections;
using System.Collections.Generic;
using Unity.FPS.Gameplay;
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
        PlayerInfo playerInfo = other.GetComponent<PlayerInfo>();
        //Debug.Log($"The player has {(Player) other.GetComponent<PlayerInfo>().GetPlayerPoints()}");
        Debug.Log($"The player has { playerInfo.GetPlayerPoints() } and { (playerInfo.GetPlayerPoints() > DoorPrice ? "can" : "cannot") } buy this door");
    }
}
