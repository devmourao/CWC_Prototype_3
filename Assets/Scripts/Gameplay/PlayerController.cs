using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public InputAction jumpAction;

    public float jumpForce = 10f;
    public float gravityModifier;
    public bool isOnGround = true;
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
       
        jumpAction.Enable();

        Physics.gravity *= gravityModifier;

        

    }

    // Update is called once per frame
    void Update()
    {
        if (jumpAction.triggered  && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse );

            isOnGround = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
    }


}
