using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class DragVL2B :  MonoBehaviour,IPointerDownHandler,IPointerUpHandler, IDragHandler {

	#region Singelton
	public static DragVL2B instance;

	void Awake()
	{
		if(instance !=null)
		{
			Debug.LogWarning ("more than one instance!!!");
			return;
		}
		instance = this;
	}
	#endregion

	private Image background;
	private Image virjoystrick;

	public Vector3 inputvector4;
	public int pilih;
	public Text KecepetandotsText;
	public float KecepatandotFloat; 

	public Image airkeran;
	// Use this for initialization
	void Start () {
		background = GetComponent<Image> ();
		virjoystrick = transform.GetChild (0).GetComponent<Image> ();
		KecepatandotFloat = 700;
	}

	// Update is called once per frame
	void Update () {
		KecepetandotsText.text = "" + KecepatandotFloat;



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
				virjoystrick.rectTransform.anchoredPosition = new Vector3 (inputvector4.x * (background.rectTransform.sizeDelta.x /2) ,virjoystrick.rectTransform.anchoredPosition.y);

				inputvector4 = new Vector3 (pos.x * 2- 1,0, pos.y*2 -1);



				if (inputvector4.x < 0f) {
					inputvector4.x = 0f;
				} 
				else if(inputvector4.x > 25f)
				{
					inputvector4.x = 25f;
				}

				KecepatandotFloat = 700 + Mathf.FloorToInt (inputvector4.x * 28.8f );

			}
			else if(pilih == 4)
			{
				virjoystrick.rectTransform.anchoredPosition = new Vector3 (inputvector4.x * (background.rectTransform.sizeDelta.x /2) ,virjoystrick.rectTransform.anchoredPosition.y);

				inputvector4 = new Vector3 (pos.x * 2- 1,0, pos.y*2 -1);



				if (inputvector4.x < 0f) {
					inputvector4.x = 0f;
				} 
				else if(inputvector4.x > 25f)
				{
					inputvector4.x = 25f;
				}

				KecepatandotFloat = 44 + Mathf.FloorToInt (inputvector4.x * 1.8f );
			}
			///////////////////////////////////////////////////////////////
			if(KecepatandotFloat  >=800 && KecepatandotFloat  <= 900  ||  KecepatandotFloat   >=49.9f && KecepatandotFloat  <= 51.9f)
			{
				airkeran.color = new Color (0.647f,0.647f,0.647f);


			}
			else if(KecepatandotFloat > 900 && KecepatandotFloat <= 1000 ||   KecepatandotFloat  >=51.9f && KecepatandotFloat   <= 55.9f)
			{
				airkeran.color = new Color (0.429f,0.568f,0.596f);

			}
			else if(KecepatandotFloat > 1000 &&KecepatandotFloat <= 1050 ||   KecepatandotFloat   >=55.9f && KecepatandotFloat   <= 57.9f)
			{
				airkeran.color = new Color (0.289f,0.655f,0.728f);

			}
			else if(KecepatandotFloat > 1050 && KecepatandotFloat <= 1100 || KecepatandotFloat  >=57.9f && KecepatandotFloat <= 60.9f)
			{
				airkeran.color = new Color (0.123f,0.757f,0.882f);

			}
			else if(KecepatandotFloat > 1100 && KecepatandotFloat <= 1150 || KecepatandotFloat  >=60.9f && KecepatandotFloat  <= 65.9f)
			{
				airkeran.color = new Color (0.000f,0.834f,1000f);


			}


			else if(KecepatandotFloat > 1150 && KecepatandotFloat <= 1200  || KecepatandotFloat  >=65.9f && KecepatandotFloat <= 70.9f)
			{
				airkeran.color = new Color (0.000f,0.710f,1000f);

			}
			else if(KecepatandotFloat > 1200 && KecepatandotFloat <= 1250 || KecepatandotFloat  >=70.9f && KecepatandotFloat <= 75.9f)
			{
				airkeran.color = new Color (0.098f,1000f,0.000f);

			}
			else if(KecepatandotFloat > 1250 && KecepatandotFloat <= 1300 || KecepatandotFloat  >=75.9f && KecepatandotFloat  <= 80.9f )
			{
				airkeran.color = new Color (0.073f,0.743f,0.000f);

			}
			else if(KecepatandotFloat > 1300 && KecepatandotFloat <= 1350 || KecepatandotFloat >=80.9f && KecepatandotFloat  <= 85.9f)
			{
				airkeran.color = new Color (0.716f,0.757f,0000f);

			}
			else if(KecepatandotFloat > 1400 && KecepatandotFloat <= 1450|| KecepatandotFloat  >=85.9f && KecepatandotFloat  <= 89.9f )
			{
				airkeran.color = new Color (0.945f,1000f,0000f);

				//airalas.color = Color.yellow;
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
