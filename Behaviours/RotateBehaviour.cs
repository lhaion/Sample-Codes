using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBehaviour : MonoBehaviour
{

    public enum Type {XAxis, YAxis, ZAxis};
    public Type type;
    public float speed = 10;
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
            if(type == Type.XAxis)
            {
                transform.Rotate(speed * Time.deltaTime, 0, 0);
            } else if(type == Type.YAxis)
            {
                transform.Rotate(0, speed * Time.deltaTime, 0);
            } else if(type == Type.ZAxis)
            {
                transform.Rotate(0, 0, speed * Time.deltaTime);
            } else {

            }
        } else
        {
            if(type == Type.XAxis)
            {
                transform.rotation = Quaternion.Euler(initialXRot + Mathf.Sin(Time.time * speed / 5) * 180, 0, 0);
            } else if(type == Type.YAxis)
            {
                transform.rotation = Quaternion.Euler(0, initialXRot + Mathf.Sin(Time.time * speed / 5) * 180, 0);
            } else if(type == Type.ZAxis)
            {
                transform.rotation = Quaternion.Euler(0, 0, initialXRot + Mathf.Sin(Time.time * speed / 5) * 180);
            } else {

            }
        }
    }
}
