using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//
//  BaseCar.cs
//  Base Car Script
//
//  Created by Kyo Matias on 00/00/2022.
//  Copyright © 2022 Kyo Matias. All rights reserved.
//
public class ExoticClass : BaseCar
{   
    public void BaseCar()
    {
        _name = "Mclaren P1";
        _horsePower = 903f;
        _baseSpeed = 62f;
        _type = "Exotic";
    }

    public void Tune()
    {
        EngineTune = 1;
        ECUTune = 4;
        BrakeTune = 3;
        TireTune = 2;
        TurboTune = 3;
        TransmissionTune = 2;
        SuspensionTune = 5;
        NitrousLevel = 2;

    }
}
