using UnityEngine;

public class Mover : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] float moveSpeed = 10f; //This variable controls how fast the object moves. You can change it in the Inspector.

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   // Time.deltaTime makes frame rate the same on fast and slow computers.
        
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed; 
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xValue, yValue, zValue);
        // Translate(x,y,z)

        // Note: "f" after a number (e.g., 0.1f) tells the computer it's a float.
        // This prevents confusion with other number types like double or int.
    }
}
