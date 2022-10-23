using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFellow : MonoBehaviour
{
   public GameObject obj;
    Vector3 posY = new Vector3(0, 5, -12);
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = obj.transform.position+posY;
        
    }
}
