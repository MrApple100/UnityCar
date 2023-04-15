using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touchable : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Player;
    public GameObject[] Objects = new GameObject[1];
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i=0;i<Objects.Length;i++){

            Vector3 distanceToPlayer = Objects[i].transform.position - Player.transform.position;
            print("i "+i+" distanceToPlayer "+Mathf.Sqrt(distanceToPlayer.z*distanceToPlayer.z+distanceToPlayer.y*distanceToPlayer.y+distanceToPlayer.x*distanceToPlayer.x) );

           if(Mathf.Sqrt(distanceToPlayer.z*distanceToPlayer.z+distanceToPlayer.y*distanceToPlayer.y+distanceToPlayer.x*distanceToPlayer.x)< 3){
                Objects[i].SetActive(false);
                print("i "+i+" touch");
           }
        }
        
        
    }
}
