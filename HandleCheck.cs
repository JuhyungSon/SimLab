using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleCheck : MonoBehaviour
{
    public GameObject handleChecker;
    public GameObject Sucess;
    public GameObject tino;
    public GameObject v6Defence;
 
   
 
    // Start is called before the first frame update
    void Start()
    {
     
    }

   
    void Update()
    {
      
        if (handleChecker.transform.rotation.z < 0.1f)
        {
            Sucess.SetActive(true);
            tino.SetActive(true);
          
            v6Defence.SetActive(false);
            
          
            UnityEngine.Debug.Log(System.DateTime.Now.ToLongTimeString() + " : ");
            Debug.Log("User Success valve task time");
        }
    }

  


}
