using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static PlayerPrefsX;

public class QuizHandlerScript : MonoBehaviour
{
    [SerializeField]Text _soalnya, _pilA, _pilB, _pilC, _pilD;
    string[] tempSoal, tempA, tempB, tempC, tempD;

    void Start()
    {
        setSoal();
    }

    void setSoal(){
        tempSoal = PlayerPrefsX.GetStringArray("SoalPilgan"); 
        tempA = PlayerPrefsX.GetStringArray("PilihanA");
		tempB = PlayerPrefsX.GetStringArray("PilihanB"); 
        tempC = PlayerPrefsX.GetStringArray("PilihanC");
		tempD = PlayerPrefsX.GetStringArray("PilihanD"); 
        
        int noSoal = PlayerPrefs.GetInt("nomorquiz");
        _soalnya.text = tempSoal[noSoal];
        _pilA.text = tempA[noSoal];
        _pilB.text = tempB[noSoal];
        _pilC.text = tempC[noSoal];
        _pilD.text = tempD[noSoal];
    }
}
