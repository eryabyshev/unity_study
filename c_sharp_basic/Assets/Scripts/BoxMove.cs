using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.name = "My super cube";
        gameObject.SetActive(false);
        gameObject.SetActive(true);

        transform.position = new Vector3(0, 2, 0);
        transform.eulerAngles = new Vector3(0, 45, 30);
        transform.localScale = new Vector3(1, 2, 4);


    }

    // Update is called once per frame
    void Update()
    {
       

        if(Input.GetKey(KeyCode.W))
        {
            transform.eulerAngles += new Vector3(0, 0.1f, 0.1f);
        }


        if (Input.GetKey(KeyCode.S))
        {
            transform.eulerAngles -= new Vector3(0, 0.1f, 0.1f);
        }
        if(Input.GetMouseButtonDown(0)) //LMB
        {
            transform.position += new Vector3(0, 0.1f, 0);
        }

        if (Input.GetMouseButtonDown(1)) //RMB
        {
            transform.position -= new Vector3(0, 0.1f, 0);
        }
    }
}
