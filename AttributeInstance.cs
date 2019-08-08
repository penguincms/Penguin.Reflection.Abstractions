using System;
using System.Reflection;

namespace Penguin.Reflection.Abstractions
{
    /// <summary>
    /// An instance of an attribute
    /// </summary>
    public class AttributeInstance
    {
        #region Properties

        /// <summary>
        /// The type/property that this was declared on
        /// </summary>
        public MemberInfo DeclaringMember { get; set; }

        /// <summary>
        /// And instantiated version of the attribute
        /// </summary>
        public Attribute Instance { get; set; }

        /// <summary>
        /// Is this attribute defined on a parent type/overridden property from where it was retrieved?
        /// </summary>
        public bool IsInherited { get; set; }

        #endregion Properties

        #region Constructors

        /// <summary>
        /// Constructs a new instance
        /// </summary>
        /// <param name="declaringMember">Where the attribute was declared</param>
        /// <param name="instance">An instance of this attribute</param>
        /// <param name="isInherited">Is this attribute defined on a parent type/overridden property from where it was retrieved?</param>
        public AttributeInstance(MemberInfo declaringMember, Attribute instance, bool isInherited)
        {
            if (instance is null)
            {
                throw new Exception("Can not instantiate null attribute instance");
            }

            DeclaringMember = declaringMember;
            Instance = instance;
            IsInherited = isInherited;
        }

        #endregion Constructors
    }
}