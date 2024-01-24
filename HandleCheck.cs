using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleCheck : MonoBehaviour
{
    public GameObject handleChecker;
    public GameObject Sucess;
    public GameObject tino;
    public GameObject v6Defence;
   // public GameObject timeChecker;
   
 
    // Start is called before the first frame update
    void Start()
    {
        
       // UnityEngine.Debug.Log(System.DateTime.Now.ToLongTimeString() + " : ");
        //   handleChecker.transform.position = new Vector3(1.442f,0.72f,4.31f);
    }

    // Update is called once per frame
    void Update()
    {
       // UnityEngine.Debug.Log(System.DateTime.Now.ToLongTimeString() + " : ");
        if (handleChecker.transform.rotation.z < 0.1f)
        {
            Sucess.SetActive(true);
            tino.SetActive(true);
          
            v6Defence.SetActive(false);
            
           // Debug.Log("Success");
            //Debug.Log(Time.time);
            UnityEngine.Debug.Log(System.DateTime.Now.ToLongTimeString() + " : ");
            Debug.Log("User Success valve task time");
        }
    }

  


}
