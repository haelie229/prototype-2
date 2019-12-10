using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    public float horizontalinput;
    public float speed = 40;
    public float xRange = 10;

    public GameObject projectilePrefab;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    // keep the player in bounds
    { 
    if (transform.position.x < -xRange)
    {
        transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
    }
    if (transform.position.x > xRange)
    {    
        horizontalinput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalinput * Time.deltaTime * speed);
    } transform.Translate(Vector3.forward * Time.deltaTime * speed);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        
        

