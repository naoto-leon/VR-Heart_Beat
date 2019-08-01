using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatLine : MonoBehaviour
{
    //[SerializeField]
    //int Num;

    //public GameObject PrefabBeatLinePoints;
    //public GameObject[] Prefabs;

    public AudioSpectrum spectrum;
    public GameObject[] BeatLinePoints;


    //LineRender

    public GameObject obj;
    private LineRenderer lineRenderer; 


    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = obj.GetComponent<LineRenderer>();

        BeatLinePoints = new GameObject[transform.childCount];

        lineRenderer.SetWidth(.2f, .2f);
        //Prefabs = new GameObject[Num];

        //var parent = this.transform;


        //for (int i = 0; i < Prefabs.Length; i = i + 1)
        //{
        //    Prefabs[i] = (GameObject)Instantiate(PrefabBeatLinePoints, new Vector3(-1.8f + i, -1f, -9f), Quaternion.identity, parent);
        //}

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 1; i < BeatLinePoints.Length; i = i + 2)
        {
            BeatLinePoints[i] = transform.GetChild(i).gameObject;
            Vector3 Pos = BeatLinePoints[i].transform.position;

            lineRenderer.SetPosition(i, Pos);


            Pos.y = (spectrum.MeanLevels[i] * -120)+5;

            BeatLinePoints[i].transform.position = Pos;
        }

        for (int i = 0; i < BeatLinePoints.Length; i = i + 2)
        {
            BeatLinePoints[i] = transform.GetChild(i).gameObject;
            Vector3 Pos = BeatLinePoints[i].transform.position;

            lineRenderer.SetPosition(i, Pos);


            Pos.y = (spectrum.MeanLevels[i] * +120)+5;

            BeatLinePoints[i].transform.position = Pos;
        }




    }
}
