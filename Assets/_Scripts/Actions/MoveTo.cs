using BehaviorDesigner.Runtime.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

[TaskDescription("使当前物体前往某地")]
[TaskCategory("MyMovement")]
[TaskIcon("Assets/Behavior Designer Movement/Editor/Icons/{SkinColor}MoveTowardsIcon.png")]
public class MoveTo : Action
{
   
    public Transform destination;
    
    public float duration;

    private Tweener anim;


    public override void OnStart() {
        anim=  transform.DOMove(destination.position, duration).SetEase(Ease.InOutSine);
       
    
    }
    public override TaskStatus OnUpdate()
    {
        if (anim.IsPlaying())
        {
            return TaskStatus.Running;
        }
        else
        {
            return TaskStatus.Success;
        }
    }
}
