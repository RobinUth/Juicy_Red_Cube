using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Behaviour : MonoBehaviour {




    [Range(1, 10)]
    [SerializeField] float jumpVelocity;
    [SerializeField] int normalSize = 1;
    [SerializeField] float scalingX = 0.1f;
    [SerializeField] float scalingY = 0.1f;
    [SerializeField] float scalingZ = 0.1f;
    bool size = true;
    Rigidbody rigidbody;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void Update () {

        Jump();


        if (transform.localScale.y <= 0.1f || transform.localScale.x <= 0.1f)
        {
            size = false;
        }


        if (size)
        {
           // SquashStrech();
        }
       if(Input.GetKey(KeyCode.R))
        {
            transform.localScale = new Vector3(normalSize, normalSize, normalSize);
            size = true;
        }
	}

    void Jump()
    {
        if(Input.GetButtonDown("Jump"))
        {
            rigidbody.velocity = Vector3.up * jumpVelocity;


        }
    }
    
    void SquashStrech()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            transform.localScale += new Vector3(scalingX, -scalingY, scalingZ );
            
        }
        if(Input.GetKey(KeyCode.F))
        {
            transform.localScale -= new Vector3(scalingX, -scalingY, scalingZ);
        }
    }
}
