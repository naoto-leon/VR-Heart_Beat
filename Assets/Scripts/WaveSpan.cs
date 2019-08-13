using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpan : MonoBehaviour
{
    //public AudioSpectrum spectrum;

    public GameObject[] Cubes;
    public Transform[] Points;

    public GameObject StarParticle;


    /// <summary>
    /// テスト
    /// </summary>


    float count = 0;


    // Update is called once per frame
    void Update()
    {
       
        count = count + Time.deltaTime;
        //Debug.Log(count);


        //if (Music.IsJustChangedBeat())
        //{

        //    GameObject cube = Instantiate(Cubes[Random.Range(0, 4)], Points[Random.Range(0, 2)]);

        //    GameObject StPa = (GameObject)Instantiate(StarParticle, cube.transform.position, cube.transform.rotation);
        //    Destroy(StPa, .5f);
        //    cube.transform.localPosition = Vector3.zero;
        //    cube.transform.Rotate(transform.forward * 90, Random.Range(0, 2));

        //}

        if (Music.CurrentSection.Name == "Test1")
        {


            if (Music.IsJustChangedBeat())
            {

                GameObject cube = Instantiate(Cubes[Random.Range(0, 4)], Points[Random.Range(0, 2)]);

                GameObject StPa = (GameObject)Instantiate(StarParticle, cube.transform.position, cube.transform.rotation);
                Destroy(StPa, .5f);

                cube.transform.localPosition = Vector3.zero;
                cube.transform.Rotate(transform.forward * 90, Random.Range(0, 2));

            }


        }

        if (Music.CurrentSection.Name == "Test2")
        {
            if (Music.IsJustChangedBeat())
            {

                GameObject cube = Instantiate(Cubes[Random.Range(0, 2)], Points[Random.Range(0, 2)]);

                GameObject StPa = (GameObject)Instantiate(StarParticle, cube.transform.position, cube.transform.rotation);
                Destroy(StPa, .5f);
                cube.transform.localPosition = Vector3.zero;
                cube.transform.Rotate(transform.forward * 90, Random.Range(0, 2));

            }

        }
        if (Music.CurrentSection.Name == "Test3")
        {
            if (Music.IsJustChangedBeat())
            {

                GameObject cube = Instantiate(Cubes[Random.Range(0, 3)], Points[Random.Range(0, 2)]);

                GameObject StPa = (GameObject)Instantiate(StarParticle, cube.transform.position, cube.transform.rotation);
                Destroy(StPa, .5f);
                cube.transform.localPosition = Vector3.zero;
                cube.transform.Rotate(transform.forward * 90, Random.Range(0, 2));

            }

        }
        if (Music.CurrentSection.Name == "Test4")
        {
            if (Music.IsJustChangedBeat())
            {

                GameObject cube = Instantiate(Cubes[Random.Range(0, 3)], Points[Random.Range(0, 2)]);

                GameObject StPa = (GameObject)Instantiate(StarParticle, cube.transform.position, cube.transform.rotation);
                Destroy(StPa, .5f);
                cube.transform.localPosition = Vector3.zero;
                cube.transform.Rotate(transform.forward * 90, Random.Range(0, 2));

            }

        }

        if (Music.CurrentSection.Name == "Test5")
        {
            if (Music.IsJustChangedBeat())
            {

                GameObject cube = Instantiate(Cubes[Random.Range(0, 4)], Points[Random.Range(0, 2)]);

                GameObject StPa = (GameObject)Instantiate(StarParticle, cube.transform.position, cube.transform.rotation);
                Destroy(StPa, .5f);
                cube.transform.localPosition = Vector3.zero;
                cube.transform.Rotate(transform.forward * 90, Random.Range(0, 2));

            }

        }

        if (Music.CurrentSection.Name == "Test6")
        {
            if (Music.IsJustChangedBeat())
            {

                GameObject cube = Instantiate(Cubes[Random.Range(0, 2)], Points[Random.Range(0, 2)]);

                GameObject StPa = (GameObject)Instantiate(StarParticle, cube.transform.position, cube.transform.rotation);
                Destroy(StPa, .5f);
                cube.transform.localPosition = Vector3.zero;
                cube.transform.Rotate(transform.forward * 90, Random.Range(0, 2));

            }

        }

        if (Music.CurrentSection.Name == "Test7")
        {
            if (Music.IsJustChangedBeat())
            {

                GameObject cube = Instantiate(Cubes[Random.Range(0, 3)], Points[Random.Range(0, 2)]);

                GameObject StPa = (GameObject)Instantiate(StarParticle, cube.transform.position, cube.transform.rotation);
                Destroy(StPa, .5f);
                cube.transform.localPosition = Vector3.zero;
                cube.transform.Rotate(transform.forward * 90, Random.Range(0, 2));

            }

        }

        if (Music.CurrentSection.Name == "Test8")
        {
            if (Music.IsJustChangedBeat())
            {

                GameObject cube = Instantiate(Cubes[Random.Range(0, 3)], Points[Random.Range(0, 2)]);

                GameObject StPa = (GameObject)Instantiate(StarParticle, cube.transform.position, cube.transform.rotation);
                Destroy(StPa, .5f);
                cube.transform.localPosition = Vector3.zero;
                cube.transform.Rotate(transform.forward * 90, Random.Range(0, 2));

            }

        }

        if (Music.CurrentSection.Name == "Test9")
        {
            if (Music.IsJustChangedBeat())
            {

                GameObject cube = Instantiate(Cubes[Random.Range(0, 2)], Points[Random.Range(0, 2)]);

                GameObject StPa = (GameObject)Instantiate(StarParticle, cube.transform.position, cube.transform.rotation);
                Destroy(StPa, .5f);
                cube.transform.localPosition = Vector3.zero;
                cube.transform.Rotate(transform.forward * 90, Random.Range(0, 2));

            }

        }

        if (Music.CurrentSection.Name == "Test10")
        {
            if (Music.IsJustChangedBeat())
            {

                GameObject cube = Instantiate(Cubes[Random.Range(0, 4)], Points[Random.Range(0, 2)]);

                GameObject StPa = (GameObject)Instantiate(StarParticle, cube.transform.position, cube.transform.rotation);
                Destroy(StPa, .5f);
                cube.transform.localPosition = Vector3.zero;
                cube.transform.Rotate(transform.forward * 90, Random.Range(0, 2));

            }

        }

        if (Music.CurrentSection.Name == "Test11")
        {
            if (Music.IsJustChangedBeat())
            {

                GameObject cube = Instantiate(Cubes[Random.Range(0, 2)], Points[Random.Range(0, 2)]);

                GameObject StPa = (GameObject)Instantiate(StarParticle, cube.transform.position, cube.transform.rotation);
                Destroy(StPa, .5f);
                cube.transform.localPosition = Vector3.zero;
                cube.transform.Rotate(transform.forward * 90, Random.Range(0, 2));

            }

        }

        if (Music.CurrentSection.Name == "Test12")
        {
            if (Music.IsJustChangedBeat())
            {

                GameObject cube = Instantiate(Cubes[Random.Range(0, 3)], Points[Random.Range(0, 2)]);

                GameObject StPa = (GameObject)Instantiate(StarParticle, cube.transform.position, cube.transform.rotation);
                Destroy(StPa, .5f);
                cube.transform.localPosition = Vector3.zero;
                cube.transform.Rotate(transform.forward * 90, Random.Range(0, 2));

            }

        }

        if (Music.CurrentSection.Name == "Test13")
        {
            if (Music.IsJustChangedBeat())
            {

                GameObject cube = Instantiate(Cubes[Random.Range(0, 4)], Points[Random.Range(0, 2)]);

                GameObject StPa = (GameObject)Instantiate(StarParticle, cube.transform.position, cube.transform.rotation);
                Destroy(StPa, .5f);
                cube.transform.localPosition = Vector3.zero;
                cube.transform.Rotate(transform.forward * 90, Random.Range(0, 2));

            }

        }

        if (Music.CurrentSection.Name == "Test14")
        {
            if (Music.IsJustChangedBeat())
            {

                //GameObject cube = Instantiate(Cubes[Random.Range(0, 0)], Points[Random.Range(0, 2)]);

                //GameObject StPa = (GameObject)Instantiate(StarParticle, cube.transform.position, cube.transform.rotation);
                //Destroy(StPa, .5f);
                //cube.transform.localPosition = Vector3.zero;
                //cube.transform.Rotate(transform.forward * 90, Random.Range(0, 2));

            }

        }

    }




    void SpanWave()
    {

    }


}
