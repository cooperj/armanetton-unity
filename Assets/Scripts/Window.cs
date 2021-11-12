using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Window : MonoBehaviour
{
    private Vector3 screenPoint;
    private Vector3 offset;


    // Run this when you click on dah window, get the point and select it
    private void OnMouseDown()
    {
        Debug.Log("Clicky");
        //screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        //offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));

        //Debug.Log($"Screen Point: {screenPoint}, Offset: {offset}");
    }

    // Handle this for dragging on dah screen
    private void OnMouseDrag()
    {
        Vector3 currentScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 currentPosition = Camera.main.ScreenToWorldPoint(currentScreenPoint) + offset;

        Debug.Log(currentPosition);

        transform.position = currentPosition;

    }

}