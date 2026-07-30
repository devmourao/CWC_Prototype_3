using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 30.0f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
