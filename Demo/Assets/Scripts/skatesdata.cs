using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class skatesdata : MonoBehaviour
{
    public List<string> correctAnswers = new List<string>(); 
    public List<string> incorrectAnswers = new List<string>();
    public GameObject spawnobject;
    public GameObject spawner1,spawner2,spawner3;
    int k = 0;
    int l= 0;
    int m = 0;

    private int timer=0;
   
    void Start()
    {
        SpawnSkates();
    }

   
    void Update()
    {
        
    }

    public void SpawnSkates()
    {
        int sums=(correctAnswers.Count + incorrectAnswers.Count);
        if (sums % 3 == 1)
        {
            for (int i = 0; i < (correctAnswers.Count + incorrectAnswers.Count) / 3; i++)
            {
           
          
                GameObject temp=  Instantiate(spawnobject,
                    new Vector3(spawner1.transform.position.x + k, spawner1.transform.position.y,
                        spawner1.transform.position.z), quaternion.identity);
                k+=6;
                temp.transform.parent = spawner1.transform;
            }
            for (int i = 0; i < ((correctAnswers.Count + incorrectAnswers.Count) / 3)+1; i++)
            {
           
          
                GameObject temp=  Instantiate(spawnobject,
                    new Vector3(spawner2.transform.position.x + l, spawner2.transform.position.y,
                        spawner2.transform.position.z), quaternion.identity);
                l-=5;
                temp.transform.parent = spawner2.transform;
                timer++;
            }
            for (int i = 0; i < (correctAnswers.Count + incorrectAnswers.Count) / 3; i++)
            {
           
          
                GameObject temp=  Instantiate(spawnobject,
                    new Vector3(spawner3.transform.position.x + m, spawner3.transform.position.y,
                        spawner3.transform.position.z), quaternion.identity);
                m+=4;
                temp.transform.parent = spawner3.transform;
                
            }
        }else if (sums % 3 == 2 || sums % 3 == -2)
        {
            for (int i = 0; i < ((correctAnswers.Count + incorrectAnswers.Count) / 3)+1; i++)
            {
           
          
                GameObject temp=  Instantiate(spawnobject,
                    new Vector3(spawner1.transform.position.x + k, spawner1.transform.position.y,
                        spawner1.transform.position.z), quaternion.identity);
                k+=6;
                temp.transform.parent = spawner1.transform;
                
            }
            for (int i = 0; i < ((correctAnswers.Count + incorrectAnswers.Count) / 3); i++)
            {
           
          
                GameObject temp=  Instantiate(spawnobject,
                    new Vector3(spawner2.transform.position.x + l, spawner2.transform.position.y,
                        spawner2.transform.position.z), quaternion.identity);
                l-=5;
                temp.transform.parent = spawner2.transform;
                timer++;
            }
            for (int i = 0; i < ((correctAnswers.Count + incorrectAnswers.Count) / 3)+1; i++)
            {
           
          
                GameObject temp=  Instantiate(spawnobject,
                    new Vector3(spawner3.transform.position.x + m, spawner3.transform.position.y,
                        spawner3.transform.position.z), quaternion.identity);
                m+=4;
                temp.transform.parent = spawner3.transform;
                
            }
        }
       
    }
}
