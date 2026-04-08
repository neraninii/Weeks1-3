using UnityEngine;

public class audience : MonoBehaviour
{
    public float speed = 2; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPos = transform.position;
        newPos.x += speed; 
        transform.position = newPos; 

        if (newPos.x > 2 || newPos.x < -5)
        {
            speed *= -1;
        }

        
    }

}
