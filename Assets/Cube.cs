using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour{

   public bool CubeOnTheGround = true;
   public float speed = 10f;
   public Rigidbody rb;
   

    public void Start(){
       rb = GetComponent<Rigidbody>();
   }

        // Update is called once per frame
    void Update()
    {
                transform.Translate(Input.GetAxis("Horizontal") *Time.deltaTime *speed, 0, Input.GetAxis("Vertical") *Time.deltaTime *speed);

                if(Input.GetButtonDown("Jump") && CubeOnTheGround ){              
                rb.AddForce(new Vector3(0, 6, 0), ForceMode.Impulse);
                CubeOnTheGround = false;}
    }
 void OnCollisionEnter(Collision other) {
    if(other.gameObject.tag == "Untagged")
    CubeOnTheGround = true;
}

    }



 

