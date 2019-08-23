using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class HertsParticleDesTimeEfect : MonoBehaviour
{
    //public static bool hertPaDesTimeEfect;

/// <summary>
/// 微妙・改善必要
/// particlenでlerpが使え無い。
/// </summary>

    public List<GameObject> Herts;

    private float m1st;
    private float m2st;
    private float m3st;

    ParticleSystem.MainModule main1;
    ParticleSystem.MainModule main2;
    ParticleSystem.MainModule main3;

    public float timer;


    // Start is called before the first frame update
    void Start()
    {

        //hertPaDesTimeEfect = false;
        Herts = new List<GameObject>(transform.childCount);

        m1st = 41.5f;
        m2st = 38f;
        m3st = 36.91f;

        for (int i = 0; i < transform.childCount; i++)
        {
            Herts.Add(transform.GetChild(i).gameObject);

        }
        var PA1 = Herts[0].GetComponent(typeof(ParticleSystem)) as ParticleSystem;
        var PA2 = Herts[1].GetComponent(typeof(ParticleSystem)) as ParticleSystem;
        var PA3 = Herts[2].GetComponent(typeof(ParticleSystem)) as ParticleSystem;


        main1 = PA1.main;
        main2 = PA2.main;
        main3 = PA3.main;


    }

    // Update is called once per frame
    void Update()
    {
        //AnimationCurve curve = new AnimationCurve();
      


        if (timer > WaveSpanNotMusicSc.beat)
        {
            timer -= WaveSpanNotMusicSc.beat;

            main1.startSize = new ParticleSystem.MinMaxCurve(41.5f, 51.5f);
            main2.startSize = new ParticleSystem.MinMaxCurve(38f, 48f);
            main3.startSize = new ParticleSystem.MinMaxCurve(36.91f, 46.91f);
        }
        else
        {
            main1.startSize = new ParticleSystem.MinMaxCurve(51.5f, 41.5f);
            main2.startSize = new ParticleSystem.MinMaxCurve(48f, 38f);
            main3.startSize = new ParticleSystem.MinMaxCurve(46.91f, 36.91f);
        }

        timer += Time.deltaTime;

    }

}
