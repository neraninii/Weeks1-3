using UnityEngine;

public class audiencemember : MonoBehaviour
{

    public float speed = 1; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPos = transform.position;
        newPos.y += speed; 
        transform.position = newPos; 

        if (newPos.y > -4 || newPos.y < -6)
        {
            speed *= -1;
        }
        
    }
}
