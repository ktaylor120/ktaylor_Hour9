using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		float mX = Input.GetAxis("Mouse X") / 10f;
		float mY = Input.GetAxis("Mouse Y") / 10f;
		transform.Translate(mX, mY, 0);
    }
}
