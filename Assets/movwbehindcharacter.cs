using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movwbehindcharacter : MonoBehaviour

{
    public GameObject character;
public float damping = 1;
Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = character.transform.position - transform.position;
    }

    // Update is called once per frame
    
    void Update(){
       // float currentAngle = transform.eulerAngles.y;
        float desiredAngle = character.transform.eulerAngles.y-90;
       // float angle = Mathf.LerpAngle(currentAngle,desiredAngle,Time.deltaTime * damping);
        Quaternion rotation = Quaternion.Euler(0,desiredAngle,0);
        transform.position = character.transform.position - (rotation*offset);
        transform.LookAt(character.transform);
    }
}
