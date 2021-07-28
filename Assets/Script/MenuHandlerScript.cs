using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuHandlerScript : MonoBehaviour
{
    public void sound_volume(float volume)
    {
        PlayerPrefs.SetFloat("volume", volume);
    }

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

    public AudioSource musik, touch; 

    public Slider volume_musik, volume_effect;

    void OnMouseDown()
    {
        touch.volume = volume_effect.value;

        musik.volume = volume_musik.value;  
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
