﻿namespace SourceBit.Inject
{
    /// <summary>
    /// Specifies how the class can be resolved in IoC container.
    /// </summary>
    public enum InjectType
    {
        /// <summary>
        /// The class can be resolved by any of the implemented interfaces.
        /// </summary>
        AsInterface = 1,

        /// <summary>
        /// The class can be resolved by its own type.
        /// </summary>
        AsSelf = 2
    }
}
