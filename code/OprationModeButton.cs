using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OprationModeButton : MonoBehaviour
{
    public GameObject AF_Content_1;
    public GameObject Next;
    public GameObject V3_1;
    public GameObject disapper;

    // Start is called before the first frame update
    public void OperationButton_Pre_Operation()
    {
        if (AF_Content_1 != null)
        {
            AF_Content_1.SetActive(true);

        }

        if (Next != null)
        {
            Next.SetActive(true);
        }

        if (V3_1 != null)
        {
            V3_1.SetActive(true);
        }
    }

    public void Disapper()
    {
        disapper.SetActive(false);
    }
}
