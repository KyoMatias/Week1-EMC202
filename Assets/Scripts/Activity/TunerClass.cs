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
public class TunerClass : BaseCar
{
    public void BaseCar()
    {
        _name = "Mazda Rx-7 FD3S";
        _horsePower = 280f;
        _baseSpeed = 86f;
        _type = "Tuner";
    }

    public void Tune()
    {
        EngineTune = 3;
        ECUTune = 5;
        BrakeTune = 3;
        TireTune = 4;
        TurboTune = 4;
        TransmissionTune = 5;
        SuspensionTune = 4;
        NitrousLevel = 5;

    }
}
