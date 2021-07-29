using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIHandlerScript : MonoBehaviour
{
    private bool isClosed = true;
    [SerializeField]Animator anim;

    public void menuPressed(){
        if(isClosed == true){
            anim.SetTrigger("Open");
            isClosed = false;
        }else{
            anim.SetTrigger("Close");
            isClosed = true;
        }
    }

    public void inmenuPressed(GameObject _toPanel){
        _toPanel.SetActive(true);
    }

    public void backtoScan(GameObject _currentPanel){
        _currentPanel.SetActive(false);
    }

    public void backtoMain(){
        SceneManager.LoadScene("MainMenu");
    }
    public void QuizStart(){
        SceneManager.LoadScene("MiniQuiz");
    }
    public void QuizEnded(){
        SceneManager.LoadScene("ScanScene");
    }
}
