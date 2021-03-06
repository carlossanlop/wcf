// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.Xml.Schema
{
    using System;
    using System.IO;
    using System.Resources;
    using System.Text;
    using System.Diagnostics;
    // using System.Security.Permissions;
    using System.Globalization;

    // [Serializable],
    public class XmlSchemaInferenceException : XmlSchemaException
    {
        public XmlSchemaInferenceException() : base(null)
        {
        }


        public XmlSchemaInferenceException(String message) : base(message, ((Exception)null), 0, 0)
        {
        }

        public XmlSchemaInferenceException(String message, Exception innerException) : base(message, innerException, 0, 0)
        {
        }

        /// <include file='doc\XmlSchemaException.uex' path='docs/doc[@for="XmlSchemaException.XmlSchemaException3"]/*' />
        public XmlSchemaInferenceException(String message, Exception innerException, int lineNumber, int linePosition) :
            base(message, innerException, lineNumber, linePosition)
        {
        }

        internal XmlSchemaInferenceException(string res, string[] args) : base(res, args, null, null, 0, 0, null)
        {
        }

        internal XmlSchemaInferenceException(string res, string arg) : base(res, new string[] { arg }, null, null, 0, 0, null)
        {
        }
        internal XmlSchemaInferenceException(string res, string arg, string sourceUri, int lineNumber, int linePosition) :
            base(res, new string[] { arg }, null, sourceUri, lineNumber, linePosition, null)
        {
        }

        internal XmlSchemaInferenceException(string res, string sourceUri, int lineNumber, int linePosition) :
            base(res, (string[])null, null, sourceUri, lineNumber, linePosition, null)
        {
        }

        internal XmlSchemaInferenceException(string res, string[] args, string sourceUri, int lineNumber, int linePosition) :
            base(res, args, null, sourceUri, lineNumber, linePosition, null)
        {
        }

        internal XmlSchemaInferenceException(string res, int lineNumber, int linePosition) :
            base(res, null, null, null, lineNumber, linePosition, null)
        {
        }
    }
} // namespace Microsoft.Xml.Schema

