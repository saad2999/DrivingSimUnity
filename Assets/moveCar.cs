using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCar : MonoBehaviour
{
    
    public float speed=2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)) {
            transform.position += Vector3.forward * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            transform.position += Vector3.back * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.position += Vector3.left * Time.deltaTime * speed;
        }if (Input.GetKey(KeyCode.RightArrow)) {
            transform.position += Vector3.right * Time.deltaTime * speed;
        }
        if (transform.position.z>=164) {
            transform.position = new Vector3(0, 0, -10);
        } if (transform.position.z<=-11) {
            transform.position = new Vector3(0, 0, 158);
        }
        
    }
}
