using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe_Spawner : MonoBehaviour
{
    public GameObject pipe;
    public float SpawnTime;
    float timer = 0;
    public float Height;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Spawn_Pipe();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > SpawnTime)
        {
            timer = 0;
            Spawn_Pipe();
        }
    }
    private void Spawn_Pipe()
    {
        Instantiate(pipe, transform.position + new Vector3(0,Random.Range(-Height,Height),0), Quaternion.identity);
    }
}
