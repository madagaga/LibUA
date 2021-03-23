﻿
// Type: LibUA.Core.LiteralOperand



namespace LibUA.Core
{
    public class LiteralOperand : FilterOperand
    {
        public object Value { get; protected set; }

        public LiteralOperand(object Value)
        {
            this.Value = Value;
        }
    }
}
