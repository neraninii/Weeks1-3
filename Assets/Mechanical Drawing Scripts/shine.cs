using UnityEngine;

public class shine : MonoBehaviour
{
    //setting variables for movement and positions
    public Transform start;
    public Transform end; 
    public float t; 

    public AnimationCurve curve; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //setting time and looping
        t += Time.deltaTime;

        if (t > 1)
        {
            t = 0; 
        }

        //setting linear interpolation
        transform.position = Vector2.Lerp(start.position, end.position, curve.Evaluate(t));
        
    }
}
