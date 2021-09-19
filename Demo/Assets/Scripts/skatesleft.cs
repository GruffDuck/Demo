using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skatesleft : MonoBehaviour
{
    public float speed;
    public float dist;
    private bool rights;
    public Transform groud;
    public GameObject spawn;
    public GameObject skate;
  

    
    void Update()
    {
        if (transform.position.x > -12)
        {
            transform.Translate((Vector2.left*speed*Time.deltaTime));
            RaycastHit2D gc = Physics2D.Raycast(groud.position, Vector2.down, dist); 
        }
       
        else 
        {
            transform.position = spawn.transform.position;
        }
    }
}
