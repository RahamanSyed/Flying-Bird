using UnityEngine;

public class TapToPlay : MonoBehaviour
{
    private void Awake() 
    {
        Time.timeScale = 0;
    }
    // Update is called once per frame
    void Update()
    {
      if(Input.GetMouseButtonDown(0))  
      {
        Time.timeScale = 1;
        Destroy(gameObject);
      }
    }
}
