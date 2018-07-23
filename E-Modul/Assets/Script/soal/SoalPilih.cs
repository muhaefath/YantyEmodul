using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SoalPilih : MonoBehaviour {

	[System.Serializable]
	public class Daftar
	{
		public Button[] Alpah;

	}





	[System.Serializable]
	public class koleksi
	{
		public int SoalBenar1;
		public int SoalBenar2;
	}

	public koleksi[] koleksis;
	public Daftar[] daftars;
	public int jumlahsoalyangbenar3;
	public int CurrGlobal;

	WaktuSoal manager;

	public GameObject SoalKerjain;
	public GameObject SoalSelesai;
	public GameObject Waktunya;

	public Text menit2;
	public Text detik2;
	public Text Soalbenarnya;



	// Use this for initialization
	void Start () {
		manager = FindObjectOfType<WaktuSoal> ();
		SoalKerjain.SetActive (true);
		SoalSelesai.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}





	public void TandainSoal(int curr)
	{
		CurrGlobal = curr;
	}

	public void PilihJawaban(int curr)
	{
		for (int i = 0; i < daftars[CurrGlobal].Alpah.Length; i++) {
			daftars[CurrGlobal].Alpah [i].interactable = true;

		}
		daftars[CurrGlobal].Alpah [curr].interactable = false;
	
	}




	public void JawabYangBenar(int curr)
	{	

		koleksis [curr].SoalBenar1 = 1; 
	}

	public void JawabYangBenar2(int curr)
	{	
		
		koleksis [curr].SoalBenar2 = 1; 
	}

	public void JawabYangSalah(int curr)
	{
		koleksis [curr].SoalBenar1 = 0; 
	}

	public void JawabYangSalah2(int curr)
	{
		koleksis [curr].SoalBenar2 = 0; 
	}

	public void HitungJawabanBenar()
	{
		for (int i = 0; i < koleksis.Length; i++) {
			if(koleksis[i].SoalBenar1 == 1 )
			{
				jumlahsoalyangbenar3 += 1;
			}
		}
		SoalKerjain.SetActive (false);
		SoalSelesai.SetActive (true);

		menit2.text = manager.Menit + " :";
		detik2.text = "" + Mathf.Round (manager.Detik);
		Soalbenarnya.text = "" + jumlahsoalyangbenar3;

		Destroy (Waktunya.gameObject);

	}

	public void PindahScene2(string nama)
	{
		PlayerPrefs.SetInt ("BalikSoal", 1);
		SceneManager.LoadScene (nama);
	}
}
