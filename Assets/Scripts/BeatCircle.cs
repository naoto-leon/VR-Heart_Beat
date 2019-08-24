using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatCircle : MonoBehaviour
{

    [SerializeField]
    float pospoX, pospoY;

    public float speed;
    public float radius;
    public float zPosition;
    float x;
    float y;
    float z;


    private TrailRenderer _trailLenderer;


private float timer;
  

    // Use this for initialization
    void Start()
    {
        speed = 3.75f;
        //radius = 6f;

        //zPosition = 0f;

        _trailLenderer = GetComponent<TrailRenderer>();





    }



    // Update is called once per frame
    void Update()
    {

        x = pospoX + (radius * Mathf.Sin(Time.time * speed));
        z = zPosition;
        y = pospoY + (radius * Mathf.Cos(Time.time * speed));

        //x = pospoX + (radius * Mathf.Sin(Time.time * speed));
        //z = pospoZ + (radius * Mathf.Cos(Time.time * speed));
        //y = yPosition;

        transform.position = new Vector3(x, y, z);



        if (timer > WaveSpanNotMusicSc.beat)
        {
            timer -= WaveSpanNotMusicSc.beat;
            radius = 3.5f;
        }
        else
        {
            radius = 7f;
        }

        timer += Time.deltaTime;

    }


}
