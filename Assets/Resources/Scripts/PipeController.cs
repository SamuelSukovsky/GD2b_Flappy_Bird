using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : MonoBehaviour
{
    public Transform pipeTop;
    public Transform pipeBot;
    public Vector3 spread = new (0f, 4f, 0f);

    // Start is called before the first frame update
    void Start()
    {
        pipeTop.transform.localPosition = spread;
        pipeBot.transform.localPosition = -spread;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
