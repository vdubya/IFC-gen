/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcWindowStyle : IfcTypeProduct 
	{
		public IfcWindowStyle(IfcWindowStyleConstructionEnum constructionType,
				Boolean constructionTypeSpecified,
				IfcWindowStyleOperationEnum operationType,
				Boolean operationTypeSpecified,
				Boolean parameterTakesPrecedence,
				Boolean parameterTakesPrecedenceSpecified,
				Boolean sizeable,
				Boolean sizeableSpecified,
				IfcTypeProductRepresentationMaps representationMaps,
				String tag,
				IfcTypeObjectHasPropertySets hasPropertySets,
				String applicableOccurrence,
				IfcObjectDefinitionIsNestedBy isNestedBy,
				IfcObjectDefinitionIsDecomposedBy isDecomposedBy,
				IfcOwnerHistory ownerHistory,
				String globalId,
				String name,
				String description,
				String href,
				String reference,
				String id,
				String path,
				String[] pos) : base(representationMaps,
				tag,
				hasPropertySets,
				applicableOccurrence,
				isNestedBy,
				isDecomposedBy,
				ownerHistory,
				globalId,
				name,
				description,
				href,
				reference,
				id,
				path,
				pos)
		{
			this.constructionTypeField = constructionType;
			this.constructionTypeSpecifiedField = constructionTypeSpecified;
			this.operationTypeField = operationType;
			this.operationTypeSpecifiedField = operationTypeSpecified;
			this.parameterTakesPrecedenceField = parameterTakesPrecedence;
			this.parameterTakesPrecedenceSpecifiedField = parameterTakesPrecedenceSpecified;
			this.sizeableField = sizeable;
			this.sizeableSpecifiedField = sizeableSpecified;
		}
	}
}