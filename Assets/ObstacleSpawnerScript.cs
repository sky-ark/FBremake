using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawnerScript : MonoBehaviour
{
    public GameObject obstacle;

    public float spawnRate = 5;

    public float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate) timer += Time.deltaTime;
        else
        {
            Instantiate(obstacle, transform.position, transform.rotation);
            timer = 0;
        }
    }
}
