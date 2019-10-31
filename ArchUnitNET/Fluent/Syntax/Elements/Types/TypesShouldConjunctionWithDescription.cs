﻿//  Copyright 2019 Florian Gather <florian.gather@tngtech.com>
// 	Copyright 2019 Paula Ruiz <paularuiz22@gmail.com>
// 	Copyright 2019 Fritz Brandhuber <fritz.brandhuber@tngtech.com>
// 
// 	SPDX-License-Identifier: Apache-2.0

using ArchUnitNET.Domain;

namespace ArchUnitNET.Fluent.Syntax.Elements.Types
{
    public class TypesShouldConjunctionWithDescription : ObjectsShouldConjunctionWithDescription<
        TypesShould<TypesShouldConjunction, IType>, IType>
    {
        public TypesShouldConjunctionWithDescription(IArchRuleCreator<IType> ruleCreator) : base(ruleCreator)
        {
        }
    }
}