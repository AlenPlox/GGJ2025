using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private Transform origin;
    [SerializeField] private GameObject bullet;

    private GameObject boobleIn;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if( Input.GetMouseButtonDown(0))
        {
            boobleIn = Instantiate(bullet, origin.position, origin.rotation);
            boobleIn.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0,30f,100f), ForceMode.Force);
        }
    }
}
