using System;
using System.Reflection;

namespace Vile_ASPNET_WebAPI_MongoDB.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}