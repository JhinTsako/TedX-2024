using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColor : MonoBehaviour
{
  
    public Material[] coloredMaterials;
    public int randomNumber;
    void Start()
    {
        randomNumber=Random.Range(0,7);
        gameObject.GetComponent<Renderer>().material=coloredMaterials[randomNumber];

    }

}
