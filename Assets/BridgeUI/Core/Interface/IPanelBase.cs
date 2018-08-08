﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.Events;
using UnityEngine.Sprites;
using UnityEngine.Scripting;
using UnityEngine.Assertions;
using UnityEngine.EventSystems;
using UnityEngine.Assertions.Must;
using UnityEngine.Assertions.Comparers;
using System.Collections;
using System.Collections.Generic;
using BridgeUI.Model;

namespace BridgeUI
{
    /// <summary>
    /// 所有ui界面的父级
    /// [用于界面创建及打开的规则]
    /// </summary>
    public interface IUIPanel
    {
        string Name { get; }
        int InstenceID { get; }
        IPanelGroup Group { get; set; }
        IUIPanel Parent { get; set; }
        Transform Content { get; }
        Transform Root { get; }
        List<IUIPanel> ChildPanels { get; }
        event PanelCloseEvent onDelete;
        UIType UType { get; set; }
        bool IsShowing { get; }
        bool IsAlive { get; }
        void SetParent(Transform parent);
        void Close();
        void Hide();
        void UnHide();
        void RecordChild(IUIPanel childPanel);

        void HandleData(Bridge bridge);
        void Cover();
    }

  
}