using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class DragVL2 : MonoBehaviour,IPointerDownHandler,IPointerUpHandler, IDragHandler {

	#region Singelton
	public static DragVL2 instance;

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

	public List<MerahMerah> items = new List<MerahMerah>();
	public MerahMerah prefabnya;
	public delegate void OnItemChanged();
	public OnItemChanged onitemchangedcallback;

	public Text[] SpeedCurr;public float SpeedAngka;

	// Use this for initialization
	void Start () {
		background = GetComponent<Image> ();
		virjoystrick = transform.GetChild (0).GetComponent<Image> ();
		KecepatandotFloat = 1000;
		SpeedCurr [1].text = "m/s"  ;
		SpeedAngka = 0.3f;
	}

	// Update is called once per frame
	void Update () {
		KecepetandotsText.text = "" + KecepatandotFloat;

		SpeedCurr [0].text = "" + SpeedAngka;

	}

	public virtual void OnDrag(PointerEventData ped)
	{
		Vector2 pos;
		if(RectTransformUtility.ScreenPointToLocalPointInRectangle(background.rectTransform,ped.position,ped.pressEventCamera,out pos))
		{
			pos.x = (pos.x / background.rectTransform.sizeDelta.x);
			pos.y = (pos.y / background.rectTransform.sizeDelta.y);


			 if(pilih == 1)
			{
				virjoystrick.rectTransform.anchoredPosition = new Vector3 (inputvector4.x * (background.rectTransform.sizeDelta.x /2) ,virjoystrick.rectTransform.anchoredPosition.y);

				inputvector4 = new Vector3 (pos.x * 2- 1,0, pos.y*2 -1);



				if (inputvector4.x < 0f) {
					inputvector4.x = 0f;
				} 
				else if(inputvector4.x > 20f)
				{
					inputvector4.x = 20f;
				}

				KecepatandotFloat = 1000 +  Mathf.FloorToInt (inputvector4.x * 450f ) ;
				SpeedAngka = 0.3f + Mathf.FloorToInt( inputvector4.x * 0.145f*10 )/10f  ;

				for (int i = 0; i < items.Count; i++) {
					items [i].Speed = KecepatandotFloat/10;
				}
				prefabnya.Speed = KecepatandotFloat / 10;

			}
			else if(pilih == 2)
			{
				virjoystrick.rectTransform.anchoredPosition = new Vector3 (inputvector4.x * (background.rectTransform.sizeDelta.x /2) ,virjoystrick.rectTransform.anchoredPosition.y);

				inputvector4 = new Vector3 (pos.x * 2- 1,0, pos.y*2 -1);



				if (inputvector4.x < 0f) {
					inputvector4.x = 0f;
				} 
				else if(inputvector4.x > 20f)
				{
					inputvector4.x = 20f;
				}

				KecepatandotFloat = 35 +  Mathf.FloorToInt (inputvector4.x * 15.75f ) ;
				SpeedAngka = 1.0f + Mathf.FloorToInt( inputvector4.x * 0.47f*10f )/10f  ;

				for (int i = 0; i < items.Count; i++) {
					items [i].Speed =  (DragVL2.instance.KecepatandotFloat * 1000 /35) /10 ;
				}
				prefabnya.Speed = (DragVL2.instance.KecepatandotFloat * 1000 /35) /10 ;
			}
			else if(pilih == 3)
			{
				virjoystrick.rectTransform.anchoredPosition = new Vector3 (inputvector4.x * (background.rectTransform.sizeDelta.x /2) ,virjoystrick.rectTransform.anchoredPosition.y);

				inputvector4 = new Vector3 (pos.x * 2- 1,0, pos.y*2 -1);



				if (inputvector4.x < 0f) {
					inputvector4.x = 0f;
				} 
				else if(inputvector4.x > 20f)
				{
					inputvector4.x = 20f;
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

	public bool Add(MerahMerah item)
	{	
		bool masukgak = false;

		//item = GameObject.Find ("Merah(Clone)").GetComponent<MerahMerah>();


		if (!masukgak) {	
			
			if (!item.ada) {
				
				items.Add (item);

				if (onitemchangedcallback != null) {
					onitemchangedcallback.Invoke ();
				}
				masukgak = false;
			}
		}
		return true;
	}
	public void Remove(MerahMerah item)
	{

		items.Remove (item);
		if(onitemchangedcallback!= null)
		{
			onitemchangedcallback.Invoke ();
		}
	}
}

