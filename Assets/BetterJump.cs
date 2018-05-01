using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetterJump : MonoBehaviour {

    [SerializeField] float fallMultiplier = 2.5f;
    [SerializeField] float lowJumpMultiplier = 2f;

    Rigidbody rigidbody;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if(rigidbody.velocity.y < 0)
        {
            rigidbody.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier-1) * Time.deltaTime;
        }else if(rigidbody.velocity.y > 0 && !Input.GetButton("Jump"))
        {
            rigidbody.velocity += Vector3.up * Physics.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
        }
        
    }
}
