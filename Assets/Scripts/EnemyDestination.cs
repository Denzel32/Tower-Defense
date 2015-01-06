using UnityEngine;
using System.Collections;

public class EnemyDestination : MonoBehaviour 
{	
	private NavMeshAgent agent;
	[SerializeField]
	public GameObject [] targets;
	private int currentTarget = 0;

	// Use this for initialization
	void Start () 
	{
		agent = GetComponent<NavMeshAgent>();
		MoveToTarget();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(targets[currentTarget] == null && currentTarget < targets.Length -1)
		{
			currentTarget++;
			MoveToTarget();
		}
	}

	void MoveToTarget()
	{
		agent.SetDestination(targets[currentTarget].transform.position);
	}
}
