using UnityEngine;
using UnityEngine.InputSystem;

public class Lightstick : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        if (mousePos.x > -5 && mousePos.x < 10 && mousePos.y < -2 && mousePos.y > -4)
        {
            transform.position = mousePos;
        }

    }
}
