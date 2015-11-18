using UnityEngine;
using System.Collections;
// PRIMARY OBJECTIVE NARRATIVE //
public class UpdatePrimaryObjective : MonoBehaviour 
{

	public GameObject PrimaryObjective2;
	public GameObject PrimaryObjective3;
	public AudioSource audio_objective_complete;

	// Use this for initialization
	void Start () 
	{


	}

	public void Awake()
	{
		audio_objective_complete = GetComponent<AudioSource> ();
	}

	public void OnTriggerEnter(Collider other)
	{
		audio_objective_complete.Play ();
	}

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.name == "primary_objective_waypoint_01") 
		{
			Destroy(col.gameObject);
			PrimaryObjective2.SetActive (true);
			audio_objective_complete.Play();

		}

		if (col.gameObject.name == "primary_objective_waypoint_02") 
		{
			Destroy(col.gameObject);
			PrimaryObjective3.SetActive (true);
			
		}

	}



	// Update is called once per frame
	void Update () 
	{
	
	}

}
