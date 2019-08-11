using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamColor : MonoBehaviour
{
    Camera cam;
    

    public float timer;

    public float beat;
    private int count;


    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
        cam.clearFlags = CameraClearFlags.SolidColor;


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (timer > beat)
        {
            timer -= beat;
            cam.backgroundColor = new Color(0, 0, 0, 0);

            count = count + 1;
            Debug.Log(count);
        }
       else if(count == 20)
        {
            cam.backgroundColor = new Color(1, 1, 1, 1);
            count = 0;
        }

        timer += Time.deltaTime;

    }
}
