using UnityEngine;
using System.Collections;

public class EnemyDestination : MonoBehaviour 
{	
	private NavMeshAgent agent;
	[SerializeField]
	private GameObject target;

	// Use this for initialization
	void Start () 
	{
		agent = GetComponent<NavMeshAgent>();
		agent.SetDestination(target.transform.position);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
