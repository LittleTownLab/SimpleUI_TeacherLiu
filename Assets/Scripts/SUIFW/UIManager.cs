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
using System.Collections.Generic;

namespace SUIFW
{
	public class UIManager : MonoBehaviour 
	{
        private static  UIManager _Instance = null;
        private Dictionary<string, string> _DicFormsPaths;
       // private Dictionary<string, BaseUIForm> _DicAllUIForms;
      //  private Dictionary<string, BaseUIForm> _DicCurrentShowForms;

        private Transform _TraNormal = null;
        private Transform _TraFixed = null;
        private Transform _TraPopUp = null;
        private Transform _TraUIScripts = null;

        public static UIManager GetInstance()
        {
            if(_Instance == null)
            {
                _Instance = new UIManager();
            }

            return _Instance;
        }

        public void Awake()
        {
            
        }

		void Start () 
		{
			
		}
	}
}