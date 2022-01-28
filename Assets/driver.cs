using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class driver : MonoBehaviour
{
    [SerializeField]float steerSpeed=0.1f;
    [SerializeField]float moveSpeed=0.01f;
    [SerializeField] float bootsSpeed=30f;
    // Start is called before the first frame update
    void Start()
    {
     
    
        
    }

    // Update is called once per frame
    void Update()
    {
        // input.getAxis take user input 
        float steerAmount=Input.GetAxis("Horizontal")* steerSpeed*Time.deltaTime;
        float moveAmount=Input.GetAxis("Vertical")* moveSpeed*Time.deltaTime;
transform.Rotate(0,0,steerAmount);
transform.Translate(0,moveAmount,0);
    }
     void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag =="Boost"){
moveSpeed=bootsSpeed;
        }
    }
}
