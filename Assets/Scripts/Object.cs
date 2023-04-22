using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveSpeed * Time.deltaTime, 0, 0);

        if(transform.position.x < -10f)
        {
            Destroy(gameObject);
        }
    }
}
