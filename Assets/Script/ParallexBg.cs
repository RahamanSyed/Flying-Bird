using UnityEngine;

public class ParallexBg : MonoBehaviour
{   public float parallaxSpeed;
    Vector3 startPosition;
    public float endPoint;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if(transform.position.x <= endPoint)
        {
            transform.position = startPosition;
        }
        transform.position += Vector3.left * parallaxSpeed * Time.deltaTime;
    }
}
