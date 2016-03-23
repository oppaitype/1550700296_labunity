using UnityEngine;
using System.Collections;

public class Contro : MonoBehaviour
{
	public GameObject hazard;
	public float delta = 1.5f;
	public float speed = 2.0f;
	//public Vector3 spawnValues;
	public int hazardCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;
	
	void Start()
	{
		StartCoroutine(SpawnWaves());
	}
	
	IEnumerator SpawnWaves()
	{
		yield return new WaitForSeconds(startWait);
		while (true)
		{
			for (int i = 0; i < hazardCount; i++)
			{

				float haza = Random.Range (0.8f,4.6f);
				GameObject hazard2 = (GameObject)Instantiate (hazard,new Vector3(-5,haza,0),Quaternion.identity);
				hazard2.transform.Rotate(0,0,90);

				yield return new WaitForSeconds(spawnWait);
			}
			yield return new WaitForSeconds(waveWait);
		}
	}
}
