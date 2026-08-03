using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 30.0f;

    private PlayerController playerControllerScript;

    private float leftBound = -15;

    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void Update()
    {
        if (playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        if (transform.position.x > leftBound && gameObject.CompareTag("Ostacle") )
        {
            GameObject.Destroy(gameObject);
        }
        
    }
}
