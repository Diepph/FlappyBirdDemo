using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomPipeMoving : MonoBehaviour
{
    float speed = 1f;
    float height = 1.5f;
    float startY = -18f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var pos = transform.position;
        var newY = startY - height * Mathf.Sin(Time.time * speed);
        transform.position = new Vector3(pos.x, newY, pos.z);
    }
}

