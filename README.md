# VR-test-4-Backup2-2
[VR Oculus-Go] use Arduino and Sonic_pi made game like Beatsaver 

#### PulseSEnsorで人間の心拍数を取得し、ArduinoでBPM変換してSonic_piの楽曲とゲームシステムに取り込み、Oculus GoでBeatSaverのようなゲームを作りました。初めてのVR開発でわりかし手間取ったのと時間を掛けたので詳細に記録します。
##### [YouTube](https://youtu.be/9nsiCdtRgEo)
![VR_GIF1](https://user-images.githubusercontent.com/43961147/61991270-e2493480-b088-11e9-8c0b-e08919d54cd5.gif)

***

### 製作動機　

恐らくBeat-Saverをやる為にVRの購入をした人は多いと思う、僕もその一人です。　
しかし、当時の僕はVRに関して全くの無知であり、適正機種がある事など全く知らなかったので、取り敢えず安いお手頃のOculas-Goを買いました。　
##### が、しかし、ご存知の通りOculas-GoではBeat-Saverが出来ない。　　
なんとも悔しい気持ちになったので作ってみました。
結果や満足度に関しては最後にまとめてあります。

***

### コンセプト　

#### [音と心臓の関係性に関して〜僕らは生まれた時からリズムを刻んでいる〜]

#### <BPMとは>  

BPMとは"Beat Per Minute"の略で**音楽用語での「１分間あたりの拍数**を意味する。  
音楽に合わせて「ドン　ドン　チキ　チキ」とリズムを取った時のドン　チキが１分間に何回あるかを数えたもので  
ヒップホップは60~100くらいだし、ハードテクノは150くらい。　

そしてここで大事なのがBPMのもう一つの意味であり、それは**医学用語での「１分間あたりの脈拍数**という意味である。

ここで僕が考えたのは**音と心体の関係は何か直接的な関係性があるのでは**という事だ。  

例えば、「ある曲を聴くとテンションが上がる」「良く眠れる曲」極端な例としては「お互いの好みの曲が同じカップルは波長が合う」や「激しい曲の好きな人は高血圧」といった感じ。　

心拍のBPMと音楽のBPMの関連性に関しては[成城大学の論文](https://www.jcss.gr.jp/meetings/jcss2010/pdf/JCSS2010_P3-47.pdf)でも取り扱われており(作業効率とBPM（作業中に流す曲）の関連性に関しての内容)確証（医学的な根拠）はないが何かしらの関連性はありそうだ。

#### <自分の心拍数を可視化・可聴化して気持ちよくなってもらいたい>

**今回のゲームは球の排出のタイミングにプレイヤーのBPMを使っています。**

人間が適度な興奮状態にある場合のBPMは約120~130と言われています。　　
今回は楽曲にBPM130の曲を使用しておりますので、適度に体を動かして(早歩きくらい)プレイすると丁度良い感じになるかと思います。  

人間の普段のBPMは70~80と言われていますので、いかに興奮できるかが面白くなるコツです。　

***
### 開発環境　

#### Oculas-Go 
□ 3Dof（回転のみ)  
□ 60~72hz 

#### MacBook Pro 
□  バージョン　10.14.5  

#### Unity 
□  バージョン　2019 1.8f1  
□  レンダリング　LWRP  

#### Andoroid SDK 
□ Andoroid 9.0(pie) 

#### JDK 
□ java version "1.8.0_211"  

#### Arduino 
□ Leonardo 

#### PulseSensor 


大事なのはUnityとOculas-Goのスペックと設定。  
まず、3DofというのはVR空間において首の動きのみ連動するという事。（対して屈んだりの動作にも連動している機種を6Dofという）  
正規のBeat-Saverは6Dof対応。  
また、60~72hzはリフレッシュノートであるが、PsVRなどの機種が120hzに対してかなり低い。  
どれくらい低いかというと、スマホと同じくらい。  
なお、スタンドアローン型？(Pcとの連動で動くやつじゃないやつ)。
#### 自分なりにまとめると、スマホのスペックでVRの挙動を実装しなくてはいけない。  
これがかなりネック  
Pc開発時でのFpsが200オーバーにも関わらず実機で確認すると挙動がガタツク場合がある。  

***

### 開発時のエラー　

起きたエラーの中でも印象的だったものについて。  

#### □ Particleが表示されない　
　Unityのバグ、バージョンアップで解決  

#### □ Build成功してもOculas-Goで表示されない（黒い画面）  

  同様のエラーの報告多数有り、原因と解決策は未だ不明のよう。  
  自分は新しくプロジェクトを立て直す事で解決した。    
  ついでに、一度BuildしてアプリとしてOculas-Go内に残したプロジェクトはadbコマンドでなければ消せない（開発者にかなり不評）
　ここら辺のadbコマンドの環境を整えるまでに普段からターミナルを使わない自分はかなり手こずった。    
  (最終的には、プロに教えてもらった)  
  
#### □ Oculas-Go内で録画が出来なくなった件について　

この件に関しては、同様の例がなく根本的な理由、解決方法が未だ不明。  
 スマホとのミラーリングをしての画面録画も試みたが、同様にエラー。  
  
  結局、GoogleのVysorとMediaPlayerを使って録画した。(画質も余り良くないし２画面になった)
  
#### □ Unity Canvasの設定に関して。（表示はされるが。。。）　

　これは完全に自分の考え不足であった。  
 最初は自分の首が動く度にUIが動き不快であり（エースコンバットのような標準を常に首の動きとリンクさせるには良いかもしれないが）  
 なんとか改良したかった。  
 
 Canvasの設定をWorld座標にする事で解決した。（FPSでのUIの挙動を考えれば上記の挙動は自然である）

#### □ Arduino(Leonardo)がシリアルモニタを開かないとunityへ通信されない事に関して。    
 
  Genuino Unoでは問題なく動作するがLeonardoではシリアルモニタを開かなければPrintlnがされない問題に関して。  
  おそらくunityのバグ。  
  有料でのunityアセットUNIDUINO(Arduino連携で推奨されたやり方)であれば恐らく動作する気がするので今後改善はされなさそう。  
  

***

### 心拍数を使った音ゲーとしての実装に関して　

　音ゲーと実装としてまず思いつくのが、Jsonやcsv?で楽譜(発生場所や時間)を作り、配列にしてfor文内で、再生曲時間からTimeを引いた値と同じ値に処理される関数をIf文で呼び出すような作り方で、この方法（若干違うけどJsonとか使うのは概ね同じ）を紹介しているサイトは多い。
 
 しかし、今回の音ゲーとしての実装には掲げたテーマに沿って人体の心拍数を元に設計した。　　
 
 おおよそ三つの方法を試し、三つ目の方法で成功した。　
 
#### □BPMを使った基本の設計  
 
 基本の設計としてはBPMを60で割り(60/bpm)それを繰り返す中に処理をさせると言うもの。
 
    beat = 60/BPM
 
         if (timer > beat)
        {
            timer -= beat;
            [[処理]]
      }
           timer += Time.deltaTime;

今回はこのBPMに心拍数を持ってくる。

#### □方法その１
<img width="535" alt="vj通信1" src="https://user-images.githubusercontent.com/43961147/63077581-be845a80-bf73-11e9-967d-9f20d0a16e35.png">

クラウドプラットフォームであるmilkkokoaを使っての実装を試みた。  
milkkokoaはArduinoから直接通信可能な環境があり、使用例も公式で紹介されている。  

自身の環境でもunity間での通信は容易に実装が出来た為このままmilkkokoaを使っての実装を考えたが。  

#### しかし、milkkokoaは今年の9月でサービス終了のようである為断念した。
 ##### [mlkcca](https://mlkcca.com)


#### □方法その２
<img width="538" alt="vj通信2" src="https://user-images.githubusercontent.com/43961147/63078713-60f20d00-bf77-11e9-86ed-b1af55e5dec2.png">

二つ目に試した事はOculasGoとarduinoを充電ケーブルを使い直接連携させる方法である。  
これはTwitterで試している人を偶々見つけた為自身でもやってみた試みである。　

理論的にはLeonnarudoとOculasGoがHIDデバイスの互換性がある為可能っぽい。

結果は失敗で、理由は上記に挙げたLeonarudoによるエラーである。  
恐らくこのエラー(シリアルモニタを開かなければ動作が始まらない問題)がなければ一番手軽かつスムーズな動作が実現できる方法だと思う。  

有料のアセットを購入した際は再チャレンジしたい。

 ##### [ HID デバイスに関して詳しくはここ](https://ht-deko.com/arduino/hid.html)

#### □方法その３
<img width="532" alt="vj通信3" src="https://user-images.githubusercontent.com/43961147/63081438-8fbfb180-bf7e-11e9-8d96-e9835b696eb7.png">

最終的な方法は、OSC通信ようにunityで別プログラムを作り、OculasGoに送るというもの。　

□導入にあたりInspectorのOtherのSettingsにある「Api Compatibility Level」を「.NET 2.0」にする必要があるのだが、Unityのバージョンアップに伴い
　使用が変わり「.NET 2.0」が無くなった。試しに「.NET 4.0」を使用したらエラーが無くなった。
 
□Oculas GoのIPアドレスを調べるのにadbコマンドを打つ必要があり(なぜユーザアビリティに関する設定画面をOculasGo内に作らなかったのか。。。)苦労した。

□ Arduinoから送られてくる情報がintなのかstringなのか分からずキャストに少し苦労した。

 ##### PulseSensor~Arduinoとの連携に関して  
 基本的にはPulseSensorの公式HPに使用例が書いてあるので、ほぼ丸写し。　
 
     #define USE_ARDUINO_INTERRUPTS true  
    #include <PulseSensorPlayground.h>       

    //  Variables
    const int PulseWire = 0;            
    int Threshold = 550;           
                                                                                     
    PulseSensorPlayground pulseSensor;  

    void setup() {   

      Serial.begin(9600);          // For Serial Monitor

      // Configure the PulseSensor object, by assigning our variables to it. 
      pulseSensor.analogInput(PulseWire);   
      pulseSensor.setThreshold(Threshold);   

      // Double-check the "pulseSensor" object was created and "began" seeing a signal. 
      if (pulseSensor.begin()) {
       Serial.println("We created a pulseSensor Object !");  //This prints one time at Arduino power-up,  or on Arduino reset.  
    }
    }
    void loop() {

    int myBPM = pulseSensor.getBeatsPerMinute();  
                                              
    if (pulseSensor.sawStartOfBeat()) {            
     Serial.println(myBPM);                      
    }
      delay(20);                   
    }
 
 <img width="368" alt="arduino" src="https://user-images.githubusercontent.com/43961147/63151672-fc9d7f00-c044-11e9-80af-c405550c5f5c.png">
 
 ##### [参考arduino](http://rikoubou.hatenablog.com/entry/2018/01/16/175113)
 ##### [参考OSC]( http://tips.hecomi.com/entry/2017/08/20/193823)
##### [PulseSensor]( https://pulsesensor.com)
***

### VRとしての組み立て　

導入の組み立て(アクティブなコントローラの取得まで)はググれば出てくる。  

基本的にはRaycastを使うがRaycastHitの情報で組み立てるとポイントが当たったら消すという切ってる感が全くなくなる為（第一段階ではTagを使用しての実装を試みた）

      if (hitInfo.collider.tag == "TagName")
          {  Destroy(hitInfo.collider.gameObject);}
        
        
  こんな感じ  
  
  繰り返すが、これだと切ってる感が全くない為下記の方法を試してみた。

<img width="400" alt="VR2" src="https://user-images.githubusercontent.com/43961147/61995139-0de71180-b0bf-11e9-99f0-61f2abe626f0.png">

    if (Vector3.Angle(pointer.position - previousPos, hitInfo.transform.up) > 130f) { 
     Destroy(hitInfo.transform.gameObject);
     }
 
 実際のコードでは130度以上で消すようにした。  
 また、荒い方法ではあるが下からの処理(下からの振り上げへの反応)はマイナスの処理で実装した。(角度及びhitinfoのベクトル)
 
 ***
 
 ### 音とのマッチング　
 
 音とのマッチング性を高める為にゲームそのものにオーディオビジュアルの側面を持たせた。　　
 
####  □ スペクトラムに合わせてParticle、シェーダーを動かす。 

unityでは下記の一文でスペクトラムの取得が可能であり  
    AudioListener.GetSpectrumData(spectrum, 0, FFTWindow.Rectangular);  
 これを下記のようなfor文で処理する事ができる。  
    for (int i = 1; i < spectrum.Length - 1; i++)  

こんな感じ
 ![Spectram](https://user-images.githubusercontent.com/43961147/61995838-61aa2880-b0c8-11e9-9cf0-0f76c6c9f892.gif)

プロジェクトファイルに入れてないので一応記載しとく  
適当なgameobjectにぶっこんでインスペクターからCubeいれれば動く  

    
    using UnityEngine;
    [RequireComponent(typeof(AudioSource))]
    ublic class AudioSourceGetSpectrumDataExample : MonoBehaviour
    {
    public Transform[] cubes;
    public float scale;
    void Update()
    {
        float[] spectrum = new float[256];
        AudioListener.GetSpectrumData(spectrum, 0, FFTWindow.Rectangular);
        for (int i = 0; i < cubes.Length; i++)
        {
            var cube = cubes[i];
            var localScale = cube.localScale;
            localScale.y = spectrum[i] * scale;
            cube.localScale = localScale;
           }
        }
    }   
    

 実装にはkeijiroさんのunity-audio-spectrumを利用させていただいた。　
 ##### [keijiro/unity-audio-spectrum]( https://github.com/keijiro/unity-audio-spectrum)

 ##### Particleの取得はジェネリック型ではない為GetComponent(typeof(ParticleSystem))で取得。      
 ##### シェーダーに関してはGetComponent<MeshRenderer>();でマテリアルにアクセスし、SetFloatでシェーダーで設定した変数を取得。
  
  ***
  
   ### ビジュアライズに関して　
   
   可能限り使用したParticle Shader諸々を紹介します。

***

  ### 開発のヒント
