using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class MagneticBehaviour : MonoBehaviour
{

    public enum Polarity{Positive, Negative};
    public Polarity polarity;
    public enum MagneticAxis{PositiveX, NegativeX, PositiveY, NegativeY, PositiveZ, NegativeZ}
    public MagneticAxis magneticAxis;
    public float magneticForce = 0.1f;
    [SerializeField] private GameObject atractionObject;
    private Vector3 atractionPoint;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        atractionObject = GameObject.FindGameObjectWithTag("Magnetic");
        atractionPoint = atractionObject.transform.position;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        atractionPoint = atractionObject.transform.position;

        //float distance = Vector3.Distance(atractionPoint, transform.position);
        float distance = atractionPoint.x - transform.position.x;
        print(distance);

        if(magneticAxis == MagneticAxis.PositiveX){
            rb.AddForce(Vector3.right * (magneticForce/2) * distance, ForceMode.Force);
        } else if (magneticAxis == MagneticAxis.NegativeX){
            rb.AddForce(-Vector3.right * (magneticForce/2) * distance, ForceMode.Force);
        }
    }
}
