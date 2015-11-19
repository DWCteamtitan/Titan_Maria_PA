using UnityEngine;
using System.Collections;
// PRIMARY OBJECTIVE NARRATIVE //
public class UpdatePrimaryObjective : MonoBehaviour 
{

	public GameObject PrimaryObjective2;
	public GameObject PrimaryObjective3;
	public GameObject text_recon_point_reached;

	// Use this for initialization
	void Start () 
	{

	}

	public void Awake()
	{

	}

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.name == "primary_objective_waypoint_01") 
		{
			Destroy(col.gameObject);
			PrimaryObjective2.SetActive (true);
			text_recon_point_reached.SetActive (true);

		}

		if (col.gameObject.name == "primary_objective_waypoint_02") 
		{
			Destroy(col.gameObject);
			PrimaryObjective3.SetActive (true);
			text_recon_point_reached.SetActive (true);
			
		}

	}

	// Update is called once per frame
	void Update () 
	{
	
	}

}
