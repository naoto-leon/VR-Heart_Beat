using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class boxLine : MonoBehaviour
{
    [SerializeField]
     int NUM;


    public GameObject PrefabLineBox;
    //public GameObject[] LineBox;
    public List<GameObject> BoxLine;

    //[SerializeField]
    //private float[] time;

    //[SerializeField]
    //private float time0;
    //[SerializeField]
    //private float time1;
    //[SerializeField]
    //private float time2;
    //[SerializeField]
    //private float time3;
    //[SerializeField]
    //private float time4;
    //[SerializeField]
    //private float time5;
    //[SerializeField]
    //private float time6;
    //[SerializeField]
    //private float time7;
    //[SerializeField]
    //private float time8;
    //[SerializeField]
    //private float time9;
    //[SerializeField]
    //private float time10;
    //[SerializeField]
    //private float time11;
    //[SerializeField]
    //private float time12;
    //[SerializeField]
    //private float time13;
    //[SerializeField]
    //private float time14;
    //[SerializeField]
    //private float time15;
    //[SerializeField]
    //private float time16;
    //[SerializeField]
    //private float time17;
    //[SerializeField]
    //private float time18;
    //[SerializeField]
    //private float time19;
    //[SerializeField]
    //private float time20;
    //[SerializeField]
    //private float time21;


    //[SerializeField]
    //private float time22;
    //[SerializeField]
    //private float time23;
    //[SerializeField]
    //private float time24;
    //[SerializeField]
    //private float time25;
    //[SerializeField]
    //private float time26;


    ////[SerializeField]
    ////private float[] moveTime;

    //[SerializeField]
    //private float moveTime0;
    //[SerializeField]
    //private float moveTime1;
    //[SerializeField]
    //private float moveTime2;
    //[SerializeField]
    //private float moveTime3;
    //[SerializeField]
    //private float moveTime4;
    //[SerializeField]
    //private float moveTime5;
    //[SerializeField]
    //private float moveTime6;
    //[SerializeField]
    //private float moveTime7;
    //[SerializeField]
    //private float moveTime8;
    //[SerializeField]
    //private float moveTime9;
    //[SerializeField]
    //private float moveTime10;
    //[SerializeField]
    //private float moveTime11;
    //[SerializeField]
    //private float moveTime12;
    //[SerializeField]
    //private float moveTime13;
    //[SerializeField]
    //private float moveTime14;
    //[SerializeField]
    //private float moveTime15;
    //[SerializeField]
    //private float moveTime16;
    //[SerializeField]
    //private float moveTime17;
    //[SerializeField]
    //private float moveTime18;
    //[SerializeField]
    //private float moveTime19;
    //[SerializeField]
    //private float moveTime20;
    //[SerializeField]
    //private float moveTime21;

    //[SerializeField]
    //private float moveTime22;
    //[SerializeField]
    //private float moveTime23;
    //[SerializeField]
    //private float moveTime24;
    //[SerializeField]
    //private float moveTime25;
    //[SerializeField]
    //private float moveTime26;



    //MeshRenderer meshRenderer;


    // Start is called before the first frame update
    void Start()
    {
        var parent = this.transform;

        BoxLine = new List<GameObject>(NUM);
        //LineBox = new GameObject[NUM];


        //meshRenderer = GetComponent<MeshRenderer>();

        for (int i = 0; i < NUM; i++)
        {
            //LineBox[i] = (GameObject)Instantiate(PrefabLineBox, new Vector3(0f, -1.2f, 120 - (i*5)), Quaternion.identity,parent);
            //LineBox[i] = transform.GetChild(i).gameObject;


            BoxLine.Add((GameObject)Instantiate(PrefabLineBox, new Vector3(0f, -1.2f, 130 - (i * 5)), Quaternion.identity, parent));

            //Debug.Log(LineBox[1]);

            //var LB = LineBox[i].GetComponent<MeshRenderer>();


            //LB.material.SetFloat("_time", time[i]);
            //LB.material.SetFloat("_moveTime", moveTime[i]);

            var LB = BoxLine[i].GetComponent<MeshRenderer>();
            LB.material.SetFloat("_time", (i+1) * .4f);
            LB.material.SetFloat("_moveTime", (i+1) *.15f);

        }

   

        //var LB0 = LineBox[0].GetComponent<MeshRenderer>();
        //var LB1 = LineBox[1].GetComponent<MeshRenderer>();
        //var LB2 = LineBox[2].GetComponent<MeshRenderer>();
        //var LB3 = LineBox[3].GetComponent<MeshRenderer>();
        //var LB4 = LineBox[4].GetComponent<MeshRenderer>();
        //var LB5 = LineBox[5].GetComponent<MeshRenderer>();
        //var LB6 = LineBox[6].GetComponent<MeshRenderer>();
        //var LB7 = LineBox[7].GetComponent<MeshRenderer>();
        //var LB8 = LineBox[8].GetComponent<MeshRenderer>();
        //var LB9 = LineBox[9].GetComponent<MeshRenderer>();
        //var LB10 = LineBox[10].GetComponent<MeshRenderer>();
        //var LB11 = LineBox[11].GetComponent<MeshRenderer>();
        //var LB12 = LineBox[12].GetComponent<MeshRenderer>();
        //var LB13 = LineBox[13].GetComponent<MeshRenderer>();
        //var LB14 = LineBox[14].GetComponent<MeshRenderer>();
        //var LB15 = LineBox[15].GetComponent<MeshRenderer>();
        //var LB16 = LineBox[16].GetComponent<MeshRenderer>();
        //var LB17 = LineBox[17].GetComponent<MeshRenderer>();
        //var LB18 = LineBox[18].GetComponent<MeshRenderer>();
        //var LB19 = LineBox[19].GetComponent<MeshRenderer>();
        //var LB20 = LineBox[20].GetComponent<MeshRenderer>();
        //var LB21 = LineBox[21].GetComponent<MeshRenderer>();

        //var LB22 = LineBox[22].GetComponent<MeshRenderer>();
        //var LB23 = LineBox[23].GetComponent<MeshRenderer>();
        //var LB24 = LineBox[24].GetComponent<MeshRenderer>();
        //var LB25 = LineBox[25].GetComponent<MeshRenderer>();
        //var LB26 = LineBox[26].GetComponent<MeshRenderer>();

        //LB0.material.SetFloat("_time", time0);
        //LB1.material.SetFloat("_time", time1);
        //LB2.material.SetFloat("_time", time2);
        //LB3.material.SetFloat("_time", time3);
        //LB4.material.SetFloat("_time", time4);
        //LB5.material.SetFloat("_time", time5);
        //LB6.material.SetFloat("_time", time6);
        //LB7.material.SetFloat("_time", time7);
        //LB8.material.SetFloat("_time", time8);
        //LB9.material.SetFloat("_time", time9);
        //LB10.material.SetFloat("_time", time10);
        //LB11.material.SetFloat("_time", time11);
        //LB12.material.SetFloat("_time", time12);
        //LB13.material.SetFloat("_time", time13);
        //LB14.material.SetFloat("_time", time14);
        //LB15.material.SetFloat("_time", time15);
        //LB16.material.SetFloat("_time", time16);
        //LB17.material.SetFloat("_time", time17);
        //LB18.material.SetFloat("_time", time18);
        //LB19.material.SetFloat("_time", time19);
        //LB20.material.SetFloat("_time", time20);
        //LB21.material.SetFloat("_time", time21);

        //LB22.material.SetFloat("_time", time22);
        //LB23.material.SetFloat("_time", time23);
        //LB24.material.SetFloat("_time", time24);
        //LB25.material.SetFloat("_time", time25);
        //LB26.material.SetFloat("_time", time26);




        //LB0.material.SetFloat("_moveTime", moveTime0);
        //LB1.material.SetFloat("_moveTime", moveTime1);
        //LB2.material.SetFloat("_moveTime", moveTime2);
        //LB3.material.SetFloat("_moveTime", moveTime3);
        //LB4.material.SetFloat("_moveTime", moveTime4);
        //LB5.material.SetFloat("_moveTime", moveTime5);
        //LB6.material.SetFloat("_moveTime", moveTime6);
        //LB7.material.SetFloat("_moveTime", moveTime7);
        //LB8.material.SetFloat("_moveTime", moveTime8);
        //LB9.material.SetFloat("_moveTime", moveTime9);
        //LB10.material.SetFloat("_moveTime", moveTime10);
        //LB11.material.SetFloat("_moveTime", moveTime11);
        //LB12.material.SetFloat("_moveTime", moveTime12);
        //LB13.material.SetFloat("_moveTime", moveTime13);
        //LB14.material.SetFloat("_moveTime", moveTime14);
        //LB15.material.SetFloat("_moveTime", moveTime15);
        //LB16.material.SetFloat("_moveTime", moveTime16);
        //LB17.material.SetFloat("_moveTime", moveTime17);
        //LB18.material.SetFloat("_moveTime", moveTime18);
        //LB19.material.SetFloat("_moveTime", moveTime19);
        //LB20.material.SetFloat("_moveTime", moveTime20);
        //LB21.material.SetFloat("_moveTime", moveTime21);

        //LB22.material.SetFloat("_moveTime", moveTime22);
        //LB23.material.SetFloat("_moveTime", moveTime23);
        //LB24.material.SetFloat("_moveTime", moveTime24);
        //LB25.material.SetFloat("_moveTime", moveTime25);
        //LB26.material.SetFloat("_moveTime", moveTime26);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
