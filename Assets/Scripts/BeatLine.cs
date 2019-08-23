using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatLine : MonoBehaviour
{

    //public AudioSpectrum spectrum;
    public GameObject[] BeatLinePoints;


    //LineRender

    public GameObject obj;
    private LineRenderer lineRenderer;


    public float timer;

    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = obj.GetComponent<LineRenderer>();

        BeatLinePoints = new GameObject[transform.childCount];

        lineRenderer.SetWidth(.2f, .2f);

    }

    // Update is called once per frame
    void Update()
    {



        for (int i = 1; i < BeatLinePoints.Length; i = i + 2)
        {
            BeatLinePoints[i] = transform.GetChild(i).gameObject;
            Vector3 Pos = BeatLinePoints[i].transform.position;

            lineRenderer.SetPosition(i, Pos);


            if (timer > WaveSpanNotMusicSc.beat)
            {
                timer -= WaveSpanNotMusicSc.beat;

                Pos = Vector3.Lerp(Pos, new Vector3(Pos.x, Random.Range(5f,35f), Pos.z), Time.deltaTime*1);


            }
            else
            {
                Pos = Vector3.Lerp(Pos, new Vector3(Pos.x, 0f, Pos.z), Time.deltaTime*1);

            }

            timer += Time.deltaTime;


            //Pos.y = (i * -120)-0.1f;

            BeatLinePoints[i].transform.position = Pos;
        }

        for (int i = 0; i < BeatLinePoints.Length; i = i + 2)
        {
            BeatLinePoints[i] = transform.GetChild(i).gameObject;
            Vector3 Pos = BeatLinePoints[i].transform.position;

            lineRenderer.SetPosition(i, Pos);



            if (timer > WaveSpanNotMusicSc.beat)
            {
                timer -= WaveSpanNotMusicSc.beat;

                Pos = Vector3.Lerp(Pos, new Vector3(Pos.x, Random.Range(-5f,-35f), Pos.z), Time.deltaTime * 1f);


            }
            else
            {
                Pos = Vector3.Lerp(Pos, new Vector3(Pos.x, 0f, Pos.z), Time.deltaTime * 1f);

            }

            timer += Time.deltaTime;




            //Pos.y = (i * +120)-0.1f;

            BeatLinePoints[i].transform.position = Pos;
        }


 

}
}
