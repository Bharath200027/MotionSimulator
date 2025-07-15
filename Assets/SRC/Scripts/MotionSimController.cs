using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MotionSimController : MonoBehaviour
{
    public int ForceIntensity = 5;
    public GameObject gO;
    public InputField gravity, mass;
    public Text stats;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        stats.text = "" +
            "Mass = " + gO.GetComponent<Rigidbody>().mass.ToString() +
            "\nLinear Velocity:" +
            "\nX Velocity = " + gO.GetComponent<Rigidbody>().velocity.x.ToString() + 
            "\nY Velocity = " + gO.GetComponent<Rigidbody>().velocity.y.ToString() +
            "\nZ Velocity = " + gO.GetComponent<Rigidbody>().velocity.z.ToString() +
            "\nAngular Velocity:" +
            "\nX Velocity = " + gO.GetComponent<Rigidbody>().angularVelocity.x.ToString() +
            "\nY Velocity = " + gO.GetComponent<Rigidbody>().angularVelocity.y.ToString() +
            "\nZ Velocity = " + gO.GetComponent<Rigidbody>().angularVelocity.z.ToString();
    }

    public void PlusY()
    {
        gO.GetComponent<Rigidbody>().AddForce(Vector3.up * ForceIntensity);
    }
    public void NegY()
    {
        gO.GetComponent<Rigidbody>().AddForce(Vector3.down * ForceIntensity);
    }
    public void PlusX()
    {
        gO.GetComponent<Rigidbody>().AddForce(Vector3.right * ForceIntensity);
    }
    public void NegX()
    {
        gO.GetComponent<Rigidbody>().AddForce(Vector3.left * ForceIntensity);
    }
    public void PlusZ()
    {
        gO.GetComponent<Rigidbody>().AddForce(Vector3.forward * ForceIntensity);
    }
    public void NegZ()
    {
        gO.GetComponent<Rigidbody>().AddForce(Vector3.back * ForceIntensity);
    }
}
