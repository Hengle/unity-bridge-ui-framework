﻿/*************************************************************************************   
    * 作    者：       zouhunter
    * 创建时间：       2018-04-26 08:38:24
    * 说    明：       1.部分代码自动生成
                       2.尽量使用MVVM模式
                       3.宏定义内会读成注释
* ************************************************************************************/using BridgeUI;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

///<summary>
///[代码说明信息]
///<summary>
public class UserControlPanel : BridgeUI.SinglePanel
{
	[SerializeField]
	private ButtonList m_List;

	[SerializeField]
	private ButtonItem m_buttonItem;

	protected override void PropBindings ()
	{
		Binder.RegistEvent (m_List.onSelectChanged, "onSelect", m_List);
		Binder.RegistMember<System.String[]> (x=>m_List.infos=x, "infos");
	}
}
