using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public PlayerMovement playerMovement;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            playerMovement.isGrounded = true;
            Debug.Log("Player is grounded.");
        }   
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            playerMovement.isGrounded = false;
            Debug.Log("Player is not grounded.");
        }
    }   

}
