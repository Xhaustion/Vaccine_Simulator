using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunBehavior : MonoBehaviour
{
    public Rigidbody2D rbg;
    public Rigidbody2D rb1;
    public Camera cam;
    Vector2 mousePos;
    Vector2 movement;
    // Update is called once per frame
    void Update()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }
    void FixedUpdate()
    {
        Vector2 lookDir = mousePos - rbg.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
        rbg.rotation = angle;
        rbg.MovePosition(rb1.position) ;
    }
}
