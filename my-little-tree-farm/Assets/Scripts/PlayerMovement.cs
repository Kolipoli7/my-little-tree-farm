using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Debug.Log("PlayerMovement script has started.");
    }


    void Update()
    {
        float InputX = Input.GetAxisRaw("Horizontal");
        float InputY = Input.GetAxisRaw("Vertical");
        Debug.Log($"InputX: {InputX}, InputY: {InputY}");
        Vector3 movement = new Vector3(InputX, 0f, InputY).normalized;
        movement *= speed;
        rb.MovePosition(rb.position + movement * Time.deltaTime);

    }
    
        
    

}
   


    

