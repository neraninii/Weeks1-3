using UnityEngine;

public class audience : MonoBehaviour
{
    //setting speed variables
    public float speed = 2; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //creating movement on the x-axis
        Vector2 newPos = transform.position;
        newPos.x += speed; 
        transform.position = newPos; 

        //setting bounds to change direction 
        if (newPos.x > 2 || newPos.x < -5)
        {
            speed *= -1;
        }

        
    }

}
