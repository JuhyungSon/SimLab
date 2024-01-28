using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRoffsetgrabinteractable : XRGrabInteractable
{

    private Vector3 initalLocalPosions;
    private Quaternion initialLocalRot;
    // Start is called before the first frame update
    void Start()
    {
        if (!attachTransform)
        {
            GameObject attachPoint = new GameObject("Offset Grab Pivot");
            attachPoint.transform.SetParent(transform, false);
            attachTransform = attachPoint.transform;
        }
        else
        {
            initalLocalPosions = attachTransform.localPosition;
            initialLocalRot = attachTransform.localRotation;
        
        
        }
    }

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        if(args.interactorObject is XRDirectInteractor)
        {
            attachTransform.position = args.interactorObject.transform.position;
            attachTransform.rotation = args.interactorObject.transform.rotation;
        }
        else 
        {
            attachTransform.localPosition = initalLocalPosions;
            attachTransform.localRotation = initialLocalRot;
        }
       

        base.OnSelectEntered(args);
    }
}
