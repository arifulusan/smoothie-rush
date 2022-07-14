using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 7f;
    public int a;
    bool kos=false;
    Touch touch=Input.GetTouch(0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate() {
        //float x = Input.GetAxisRaw("Horizontal");
        // float y = Input.GetAxisRaw("Vertical");
       // gameObject.transform.Translate(Vector3.left * Time.deltaTime * speed);
       if(Input.touchCount>0)
       {
            kos=true;
       }
       if(kos==true)
       {
            gameObject.transform.Translate(Vector3.forward * Time.deltaTime * speed);
       }
        
        //transform.position=transform.position+new Vector3(1,0,0)*a*Time.deltaTime; 
        }
}
