using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class Correctincorrect : MonoBehaviour
{
    public GameObject[] correct, incorrect;
    private int correctsayac,incorrectsayac;
    public Text text,text2;
    public bool space = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            space = true;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            space = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        
        if (space == true) 
        {Debug.Log("sa");
           
                
                  
            if (other.gameObject.tag =="Correct")
                {
                    correctsayac++;
                    other.gameObject.GetComponentInChildren<SpriteRenderer>().color = Color.green;
                    text.text = "Correct Answers: " + correctsayac;
                }  
                else 
                {
                    incorrectsayac++;
                    other.gameObject.GetComponentInChildren<SpriteRenderer>().color = Color.red;
                    text2.text = "Incorrect Answers: " + incorrectsayac;
                }
            
        }
        
     
    }
}
