using System;
using System.Linq;

namespace ArchUnitNET.Domain.Extensions
{
    public static class AttributeExtensions
    {
        [Obsolete(
            "Either HasAttribute() without the useRegularExpressions parameter or HasAttributeMatching() should be used"
        )]
        public static bool HasAttribute(
            this IHasAttributes a,
            string pattern,
            bool useRegularExpressions
        )
        {
            return a.Attributes.Any(attribute =>
                attribute.FullNameMatches(pattern, useRegularExpressions)
            );
        }

        public static bool HasAttribute(this IHasAttributes a, string fullName)
        {
            return a.Attributes.Any(attribute => attribute.FullNameEquals(fullName));
        }

        [Obsolete(
            "Either OnlyHasAttributes() without the useRegularExpressions parameter or OnlyHasAttributesMatching() should be used"
        )]
        public static bool OnlyHasAttributes(
            this IHasAttributes a,
            string pattern,
            bool useRegularExpressions
        )
        {
            return a.Attributes.IsNullOrEmpty()
                || a.Attributes.All(attribute =>
                    attribute.FullNameMatches(pattern, useRegularExpressions)
                );
        }

        public static bool HasAttributeMatching(this IHasAttributes a, string pattern)
        {
            return a.Attributes.Any(attribute => attribute.FullNameMatches(pattern));
        }

        public static bool OnlyHasAttributes(this IHasAttributes a, string name)
        {
            return a.Attributes.IsNullOrEmpty()
                || a.Attributes.All(attribute => attribute.FullNameEquals(name));
        }

        public static bool OnlyHasAttributesMatching(this IHasAttributes a, string pattern)
        {
            return a.Attributes.IsNullOrEmpty()
                || a.Attributes.All(attribute => attribute.FullNameMatches(pattern));
        }
    }
}
