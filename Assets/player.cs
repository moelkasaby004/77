
using UnityEngine;

public class player : MonoBehaviour
{public Rigidbody rb;

  public int force=2000;
  public float stering=350f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
   
        rb.AddForce(0,0,force*Time.deltaTime);
        if (Input.GetKey("d")){
rb.AddForce(stering,0,0);
        }
        if (Input.GetKey("a")){
            rb.AddForce(-stering,0,0);
            
        }
        if (Input.GetKey("space")){
            rb.AddForce(0,16,0);
        }
         if (Input.GetKey("s")){
            rb.AddForce(0,0,-stering);
            
        }
    }
}
