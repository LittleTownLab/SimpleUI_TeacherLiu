/*
 *	Tile : "SUIFW" UI框架项目
 *			主题: 框架核心参数
 *
 *	Description:
 *           功能:
 *              1：系统常量
 *              2：全局性方法
 *              3：系统枚举类型
 *              4：委托定义
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
    #region 系统枚举类型

    public enum UIFormType
    {
        Normal,
        Fixed,
        PopUp
    }

    public enum UIFormShowMode
    {
        Normal,
        ReverseChange,//反向切换
        HideOther
    }

    public enum UIFormLucenyType
    {
        //完全透明，不能穿透
        Lucency,
        //半透明，不能穿透
        Translucence,
        //低透明，不能穿透
        ImPenetrable,
        //可以穿透
        Pentrate
    }
    #endregion

	public class SysDefine : MonoBehaviour 
	{

		void Start () 
		{
			
		}
	}
}