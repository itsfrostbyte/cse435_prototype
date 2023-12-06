using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanController : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 0.5f;
    [SerializeField] private float rotationSpeed = 100f;

    // Update is called once per frame
    void Update()
    {
        float rotationInput = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -rotationInput);

        float movementInput = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;
        transform.Translate(0, movementInput, 0, Space.Self);
    }
}
