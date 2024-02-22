
using UnityEngine;

public class camerasettings : MonoBehaviour
{
    public Transform player;
    public Vector3 memo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position=player.position+memo;
    }
}
