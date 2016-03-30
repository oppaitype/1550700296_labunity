using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Gameover : MonoBehaviour {

	public Button btnGameOver;
	public Text GameOver;
	public Button btnjump;

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "Cubebase") 
		{
			btnGameOver.gameObject.SetActive (true);
			GameOver.gameObject.SetActive (true);
			btnjump.gameObject.SetActive (false);

		}
	}
}
