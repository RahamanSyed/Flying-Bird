using UnityEngine;

public class PipesMove : MonoBehaviour
{   public float pipespeed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.right) * pipespeed * Time.deltaTime;
    }
}