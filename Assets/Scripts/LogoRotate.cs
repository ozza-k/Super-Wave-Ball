﻿using UnityEngine;
using System.Collections;

public class LogoRotate : MonoBehaviour {
	void Update () {
		transform.Rotate (new Vector3 (0, 90, 0) * Time.deltaTime);
	}
}
