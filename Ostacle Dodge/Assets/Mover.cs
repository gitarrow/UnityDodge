using UnityEngine;

public class Mover : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal");
        float yValue = 0;
        float zValue = Input.GetAxis("Vertical");

        transform.Translate(xValue, yValue, zValue); 
        // Translate(x,y,z)
                                       
        // 0.1f "f" = float. This is essentail so that the computer doesnt get confused weather it is double or float or int.
    }
}
