using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletController : MonoBehaviour
{
    public float Speed;
    private Rigidbody2D _compRigidBody;
    // Start is called before the first frame update
    void Awake()
    {
        _compRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame

    private void FixedUpdate()
    {
        _compRigidBody.velocity = new Vector2(Speed * 1, 0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag =="littleEnemy")
        {
            Destroy(this.gameObject);
        }
        else if(collision.gameObject.tag == "floor")
        {
            Destroy(this.gameObject);
        }
    }
}
