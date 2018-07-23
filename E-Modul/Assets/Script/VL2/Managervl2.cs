using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Managervl2 : MonoBehaviour {
	public GameObject penggaris; public bool nyala;

	public bool udahdipencet1;public bool udahdipencet2;

	public GameObject Dotsnya;public bool DOtNyala;
	public Transform[] LokasiDotnya; public float waktudots;
	public GameObject canvas2;
	public Image DotsTombol;

	public  bool FluxMeterNyala;
	public GameObject FluxMeternya;

	public Image[] TombolBiruNyala;

	public Text[] FlowRate;public float flowratearea;
	public GameObject[] SatuanFlowrate;

	public Text[] FluiDensity;

	public Image AirJalan;

	void Start()
	{
		penggaris.SetActive (false);
		FluxMeternya.SetActive (false);
		flowratearea = 3.1f;
		FlowRate [3].text = "m"; 

		FluiDensity [1].text = "kg/m";

		SatuanFlowrate [0].SetActive (true);
		SatuanFlowrate [1].SetActive (false);
		SatuanFlowrate [2].SetActive (true);
		SatuanFlowrate [3].SetActive (false);

		for (int i = 0; i < TombolBiruNyala.Length; i++) {
			TombolBiruNyala [i].color = new Color (	TombolBiruNyala [i].color.r,	TombolBiruNyala [i].color.g,	TombolBiruNyala [i].color.b,0);
		}
		TombolBiruNyala [1].color = new Color (	TombolBiruNyala [1].color.r,	TombolBiruNyala [1].color.g,	TombolBiruNyala [1].color.b,255);
	}

	void Update()
	{
		StartCoroutine (DotsJeda());

	


		FlowRate [0].text = "" + DragVL2.instance.KecepatandotFloat;
		FlowRate [1].text = "" + flowratearea;
		FlowRate [2].text = "" + Mathf.RoundToInt( DragVL2.instance.KecepatandotFloat * flowratearea); 
	}

	public void RulerNyala()
	{
		
		if (!nyala) {
			nyala = true;
			penggaris.SetActive (true);
			TombolBiruNyala [0].color = new Color (	TombolBiruNyala [0].color.r,	TombolBiruNyala [0].color.g,	TombolBiruNyala [0].color.b,255);

		} else {
			nyala = false;
			penggaris.SetActive (false);
			TombolBiruNyala [0].color = new Color (	TombolBiruNyala [0].color.r,	TombolBiruNyala [0].color.g,	TombolBiruNyala [0].color.b,0);

		}
	}

	public void AturUnit(bool metric)
	{
		if (metric && !udahdipencet1) {
			udahdipencet1 = true;
			udahdipencet2 = false;
			DragVL2.instance.pilih = 1;
			DragVL2B.instance.pilih = 3;
			flowratearea = 3.1f;
			FlowRate [3].text = "m";
			TombolBiruNyala [1].color = new Color (TombolBiruNyala [1].color.r,	TombolBiruNyala [1].color.g,	TombolBiruNyala [1].color.b, 255);
			TombolBiruNyala [2].color = new Color (TombolBiruNyala [1].color.r,	TombolBiruNyala [1].color.g,	TombolBiruNyala [1].color.b, 0);

			DragVL2.instance.KecepatandotFloat =  Mathf.RoundToInt( DragVL2.instance.KecepatandotFloat * 1000 /35); 
			DragVL2.instance.SpeedAngka = Mathf.Round( DragVL2.instance.SpeedAngka * 0.3f /1f *10) /10 ;
			DragVL2B.instance.KecepatandotFloat =  Mathf.RoundToInt( DragVL2B.instance.KecepatandotFloat * 700 /44);

			SatuanFlowrate [0].SetActive (true);
			SatuanFlowrate [1].SetActive (false);
			SatuanFlowrate [2].SetActive (true);
			SatuanFlowrate [3].SetActive (false);
			FluiDensity [1].text = "kg/m";


		} else if(!metric && !udahdipencet2){
			udahdipencet2 = true;
			udahdipencet1 = false;
			DragVL2.instance.pilih = 2; 
			DragVL2B.instance.pilih = 4;
			flowratearea = 33.8f;
			FlowRate [3].text = "ft";
			TombolBiruNyala [1].color = new Color (TombolBiruNyala [1].color.r,	TombolBiruNyala [1].color.g,	TombolBiruNyala [1].color.b, 0);
			TombolBiruNyala [2].color = new Color (TombolBiruNyala [1].color.r,	TombolBiruNyala [1].color.g,	TombolBiruNyala [1].color.b, 255);

			DragVL2.instance.KecepatandotFloat = Mathf.RoundToInt (DragVL2.instance.KecepatandotFloat * 35 /1000); 
			DragVL2.instance.SpeedAngka = Mathf.Round( DragVL2.instance.SpeedAngka * 1f /0.3f *10)/10;
			DragVL2B.instance.KecepatandotFloat =  Mathf.RoundToInt( DragVL2B.instance.KecepatandotFloat * 44 /700);

			SatuanFlowrate [0].SetActive (false);
			SatuanFlowrate [1].SetActive (true);
			SatuanFlowrate [2].SetActive (false);
			SatuanFlowrate [3].SetActive (true);
			FluiDensity [1].text = "lb/ft";


		}
	}

	public void FluxMeter()
	{
		if (!FluxMeterNyala) {
			FluxMeternya.SetActive (true);
			TombolBiruNyala [4].color = new Color (TombolBiruNyala [1].color.r,	TombolBiruNyala [1].color.g,	TombolBiruNyala [1].color.b, 255);
			FluxMeterNyala = true;
		} else {
			FluxMeternya.SetActive (false);
			TombolBiruNyala [4].color = new Color (TombolBiruNyala [1].color.r,	TombolBiruNyala [1].color.g,	TombolBiruNyala [1].color.b, 0);
			FluxMeterNyala = false;
		}
	}

	public void Dots()
	{
		if (DOtNyala) {

			DotsTombol.color = new Color (TombolBiruNyala [0].color.r,	TombolBiruNyala [0].color.g,	TombolBiruNyala [0].color.b, 0);
			DOtNyala = false;
		} else {

			DotsTombol.color = new Color (TombolBiruNyala [0].color.r,	TombolBiruNyala [0].color.g,	TombolBiruNyala [0].color.b, 255);
			DOtNyala = true;
		}

	}

	public void SizeAir(int pilih)
	{
		if(pilih == 1)
		{
			AirJalan.rectTransform.sizeDelta = new Vector2 (AirJalan.rectTransform.rect.width, 230);
			flowratearea = 3.1f;
		}
		else if(pilih == 2)
		{
			AirJalan.rectTransform.sizeDelta = new Vector2 (AirJalan.rectTransform.rect.width, 250);
			flowratearea = 3.3f;
		}
		else if(pilih == 3)
		{
			AirJalan.rectTransform.sizeDelta = new Vector2 (AirJalan.rectTransform.rect.width, 270);
			flowratearea = 3.5f;
		}
	}

	 IEnumerator DotsJeda()
	{
		if (DOtNyala) {
			if (waktudots >= 0) {
				waktudots -= Time.deltaTime;
				yield return 0;
			} else {
				
				for (int i = 0; i < Random.Range (0, 6); i++) {
					Instantiate (Dotsnya, LokasiDotnya [Random.Range (0, 4)], false);
				}
				
				waktudots = 0.5f;
			}
	
		}
	}

	public void ResetAll()
	{
		udahdipencet1 = true;
		udahdipencet2 = false;
		DragVL2.instance.pilih = 1;
		DragVL2B.instance.pilih = 3;
		flowratearea = 3.1f;
		FlowRate [3].text = "m";
		TombolBiruNyala [1].color = new Color (TombolBiruNyala [1].color.r,	TombolBiruNyala [1].color.g,	TombolBiruNyala [1].color.b, 255);
		TombolBiruNyala [2].color = new Color (TombolBiruNyala [1].color.r,	TombolBiruNyala [1].color.g,	TombolBiruNyala [1].color.b, 0);

		DragVL2.instance.KecepatandotFloat = 1000; 
		DragVL2.instance.SpeedAngka = 0.3f ;
		DragVL2B.instance.KecepatandotFloat =  700;

		SatuanFlowrate [0].SetActive (true);
		SatuanFlowrate [1].SetActive (false);
		SatuanFlowrate [2].SetActive (true);
		SatuanFlowrate [3].SetActive (false);
		FluiDensity [1].text = "kg/m";
	}
}
