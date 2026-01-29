using UnityEngine;

public class playercontroller : MonoBehaviour
{
    public float moveSpeed = 12;
    public CharacterController characterController;

    private void Awake()
    {
        characterController = GetComponent<CharacterController>(); 
    }

    private void Update()
    {
        float x = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float z = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        Vector3 move = transform.right * x + transform.forward * z;
        characterController.Move(move);


    }
}
