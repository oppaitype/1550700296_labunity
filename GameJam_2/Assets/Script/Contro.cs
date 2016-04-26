using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Contro : MonoBehaviour
{
	public GameObject hazard;
	public GameObject hazard3;
	public GameObject hazard5;
	public float delta = 1.5f;
	public float speed = 2.0f;
	//public Vector3 spawnValues;
	public int hazardCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;
	public Button btnGameOver;
	public Text GameOver;
	
	void Start()
	{
		StartCoroutine(SpawnWaves());
		btnGameOver.gameObject.SetActive (false);
		GameOver.gameObject.SetActive (false);
	}
	
	IEnumerator SpawnWaves()
	{
		yield return new WaitForSeconds(startWait);
		while (true)
		{
			for (int i = 0; i < hazardCount; i++)
			{

				float haza = Random.Range (0.8f,4.6f);
                float haza2 = Random.Range(0.4f, 7.6f);
                GameObject hazard2 = (GameObject)Instantiate (hazard,new Vector3(-1,-1,0),Quaternion.identity);
				hazard2.transform.Rotate(90,0,0);
				GameObject hazard4 = (GameObject)Instantiate (hazard3,new Vector3(-3,haza2,0),Quaternion.identity);
				hazard2.transform.Rotate(90,0,0);
				GameObject hazard6 = (GameObject)Instantiate (hazard5,new Vector3(-10,haza,0),Quaternion.identity);
				hazard2.transform.Rotate(90,0,0);

				yield return new WaitForSeconds(spawnWait);
			}
			yield return new WaitForSeconds(waveWait);
		}
	}
}
