using UnityEngine;
using UnityEngine.InputSystem.LowLevel;

public class cameraController : MonoBehaviour
{
    public GameObject player;
    [SerializeField] private float mouseSensitivity = 100f;
    private float yRotation = 0f;
    private Vector2 mouseInput;
    void Start()
    {
        Debug.Log("Camera Controller script is running."); 
        Cursor.lockState = CursorLockMode.Locked;
    }

    
    void Update()
    {
        mouseInput = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

        player.transform.Rotate(Vector3.up * mouseSensitivity * mouseInput.x * Time.deltaTime);
        yRotation += mouseInput.y * mouseSensitivity * Time.deltaTime;
        yRotation = Mathf.Clamp(yRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(-yRotation, 0f, 0f);

    }
}
