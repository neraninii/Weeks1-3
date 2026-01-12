using UnityEngine;

public class bouncingBall : MonoBehaviour
{
   public float speedX = 0.1f;
    public float speedY = 0.1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = (Vector2)transform.position + Random.insideUnitCircle * 9; 
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPosition = transform.position;
        newPosition.x += speedX + Time.deltaTime;
        newPosition.y += speedY + Time.deltaTime;

        transform.position = newPosition;

        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);

        if (screenPos.x < 0 || screenPos.x > Screen.width)
        {
            speedX = speedX * -1;
        }

        if ( screenPos.y < 0 || screenPos.y > Screen.height)
        {
            speedY = speedY * -1;
        }
    }
}
