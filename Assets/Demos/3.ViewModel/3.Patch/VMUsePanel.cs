﻿/*************************************************************************************   
    * 作    者：       zouhunter
    * 创建时间：       2018-06-29 04:37:51
    * 说    明：       1.部分代码自动生成
                       2.尽量使用MVVM模式
                       3.宏定义内会读成注释
* ************************************************************************************/using BridgeUI;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using BridgeUI.Binding;

///<summary>
///[代码说明信息]
///<summary>
public class VMUsePanel : BridgeUI.SinglePanel
{
	[SerializeField]
	private UnityEngine.UI.Button m_click;

	[SerializeField]
	private UnityEngine.UI.Text m_title;

	[SerializeField]
	private UnityEngine.UI.Text m_info;

	protected override void PropBindings ()
	{
		Binder.RegistEvent<UnityEngine.UI.Button> (m_click.onClick, "onClick", m_click);
		//Binder.RegistMember<System.String> (m_title.text, "title");
		Binder.RegistValueChange<System.String> (x=>m_title.text=x, "title");
        Binder.RegistValueChange<System.Int32> (x => m_title.fontSize=x, "fontSize");
		Binder.RegistValueChange<System.String> (x => m_info.text=x, "info");
		Binder.RegistValueChange<System.String> (x => m_title.text = x, "title");
		Binder.RegistValueChange<System.Int32> (x => m_title.fontSize = x, "fontSize");
		Binder.RegistValueChange<System.String> (x => m_info.text = x, "info");
	}
}
