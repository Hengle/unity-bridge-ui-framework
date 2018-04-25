/*************************************************************************************   
    * 作    者：       zouhunter
    * 创建时间：       2018-04-23 01:42:32
    * 说    明：       1.部分代码自动生成
                       2.尽量使用MVVM模式
* ************************************************************************************/
using BridgeUI;
using BridgeUI.Binding;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
//#if xLua
///<summary>
///[代码说明信息]
///<summary>
public class LuaPanel01 : BridgeUI.LuaPanel
{
	[SerializeField]
	private UnityEngine.UI.Button m_Button;

	[SerializeField]
	private UnityEngine.UI.Slider m_Slider;

	[SerializeField]
	private UnityEngine.UI.Toggle m_Toggle;

	[SerializeField]
	private UnityEngine.UI.Dropdown m_Dropdown;

	[SerializeField]
	private UnityEngine.UI.InputField m_InputField;

	[SerializeField]
	private UnityEngine.UI.Text m_Text;

	[SerializeField]
	private UnityEngine.RectTransform m_RawImage;

	[SerializeField]
	private UnityEngine.UI.Image m_Image;

	[SerializeField]
	private UnityEngine.UI.ScrollRect m_ScrollView;

	protected override void InitComponents ()
	{
	}

	protected override void PropBindings ()
	{
        Binder.RegistMember<Sprite>("m_Image.sprite", "image");
        Binder.RegistEvent<ButtonEvent>("m_Button.onClick", "on_button_clicked", "我是一个按扭");
        Binder.RegistEvent<ToggleEvent>("m_Toggle.onValueChanged", "on_toggle_switched", "我是一个Toggle");

        //Binder.RegistButtonEvent (m_Button, "on_button_clicked", "我是一个按扭");
        //Binder.RegistSliderEvent (m_Slider, "on_slider_changed");
        //Binder.RegistToggleEvent (m_Toggle, "on_toggle_switched");
        //      //Binder.RegistToggleView(m_Toggle)
        //Binder.RegistTextView (m_Text, "text");
        //Binder.RegistImageView (m_Image, "image");
        //Binder.RegistDropdownEvent (m_Dropdown, "on_dropdown_switched");
    }

	protected override void Update ()
	{
		base.Update ();
		if (Input.GetMouseButtonDown (1)) {
			HandleData ("我是面板启动参数测试");
		}
	}
}
//#endif
