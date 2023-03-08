using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 10;
    public float deadZone = -30;
    
    void Start()
    {
        
    }
    void Update()
    {
        if (transform.position.x < deadZone) {
            Destroy(gameObject);

        }
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
    }
}
