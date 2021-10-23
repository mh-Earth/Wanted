using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimControll : MonoBehaviour
{   
private Vector2 mosuePostion;
private float speed = 10;
//  var start : Vector3;
 private Vector3 start;
//  var pos : Vector3;
 private Vector3 pos;
public LayerMask hitLayers;
 private void Start() {
     Cursor.visible = false;
     start = transform.position;
 }
 
private void Update() 
{
     
        pos = transform.position;
         Vector3 mouse = Input.mousePosition;
         mouse.z = 10;
        //  Ray castPoint = Camera.main.ScreenPointToRay(mouse);
        // Vector3 objectPos = Camera.main.WorldToScreenPoint(transform.position);
        // mouse.x = mouse.x - objectPos.x;
        // mouse.y = mouse.y - objectPos.y;
        if(pos.x > -4.331f){
            pos.x = -4.331f;
        }

        pos = Camera.main.ScreenToWorldPoint(mouse);
        transform.position = pos;

}

}