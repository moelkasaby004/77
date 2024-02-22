
using UnityEngine;

public class playercollision : MonoBehaviour
{
    public player pl;
  public game _game;
    //public obstaclescript ee;
    //public game rr;
    // Start is called before the first frame update
     void OnCollisionEnter(Collision clold){
if(clold.collider.tag=="obstacle"){
   // Debug.Log("we hit an obstacle");
  // rr.endgame();
_game.EndGame();
   Debug.Log(FindObjectOfType<game>().name);
//pl.enabled=false;
}
     }

    // Update is called once per frame
  
}
