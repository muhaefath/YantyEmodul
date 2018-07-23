using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WaktuSoal : MonoBehaviour {
	public float Menit;
	public float Detik;
	public Text MenitText;
	public Text DetikText;
	// Use this for initialization
	void Start () {
		Menit = 0;
		Detik = 0;
	}
	
	// Update is called once per frame
	void Update () {
		MenitText.text = Menit + " :";
		DetikText.text = "" + Mathf.Round (Detik);
		StartCoroutine (HitungNaik());
	}

	IEnumerator HitungNaik()
	{
		if (Detik >= 0 && Detik <= 60) {
			Detik += Time.deltaTime;
			yield return 0;
		}
			
		else {
			Menit++;
			if(Menit >= 60)
			{
				Menit = 0;
			}
			Detik = 0;
		}

	}
}
