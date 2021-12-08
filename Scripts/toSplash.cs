using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class toSplash : MonoBehaviour
{
   private static int sceneNum =0; 
    void Start()
    {
        StartCoroutine(ToSplash());
    }

   IEnumerator ToSplash (){
       yield return new WaitForSeconds(4);
       sceneNum+=1;
       SceneManager.LoadScene (sceneNum);
   }
}
