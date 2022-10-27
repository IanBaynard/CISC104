using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody))]

public class PlayerMovement : MonoBehaviour
  
{
    private GameObject cubes;
    new Rigidbody rigidbody;
    [SerializeField]
    Transform tractor;
    [SerializeField]
    float speed = 1.5f;
    [SerializeField]
    Vector3 rotationLimit = new Vector3(0, 30, 0);


    // Start is called before the first frame update
    void Start()
    {
     rigidbody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        tractor.rotation = Quaternion.Euler(rotationLimit * Input.GetAxis("Horizontal"));
    }

    void FixedUpdate()
    {
        rigidbody.velocity = tractor.forward * speed;
    }
    void OnCollisionEnter(Collision rigidbody)
    {
     SceneManager.LoadScene("SampleScene");
    }

   
}
