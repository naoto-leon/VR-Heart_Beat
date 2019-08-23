using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Point_Laser : MonoBehaviour
{

    // 右手
    [SerializeField]
    private Transform _RightHandAnchor;

    // 左手
    [SerializeField]
    private Transform _LeftHandAnchor;

    // 目の中心
    [SerializeField]
    private Transform _CenterEyeAnchor;

    // 距離
    [SerializeField]
    private float _MaxDistance = 100.0f;

    // LineRenderer
    [SerializeField]
    private LineRenderer _LaserPointerRenderer;
    //LineRenderer = ラインの描画


    Box boxes;

    public LayerMask layer;
    private Vector3 previousPos;

    [SerializeField]
    public AudioClip clip1;
    //public AudioClip clip2;

    private AudioSource audioSource;

    //Efect 

    public GameObject DestroyEfect;


    //TEST KASOKUDO 

    public Text accText;

    //public Text accY;
    //public Text accx;

    public Text accyy;
    public Text accxx;

    // コントローラー
    private Transform Pointer
    {
        get
        {
            // 現在アクティブなコントローラーを取得
            var controller = OVRInput.GetActiveController();
            if (controller == OVRInput.Controller.RTrackedRemote)
            {
                return _RightHandAnchor;
            }
            else if (controller == OVRInput.Controller.LTrackedRemote)
            {
                return _LeftHandAnchor;
            }

            //上が右手、下が左手　
            // どちらも取れなければ目の間からビームが出る
            return _CenterEyeAnchor;
        }
    }

    private void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
     
    }


    void Update()
    {
        RaycastHit hitInfo;


        // コントローラーを取得
        var pointer = Pointer;//var=transform pointer 

        //    //TEST KASOKUDO 
        OVRInput.Controller activeController = OVRInput.GetActiveController();
        Vector3 angAcc = OVRInput.GetLocalControllerAngularAcceleration(activeController);

        accText.text = "Acc : " + angAcc;

        //if (Mathf.Abs(angAcc.y) > 80f)
        //{
        //    //100 not Get
        //    //10 can get
        //    accY.text = "Get Y";
        //}
        //else
        //{
        //    accY.text = "";
        //}

        if (Mathf.Abs(angAcc.y) > 70f)
        {            
            accyy.text = "Get yy";
        }
        else
        {
            accyy.text = "";
        }

        //if (Mathf.Abs(angAcc.x) > 80f)
        //{
        //    accx.text = "Get X";
        //}
        //else
        //{
        //    accx.text = "";
        //}

        if (Mathf.Abs(angAcc.x) > 70f)
        {
            accxx.text = "Get XX";
        }
        else
        {
            accxx.text = "";
        }




        // コントローラーがない or LineRendererがなければ何もしない
        if (pointer == null || _LaserPointerRenderer == null)
        {
            return;
        }

        // コントローラー位置からRayを飛ばす
        Ray pointerRay = new Ray(pointer.position, pointer.forward);

        // レーザーの起点
        _LaserPointerRenderer.SetPosition(0, pointerRay.origin);

       

        //if (Physics.Raycast(pointerRay, out hitInfo, _MaxDistance))
        //{
        if (Physics.Raycast(pointerRay, out hitInfo, _MaxDistance, layer)) { 
            ////////////////////////////////追加/////////////////////////////////


            //GameObject obj = hitInfo.collider.gameObject;

            // Rayがヒットしたらそこまで
            //_LaserPointerRenderer.SetPosition(1, hitInfo.point);


            if (Vector3.Angle(pointer.position - previousPos, hitInfo.transform.up) > 130f && (Mathf.Abs(angAcc.y) > 70f || Mathf.Abs(angAcc.x) > 70f)) { 
                audioSource.PlayOneShot(clip1);


                GameObject destroypact = (GameObject)Instantiate(DestroyEfect, hitInfo.transform.position, hitInfo.transform.rotation);

                Destroy(destroypact,.9f);
                Destroy(hitInfo.transform.gameObject);
                Player.Combo++;
                Player.Point+= 0.005f;

                Tapu.TapuEect = true;
                //HertsParticleDesTimeEfect.hertPaDesTimeEfect = true;

                return;

            }

            else if  (Vector3.Angle(pointer.position - previousPos, - hitInfo.transform.up) > -130 && (Mathf.Abs(angAcc.y) > 70f || Mathf.Abs(angAcc.x) > 70f))
            {
                audioSource.PlayOneShot(clip1);


                GameObject destroypact = (GameObject)Instantiate(DestroyEfect, hitInfo.transform.position, hitInfo.transform.rotation);

                Destroy(destroypact, .9f);

                Destroy(hitInfo.transform.gameObject);
                Player.Combo++;
                Player.Point+= 0.01f;

                Tapu.TapuEect = true;
                //HertsParticleDesTimeEfect.hertPaDesTimeEfect = true;

                return;
            }


        }
        else
        {
            // Rayがヒットしなかったら向いている方向にMaxDistance伸ばす
            _LaserPointerRenderer.SetPosition(1, pointerRay.origin + pointerRay.direction * _MaxDistance);

        }



        previousPos = pointer.position;

        //if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        //{
        //    Shot(pointer);
        //}

        ////////////////////////////////追加/////////////////////////////////
        //if (hitInfo.collider.tag == "BoxIcon")
        //{
        //GameObject Box = GameObject.FindGameObjectWithTag("BoxIcon");

        //if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        //{
        //    //Destroy(hitInfo.collider.gameObject);
        //    Destroy(BoxIcon);
        //}

        //    Destroy(hitInfo.collider.gameObject);
        //    Player.Point++;


        //}

        ////////////////////////////
        /// 



    }



}



