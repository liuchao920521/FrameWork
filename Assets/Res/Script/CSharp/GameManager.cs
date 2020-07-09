using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace WZQ
{
	public class GameManager : MonoBehaviour
	{

		// Start is called before the first frame update
		void Start()
		{
			Init();
		}

		// Update is called once per frame
		void Update()
		{

		}

		void Init()
		{
			Debug.Log("***********初始化***************");
			DontDestroyOnLoad(gameObject);  //防止销毁自己		

		}

		public void BloodBar()
		{

		}

	}
}
