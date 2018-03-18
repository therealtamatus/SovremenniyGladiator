using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plRotation : MonoBehaviour
{

    public Joystick joystick;

    void Update()
    {
        float angle= Mathf.Atan2(joystick.Horizontal, joystick.Vertical)*Mathf.Rad2Deg*-1f;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
