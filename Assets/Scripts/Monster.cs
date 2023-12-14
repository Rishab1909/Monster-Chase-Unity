using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [HideInInspector]
    public float speed;

    private Rigidbody2D myRigidBody;
    // Start is called before the first frame update

    void Awake()
    {
        myRigidBody = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        myRigidBody.velocity = new Vector2(speed, myRigidBody.velocity.y);
    }
}
 