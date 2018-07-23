using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DragNEW2 : MonoBehaviour,IPointerDownHandler,IPointerUpHandler, IDragHandler {
	private Image background;
	private Image virjoystrick;


	public Vector3 inputvector3;
	public Vector3 inputvector4;

	[SerializeField] private int pilih;
	public dragitem manager;
	public aturtombolonof manager2;

	// Use this for initialization
	void Start () {
		background = GetComponent<Image> ();
		virjoystrick = transform.GetChild (0).GetComponent<Image> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public virtual void OnDrag(PointerEventData ped)
	{
		Vector2 pos;
		if(RectTransformUtility.ScreenPointToLocalPointInRectangle(background.rectTransform,ped.position,ped.pressEventCamera,out pos))
		{
			pos.x = (pos.x / background.rectTransform.sizeDelta.x);
			pos.y = (pos.y / background.rectTransform.sizeDelta.y);

			if(pilih == 3)
			{
				virjoystrick.rectTransform.anchoredPosition = new Vector3 (inputvector3.x * (background.rectTransform.sizeDelta.x /2) ,virjoystrick.rectTransform.anchoredPosition.y);

				inputvector3 = new Vector3 (pos.x * 2- 1,0, pos.y*2 -1);


			
				if (inputvector3.x < -0.2f) {
					inputvector3.x = -0.15f;
				} 
				else if(inputvector3.x > 24.9f)
				{
					inputvector3.x = 24.9f;
				}

				///////////////////////////////////////////////////////////////////
				if(manager.PatokanSatuan == 1 || manager.PatokanSatuan == 2 )
				{
					manager2.TulisanSatuan [0] = 800 +(Mathf.Round((virjoystrick.rectTransform.anchoredPosition.x +4 )+ inputvector3.x*13.75f))  ;
				}
				else if(manager.PatokanSatuan == 3)
				{
					manager2.TulisanSatuan [0] = 49.9f +(Mathf.Round((manager.Seretan [0].rectTransform.anchoredPosition.x +2 )+ inputvector3.x*4.45f))/10   ;
				}



				///////////////////////////////////////////////////////////////
				if(manager2.TulisanSatuan [0]  >=800 && manager2.TulisanSatuan [0]  <= 900 && manager.PatokanSatuan == 1 ||  manager.PatokanSatuan == 2 && manager2.TulisanSatuan [0]  >=49.9f && manager2.TulisanSatuan [0]  <= 51.9f)
				{
					manager.airalas.color = new Color (0.647f,0.647f,0.647f);
					manager.airkeran.color = new Color (0.647f,0.647f,0.647f);
					manager.airkeran2.color = new Color (0.647f,0.647f,0.647f);

				}
				else if(manager2.TulisanSatuan [0] > 900 && manager2.TulisanSatuan [0] <= 1000 && manager.PatokanSatuan == 1 ||  manager.PatokanSatuan == 2 && manager2.TulisanSatuan [0]  >=51.9f && manager2.TulisanSatuan [0]  <= 55.9f)
				{
					manager.airalas.color = new Color (0.429f,0.568f,0.596f);
					manager.airkeran.color = new Color (0.429f,0.568f,0.596f);
					manager.airkeran2.color = new Color (0.429f,0.568f,0.596f);
				}
				else if(manager2.TulisanSatuan [0] > 1000 && manager2.TulisanSatuan [0] <= 1050 && manager.PatokanSatuan == 1||  manager.PatokanSatuan == 2 && manager2.TulisanSatuan [0]  >=55.9f && manager2.TulisanSatuan [0]  <= 57.9f)
				{
					manager.airalas.color = new Color (0.289f,0.655f,0.728f);
					manager.airkeran.color = new Color (0.289f,0.655f,0.728f);
					manager.airkeran2.color = new Color (0.289f,0.655f,0.728f);
				}
				else if(manager2.TulisanSatuan [0] > 1050 && manager2.TulisanSatuan [0] <= 1100 && manager.PatokanSatuan == 1||  manager.PatokanSatuan == 2 && manager2.TulisanSatuan [0]  >=57.9f && manager2.TulisanSatuan [0]  <= 60.9f)
				{
					manager.airalas.color = new Color (0.123f,0.757f,0.882f);
					manager.airkeran.color = new Color (0.123f,0.757f,0.882f);
					manager.airkeran2.color = new Color (0.123f,0.757f,0.882f);
				}
				else if(manager2.TulisanSatuan [0] > 1100 && manager2.TulisanSatuan [0] <= 1150 && manager.PatokanSatuan == 1||  manager.PatokanSatuan == 2 && manager2.TulisanSatuan [0]  >=60.9f && manager2.TulisanSatuan [0]  <= 65.9f)
				{
					manager.airalas.color = new Color (0.000f,0.834f,1000f);
					manager.airkeran.color = new Color (0.000f,0.834f,1000f);
					manager.airkeran2.color = new Color (0.000f,0.834f,1000f);

				}


				else if(manager2.TulisanSatuan [0] > 1150 && manager2.TulisanSatuan [0] <= 1200 && manager.PatokanSatuan == 1||  manager.PatokanSatuan == 2 && manager2.TulisanSatuan [0]  >=65.9f && manager2.TulisanSatuan [0]  <= 70.9f)
				{
					manager.airalas.color = new Color (0.000f,0.710f,1000f);
					manager.airkeran.color = new Color (0.000f,0.710f,1000f);
					manager.airkeran2.color = new Color (0.000f,0.710f,1000f);
				}
				else if(manager2.TulisanSatuan [0] > 1200 && manager2.TulisanSatuan [0] <= 1250 && manager.PatokanSatuan == 1||  manager.PatokanSatuan == 2 && manager2.TulisanSatuan [0]  >=70.9f && manager2.TulisanSatuan [0]  <= 75.9f)
				{
					manager.airalas.color = new Color (0.098f,1000f,0.000f);
					manager.airkeran.color = new Color (0.098f,1000f,0.000f);
					manager.airkeran2.color = new Color (0.098f,1000f,0.000f);
				}
				else if(manager2.TulisanSatuan [0] > 1250 && manager2.TulisanSatuan [0] <= 1300 && manager.PatokanSatuan == 1||  manager.PatokanSatuan == 2 && manager2.TulisanSatuan [0]  >=75.9f && manager2.TulisanSatuan [0]  <= 80.9f )
				{
					manager.airalas.color = new Color (0.073f,0.743f,0.000f);
					manager.airkeran.color = new Color (0.073f,0.743f,0.000f);
					manager.airkeran2.color = new Color (0.073f,0.743f,0.000f);
				}
				else if(manager2.TulisanSatuan [0] > 1300 && manager2.TulisanSatuan [0] <= 1350 && manager.PatokanSatuan == 1||  manager.PatokanSatuan == 2 && manager2.TulisanSatuan [0]  >=80.9f && manager2.TulisanSatuan [0]  <= 85.9f)
				{
					manager.airalas.color = new Color (0.716f,0.757f,0000f);
					manager.airkeran.color = new Color (0.716f,0.757f,0000f);
					manager.airkeran2.color = new Color (0.716f,0.757f,0000f);
				}
				else if(manager2.TulisanSatuan [0] > 1400 && manager2.TulisanSatuan [0] <= 1450 && manager.PatokanSatuan == 1||  manager.PatokanSatuan == 2 && manager2.TulisanSatuan [0]  >=85.9f && manager2.TulisanSatuan [0]  <= 89.9f )
				{
					manager.airalas.color = new Color (0.945f,1000f,0000f);
					manager.airkeran.color = new Color (0.945f,1000f,0000f);
					manager.airkeran2.color = new Color (0.945f,1000f,0000f);
					//airalas.color = Color.yellow;
				}

			}
			else if(pilih == 4)
			{
				virjoystrick.rectTransform.anchoredPosition = new Vector3 (inputvector4.x * (background.rectTransform.sizeDelta.x /2) ,virjoystrick.rectTransform.anchoredPosition.y);

				inputvector4 = new Vector3 (pos.x * 2- 1,0, pos.y*2 -1);



				if (inputvector4.x < 0f) {
					inputvector4.x = 0f;
				} 
				else if(inputvector4.x > 25.3f)
				{
					inputvector4.x = 25.1f;
				}



				if(manager.PatokanSatuan == 1)
				{
					manager2.TulisanSatuan [1] = 3.7f + Mathf.Round(  (((virjoystrick.rectTransform.anchoredPosition.x )) ) + inputvector4.x*-2.55f )/10  ;

					for (int i = 0; i < manager2.angkapressure4.Length; i++) {
						manager2.angkapressure4 [i] = 38.3f + Mathf.Round ((virjoystrick.rectTransform.anchoredPosition.x) + inputvector4.x * 8743.4f)/10 ;
					}
				}
				else if(manager.PatokanSatuan == 2)
				{
					manager2.TulisanSatuan [1] = 3.7f + Mathf.Round(  (((virjoystrick.rectTransform.anchoredPosition.x )) ) + inputvector4.x*-2.55f )/10  ;

					for (int i = 0; i < manager2.angkapressure4.Length; i++) {
						manager2.angkapressure4 [i] = 0.37f + Mathf.Round ((virjoystrick.rectTransform.anchoredPosition.x) + inputvector4.x * 853.03f  )/100 ;
					}
				} 
				else if(manager.PatokanSatuan == 3)
				{
					manager2.TulisanSatuan [1] = 12.2f +(Mathf.Round((virjoystrick.rectTransform.anchoredPosition.x  )+ inputvector3.x ))/3.965f ;
					for (int i = 0; i < manager2.angkapressure4.Length; i++) {
						manager2.angkapressure4 [i] = 5.56f + Mathf.Round ((virjoystrick.rectTransform.anchoredPosition.x) + inputvector4.x * 12631.42f )/100f ;
					}
				}
			}


		}
	}

	public virtual void OnPointerDown(PointerEventData ped)
	{
		//inputvector3.x = -0.4f;
		OnDrag (ped);

	}

	public virtual void OnPointerUp(PointerEventData ped)
	{
		
	}

}
