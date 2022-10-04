using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemFollowMouse : MonoBehaviour
{
    public Vector2 amount = new Vector2(72, 72);
    private void LateUpdate(){
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition * amount);
    }
}
