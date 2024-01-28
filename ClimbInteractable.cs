using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ClimbInteractable : XRBaseInteractable
{
    [System.Obsolete]
    protected override void OnSelectEntered(XRBaseInteractor interactor)
    {
        base.OnSelectEntered(interactor);

        if (interactor is XRDirectInteractor)
            Climber.climbingHand = interactor.GetComponent<XRController>();

       Debug.Log("Select Enter");
    }
   
    [System.Obsolete]
    protected override void OnSelectExited(XRBaseInteractor interactor)
    {
        
        base.OnSelectExited(interactor);

        if (interactor is XRDirectInteractor)
        {
            if(Climber.climbingHand && Climber.climbingHand.name == interactor.name)
            {
                Climber.climbingHand = null;
            }
        }

       Debug.Log("Select Exit");
    }
}
//
