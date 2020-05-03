using System;

namespace StoreCupboardDomain
{
    /// <summary>
    /// Domain entity for Storage
    /// </summary>
    internal class Storage
    {
        internal Storage(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }

        public Guid Id { get; }

        public string Name { get; }
    }
}