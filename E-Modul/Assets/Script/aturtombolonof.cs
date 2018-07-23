using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class aturtombolonof : MonoBehaviour {


	public GameObject[] TombolOn;
	public bool[] UdahOn;

	public GameObject[] benda;

	public GameObject[] langit;

	public GameObject[] UNits;

	public int CekGrids;
	public bool  cekgrid2; // ini untuk ngecek apakah gridnya udah dinyalain

	// text

	public Text[] Tulisan;
	public float[] TulisanSatuan;
	public Image[] ParamFluidGravity;
	public float CurrTambahin;
	public float CurrTambahin2;

	public float min1, max1, min2, max2;

	public int Darimana; // untuk pindah unit dia sebelumnya darimana

	public Text[] SatuanPressure;


		//public Text[] AngkaPressure;
		//public float[] AngkaPressure2;
	public Text[] angkapressure3;
	public float[] angkapressure4;


	public Text TekananMutlak;
	public float TekananMutLAKaNGKA;

	//public datapressure[] datapresuress;
	dragitem manager2;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < TombolOn.Length; i++) {
			TombolOn [i].SetActive (false);
			UdahOn [i] = false;
		}
		TombolOn [2].SetActive (true);
		UdahOn [2] = true;


		for (int i = 0; i < benda.Length; i++) {
			benda [i].SetActive (false);
		}

		for (int i = 0; i < UNits.Length; i++) {
			UNits [i].SetActive (false);
		}
		UNits [0].SetActive (true);

		for (int i = 0; i < Tulisan.Length; i++) {
			Tulisan [i].enabled = true;
		}
		Tulisan [3].text = "kg/m";
		Tulisan [5].text = "m/s";

		for (int i = 0; i < SatuanPressure.Length; i++) {
			SatuanPressure[i].text = "kPa";
		}

		/* data
		for (int i = 0; i < AngkaPressure2.Length; i++) {
			AngkaPressure2 [i] = 38.356f;
		}
		*/ // di bawah ini adalah data pressure
		for (int i = 0; i < angkapressure3.Length; i++) {
			angkapressure3 [i].enabled = false;
		}

		angkapressure3 [0].enabled = true;

		angkapressure4 [0] = 38.350f;
		angkapressure4 [1] = 0.3785f;
		angkapressure4 [2] = 5.5623f;


		CurrTambahin = 4712.5f / 800f;
		CurrTambahin2 = -100f / 212f;

		min1 = 3.7f;
		min2 = 800f;
		max1 = 24.9f;
		max2 = 13600f;

		cekgrid2 = true;

		manager2 = FindObjectOfType<dragitem> ();
		Darimana = 1;
	}
	
	// Update is called once per frame
	void Update () {
		Tulisan [0].text = "" + Mathf.Round( TulisanSatuan[0] * 10)/10 ;
		Tulisan [1].text = "" + Mathf.Round( TulisanSatuan[1] * 10)/10;

		TekananMutLAKaNGKA = 1 + (TulisanSatuan[0] * TulisanSatuan [1]);
		TekananMutlak.text = "" + TekananMutLAKaNGKA;

		/* data
		for (int i = 0; i < AngkaPressure.Length; i++) {
			AngkaPressure [i].text = "" + AngkaPressure2 [i];
		}
		*/

		for (int i = 0; i < angkapressure3.Length; i++) {
			angkapressure3 [i].text = "" + angkapressure4 [i];
		}
	}

	public void PencetTombolOff(int Index)
	{
		
		if (UdahOn[Index] == false) {
			TombolOn [Index].SetActive (true);
			UdahOn[Index] = true;
		}
		else if (UdahOn[Index] == true) {
			TombolOn [Index].SetActive (false);
			UdahOn[Index] = false;

		}
	}



	public void ATMOSFIR(bool  atmos)
	{
		
		if (atmos) {
			TombolOn [3].SetActive (false);
			UdahOn [3] = false;
			langit [0].SetActive (true);
			langit [1].SetActive (false);

		} else {
			TombolOn [2].SetActive (false);
			UdahOn [2] = false;
			langit [0].SetActive (false);
			langit [1].SetActive (true);
		}
		
	}

	public void Ruler(bool cekgrid)
	{
		if (cekgrid) {
			benda [2].SetActive (true);
			cekgrid = false;
		} else {
			benda [2].SetActive (false);
			cekgrid = true;
		}
	}

	public void Grid( bool cekgrid)
	{
		//benda [1].SetActive (true);

		if (CekGrids == 0) {
			
			if (cekgrid2 && cekgrid) {
				benda [0].SetActive (true);
				benda [1].SetActive (false);
				cekgrid2 = false;
				cekgrid = false;
			} else {
				benda [0].SetActive (false);
				cekgrid2 = true;
			}

		} else if (CekGrids == 1) {
			//benda [0].SetActive (false);

			if (cekgrid2) {
				benda [1].SetActive (true);
				benda [0].SetActive (false);
				cekgrid2 = false;
			} else {
				benda [1].SetActive (false);
				cekgrid2 = true;
			}
		
		}
	}

	public void Units(int CurrUnits )
	{
		if(CurrUnits == 1)
		{
			for (int i = 0; i < UNits.Length; i++) {
				UNits [i].SetActive (false);
			}

			for (int i = 0; i < SatuanPressure.Length; i++) {
				SatuanPressure[i].text = "kPa";
			}



			UNits [0].SetActive (true);
			CekGrids = 0;
			if(cekgrid2 == false)
			{
				cekgrid2 = true;
				Grid(true) ;
				cekgrid2 = false;
			}
			Tulisan [3].text = "kg/m";
			Tulisan [5].text = "m/s";



			if(Darimana == 3 )
			{
				TulisanSatuan [0] = Mathf.Round((TulisanSatuan[0]*800)/49.9f);
				TulisanSatuan [1]  = Mathf.Round(((TulisanSatuan[1]*24.9f)/81.775f)*10)/10;
				for (int i = 0; i < angkapressure4.Length; i++) {
					angkapressure4 [i] = Mathf.Round ( TulisanSatuan[1]* 38.350f /3.7f *10 )/10 ;
				}
			}

			else if(Darimana == 2)
			{
				for (int i = 0; i < angkapressure4.Length; i++) {
					angkapressure4 [i] = Mathf.Round ( TulisanSatuan[1]* 38.350f /3.7f *10 )/10 ;
				}
			}


			TekananMutLAKaNGKA = 1 + TulisanSatuan [0] * TulisanSatuan [1] * 1;
			for (int i = 0; i < angkapressure3.Length; i++) {
				angkapressure3 [i].enabled = false;
			}

			angkapressure3 [0].enabled = true;

			manager2.PatokanSatuan = 1;

			Darimana = CurrUnits;

			min1 = 3.7f;
			min2 = 800f;
			max1 = 24.9f;
			max2 = 1420f;
		}
		else if(CurrUnits == 2)
		{
			for (int i = 0; i < UNits.Length; i++) {
				UNits [i].SetActive (false);
			}
			for (int i = 0; i < SatuanPressure.Length; i++) {
				SatuanPressure[i].text = "atm";
			}


			UNits [1].SetActive (true);
			CekGrids = 0;
			if(cekgrid2 == false)
			{
				cekgrid2 = true;
				Grid(true) ;
				cekgrid2 = false;
			}
			Tulisan [3].text = "kg/m";
			Tulisan [5].text = "m/s";





			 if(Darimana == 3 )
			{
				TulisanSatuan [0] = Mathf.Round((TulisanSatuan[0]*800)/49.9f);
				TulisanSatuan [1] = TulisanSatuan [1] = Mathf.Round(((TulisanSatuan[1]*24.9f)/81.775f)*10)/10;

				for (int i = 0; i < angkapressure4.Length; i++) {
					angkapressure4 [i] = Mathf.Round ( TulisanSatuan[1]* 0.3785f /3.7f *100 )/100 ;
				}
			}
			else if(Darimana == 1)
			{
				for (int i = 0; i < angkapressure4.Length; i++) {
					angkapressure4 [i] = Mathf.Round ( TulisanSatuan[1]* 0.3785f /3.7f *100 )/100 ;
				}
			}

			TekananMutLAKaNGKA = 1 + TulisanSatuan [0] * TulisanSatuan [1] * 1;
				for (int i = 0; i < angkapressure3.Length; i++) {
					angkapressure3 [i].enabled = false;
				}

				angkapressure3 [1].enabled = true;
			

			manager2.PatokanSatuan = 2;

			Darimana = CurrUnits;


			min1 = 3.7f;
			min2 = 800f;
			max1 = 24.9f;
			max2 = 1420f;
		}
		else if(CurrUnits == 3)
		{
			for (int i = 0; i < UNits.Length; i++) {
				UNits [i].SetActive (false);
			}
			for (int i = 0; i < SatuanPressure.Length; i++) {
				SatuanPressure[i].text = "psi";
			}

			UNits [2].SetActive (true);
			CekGrids = 1;
			if(cekgrid2 == false)
			{
				cekgrid2 = true;
				Grid(true) ;
				cekgrid2 = false;
			}
			Tulisan [3].text = "lb/ft";
			Tulisan [5].text = "ft/s";

			TulisanSatuan [0] = Mathf.Round(((TulisanSatuan[0]*49.9f)/800)*10)/10;
			TulisanSatuan [1] =TulisanSatuan [1] = Mathf.Round(((TulisanSatuan[1]*81.775f)/24.9f)*10)/10;

			TekananMutLAKaNGKA = 1 + TulisanSatuan [0] * TulisanSatuan [1] * 1;

			if(Darimana == 1)
			{
				for (int i = 0; i < angkapressure4.Length; i++) {
					angkapressure4 [i] = Mathf.Round ( TulisanSatuan[1]* 5.5623f /12.2f *100 )/100 ;
				}
			}
			else if(Darimana == 2)
			{
				for (int i = 0; i < angkapressure4.Length; i++) {
					angkapressure4 [i] = Mathf.Round ( TulisanSatuan[1]* 5.5623f /12.2f *100 )/100 ;
				}
			}

			for (int i = 0; i < angkapressure3.Length; i++) {
				angkapressure3 [i].enabled = false;
			}

			angkapressure3 [2].enabled = true;

			manager2.PatokanSatuan = 3;

			Darimana = CurrUnits;


			min1 = 43.7f;
			min2 = 12.2f;
			max1 = 88.6f;
			max2 = 81.7f;
		}
	}

	public void TambahinInt(int curr)
	{
		
		float a = 0.1f;
		if (curr == 1) {
			if (TulisanSatuan [0] < max2) {
				TulisanSatuan [0] += 1;
			
				ParamFluidGravity [0].rectTransform.anchoredPosition = new Vector2 (ParamFluidGravity [0].rectTransform.anchoredPosition.x + CurrTambahin, ParamFluidGravity [0].rectTransform.anchoredPosition.y);
			} 
		} else if (curr == 2) {
			if (TulisanSatuan [0] > min2) {
				TulisanSatuan [0] -= 1;
				ParamFluidGravity [0].rectTransform.anchoredPosition = new Vector2 (ParamFluidGravity [0].rectTransform.anchoredPosition.x - CurrTambahin, ParamFluidGravity [0].rectTransform.anchoredPosition.y);
			}
		} else if (curr == 3) {
			if (TulisanSatuan [1] < max1) {
				TulisanSatuan [1] += Mathf.Round(a*10)/10;

				ParamFluidGravity [1].rectTransform.anchoredPosition = new Vector2 (ParamFluidGravity [1].rectTransform.anchoredPosition.x + CurrTambahin2, ParamFluidGravity [1].rectTransform.anchoredPosition.y);
			}
		} else if (curr == 4) {
			if (TulisanSatuan [1] > min1) {
				TulisanSatuan [1] -=Mathf.Round(a*10)/10;
				ParamFluidGravity [1].rectTransform.anchoredPosition = new Vector2 (ParamFluidGravity [1].rectTransform.anchoredPosition.x - CurrTambahin2, ParamFluidGravity [1].rectTransform.anchoredPosition.y);
			}
		}
	}
}

