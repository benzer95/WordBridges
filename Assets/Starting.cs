﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starting : MonoBehaviour {

	// Use this for initialization
	void Start () {
		TextAsset txt = (TextAsset)Resources.Load("unixdict", typeof(TextAsset));
		GameInfo.l.file = txt.text.Split('\n');
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
