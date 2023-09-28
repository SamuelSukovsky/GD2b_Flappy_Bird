using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class PipeController : MonoBehaviour
{
    public Transform pipeTop;
    public Transform pipeBot;
    public float spread = 4f;
    public float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        pipeTop.transform.localPosition = Vector3.up * spread;
        pipeBot.transform.localPosition = Vector3.down * spread;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        if (transform.position.x < -3.4f)
        {
            Destroy(gameObject);
        }
    }
}
