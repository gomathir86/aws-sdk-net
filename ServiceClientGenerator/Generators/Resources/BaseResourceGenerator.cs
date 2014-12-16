﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 12.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ServiceClientGenerator.Generators.Resources
{
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using ServiceClientGenerator.ResourcesApi;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public partial class BaseResourceGenerator : BaseGenerator
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 9 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"
 
public void GenerateAction(ServiceClientGenerator.ResourcesApi.Action action)
{
	GenerateRequestMappings(action);

        
        #line default
        #line hidden
        
        #line 13 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"
this.Write("\t\t\t");

        
        #line default
        #line hidden
        
        #line 14 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(action.ReturnTypeInterface.Equals("void") ? "" : "var response = "));

        
        #line default
        #line hidden
        
        #line 14 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"
this.Write("ResourcesUtilities.Invoke(request, this.Client.");

        
        #line default
        #line hidden
        
        #line 14 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(action.RequestOperationName));

        
        #line default
        #line hidden
        
        #line 14 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"
this.Write(", \"");

        
        #line default
        #line hidden
        
        #line 14 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(action.Name));

        
        #line default
        #line hidden
        
        #line 14 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"
this.Write("\");\r\n");

        
        #line default
        #line hidden
        
        #line 15 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"

	if(action.Resource!=null)	
	{

        
        #line default
        #line hidden
        
        #line 18 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"
this.Write("\t\t\treturn ");

        
        #line default
        #line hidden
        
        #line 19 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(action.ResourceConstructionExpression));

        
        #line default
        #line hidden
        
        #line 19 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"
this.Write(";\r\n\t\t\t\r\n");

        
        #line default
        #line hidden
        
        #line 21 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"

	}
}

        
        #line default
        #line hidden
        
        #line 26 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"
 public void FormatResourceReferenceFactoryDocumentation(ServiceClientGenerator.ResourcesApi.Resource resource) 
{

        
        #line default
        #line hidden
        
        #line 28 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"
this.Write("        /// <summary>\r\n        /// Gets a ");

        
        #line default
        #line hidden
        
        #line 30 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(resource.ClassName));

        
        #line default
        #line hidden
        
        #line 30 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"
this.Write(@" resource associated with the service using 
		/// its identifier.
		/// <para>
		/// This method does not make a service call, it returns a resource instance
		/// only with its identifier properties initialized. Accessing any non-identifier 
		/// properties or operations on the resource that in turn access any non-identifier 
		/// properties will cause the resource to make a service call to load its data.
		/// </para>
		/// <para>
		/// NOTE : This method does not make a service call when the resource is initally
		/// constructed. If you pass invalid identifiers to this method, it will return a resource
		/// that may not exist on the server. In this case an exception will be thrown when 
		/// the resource tries to load itself due to conditions listed in the previous section.
		/// </para>
        /// </summary>
");

        
        #line default
        #line hidden
        
        #line 45 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"

        foreach (var p in resource.Identifiers)
        {           

        
        #line default
        #line hidden
        
        #line 48 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"
this.Write("        /// <param name=\"");

        
        #line default
        #line hidden
        
        #line 49 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(p.Name.ToCamelCase()));

        
        #line default
        #line hidden
        
        #line 49 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"
this.Write("\">The ");

        
        #line default
        #line hidden
        
        #line 49 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(p.Name.ToLower()));

        
        #line default
        #line hidden
        
        #line 49 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"
this.Write(" of the ");

        
        #line default
        #line hidden
        
        #line 49 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(resource.ClassName));

        
        #line default
        #line hidden
        
        #line 49 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"
this.Write(".</param>\r\n");

        
        #line default
        #line hidden
        
        #line 50 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"

        }

        
        #line default
        #line hidden
        
        #line 52 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"
this.Write("        /// <returns>An instance of ");

        
        #line default
        #line hidden
        
        #line 53 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(resource.Name));

        
        #line default
        #line hidden
        
        #line 53 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"
this.Write(" resource.</returns>\r\n");

        
        #line default
        #line hidden
        
        #line 54 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"

}

 public void GenerateRequestMappings(ServiceClientGenerator.ResourcesApi.Action action)
{
	if(action.HasRequestParameterMappings)
	{
		foreach(var parameter in action.RequestParameterMappings)
		{

        
        #line default
        #line hidden
        
        #line 63 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"
this.Write("\t\t\trequest.");

        
        #line default
        #line hidden
        
        #line 64 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(parameter.Target));

        
        #line default
        #line hidden
        
        #line 64 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"
this.Write(" = ");

        
        #line default
        #line hidden
        
        #line 64 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(parameter.Source.GetIdentifierExpression()));

        
        #line default
        #line hidden
        
        #line 64 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"
this.Write(";\r\n");

        
        #line default
        #line hidden
        
        #line 65 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"

		}
	}
}

public void GenerateHasMany(EnumerableAction action)
{
	GenerateRequestMappings(action);
	if(!action.IsPageable && action.ReturnsResource)
	{

        
        #line default
        #line hidden
        
        #line 75 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"
this.Write("\t\t\tvar items = new List<");

        
        #line default
        #line hidden
        
        #line 76 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(action.ReturnTypeInterface));

        
        #line default
        #line hidden
        
        #line 76 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"
this.Write(">();\r\n\t\t\tforeach (var item in this.Client.");

        
        #line default
        #line hidden
        
        #line 77 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(action.RequestOperationName));

        
        #line default
        #line hidden
        
        #line 77 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"
this.Write("(request))\r\n\t\t\t{\t\t\r\n\t\t\t\titems.Add(new ");

        
        #line default
        #line hidden
        
        #line 79 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(action.ReturnType));

        
        #line default
        #line hidden
        
        #line 79 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"
this.Write("(item, this.Client));\r\n\t\t\t}\r\n\t\t\treturn items;test\r\n");

        
        #line default
        #line hidden
        
        #line 82 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"
	
	}
	else if(!action.IsPageable && !action.ReturnsResource)
	{

        
        #line default
        #line hidden
        
        #line 86 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"
this.Write("\t\t\r\n\t\t\tvar items = new List<");

        
        #line default
        #line hidden
        
        #line 87 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(action.ReturnTypeInterface));

        
        #line default
        #line hidden
        
        #line 87 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"
this.Write(">();\r\n\t\t\tforeach (var item in ResourcesUtilities.Invoke(request, this.Client.");

        
        #line default
        #line hidden
        
        #line 88 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(action.RequestOperationName));

        
        #line default
        #line hidden
        
        #line 88 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"
this.Write(", \"");

        
        #line default
        #line hidden
        
        #line 88 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(action.Name));

        
        #line default
        #line hidden
        
        #line 88 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"
this.Write("\")");

        
        #line default
        #line hidden
        
        #line 88 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(action.ResultKey));

        
        #line default
        #line hidden
        
        #line 88 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"
this.Write(")\r\n\t\t\t{\t\t\r\n\t\t\t\titems.Add(");

        
        #line default
        #line hidden
        
        #line 90 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(action.ResourceConstructionExpression));

        
        #line default
        #line hidden
        
        #line 90 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"
this.Write(");\r\n\t\t\t}\r\n\t\t\treturn items;\r\n");

        
        #line default
        #line hidden
        
        #line 93 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"
	
	}
	else if(action.IsPageable)
	{

        
        #line default
        #line hidden
        
        #line 97 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"
this.Write("\t\t\r\n\t\t\tforeach (var item in ResourcesUtilities.InvokePaginator(request, this.Clie" +
        "nt.");

        
        #line default
        #line hidden
        
        #line 98 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(action.RequestOperationName));

        
        #line default
        #line hidden
        
        #line 98 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"
this.Write(", \"");

        
        #line default
        #line hidden
        
        #line 98 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(action.Name));

        
        #line default
        #line hidden
        
        #line 98 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"
this.Write("\"))\r\n\t\t\t{\t\t\t\r\n\t\t\t\tyield return ");

        
        #line default
        #line hidden
        
        #line 100 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(action.ResourceConstructionExpression));

        
        #line default
        #line hidden
        
        #line 100 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"
this.Write(";\t\r\n\t\t\t}\r\n");

        
        #line default
        #line hidden
        
        #line 102 "C:\dev\net\sdk.resource.api\sdk\src\ServiceClientGenerator\Generators\Resources\BaseResourceGenerator.tt"
	
	}
}

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
}
