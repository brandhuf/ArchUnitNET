﻿//  Copyright 2019 Florian Gather <florian.gather@tngtech.com>
// 	Copyright 2019 Paula Ruiz <paularuiz22@gmail.com>
// 	Copyright 2019 Fritz Brandhuber <fritz.brandhuber@tngtech.com>
// 
// 	SPDX-License-Identifier: Apache-2.0

namespace ArchUnitNET.Fluent.Syntax.Elements.Types.Classes
{
    public interface IClassConditions<out TReturnType> : ITypeConditions<TReturnType>
    {
        TReturnType BeAbstract();
        TReturnType BeSealed();
        TReturnType BeValueTypes();
        TReturnType BeEnums();
        TReturnType BeStructs();


        //Negations


        TReturnType NotBeAbstract();
        TReturnType NotBeSealed();
        TReturnType NotBeValueTypes();
        TReturnType NotBeEnums();
        TReturnType NotBeStructs();
    }
}