﻿using System;
using System.Reflection;
using JSIL.Meta;
using JSIL.Proxy;

namespace JSIL.Proxies.Bcl
{
    [JSProxy(typeof(ParameterInfo), JSProxyMemberPolicy.ReplaceNone, JSProxyAttributePolicy.ReplaceDeclared, JSProxyInterfacePolicy.ReplaceNone, false)]
    [JSStubOnly]
    public class System_Reflection_ParameterInfo
    {
    }

    [JSProxy(typeof(EventInfo), JSProxyMemberPolicy.ReplaceNone, JSProxyAttributePolicy.ReplaceDeclared, JSProxyInterfacePolicy.ReplaceNone, false)]
    [JSStubOnly]
    public class System_Reflection_EventInfo
    {
    }

    [JSProxy("System.Reflection.IntrospectionExtensions", JSProxyMemberPolicy.ReplaceNone, JSProxyAttributePolicy.ReplaceDeclared, JSProxyInterfacePolicy.ReplaceNone, false)]
    [JSStubOnly]
    public class System_Reflection_IntrospectionExtensions
    {
        [JSExternal]
        public static AnyType /* System.Reflection.TypeInfo */ GetTypeInfo(Type type)
        {
            throw new NotImplementedException();
        }
    }
}
