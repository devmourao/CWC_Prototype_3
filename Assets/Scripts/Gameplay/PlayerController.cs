using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    private Animator playerAnim;

    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParticle;

    public float jumpForce = 10f;
    public float gravityModifier;
    public bool isOnGround = true;
    public bool gameOver = false;


    public InputAction jumpAction;

    
    
    
    

    
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
       
        jumpAction.Enable();

        Physics.gravity *= gravityModifier;

        playerAnim = GetComponent<Animator>();

    }

    void Update()
    {
        if (jumpAction.triggered  && isOnGround  && !gameOver)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse );

            isOnGround = false;

            playerAnim.SetTrigger("Jump_trig");

            dirtParticle.Stop();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            dirtParticle.Play();
        }

        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            gameOver = true;
            Debug.Log("Game Over!");

            // Play death animation
            explosionParticle.Play();
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
            dirtParticle.Stop();
        }
    }
}
