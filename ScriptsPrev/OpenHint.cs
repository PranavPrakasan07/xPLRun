using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenHint : MonoBehaviour
{
    public GameObject Panel;

    public void OpenPanel(){

        if(Panel != null){
            
            bool isActive = Panel.activeSelf;
            Debug.Log("State : " + isActive);
            Panel.SetActive(!isActive);
        }
    }
}
