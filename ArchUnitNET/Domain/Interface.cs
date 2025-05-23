﻿using System.Collections.Generic;
using System.Linq;
using ArchUnitNET.Domain.Dependencies;
using ArchUnitNET.Domain.Extensions;

namespace ArchUnitNET.Domain
{
    public class Interface : IType
    {
        public Interface(IType type)
        {
            Type = type;
        }

        public IType Type { get; }
        public string Name => Type.Name;
        public string FullName => Type.FullName;
        public string AssemblyQualifiedName => Type.AssemblyQualifiedName;

        public Visibility Visibility => Type.Visibility;
        public bool IsNested => Type.IsNested;
        public bool IsGeneric => Type.IsGeneric;
        public bool IsGenericParameter => Type.IsGenericParameter;
        public bool IsStub => Type.IsStub;
        public bool IsCompilerGenerated => Type.IsCompilerGenerated;

        public Namespace Namespace => Type.Namespace;
        public Assembly Assembly => Type.Assembly;

        public IEnumerable<Attribute> Attributes =>
            AttributeInstances.Select(instance => instance.Type);
        public List<AttributeInstance> AttributeInstances => Type.AttributeInstances;

        public List<ITypeDependency> Dependencies => Type.Dependencies;
        public List<ITypeDependency> BackwardsDependencies => Type.BackwardsDependencies;
        public IEnumerable<IType> ImplementedInterfaces => Type.ImplementedInterfaces;

        public MemberList Members => Type.Members;
        public List<GenericParameter> GenericParameters => Type.GenericParameters;

        public override string ToString()
        {
            return FullName;
        }

        private bool Equals(Interface other)
        {
            return Equals(Type, other.Type);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            return obj.GetType() == GetType() && Equals((Interface)obj);
        }

        public override int GetHashCode()
        {
            return Type != null ? Type.GetHashCode() : 0;
        }
    }
}
