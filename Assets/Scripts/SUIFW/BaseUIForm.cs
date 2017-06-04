/*
 *	Tile : "SUIFW" UI框架项目
 *			主题:
 *
 *	Description:
 *           功能:
 *
 *	Date: 2017
 *	Version: 0.1
 *	Modify Recorder:
 *
 */

using UnityEngine;
using System.Collections;

namespace SUIFW
{
	public class BaseUIForm : MonoBehaviour 
	{
		private UIType _CurrentUIType = new UIType();

		public UIType CurrentUIType
		{
			get { return _CurrentUIType; }
			set { _CurrentUIType = value; }
		}
		 
		
		public UIType CurrentUiType
		{
			get { return _CurrentUIType; }
			set { _CurrentUIType = value; }
		}

		public virtual void Display()
		{
			this.gameObject.SetActive(true);
		}

		public virtual void Redisplay()
		{
			this.gameObject.SetActive(false);
		}

		public virtual void Hiding()
		{
			this.gameObject.SetActive(false);
		}

		public virtual void Freeze()
		{
			this.gameObject.SetActive(true);
		}
	}
}