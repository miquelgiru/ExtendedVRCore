﻿using EVR.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeviceInputVive : DeviceInputBase
{
    private Canvas m_inputCanvas = null;

    public DeviceInputVive()
    {
        GameObject go = Resources.Load("Prefabs/Input/ViveOrRift/ViveOrRiftCamera") as GameObject;
        GameObject tmp = MonoBehaviour.Instantiate<GameObject>(go);
        m_raySetPosition = GetController(tmp);
        m_rayLength = Mathf.Infinity;
    }

    public override void Init(InputGeneralConfig config)
    {
        m_enabled = true;
        m_selectionTime = Mathf.Infinity;
    }

    public override void Clear()
    {
        m_enabled = false;
    }

    public override void ShowSelection(bool enabled)
    {
        m_enabled = enabled;
        if (!m_enabled)
        {
            m_inputCanvas.enabled = false;
        }
        else if (enabled != m_enabled)
        {
            m_inputCanvas.enabled = true;
        }
    }

    private Transform GetController(GameObject go)
    {
        Transform ret = go.transform.Find(InputStatics.MainController);
        return ret;
    }

    public override bool MainTiggerButton(InputButtonStates state)
    {

        bool ret = false;

        switch (state)
        {
            case InputButtonStates.UP:
                ret = Input.GetButtonUp(InputStatics.Main_Trigger);
                break;
            case InputButtonStates.DOWN:
                ret = Input.GetButtonDown(InputStatics.Main_Trigger);
                break;
            case InputButtonStates.PRESS:
                ret = Input.GetButton(InputStatics.Main_Trigger);
                break;
            case InputButtonStates.NONE:
                break;
        }

        return ret;
    }

    public override bool AuxiliarTiggerButton(InputButtonStates state)
    {
        bool ret = false;

        switch (state)
        {
            case InputButtonStates.UP:
                ret = Input.GetButtonUp(InputStatics.Auxiliar_Trigger);
                break;
            case InputButtonStates.DOWN:
                ret = Input.GetButtonDown(InputStatics.Auxiliar_Trigger);
                break;
            case InputButtonStates.PRESS:
                ret = Input.GetButton(InputStatics.Auxiliar_Trigger);
                break;
            case InputButtonStates.NONE:
                break;
        }

        return ret;
    }
}