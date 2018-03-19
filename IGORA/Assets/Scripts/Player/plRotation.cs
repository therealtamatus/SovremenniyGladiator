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
        CheckTarget();

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
    
    void CheckTarget()
    {
        for (int i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.GetTouch(i).position);
                RaycastHit2D hit = Physics2D.Raycast(worldPoint, Vector2.zero);
                if (hit.collider != null)
                {
                    if (hit.transform.tag == "enemy")
                    {
                        Debug.Log("Enemy!");
                        target = hit.transform;
                        isTarget = true;
                    }
                }
            }
        }

        if (Input.GetMouseButtonDown(0))
        { 
            Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(worldPoint, Vector2.zero);
            if (hit.collider != null)
            {
                if (hit.transform.tag == "enemy")
                {
                    Debug.Log("Enemy!");
                    target = hit.transform;
                    isTarget = true;
                }
            }
        }
    }
}