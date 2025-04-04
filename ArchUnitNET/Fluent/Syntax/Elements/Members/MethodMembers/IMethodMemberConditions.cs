﻿//  Copyright 2019 Florian Gather <florian.gather@tngtech.com>
// 	Copyright 2019 Paula Ruiz <paularuiz22@gmail.com>
// 	Copyright 2019 Fritz Brandhuber <fritz.brandhuber@tngtech.com>
//
// 	SPDX-License-Identifier: Apache-2.0

using System;
using System.Collections.Generic;
using ArchUnitNET.Domain;

namespace ArchUnitNET.Fluent.Syntax.Elements.Members.MethodMembers
{
    public interface IMethodMemberConditions<out TReturnType, out TRuleType>
        : IMemberConditions<TReturnType, TRuleType>
        where TRuleType : ICanBeAnalyzed
    {
        TReturnType BeConstructor();
        TReturnType BeVirtual();

        [Obsolete(
            "Another overload of this method should be used. This will be removed in a future update. You can use BeCalledBy(Types().That().HaveFullName()) instead"
        )]
        TReturnType BeCalledBy(string pattern, bool useRegularExpressions = false);

        [Obsolete(
            "Another overload of this method should be used. This will be removed in a future update. You can use BeCalledBy(Types().That().HaveFullName()) instead"
        )]
        TReturnType BeCalledBy(IEnumerable<string> patterns, bool useRegularExpressions = false);
        TReturnType BeCalledBy(IType firstType, params IType[] moreTypes);
        TReturnType BeCalledBy(Type type, params Type[] moreTypes);
        TReturnType BeCalledBy(IObjectProvider<IType> types);
        TReturnType BeCalledBy(IEnumerable<IType> types);
        TReturnType BeCalledBy(IEnumerable<Type> types);

        [Obsolete(
            "Another overload of this method should be used. This will be removed in a future update. You can use HaveDependencyInMethodBodyTo(Types().That().HaveFullName()) instead"
        )]
        TReturnType HaveDependencyInMethodBodyTo(
            string pattern,
            bool useRegularExpressions = false
        );

        [Obsolete(
            "Another overload of this method should be used. This will be removed in a future update. You can use HaveDependencyInMethodBodyTo(Types().That().HaveFullName()) instead"
        )]
        TReturnType HaveDependencyInMethodBodyTo(
            IEnumerable<string> patterns,
            bool useRegularExpressions = false
        );
        TReturnType HaveDependencyInMethodBodyTo(IType firstType, params IType[] moreTypes);
        TReturnType HaveDependencyInMethodBodyTo(Type type, params Type[] moreTypes);
        TReturnType HaveDependencyInMethodBodyTo(IObjectProvider<IType> types);
        TReturnType HaveDependencyInMethodBodyTo(IEnumerable<IType> types);
        TReturnType HaveDependencyInMethodBodyTo(IEnumerable<Type> types);

        [Obsolete(
            "Another overload of this method should be used. This will be removed in a future update. You can use HaveReturnType(Types().That().HaveFullName()) instead"
        )]
        TReturnType HaveReturnType(string pattern, bool useRegularExpressions = false);

        [Obsolete(
            "Another overload of this method should be used. This will be removed in a future update. You can use HaveReturnType(Types().That().HaveFullName()) instead"
        )]
        TReturnType HaveReturnType(
            IEnumerable<string> patterns,
            bool useRegularExpressions = false
        );
        TReturnType HaveReturnType(IType firstType, params IType[] moreTypes);
        TReturnType HaveReturnType(IEnumerable<IType> types);
        TReturnType HaveReturnType(IObjectProvider<IType> types);
        TReturnType HaveReturnType(Type type, params Type[] moreTypes);
        TReturnType HaveReturnType(IEnumerable<Type> types);

        //Negations


        TReturnType BeNoConstructor();
        TReturnType NotBeVirtual();

        [Obsolete(
            "Another overload of this method should be used. This will be removed in a future update. You can use NotBeCalledBy(Types().That().HaveFullName()) instead"
        )]
        TReturnType NotBeCalledBy(string pattern, bool useRegularExpressions = false);

        [Obsolete(
            "Another overload of this method should be used. This will be removed in a future update. You can use NotBeCalledBy(Types().That().HaveFullName()) instead"
        )]
        TReturnType NotBeCalledBy(IEnumerable<string> patterns, bool useRegularExpressions = false);
        TReturnType NotBeCalledBy(IType firstType, params IType[] moreTypes);
        TReturnType NotBeCalledBy(Type type, params Type[] moreTypes);
        TReturnType NotBeCalledBy(IObjectProvider<IType> types);
        TReturnType NotBeCalledBy(IEnumerable<IType> types);
        TReturnType NotBeCalledBy(IEnumerable<Type> types);

        [Obsolete(
            "Another overload of this method should be used. This will be removed in a future update. You can use NotHaveDependencyInMethodBodyTo(Types().That().HaveFullName()) instead"
        )]
        TReturnType NotHaveDependencyInMethodBodyTo(
            string pattern,
            bool useRegularExpressions = false
        );

        [Obsolete(
            "Another overload of this method should be used. This will be removed in a future update. You can use NotHaveDependencyInMethodBodyTo(Types().That().HaveFullName()) instead"
        )]
        TReturnType NotHaveDependencyInMethodBodyTo(
            IEnumerable<string> patterns,
            bool useRegularExpressions = false
        );
        TReturnType NotHaveDependencyInMethodBodyTo(IType firstType, params IType[] moreTypes);
        TReturnType NotHaveDependencyInMethodBodyTo(Type type, params Type[] moreTypes);
        TReturnType NotHaveDependencyInMethodBodyTo(IObjectProvider<IType> types);
        TReturnType NotHaveDependencyInMethodBodyTo(IEnumerable<IType> types);
        TReturnType NotHaveDependencyInMethodBodyTo(IEnumerable<Type> types);

        [Obsolete(
            "Another overload of this method should be used. This will be removed in a future update. You can use NotHaveReturnType(Types().That().HaveFullName()) instead"
        )]
        TReturnType NotHaveReturnType(string pattern, bool useRegularExpressions = false);

        [Obsolete(
            "Another overload of this method should be used. This will be removed in a future update. You can use NotHaveReturnType(Types().That().HaveFullName()) instead"
        )]
        TReturnType NotHaveReturnType(
            IEnumerable<string> patterns,
            bool useRegularExpressions = false
        );
        TReturnType NotHaveReturnType(IType firstType, params IType[] moreTypes);
        TReturnType NotHaveReturnType(IEnumerable<IType> types);
        TReturnType NotHaveReturnType(IObjectProvider<IType> types);
        TReturnType NotHaveReturnType(Type type, params Type[] moreTypes);
        TReturnType NotHaveReturnType(IEnumerable<Type> types);
    }
}
