﻿namespace Testura.Code.Helpers.Common.References
{
    public class MemberReference : VariableReference
    {
        public MemberReference(string name) : base(name)
        {
            Name = name;
        }

        public MemberReference(string name, MemberReference memberReference) : this(name)
        {
            Member = memberReference;
        }
    }
}