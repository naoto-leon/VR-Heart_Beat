using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using uOSC;

public class WaveSpanNotMusicSc : MonoBehaviour
{
    public float timer;

    [SerializeField]
    public  static float beat;


    public GameObject[] Cubes;
    public Transform[] Points;

    public GameObject StarParticle;

    [SerializeField]
    public static int heartBeat;

    // Start is called before the first frame update
    void Start()
    {
       
        var server = GetComponent<uOscServer>();
        server.onDataReceived.AddListener(OnDataReceived);
    }



    void OnDataReceived(Message message)
    {
        // OSC のアドレス
        var msg = message.address + ": ";

        // object[] として OSC の引数がやってくる
        foreach (var value in message.values)
        {
            if (value is int) msg += (int)value;
            else if (value is float) msg += (float)value;
            else if (value is string) msg += (string)value;
            else if (value is byte[]) msg += "byte[" + ((byte[])value).Length + "]";

            //Debug.Log(value);
            //text.text = (string)value;

            heartBeat = (int)value;

            if (heartBeat < 0)
            {
                return;
            }


            beat = (60 / (float)heartBeat);

            //Debug.Log (beat);


        }



    }


    // Update is called once per frame
    void Update()
    {

        if (timer > beat)
        {
            timer -= beat;


            GameObject cube = Instantiate(Cubes[Random.Range(0, 4)], Points[Random.Range(0, 2)]);

            GameObject StPa = (GameObject)Instantiate(StarParticle, cube.transform.position, cube.transform.rotation);
            Destroy(StPa, .5f);

            cube.transform.localPosition = Vector3.zero;
            cube.transform.Rotate(transform.forward * 90, Random.Range(0, 2));

        }
        timer += Time.deltaTime;

    }
}
