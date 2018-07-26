using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace MyBatis.Common.Logging
{
    public interface IConfigurationSectionHandler
    {
        object Create(object parent, object configContext, XmlNode section);
    }
}
