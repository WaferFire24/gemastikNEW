using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuHandlerScript : MonoBehaviour
{
    private bool isClosed = true;
    [SerializeField]Animator anim;

    public void startPressed(){
        SceneManager.LoadScene("ScanScene");
    }
    public void inmenuPressed(GameObject _toPanel){
        _toPanel.SetActive(true);
    }

    public void backtoMenu(GameObject _currentPanel){
        _currentPanel.SetActive(false);
    }

    public void quitPressed(){
        Application.Quit();
    }

    public void menuPressed(){
        if(isClosed == true){
            anim.SetTrigger("Open");
            isClosed = false;
        }else{
            anim.SetTrigger("Close");
            isClosed = true;
        }
    }
}
