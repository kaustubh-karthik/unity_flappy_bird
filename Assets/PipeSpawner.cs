using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PipeSpawner : MonoBehaviour
{

    public GameObject Pipe;
    public Camera GameCamera;
    public float spawnRate = 3;
    private float clock = 3;

    public float topOffsetScale = 10;


    // Start is called before the first frame update
    void Start()
    {
        print(Screen.currentResolution);
    }

    // Update is called once per frame
    void Update()
    {
        if (clock < spawnRate)
        {
            clock += Time.deltaTime;
        } else {
            SpawnPipe();
            clock = 0;
        }
    }

    void SpawnPipe(){
        var cameraHeight = 2*GameCamera.orthographicSize;
        var cameraWidth = cameraHeight*GameCamera.aspect;
        var topOffset = GameCamera.orthographicSize/topOffsetScale;
        print("ymax size:" + topOffset);

        var minPos = -(cameraHeight/2 - topOffset);
        var maxPos = cameraHeight/2 - topOffset;
        var randPos = new Vector3(transform.position.x, UnityEngine.Random.Range(minPos, maxPos));

        print($"min pos: {minPos}, max pos: {maxPos}, rand pos: {randPos}");
        
        Instantiate(Pipe, randPos, transform.rotation);
    }
}
