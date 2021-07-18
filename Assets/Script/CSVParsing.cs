using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;
using static PlayerPrefsX;


public class CSVParsing : MonoBehaviour 
{
	public TextAsset _rambu; // Reference of CSV file
	public TextAsset _quiz; // Reference of CSV file
	//public InputField rollNoInputField;// Reference of rollno input field
	//public InputField nameInputField; // Reference of name input filed
	//public Text contentArea; // Reference of contentArea where records are displayed

	private char lineSeperater = '\n'; // It defines line seperate character
	private char fieldSeperator = ','; // It defines field seperate chracter

	void Start () 
	{
		readRambu();
		readSoal();
	}
	private void readSoal()
	{
		string[] records = _quiz.text.Split(lineSeperater);
		int ndata = records.Length;
		int i = 0;
		
		string[] soal = new string[ndata];
		string[] pilA = new string[ndata];
		string[] pilB = new string[ndata];
		string[] pilC = new string[ndata];
		string[] pilD = new string[ndata];

		foreach (string record in records){
			string[] fields = record.Split(fieldSeperator);
			soal[i] = fields[0];
			pilA[i] = fields[1];
			pilB[i] = fields[2];
			pilC[i] = fields[3];
			pilD[i] = fields[4];
			i++;
		}

		PlayerPrefsX.SetStringArray("SoalPilgan", soal); 
        PlayerPrefsX.SetStringArray("PilihanA", pilA);
		PlayerPrefsX.SetStringArray("PilihanB", pilB); 
        PlayerPrefsX.SetStringArray("PilihanC", pilC);
		PlayerPrefsX.SetStringArray("PilihanD", pilD); 
	}

	private void readRambu()
	{
		string[] records = _rambu.text.Split (lineSeperater);
		int ndata = records.Length;
		int i = 0;
		
		string[] namaRambu = new string[ndata];
		string[] descRambu = new string[ndata];

		foreach (string record in records){
			string[] fields = record.Split(fieldSeperator);
			namaRambu[i] = fields[0];
			descRambu[i] = fields[1];
			i++;
		}

		PlayerPrefsX.SetStringArray("NamaRambu", namaRambu); 
        PlayerPrefsX.SetStringArray("DeskRambu", descRambu);
		/*
		foreach (string record in records)
		{
			string[] fields = record.Split(fieldSeperator);
			foreach(string field in fields)
			{
				contentArea.text += field + "\t";
			}
			contentArea.text += '\n';
		}*/
	}

	//incase needed, break the comment!

	// Add data to CSV file
	/*
	public void addData()
	{
		// Following line adds data to CSV file
		File.AppendAllText(getPath() + "/Assets/StudentData.csv",lineSeperater + rollNoInputField.text + fieldSeperator +nameInputField.text);
		// Following lines refresh the edotor and print data
		rollNoInputField.text = "";
		nameInputField.text = "";
		contentArea.text = "";
		#if UNITY_EDITOR
			UnityEditor.AssetDatabase.Refresh ();
		#endif
		readData();
	}

	// Get path for given CSV file
	private static string getPath(){
		#if UNITY_EDITOR
		return Application.dataPath;
		#elif UNITY_ANDROID
		return Application.persistentDataPath;// +fileName;
		#elif UNITY_IPHONE
		return GetiPhoneDocumentsPath();// +"/"+fileName;
		#else
		return Application.dataPath;// +"/"+ fileName;
		#endif
	}
	// Get the path in iOS device
	private static string GetiPhoneDocumentsPath()
	{
		string path = Application.dataPath.Substring(0, Application.dataPath.Length - 5);
		path = path.Substring(0, path.LastIndexOf('/'));
		return path + "/Documents";
	}*/

}