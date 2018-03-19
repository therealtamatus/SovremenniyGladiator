using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plRotation : MonoBehaviour
{
    public Transform target;
    public Joystick joystick;

    public bool isTarget=false;
    

    void Update()
    {
        if (isTarget)
        {
            Vector3 dir = target.position - transform.position;
            float angle = Mathf.Atan2(dir.x, dir.y) * Mathf.Rad2Deg * -1f;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
        else
        {
            float angle = Mathf.Atan2(joystick.Horizontal, joystick.Vertical) * Mathf.Rad2Deg * -1f;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
    }
    
}