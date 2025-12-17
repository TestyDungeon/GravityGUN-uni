using UnityEngine;

public class Portal : MonoBehaviour
{
    [Header("Settings")]
    public Transform destination; 
    public bool maintainRotation = false; 

    private void OnTriggerEnter(Collider other)
    {

    Debug.Log("Something hit the portal: " + other.name); 
        if (other.CompareTag("Player"))
        {
            TeleportObject(other.transform);
            
        }
    }

    void TeleportObject(Transform target)
    {

        target.position = destination.position;

       
        if (maintainRotation)
        {
            target.rotation = destination.rotation;
        }

    }
}