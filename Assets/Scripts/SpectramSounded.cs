using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpectramSounded : MonoBehaviour
{
    public AudioSpectrum spectrum;
    public GameObject[] box;
    public GameObject[] box2;
    public float Scale1;
    public float Scale2;
    public float Scale3;
    public float Scale4;

    public GameObject preBox;
    public GameObject preBox2;

    [SerializeField]
    int NUM;


    public float timer;

    // Start is called before the first frame update
    void Start()
    {
        box = new GameObject[NUM];
        box2 = new GameObject[NUM];

        var parent = this.transform;

        for (int i = 0; i < box.Length; i++)
        {
            box[i] = Instantiate(preBox, new Vector3(32f, +3f, 2 + (i * 2)), Quaternion.identity, parent);
            box2[i] = Instantiate(preBox2, new Vector3(-32f, +3f, 2 + (i * 2)), Quaternion.identity, parent);


        }
    }

    // Update is called once per frame
    void Update()
    {
        //for (int i = 0; i < box.Length; i++)
        //{
        //    var tests = box[i];
        //    var localScale = tests.transform.localScale;
        //    localScale.y = spectrum.MeanLevels[i] * Scale;
        //    tests.transform.localScale = localScale;

        //}
        //for (int i = 0; i < box2.Length; i++)
        //{
        //    var testss = box2[i];
        //    var localScale = testss.transform.localScale;
        //    localScale.y = spectrum.MeanLevels[i] * Scale;
        //    testss.transform.localScale = localScale;

        //}


        if (timer > WaveSpanNotMusicSc.beat)
        {
            timer -= WaveSpanNotMusicSc.beat;



            for (int i = 0; i < box.Length; i++)
            {
                var tests = box[i];
                var localScale = tests.transform.localScale;
                localScale = Vector3.Lerp(localScale, new Vector3(localScale.x, Random.Range(Scale1, Scale2),localScale.z),Time.deltaTime*5);
                tests.transform.localScale = localScale;

            }
            for (int i = 0; i < box2.Length; i++)
            {
                var testss = box2[i];
                var localScale = testss.transform.localScale;
                localScale = Vector3.Lerp(localScale, new Vector3(localScale.x, Random.Range(Scale1, Scale2), localScale.z), Time.deltaTime*5);
                testss.transform.localScale = localScale;

            }

        }
        else
        {


            for (int i = 0; i < box.Length; i++)
            {
                var tests = box[i];
                var localScale = tests.transform.localScale;
                localScale = Vector3.Lerp(localScale, new Vector3(localScale.x, Random.Range(Scale3, Scale4), localScale.z), Time.deltaTime*5);
                tests.transform.localScale = localScale;

            }
            for (int i = 0; i < box2.Length; i++)
            {
                var testss = box2[i];
                var localScale = testss.transform.localScale;
                localScale = Vector3.Lerp(localScale, new Vector3(localScale.x, Random.Range(Scale3, Scale4), localScale.z), Time.deltaTime*5);
                testss.transform.localScale = localScale;

            }
        }

        timer += Time.deltaTime;



        //BeatLinePoints[i].transform.position = Pos;

    }
}


