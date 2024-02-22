
using UnityEngine;
using UnityEngine.SceneManagement;

public class game : MonoBehaviour
{
    bool gameendd=false;
    public void EndGame() {
        if (gameendd==false){
        Debug.Log("memememe");
        gameendd=true;
        Invoke("restart",2);
    }
    }
    void restart(){
SceneManager.LoadScene(SceneManager.GetActiveScene().name);



    }
    // Start is called before the first frame update
   
}
