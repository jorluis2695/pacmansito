using UnityEngine;
using System.Collections;
/*
public const int DERECHA = 1;
#define IZQUIERDA  2
#define ARRIBA  3
#define ABAJO  4
*/
public enum Direccion
{
	ARRIBA,
	ABAJO,
	IZQUIERDA,
	DERECHA,
};

	void 
	{
		
	}

public class MovPacman : MonoBehaviour {

	public float speed = 3f;
	public int DirF;
	public int DirA;


	// Use this for initialization
	void Start () {
		DirA = (int) Direccion.DERECHA;
		DirF = (int) Direccion.DERECHA;
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKey(KeyCode.UpArrow))
			DirA=(int)Direccion.ARRIBA;
		else if(Input.GetKey(KeyCode.DownArrow))
			DirA=(int)Direccion.ABAJO;
		else if(Input.GetKey(KeyCode.LeftArrow))
			DirA=(int)Direccion.IZQUIERDA;
		else if(Input.GetKey(KeyCode.RightArrow))
			DirA=(int)Direccion.DERECHA;

		switch(DirA) 
		{
			case (int)Direccion.ARRIBA:
			{
				this.transform.Translate(Vector3.up*speed*Time.deltaTime);
				break;
			}
			case (int)Direccion.ABAJO:
		    {
				this.transform.Translate(Vector3.down*speed*Time.deltaTime);
				break;
			}
			case (int)Direccion.IZQUIERDA:
			{
				this.transform.Translate(Vector3.left*speed*Time.deltaTime);
				break;
			}
			case (int)Direccion.DERECHA:
			{
				this.transform.Translate(Vector3.right*speed*Time.deltaTime);
				break;
			}
			default:
			{
				Debug.Log("Hubo un error");
				break;
			}
		}

	
	}
}
