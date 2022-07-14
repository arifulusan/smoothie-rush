using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 7f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        // float y = Input.GetAxisRaw("Vertical");
       // gameObject.transform.Translate(Vector3.left * Time.deltaTime * speed);
        gameObject.transform.Translate(Vector3.forward * Time.deltaTime * speed);
        gameObject.transform.Translate(new Vector3(x, 0, 0) * speed * Time.deltaTime);
    }
}
