using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class bpmText : MonoBehaviour
{

    [SerializeField]
    private TextMeshProUGUI BpmText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BpmText = gameObject.GetComponent<TextMeshProUGUI>();
        BpmText.text = WaveSpanNotMusicSc.heartBeat.ToString()+ ":bpm";
    }
}
