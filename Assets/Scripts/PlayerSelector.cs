using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerSelector : MonoBehaviour
{
public Button next;
public Button prev;
public Button ok;  
public followplayer fp;
 
    public Sprite[] charsSprite;
    public GameObject[] char3d;

    [SerializeField] private GameObject spawner;

    public string[] continentsList;
    public GameObject continentPanel;

    public Image character;


    public GameObject SelectionPanel;

    int charID=0;
    public bool isPlayer2=true;

    Vector3 initPosition=new Vector3(-10f,10f,0f);
    void Start()
    {
    fp=GameObject.Find("MainCamera").GetComponent<followplayer>();
    //spawner=GameObject.Find("BrickSpawner");


    spawner.SetActive(false);

     next.onClick.AddListener(nextPressed);
     prev.onClick.AddListener(prevPressed);
     ok.onClick.AddListener(okPressed);

    }
   

    void InstantiatePrefab(int i)
    {
        GameObject prefabToInstantiate= char3d[i];
 
      if(isPlayer2){
         initPosition=new Vector3(8f,10f,0f);
       }
      GameObject player= Instantiate(prefabToInstantiate, initPosition, Quaternion.Euler(new Vector3 (0, 90, 0)));
      
      if(isPlayer2){
        fp.player2=player.transform;        
        }
        else {
         fp.player1=player.transform; 
         }

       player.tag = "Player";
       player.GetComponent<SimpleController>().isPlayer2=isPlayer2; 

    }

    void nextPressed(){
  gameObject.GetComponent<AudioSource>().Play();
   if (charID>=6){
    charID=0;

   }
   else{
    charID++;
   }
     character.GetComponent<Image>().sprite= charsSprite[charID];
     continentPanel.GetComponent<TMP_Text>().text= continentsList[charID];
    }

      void prevPressed(){
    gameObject.GetComponent<AudioSource>().Play();
 if (charID<=0){
    charID=6;

   }
   else{
    charID--;
   }
character.GetComponent<Image>().sprite= charsSprite[charID];
continentPanel.GetComponent<TMP_Text>().text= continentsList[charID];

    }
  
         void okPressed(){
   SelectionPanel.SetActive(false);
InstantiatePrefab(charID);

 spawner.SetActive(true);



   
    }


}
