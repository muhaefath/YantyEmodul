using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class dragitem : MonoBehaviour {
	// benda 1
	public bool masihditarik;
	public bool masihditarik2;

	public Image BendaDigerakin;
	public Image patokan;

	public Image airkeran;
	public Image airalas;

	public float CurrAir;
	public float CurrAir2;

	public Vector2 Currairkeran;

	public float NambahAirAlas;
	public bool udahpenuh;
	public bool udahabis;

	//benda 2
	public Image BendaDigerakin2;
	public Image patokan2;

	public Image airkeran2;

	// penggaris
	public Image penggaris;

	// text
	public Text[] Tulisan;

	//  buat gravity
	public Image[] Seretan;
	public GameObject patokan3;
	public GameObject patokan4;

	// patokan untuk drag 
	public int PatokanSatuan;



	aturtombolonof manager;

	public GameObject JarumMerah;
	public GameObject pivotmerah;


	// Use this for initialization
	void Start () {
		airkeran.enabled = false;
		airalas.enabled = false;
		airkeran2.enabled = false;
		udahpenuh = false;
		udahabis  = true;
		Currairkeran = new Vector2 (airkeran.rectTransform.rect.width,airkeran.rectTransform.rect.height);
		PatokanSatuan = 1;

		manager = FindObjectOfType<aturtombolonof> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void DiDrag(float curr1)
	{
		//Debug.Log (BendaDigerakin.transform.position.x);
		if (Input.mousePosition.x > patokan.transform.position.x + 20 && udahpenuh == false) {
			if (Input.mousePosition.x - patokan.transform.position.x < curr1) {
				
				airkeran.enabled = true;
				airalas.enabled = true;


				BendaDigerakin.transform.position = new Vector2 (Input.mousePosition.x, BendaDigerakin.transform.position.y);

				CurrAir += BendaDigerakin.transform.position.x  / 292;

				Didrag2 (1);
				//Didrag3 (1);

				masihditarik = true;


			}
			CurrAir = 0;

		} 


	}

	public void Didragb(float curr2)
	{
		if (Input.mousePosition.x > patokan2.transform.position.x + 20 && udahabis ==false) {
			if (Input.mousePosition.x - patokan2.transform.position.x < curr2) {

				airkeran2.enabled = true;
				//airalas.enabled = true;


				BendaDigerakin2.transform.position = new Vector2 (Input.mousePosition.x, BendaDigerakin2.transform.position.y);

				CurrAir2 += BendaDigerakin2.transform.position.x / 892;

				Didrag2 (2);
				//Didrag3 (2);

				masihditarik2 = true;





			}
			CurrAir2 = 0;
		} 

	}

	public void DragGrav(float curr3)
	{
		if (Input.mousePosition.x > patokan3.transform.position.x +0.5f ) {
			if (Input.mousePosition.x - patokan.transform.position.x < curr3) {




				Seretan[0].transform.position = new Vector2 (Input.mousePosition.x, Seretan[0].transform.position.y);

				if(PatokanSatuan == 1)
				{
					manager.TulisanSatuan [0] = 800 +(Mathf.Round((Seretan [0].rectTransform.anchoredPosition.x - (-105f)  )* manager.CurrTambahin)) *10  ;
				}
				else if(PatokanSatuan == 2)
				{
					manager.TulisanSatuan [0] = 43.7f +(Mathf.Round((Seretan [0].rectTransform.anchoredPosition.x - (-105f)/10  )* manager.CurrTambahin)) *10  ;
				}



				//Debug.Log (  (Mathf.Round((Seretan [0].rectTransform.anchoredPosition.x - (-105f)  )* manager.CurrTambahin)) *10 );
				//Debug.Log(Seretan[0].transform.position.x);
				if(Seretan[0].transform.position.x >=705 && Seretan[0].transform.position.x <= 721)
				{
					airalas.color = new Color (0.647f,0.647f,0.647f);

				}
				else if(Seretan[0].transform.position.x > 721 && Seretan[0].transform.position.x <= 741)
				{
					airalas.color = new Color (0.429f,0.568f,0.596f);
				}
				else if(Seretan[0].transform.position.x > 741 && Seretan[0].transform.position.x <= 761)
				{
					airalas.color = new Color (0.289f,0.655f,0.728f);
				}
				else if(Seretan[0].transform.position.x > 761 && Seretan[0].transform.position.x <= 791)
				{
					airalas.color = new Color (0.123f,0.757f,0.882f);
				}
				else if(Seretan[0].transform.position.x > 791 && Seretan[0].transform.position.x <= 821)
				{
					airalas.color = new Color (0.000f,0.834f,1000f);
				}


				else if(Seretan[0].transform.position.x > 821 && Seretan[0].transform.position.x <= 851)
				{
					airalas.color = new Color (0.000f,0.710f,1000f);
				}
				else if(Seretan[0].transform.position.x > 851 && Seretan[0].transform.position.x <= 881)
				{
					airalas.color = new Color (0.098f,1000f,0.000f);
				}
				else if(Seretan[0].transform.position.x > 881 && Seretan[0].transform.position.x <= 917)
				{
					airalas.color = new Color (0.073f,0.743f,0.000f);
				}
				else if(Seretan[0].transform.position.x > 917 && Seretan[0].transform.position.x <= 947)
				{
					airalas.color = new Color (0.716f,0.757f,0000f);
				}
				else if(Seretan[0].transform.position.x > 947 && Seretan[0].transform.position.x <= 987)
				{
					airalas.color = new Color (0.945f,1000f,0000f);
					//airalas.color = Color.yellow;
				}

				//for (int i = 0; i < manager.AngkaPressure2.Length; i++) {
				//	manager.AngkaPressure2 [i] = manager.TulisanSatuan[0] * manager.TulisanSatuan[1];
				//}

			}


		} 
	}

	public void DragGrav2(float curr4)
	{
		if (Input.mousePosition.x > patokan4.transform.position.x  ) {
			if (Input.mousePosition.x - patokan4.transform.position.x < curr4) {




				Seretan[1].transform.position = new Vector2 (Input.mousePosition.x, Seretan[1].transform.position.y);


				manager.TulisanSatuan [1] = 3.7f + Mathf.Round(  (((Seretan [1].rectTransform.anchoredPosition.x - (-105f))/100) *100f) + manager.CurrTambahin2)/10  ;

				//JarumMerah.transform.position = new Vector2((-30 + manager.TulisanSatuan [1])/100, (-819 + manager.TulisanSatuan [1])/100);

				//JarumMerah.transform.rotation = Quaternion.Euler(JarumMerah.transform.rotation.x,JarumMerah.transform.rotation.y,31 + manager.TulisanSatuan [1]);

				Vector3 dir = pivotmerah.transform.forward;

				JarumMerah.transform.RotateAround (pivotmerah.transform.position,dir,manager.TulisanSatuan[1] *Time.deltaTime);

				//Debug.Log (Seretan[1].transform.position.x);


				//////////////////////////////////////////
				/*
				for (int i = 0; i < manager.AngkaPressure2.Length; i++) {
					manager.AngkaPressure2 [i] = (38.350f * manager.TulisanSatuan[1] / 3.7f);
				}
				*/
				//////////////////////////////////////////

				manager.angkapressure4[0] = (38.350f * manager.TulisanSatuan[1] / 3.7f);
				//manager.angkapressure4[0] = Input.touches[0];
				manager.angkapressure4[1] = (0.3785f * manager.TulisanSatuan[1] / 3.7f);
			//	manager.angkapressure4[1] = Input.mousePosition.y;

				manager.angkapressure4[2] = (5.5623f * manager.TulisanSatuan[1] / 3.7f);




				if(manager.TulisanSatuan[1] < 3.7f)
				{
					manager.TulisanSatuan [1] = 3.7f;
				}
			}


		} 
	}

	public void DropGrav2()
	{
		manager.TulisanSatuan [1] = Seretan [1].rectTransform.rect.x - (-105f) * manager.CurrTambahin2;
	}
		

   public void Didrag2(int pilih)
	{
		

		// air yang keluar dari keran
		if(pilih ==1)
		{
			if(CurrAir <= 1.75f )
			{
				airkeran.rectTransform.sizeDelta = new Vector2 (200 , airkeran.rectTransform.rect.height);
				NambahAirAlas = 0.5f;

			}
			else if(CurrAir > 1.75 && CurrAir <= 1.85f )
			{
				airkeran.rectTransform.sizeDelta = new Vector2 (400 , airkeran.rectTransform.rect.height);
				NambahAirAlas = 1f;

			}
			else if(CurrAir > 1.85f && CurrAir <= 1.95f)
			{
				airkeran.rectTransform.sizeDelta = new Vector2 (600 , airkeran.rectTransform.rect.height);
				NambahAirAlas = 1.5f;

			}
			else if(CurrAir > 1.95)
			{
				airkeran.rectTransform.sizeDelta = new Vector2 (800 , airkeran.rectTransform.rect.height);
				NambahAirAlas = 2f;

			}
		}
		 if(pilih == 2)
		{
			
			if (CurrAir2 <= 0.95f) {
				airkeran2.rectTransform.sizeDelta = new Vector2 (100, airkeran2.rectTransform.rect.height);
				NambahAirAlas = 0.5f;

			} else if (CurrAir2 > 0.95f && CurrAir2 <= 0.97f) {
				airkeran2.rectTransform.sizeDelta = new Vector2 (200, airkeran2.rectTransform.rect.height);
				NambahAirAlas = 1f;

			} else if (CurrAir2 > 0.97f && CurrAir2 <= 0.985f) {
				airkeran2.rectTransform.sizeDelta = new Vector2 (300, airkeran2.rectTransform.rect.height);
				NambahAirAlas = 1.5f;
				
			} else if (CurrAir2 > 0.985f) {
				airkeran2.rectTransform.sizeDelta = new Vector2 (400, airkeran2.rectTransform.rect.height);
				NambahAirAlas = 2f;

			}

		}

	}

	public void Didrag3(int pilih)
	{
		if(pilih ==1)
		{
			if (airalas.rectTransform.rect.height <= 375.21f) {
				airalas.rectTransform.sizeDelta = new Vector2 (airalas.rectTransform.rect.width, airalas.rectTransform.rect.height + NambahAirAlas);
				airalas.rectTransform.anchoredPosition = new Vector2 (airalas.rectTransform.anchoredPosition.x, airalas.rectTransform.anchoredPosition.y + NambahAirAlas / 38.5f);
				udahabis = false;
			} else {
				udahpenuh = true;
				airkeran.enabled = false;
			}
		}
		else if(pilih ==2)
		{
			if (airalas.rectTransform.rect.height >= 0) {
				airalas.rectTransform.sizeDelta = new Vector2 (airalas.rectTransform.rect.width, airalas.rectTransform.rect.height - NambahAirAlas);
				airalas.rectTransform.anchoredPosition = new Vector2 (airalas.rectTransform.anchoredPosition.x, airalas.rectTransform.anchoredPosition.y - NambahAirAlas / 38.5f);
				udahpenuh = false;
			} else {
				udahabis = true;
				airkeran2.enabled = false;
			}
		}
	}



	public void DiDrop(int pilih)
	{
		if(pilih == 1)
		{
			airkeran.enabled = false;
			BendaDigerakin.rectTransform.anchoredPosition = new Vector3 (-1.83f,28.86f,0);
			airkeran.rectTransform.sizeDelta = new Vector2 (0f,99.73f); 
			CurrAir = 0;
			masihditarik = false;
		}
		else if(pilih == 2)
		{
			airkeran2.enabled = false;
			BendaDigerakin2.rectTransform.anchoredPosition = new Vector3 (302.2f,-51.3f,0);
			//airkeran.rectTransform.sizeDelta = new Vector2 (0f,99.73f); 
			CurrAir = 0;
			masihditarik2 = false;
		}
	}

	public void DragPenggaris()
	{
		if(Input.mousePosition.x > 100 && Input.mousePosition.x < 1000 && Input.mousePosition.y > 400 && Input.mousePosition.y < 1500)
		{	
			penggaris.transform.position = Input.mousePosition;
			//Debug.Log ( Input.mousePosition.y);
		}
	}


	public void PindahScene3(string nama)
	{
		PlayerPrefs.SetInt ("BalikSoal",3);
		SceneManager.LoadScene (nama);
	}
}
