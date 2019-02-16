﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class InputStatics
{
    //Controller names from SteamVR camera
    public static readonly string MainController = "Controller (right)";
    public static readonly string AuxiliarController = "Controller (left)";

    //right controller
    public static readonly string Horizontal_Main_Axis = "R_Horizontal";
    public static readonly string Vertical_Main_Axis = "R_Vertical";
    public static readonly string Main_Selection = "R_Selection";
    public static readonly string Main_Trigger = "R_Trigger";
    public static readonly string Main_Grip = "R_Grip";

    //left controller
    public static readonly string Horizontal_Auxiliar_Axis = "L_Horizontal";
    public static readonly string Vertical_Auxiliar_Axis = "L_Vertical";
    public static readonly string Auxiliar_Selection = "L_Selection";
    public static readonly string Auxiliar_Trigger = "L_Trigger";
    public static readonly string Auxiliar_Grip = "L_Grip";
}