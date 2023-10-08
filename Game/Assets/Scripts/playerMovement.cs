using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

   [SerializeField] public float playerSpeed;

   [Header("Movements")]

   [SerializeField] private float horizontalInput;
   [SerializeField] private float verticalInput;

   [SerializeField] private Vector3 movementVector;

    // Start is called before the first frame update
    void Start()
    {   }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        movementVector = new Vector3(horizontalInput, 0f, verticalInput);

        transform.Translate(movementVector * Time.deltaTime * playerSpeed);

    }
}
