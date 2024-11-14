using System.Collections;
using System.Collections.Generic;
using Unity.FPS.Gameplay;
using UnityEngine;

public class BuyableDoor : MonoBehaviour
{
    [Header("Door Price")]
    [Tooltip("The cost in points a player must pay to open the door.")]
    int DoorPrice = 1500;
    
    [Header("Distance to Move Upwards")]
    [Tooltip("The distance the object should move upwards.")]
    public float moveDistance = 5.0f; // Distance stored on the instance

    bool purchased = false;
    Renderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        PlayerInfo playerInfo = other.GetComponent<PlayerInfo>();
        if (playerInfo != null && !purchased) {
            Debug.Log($"The player has ${ playerInfo.GetPlayerPoints() } and { (playerInfo.GetPlayerPoints() > DoorPrice ? "can" : "cannot") } buy this door{ (playerInfo.GetPlayerPoints() > DoorPrice ? "!" : ".") }");
            if (playerInfo.GetPlayerPoints() >= DoorPrice) {
                playerInfo.DeductPlayerPoints(DoorPrice);
                renderer.material.color = Color.green;
                purchased = true;
                MoveUp();
            }
        }
    }

    void OnTriggerExit(Collider other) {
        if (!purchased) {
            renderer.material.color = Color.red;
        }
    }

    public void MoveUp()
    {
        StartCoroutine(MoveUpCoroutine(0.25f));  // 0.25 seconds duration
    }

    private IEnumerator MoveUpCoroutine(float duration)
    {
        Vector3 startPosition = transform.position;
        Vector3 targetPosition = startPosition + new Vector3(0, moveDistance, 0);
        float elapsedTime = 0;

        while (elapsedTime < duration)
        {
            transform.position = Vector3.Lerp(startPosition, targetPosition, elapsedTime / duration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // Ensure final position is exactly the target position
        transform.position = targetPosition;
    }
}
