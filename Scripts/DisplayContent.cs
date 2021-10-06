using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayContent : MonoBehaviour
{
    public string Title;
    public string Description;
    public GameObject Panel;

    public GameObject TitleObject;

    void Start(){
    }

    private void OnMouseEnter() {
        string content = Title.ToString() + "\n\n" + Description.ToString();

        TitleObject.GetComponent<UnityEngine.UI.Text>().text = content;
        // openHint.Open();

        OpenPanel();
    }

    private void OnMouseExit() {
        OpenPanel();
    }


    public void OpenPanel(){
        if(Panel != null){
            bool isActive = Panel.activeSelf;
            Debug.Log("State : " + isActive);
            Panel.SetActive(!isActive);
        }
    }

}
