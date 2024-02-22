
using UnityEngine;

public class playercollision : MonoBehaviour
{
    public player pl;

    //public obstaclescript ee;
    //public game rr;
    // Start is called before the first frame update
     void OnCollisionEnter(Collision clold){
if(clold.collider.tag=="obstacle"){
   // Debug.Log("we hit an obstacle");
  // rr.endgame();

//FindObjectOfType<game>().EndGame();
//pl.enabled=false;
}
     }

    // Update is called once per frame
  
}
