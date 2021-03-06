using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    //ボールが見える可能性のあるz軸の最小値
    private float visiblePosZ = -6.5f;

    //ゲームオーバを表示するテキスト
    private GameObject gameoverText;
    private GameObject pointText;

    //?@変数の初期化
    private int Point = 0;

    // Use this for initialization
    void Start()
    {
        //シーン中のGameOverTextオブジェクトを取得
        this.gameoverText = GameObject.Find("GameOverText");
        this.pointText = GameObject.Find("PointText");
    }

    // Update is called once per frame
    void Update()
    {
        //ボールが画面外に出た場合
        if (this.transform.position.z < this.visiblePosZ)
        {
            //GameoverTextにゲームオーバを表示
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
    }

    //?@オリジナル
    void OnCollisionEnter(Collision Point2)
    {
        if (Point2.gameObject.tag == "LargeStarTag")
        {
            Point += 1000;
        }
        else if (Point2.gameObject.tag == "SmallStarTag")
        {
            Point += 100;
        }
        else if (Point2.gameObject.tag == "SmallCloudTag")
        {
            Point += 10;
        }
        else if (Point2.gameObject.tag == "LargeCloudTag")
        {
            Point += 1;
        }
        this.pointText.GetComponent<Text>().text =Point+"点";
    }

}