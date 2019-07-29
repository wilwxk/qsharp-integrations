// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Microsoft.Quantum.Samples.Qiskit
{
    /*
     * Quick and dirty driver to enable the ibmq_5_tenerife (used to be IBMQ4)
     */
    class IbmQ5Yorktown : QiskitDriver
    {
        public IbmQ5Yorktown(string key) : base(key)
        {
        }

        public override int QubitCount => 5;

        public override string Name => "ibmq_5_yorktown";
    }
}
