using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scorenwaktu : MonoBehaviour {
	public float WaktuSoal1;
	public float WaktuSoal2;
	public int Score;
	public bool Selesai;

	public static Scorenwaktu control;
	// Use this for initialization
	void Awake()
	{
		if(control == null )
		{
			DontDestroyOnLoad (gameObject);
			control = this;
		}
		else if(control != this)
		{
			Destroy (gameObject);
		}
	}

	void Start () {
		Selesai = false;
	}
	
	// Update is called once per frame
	void Update () {
		StartCoroutine (WaktuKurang());
	}

	IEnumerator WaktuKurang()
	{
		if ( Selesai == false) {
			WaktuSoal1 -= Time.deltaTime;
			yield return 0;
		} 

	}

	IEnumerator WaktuTambah()
	{
		if (WaktuSoal2 >= 0) {
			WaktuSoal2 += Time.deltaTime;
			yield return 0;
		} 
	}
}
