using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class DragVL2C :MonoBehaviour,IPointerDownHandler,IPointerUpHandler, IDragHandler {

	#region Singelton
	public static DragVL2C instance;

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



			virjoystrick.rectTransform.anchoredPosition = new Vector3 (inputvector4.x * (background.rectTransform.sizeDelta.x /2) ,inputvector4.y* (background.rectTransform.sizeDelta.y /2));

			inputvector4 = new Vector3 (pos.x * 2- 1,0, pos.y*2 -1);



				




			

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
