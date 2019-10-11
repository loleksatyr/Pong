using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skrypt : MonoBehaviour
{
    [SerializeField] KeyCode moveLeft;
    [SerializeField] KeyCode moveRight;

    [SerializeField] float velocity = 0.1f;
    public float actualVelocity = 0;
    //wyświetla edytor ptwyatny
   /* void Awake()
    {
        
    }
    //wybudzenie obiektu
    */
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(moveLeft)){
            actualVelocity = -velocity;
            var positionX= gameObject.transform.position.x;
            positionX = positionX + actualVelocity;
            gameObject.transform.position = new Vector3(positionX, gameObject.transform.position.y, gameObject.transform.position.z);
        }
        if (Input.GetKey(moveRight))
        {
            actualVelocity = velocity;
            var positionX = gameObject.transform.position.x;
            positionX = positionX + actualVelocity;
            gameObject.transform.position = new Vector3(positionX, gameObject.transform.position.y, gameObject.transform.position.z);
        }
    }
     




    void FixedUpdate()
    {
        
    }
    //konkretna ilość czasu
    void LateUpdate()
    {
        
    }
    //po update
}
