using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMultipleAxesBehaviour : MonoBehaviour
{

    public float XSpeed = 10;
    public float YSpeed = 0;
    public float ZSpeed = 0;
    private Quaternion initialRotation;
    private float initialXRot;
    private float initialYRot;
    private float initialZRot;
    public bool pingPong;
    
    void Awake()
    {
        initialRotation = transform.rotation;
        initialXRot = initialRotation.x;
        initialYRot = initialRotation.y;
        initialZRot = initialRotation.z;
    }

    void Start()
    {
        initialRotation = transform.rotation;
        initialXRot = initialRotation.x;
        initialYRot = initialRotation.y;
        initialZRot = initialRotation.z;
    }
    // Update is called once per frame
    void Update()
    {
        if(!pingPong)
        {
            transform.Rotate(XSpeed * Time.deltaTime, YSpeed * Time.deltaTime, ZSpeed * Time.deltaTime);
        } else
        {
            transform.rotation = Quaternion.Euler(initialXRot + Mathf.Sin(Time.time * XSpeed / 5) * 180, initialYRot + Mathf.Sin(Time.time * YSpeed / 5) * 180, initialZRot + Mathf.Sin(Time.time * ZSpeed / 5) * 180);
        }
    }
}
