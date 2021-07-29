using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static PlayerPrefsX;

public class QuizHandlerScript : MonoBehaviour
{
    [SerializeField]Text _soalnya, _pilA, _pilB, _pilC, _pilD;
    string _kunci;
    [SerializeField]GameObject _ifTrue, _ifFalse;
    
    void Start()
    {
        _ifTrue.SetActive(false);
        _ifFalse.SetActive(false);
        setSoal();
    }

    void setSoal(){
        string[] tempSoal, tempA, tempB, tempC, tempD, tempKunci;
        tempSoal = PlayerPrefsX.GetStringArray("SoalPilgan"); 
        tempA = PlayerPrefsX.GetStringArray("PilihanA");
		tempB = PlayerPrefsX.GetStringArray("PilihanB"); 
        tempC = PlayerPrefsX.GetStringArray("PilihanC");
		tempD = PlayerPrefsX.GetStringArray("PilihanD"); 
		tempKunci = PlayerPrefsX.GetStringArray("KunciJwbn"); 
        
        int noSoal = PlayerPrefs.GetInt("nomorquiz");
        _soalnya.text = tempSoal[noSoal];
        _pilA.text = tempA[noSoal];
        _pilB.text = tempB[noSoal];
        _pilC.text = tempC[noSoal];
        _pilD.text = tempD[noSoal];
        _kunci = tempKunci[noSoal].Trim();
    }

    public void checkJawaban(Text _jwbnnnya){
        Debug.Log("ini jawaban"+_jwbnnnya.text);
        Debug.Log("ini kunci"+_kunci);
        Debug.Log("panjang jawaban"+_jwbnnnya.text.Length);
        Debug.Log("panjang kunci"+_kunci.Length);
        Debug.Log("tipe jawaban"+_jwbnnnya.text.GetType());
        Debug.Log("tipe kunci"+_kunci.GetType());

        if (_jwbnnnya.text != _kunci)
        {
            _ifFalse.SetActive(true);
        }else{
            _ifTrue.SetActive(true);
        }
    }
}
