using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContoller : MonoBehaviour
{
    //[Tooltip("Base speed of the vehicle")]
    //[SerializeField] float speed = 20f;
    [Tooltip("Base speed of the vehicle")]
    [SerializeField] private float turnSpeed = 45f;

    [SerializeField] private float horsePower = 20f;

    [SerializeField] GameObject centerOfMass;

    public SpawnManager spawnManager;

    private Rigidbody playerRb;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerRb.centerOfMass = centerOfMass.transform.position;
    }

    private float horizontalInput;
    private float verticalInput;

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Allows vehicle to move forward based on vertical input
        //transform.Translate(Vector3.forward * Time.deltaTime * /*speed*/ horsePower * verticalInput);
        playerRb.AddRelativeForce(Vector3.forward * verticalInput * horsePower);

        // Allows vehicle to rotate based on horizontal input
        transform.Rotate(Vector3.up, horizontalInput * turnSpeed * Time.deltaTime);

        
    }

    private void OnTriggerEnter(Collider other)
    {
        spawnManager.SpawnTriggerEntered();
    }
}
