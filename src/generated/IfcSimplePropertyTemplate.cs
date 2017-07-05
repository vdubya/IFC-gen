/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcSimplePropertyTemplate : IfcPropertyTemplate 
	{
		public IfcSimplePropertyTemplate(IfcPropertyEnumeration enumerators,
				IfcSimplePropertyTemplatePrimaryUnit primaryUnit,
				IfcSimplePropertyTemplateSecondaryUnit secondaryUnit,
				IfcSimplePropertyTemplateTypeEnum templateType,
				Boolean templateTypeSpecified,
				String primaryMeasureType,
				String secondaryMeasureType,
				String expression,
				IfcStateEnum accessState,
				Boolean accessStateSpecified,
				IfcOwnerHistory ownerHistory,
				String globalId,
				String name,
				String description,
				String href,
				String reference,
				String id,
				String path,
				String[] pos) : base(ownerHistory,
				globalId,
				name,
				description,
				href,
				reference,
				id,
				path,
				pos)
		{
			this.enumeratorsField = enumerators;
			this.primaryUnitField = primaryUnit;
			this.secondaryUnitField = secondaryUnit;
			this.templateTypeField = templateType;
			this.templateTypeSpecifiedField = templateTypeSpecified;
			this.primaryMeasureTypeField = primaryMeasureType;
			this.secondaryMeasureTypeField = secondaryMeasureType;
			this.expressionField = expression;
			this.accessStateField = accessState;
			this.accessStateSpecifiedField = accessStateSpecified;
		}
	}
}