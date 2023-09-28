using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float height = 2f;
    public float queue = 1.5f;
    private float time = 0f;
    public GameObject pipes;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(time >= queue)
        {
            GameObject go = Instantiate(pipes);
            go.transform.position = new Vector3(3.4f, Random.Range(-height, height), 0f);
            time = 0f;
        }
        time += Time.deltaTime;
    }
}
