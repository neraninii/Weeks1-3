using UnityEngine;

public class light : MonoBehaviour
{
    //setting variables for movement
    public AnimationCurve curve;
    public float t = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //setting time and looping
        t += Time.deltaTime; 

        if (t > 1.2)
        {
            t = 0; 
        }

        //setting sizing with animation curves
        float y = curve.Evaluate(t); 

        transform.localScale = Vector3.one * curve.Evaluate(t);



        
    }
}
