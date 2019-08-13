using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SerialLight : MonoBehaviour
{

    public SerialHandler serialHandler;
    public Text text;

    // Use this for initialization
    void Start()
    {
        //信号を受信したときに、そのメッセージの処理を行う
        serialHandler.OnDataReceived += OnDataReceived;
    }

    // Update is called once per frame
    void Update()
    {

    }

    /*
	 * シリアルを受け取った時の処理
	 */
    void OnDataReceived(string message)
    {

        //var data = message.Split(
        //   new string[] { "\t" }, System.StringSplitOptions.None);
        //if (data.Length < 2) return;

        try
        {
            text.text = message; // シリアルの値をテキストに表示
            //var angleX = float.Parse(data[0]);
            //var angleY = float.Parse(data[1]);
            //Debug.Log(data);
        }
        catch (System.Exception e)
        {
            Debug.LogWarning(e.Message);
        }
    }
}
