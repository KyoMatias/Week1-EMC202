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
public class MuscleClass : BaseCar
{
    public void BaseCar()
    {
        _name = "Dodge Challenger SRT Demon";
        _horsePower = 840f;
        _baseSpeed = 90f;
        _type = "Muscle";
    }

    public void Tune()
    {
        EngineTune = 2;
        ECUTune = 2;
        BrakeTune = 3;
        TireTune = 5;
        TurboTune = 3;
        TransmissionTune = 3;
        SuspensionTune = 2;
        NitrousLevel = 1;
    }
}
