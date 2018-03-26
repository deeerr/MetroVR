using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

/// <summary>
/// 门控制脚本
/// </summary>
public class DoorController : MonoBehaviour
{

    /// <summary>
    /// 门开起动画
    /// </summary>
    Tweener leftAnim;
    Tweener rightAnim;


    /// <summary>
    /// 门是否开启
    /// </summary>
    bool isOpen = false;



    void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            Transform child = transform.GetChild(i);
            if (child.name.Equals("LeftDoor"))
            {
                leftAnim = child.DOLocalMoveZ(-0.8f, 3).SetEase(Ease.InQuad);
                leftAnim.SetAutoKill(false);
                leftAnim.Pause();
            }
            else if (child.name.Equals("RightDoor"))
            {
                rightAnim = child.DOLocalMoveZ(0.8f, 3).SetEase(Ease.InQuad);
                rightAnim.SetAutoKill(false);
                rightAnim.Pause();
            }
        }
    }

    public void Open()
    {
        if (!isOpen)
        {
            leftAnim.PlayForward();
            rightAnim.PlayForward();
            isOpen = true;
        }
    }
    public void Close()
    {
        if (isOpen)
        {
            leftAnim.PlayBackwards();
            rightAnim.PlayBackwards();
            isOpen = false;
        }
    }

    public void OpenOrClose()
    {
        if (isOpen)
        {
            Close();
        }
        else
        {
            Open();
        }
    }

}
