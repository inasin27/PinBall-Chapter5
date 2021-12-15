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

    //①変数の初期化
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

    //①オリジナル
    void OnCollisionEnter(Collision Point2)
    {
        if (Point2.gameObject.tag == "LargeStarTag")
        {
            Point += 200;
        }
        else if (Point2.gameObject.tag == "SmallStarTag")
        {
            Point += 50;
        }
        else
        {
            Point += 0;
        }
        this.pointText.GetComponent<Text>().text =Point+"点";
    }

}