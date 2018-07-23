using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SoalSoal : MonoBehaviour {
	public Text[] Soalnya;

	[SerializeField] private int IndexSoal;
	// Use this for initialization
	void Start () {
		IndexSoal =	Random.Range (0,4);
		MunculSoal (IndexSoal);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void MunculSoal(int Indexsal)
	{
		for (int i = 0; i <Soalnya.Length ; i++) {
			Soalnya [i].enabled = false;
		}
		Soalnya [Indexsal].enabled = true;

	}
}
