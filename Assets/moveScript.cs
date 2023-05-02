using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveScript : MonoBehaviour
{

    public float moveSpeed = 5;
    private Camera mainCamera = Camera.main;
    private GameObject TopPipe;
    public BoxCollider2D pipeBoxCollider;
    private float cameraHeight;
    private float cameraWidth;

    //public GameObject Pipe;

    //public float deadzoneOffset = cameraWidth

    // Start is called before the first frame update
    void Start()
    {
        TopPipe = GameObject.Find("TopPipe");
        cameraHeight = 2*mainCamera.orthographicSize;
        cameraWidth = cameraHeight * mainCamera.aspect;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x <= -cameraWidth/2)
        {
            Destroy(gameObject);
        }
    }
}
