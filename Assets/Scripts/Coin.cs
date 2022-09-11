using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float rotateSpeed = 90f;
 
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag != "Player")
        {
            return;
        }
        GameManager.instance.incrementScore();
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, rotateSpeed * Time.deltaTime);
        
    }
}
