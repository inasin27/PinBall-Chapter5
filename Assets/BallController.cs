using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    //�{�[����������\���̂���z���̍ŏ��l
    private float visiblePosZ = -6.5f;

    //�Q�[���I�[�o��\������e�L�X�g
    private GameObject gameoverText;
    private GameObject pointText;

    //�@�ϐ��̏�����
    private int Point = 0;

    // Use this for initialization
    void Start()
    {
        //�V�[������GameOverText�I�u�W�F�N�g���擾
        this.gameoverText = GameObject.Find("GameOverText");
        this.pointText = GameObject.Find("PointText");
    }

    // Update is called once per frame
    void Update()
    {
        //�{�[������ʊO�ɏo���ꍇ
        if (this.transform.position.z < this.visiblePosZ)
        {
            //GameoverText�ɃQ�[���I�[�o��\��
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
    }

    //�@�I���W�i��
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
        this.pointText.GetComponent<Text>().text =Point+"�_";
    }

}