using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Window : MonoBehaviour
{
    public Transform[] movePoints;
    public float speed;
    private int amount;
    private Transform currentTarget;
    private float timer = 0f;

    void Start () {
        Randoming ();
    }    

    void Update () {
        Movement ();
        timer += Time.deltaTime;
        if (timer > 5.05f)
        {
            Randoming();
            timer = 0f;
        }
    }

    void Randoming() {
        amount = Random.Range (0, movePoints.Length);
        currentTarget = movePoints[amount];
    }    

    void Movement() {
        transform.position = Vector3.MoveTowards (transform.position, currentTarget.position, speed * Time.deltaTime);
    }

}