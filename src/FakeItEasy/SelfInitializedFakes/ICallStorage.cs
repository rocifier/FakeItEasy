namespace FakeItEasy.SelfInitializedFakes
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Represents storage for recorded calls for self initializing
    /// fakes.
    /// </summary>
    [Obsolete("Self-initializing fakes will be removed in version 4.0.0.")]
    public interface ICallStorage
    {
        /// <summary>
        /// Loads the recorded calls for the specified recording.
        /// </summary>
        /// <returns>The recorded calls for the recording with the specified id.</returns>
        IEnumerable<CallData> Load();

        /// <summary>
        /// Saves the specified calls as the recording with the specified id,
        /// overwriting any previous recording.
        /// </summary>
        /// <param name="calls">The calls to save.</param>
        void Save(IEnumerable<CallData> calls);
    }
}
