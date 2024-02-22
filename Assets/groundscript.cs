
using Unity.VisualScripting;
using UnityEngine;

public class groundscript : MonoBehaviour
{
    Quaternion ffr = Quaternion.identity;
    public GameObject ww;
   public void  OnTriggerEnter(Collider collo){
if(collo.CompareTag("Player")){


GameObject ggt=Instantiate(ww,new Vector3{x=transform.position.x,y=transform.position.y,z=transform.position.z+400f},ffr);
Destroy(this);

}

   }
   
}
