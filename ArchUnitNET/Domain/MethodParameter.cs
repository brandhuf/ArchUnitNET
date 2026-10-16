using System.Collections.Generic;

namespace ArchUnitNET.Domain
{
    public class MethodParameter : ITypeInstance<IType>
    {
        public MethodParameter(string name, ITypeInstance<IType> typeInstance)
        {
            Name = name;
            TypeInstance = typeInstance;
        }

        public string Name { get; }
        public ITypeInstance<IType> TypeInstance { get; }
        public List<AttributeInstance> AttributeInstances { get; } = new List<AttributeInstance>();

        public IType Type => TypeInstance.Type;
        public IEnumerable<GenericArgument> GenericArguments => TypeInstance.GenericArguments;
        public bool IsArray => TypeInstance.IsArray;
        public IEnumerable<int> ArrayDimensions => TypeInstance.ArrayDimensions;
    }
}
