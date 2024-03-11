using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

	private UnityEngine.AI.NavMeshAgent _navMeshAgent;
	private GameObject _playerObj;
	// Use this for initialization
	//void Start () {
	
	//}
	void Awake(){
		_navMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent> ();
		_playerObj = GameObject.FindGameObjectWithTag ("Player");
	}
	// Update is called once per frame
	void Update () {
		_navMeshAgent.SetDestination (_playerObj.transform.position);
	}
}