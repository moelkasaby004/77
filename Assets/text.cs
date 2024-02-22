using UnityEngine.UI; 
using UnityEngine;


public class text : MonoBehaviour
{
    // Start is called before the first frame update
public Transform pp;
public Text text2;

    // Update is called once per frame
    void Update()
    {
     text2.text =$"{pp.position.z+94f:0}";

    }
}
