using Unity.VisualScripting.Antlr3.Runtime.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameManager gameManager;
    public float velocity = 2.4f;
    private Rigidbody2D rigidbody;
    public bool isDead = false;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(!collision.gameObject.CompareTag("Ground"))
        {
            isDead = true;
            gameManager.GameOver();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rigidbody.velocity = Vector2.up * velocity;
        }
    } 
}
