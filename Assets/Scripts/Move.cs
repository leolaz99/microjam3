using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float thrust;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            rb.AddForce(Vector2.right * thrust);
    }
}
