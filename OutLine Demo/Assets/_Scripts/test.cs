using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

	EnemyOutLine _outline;

	void Start () {
		_outline = Camera.main.GetComponent<EnemyOutLine> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.F)) {
			if (_outline.OutLineWidth == 0) {
				_outline.OutLineWidth = 1;
			} else {
				_outline.OutLineWidth = 0;
			}
		}
	}
}
