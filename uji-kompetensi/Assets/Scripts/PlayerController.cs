using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
     
    public float moveSpeed;
    public GameObject bulletPrefab;
    public Transform firePoint;
    public int bulletDamage;
    void Start()
    {
        
    }

    // Update is called once per frame
     private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }

        float wKey = (Input.GetKey(KeyCode.W)) ? 1f : 0f;
        float aKey = (Input.GetKey(KeyCode.A)) ? -1f : 0f;
        float sKey = (Input.GetKey(KeyCode.S)) ? -1f : 0f;
        float dKey = (Input.GetKey(KeyCode.D)) ? 1f : 0f;

        float horizontalInputWASD = aKey + dKey;
        float verticalInputWASD = wKey + sKey;

        float finalHorizontalInput = horizontalInput + horizontalInputWASD;
        float finalVerticalInput = verticalInput + verticalInputWASD;

        Vector3 moveDirection = new Vector3(finalHorizontalInput, 0f, finalVerticalInput).normalized;
        Vector3 moveAmount = moveDirection * moveSpeed * Time.deltaTime;

        transform.Translate(moveAmount);
    }

    private void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, transform.rotation);
        Debug.Log("ditembak");
    }

    
}
