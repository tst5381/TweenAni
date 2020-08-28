using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TweenAni;
using DG.Tweening;

public class TweenAniTest : MonoBehaviour
{
    public TweenAnimation panelEnter;
    public TweenAnimation panelExit;
    public TweenAnimation loopAnimation;
    bool isInTransition;

    void Start()
    {
        // Play sequence via script
        Tween tween = loopAnimation.PlaySequence();
        // Use with callbacks
        tween.onStepComplete += () => Debug.Log("Demo: Loops completed one step.");
        tween.onComplete += () => Debug.Log("Demo: Loops all completed.");
    }

    public void OnBtnPanelEnter()
    {
        if (isInTransition) { return; }
        isInTransition = true;
        panelEnter.PlaySequence().onComplete += () => isInTransition = false;
    }

    public void OnBtnPanelExit()
    {
        if (isInTransition) { return; }
        isInTransition = true;
        panelExit.PlaySequence().onComplete += () => isInTransition = false;
    }
}