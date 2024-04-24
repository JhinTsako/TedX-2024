using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagChecker : MonoBehaviour
{
    public GameManager gm;
    void OnTriggerEnter(Collider other){
     if(other.gameObject.CompareTag("Player")){
     gm.numberOfPlayersArrived++;
    Destroy(other.gameObject);
     }
     }
}
