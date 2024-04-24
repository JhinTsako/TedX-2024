using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   // public bool Player1Flag=false;
   // public bool Player2Flag=false;
   public int numberOfPlayersArrived=0;


    [SerializeField] private GameObject winPanel;

    // Start is called before the first frame update
    void Start()
    {
        winPanel.SetActive(false);
    }


     public void Quitgame()
    {
        Application.Quit(); 
          Debug.Log("Application quited");
    }

    void Update()
    {
        if (numberOfPlayersArrived>=2){
               winPanel.SetActive(true);
        }

        if(Input.GetKeyDown(KeyCode.Escape)){
        Quitgame();
      
        }

    }
}
