using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SineBehaviour : MonoBehaviour
{

    public enum Type{Horizontal, Vertical, Depth, Scale2D, Scale3D, Width, Height, DepthScale};
    public Type type;
    public float speed = 1;
    public float magnitude = 1;
    [Tooltip("Positive values only.")]
    public float offset = 0.1f;
    private float scaleRatio;
    public bool canReverse;
    private Vector3 initialPosition;
    private Vector3 initialScale;

    void Awake()
    {
        initialPosition = transform.position;
        initialScale = transform.localScale;
        scaleRatio = 1;
    }

    void OnValidate()
    {
        offset = Mathf.Clamp(offset, 0, Mathf.Infinity);
    }

    void Start()
    {
        initialPosition = transform.position;
        initialScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if(canReverse)
        {

            //Using IF/ELSE structure
            if(type == Type.Horizontal)
            {
                transform.position = initialPosition + new Vector3(Mathf.Sin(Time.time * speed) * magnitude, 0, 0);
            } else if(type == Type.Vertical)
            {
                transform.position = initialPosition + new Vector3(0, Mathf.Sin(Time.time * speed) * magnitude, 0);
            } else if(type == Type.Depth){
                transform.position = initialPosition + new Vector3(0, 0, Mathf.Sin(Time.time * speed) * magnitude);
            } else if(type == Type.Scale2D)
            {
                transform.localScale += new Vector3(Mathf.Sin(Time.time * speed) * magnitude/scaleRatio, Mathf.Sin(Time.time * speed) * magnitude/scaleRatio, 0);
            } else if(type == Type.Scale3D)
            {
                transform.localScale += new Vector3(Mathf.Sin(Time.time * speed) * magnitude/scaleRatio, Mathf.Sin(Time.time * speed) * magnitude/scaleRatio, Mathf.Sin(Time.time * speed) * magnitude/scaleRatio);
            } else if(type == Type.Width)
            {
                transform.localScale += new Vector3(Mathf.Sin(Time.time * speed) * magnitude/scaleRatio, 0, 0);
            } else if(type == Type.Height)
            {
                transform.localScale += new Vector3(0, Mathf.Sin(Time.time * speed) * magnitude/scaleRatio, 0);
            } else if(type == Type.DepthScale)
            {
                transform.localScale += new Vector3(0, 0, Mathf.Sin(Time.time * speed) * magnitude/scaleRatio);
            } else
            {
                transform.position = initialPosition;
                transform.localScale = initialScale;
            }
        }

        else {
            
            //Using SWITCH
            switch (type)
            {
                case Type.Horizontal:
                    transform.position = initialPosition + new Vector3(Mathf.Sin(Time.time * speed) * magnitude, 0, 0);                    
                break;
                
                case Type.Vertical:
                     transform.position = initialPosition + new Vector3(0, Mathf.Sin(Time.time * speed) * magnitude, 0);
                break;

                case Type.Depth:
                    transform.position = initialPosition + new Vector3(0, 0, Mathf.Sin(Time.time * speed) * magnitude);
                break;
                
                case Type.Scale2D:
                    transform.localScale = initialScale + new Vector3((Mathf.Sin(Time.time * speed) + offset) * magnitude/scaleRatio, (Mathf.Sin(Time.time * speed) + offset) * magnitude/scaleRatio, 0);
                break;
                
                case Type.Scale3D:
                    transform.localScale = initialScale + new Vector3((Mathf.Sin(Time.time * speed) + offset) * magnitude/scaleRatio, (Mathf.Sin(Time.time * speed) + offset) * magnitude/scaleRatio,(Mathf.Sin(Time.time * speed) + offset) * magnitude/scaleRatio);
                break;

                case Type.Width:
                    transform.localScale = initialScale + new Vector3((Mathf.Sin(Time.time * speed) + offset) * magnitude/scaleRatio, 0, 0);
                break;

                case Type.Height:
                    transform.localScale = initialScale + new Vector3(0, (Mathf.Sin(Time.time * speed) + offset) * magnitude/scaleRatio, 0);
                break;

                case Type.DepthScale:
                    transform.localScale = initialScale + new Vector3(0, 0, (Mathf.Sin(Time.time * speed) + offset) * magnitude/scaleRatio);
                break;

                default:
                    transform.position = initialPosition;
                    transform.localScale = initialScale;
                break;
            }
        }
    }

    public void ResetBehaviour ()
    {
            transform.position = initialPosition;
            transform.localScale = initialScale;
    }
}
