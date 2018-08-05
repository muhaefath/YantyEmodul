using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ManagerSimpanData : MonoBehaviour {
	public InputField[] Jawab;
	public string[] NamaData;

	// Use this for initialization
	void Start () {
		
	
		for (int i = 0; i < NamaData.Length; i++) {
			NamaData [i] = "jawab " + i;
			//PlayerPrefs.SetString (NamaData[i],"Tidak Ada Jawaban");
			//Debug.Log (PlayerPrefs.GetString (NamaData[i]));
		}
		for (int i = 0; i < Jawab.Length; i++) {
			if (PlayerPrefs.GetString (NamaData [i]) == "") {
				PlayerPrefs.SetString (NamaData [i], "Empty");
			} else {
				Jawab [i].text = "" + PlayerPrefs.GetString (NamaData[i]);
			}
		}

	}
	

	public void SimpanData(int index)
	{
		PlayerPrefs.SetString (NamaData[index],Jawab[index].text);
	}
}
