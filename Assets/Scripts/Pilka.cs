using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pilka : MonoBehaviour
{

    [SerializeField] Vector3 spawnpoint = new Vector3(x:0,y:0,z:0);
    [SerializeField] Vector3 startingVelocity;
    [SerializeField] Skrypt paddle_01;
    [SerializeField] Skrypt paddle_02;
    [SerializeField] Text tekst1;
    [SerializeField] Text tekst2;
    Vector3 velocity = new Vector3(x:0,y:0,z:0);
    [SerializeField] int cunter1 =0;
    [SerializeField] int cunter2 =0;
    void Start()
    {
        gameObject.transform.position = spawnpoint;
        velocity = startingVelocity;
        
    }


    void Update()
    {
        var position = gameObject.transform.position;
        position = position + velocity;
        gameObject.transform.position = position;
        tekst1.text = cunter1.ToString();
        tekst2.text = cunter2.ToString();
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Paddle_1")) {
            velocity = new Vector3(velocity.x + paddle_01.actualVelocity, -velocity.y, 0);
        }
        if (other.gameObject.CompareTag("Paddle_2"))
        {
            velocity = new Vector3(velocity.x + paddle_02.actualVelocity, -velocity.y, 0);
        }
        if (other.gameObject.CompareTag("wall1")) {
            velocity = new Vector3(-velocity.x, velocity.y, 0);
        }
        if (other.gameObject.CompareTag("wall2"))        {
            velocity = new Vector3(-velocity.x, velocity.y, 0);
        }
        if (other.gameObject.CompareTag("Counter1"))        {
           gameObject.transform.position = spawnpoint;
            velocity = startingVelocity;
            cunter2 =+ 1; 
        }
        if (other.gameObject.CompareTag("Counter2"))        {
            gameObject.transform.position = spawnpoint;
            velocity = startingVelocity; 
            cunter1 =+ 1;
        }
    }
}
