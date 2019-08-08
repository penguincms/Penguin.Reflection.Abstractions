namespace Penguin.Reflection.Abstractions
{
    /// <summary>
    /// The simplest usable unit of a type check
    /// </summary>
    public enum CoreType
    {
        /// <summary>
        /// The type is null and cant be resolved
        /// </summary>
        Null,

        /// <summary>
        /// Any Collection, Array, List, etc.
        /// </summary>
        Collection,

        /// <summary>
        /// Any kind of dictionary
        /// </summary>
        Dictionary,

        /// <summary>
        /// A value type or anything that could easily be serialized into a single field
        /// </summary>
        Value,

        /// <summary>
        /// Any type that contains sub-properties and is best shown as a tree of values
        /// </summary>
        Reference,

        /// <summary>
        /// An enumeration or selection type
        /// </summary>
        Enum
    }
}