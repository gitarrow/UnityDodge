using UnityEngine;

public class Mover : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] float xValue = 0f; //global variable
    [SerializeField] float yValue = 0.01f;
    [SerializeField] float zValue = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(xValue, yValue, zValue); 
        // Translate(x,y,z)
                                       
        // 0.1f "f" = float. This is essentail so that the computer doesnt get confused weather it is double or float or int.
    }
}
