﻿namespace CefGlue.Interop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    ///
    // XML node types.
    ///
    internal enum cef_xml_node_type_t : int
    {
        XML_NODE_UNSUPPORTED = 0,
        XML_NODE_PROCESSING_INSTRUCTION,
        XML_NODE_DOCUMENT_TYPE,
        XML_NODE_ELEMENT_START,
        XML_NODE_ELEMENT_END,
        XML_NODE_ATTRIBUTE,
        XML_NODE_TEXT,
        XML_NODE_CDATA,
        XML_NODE_ENTITY_REFERENCE,
        XML_NODE_WHITESPACE,
        XML_NODE_COMMENT,
    }
}
