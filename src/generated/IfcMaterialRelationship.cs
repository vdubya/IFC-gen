/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcMaterialRelationship : IfcResourceLevelRelationship 
	{
		public IfcMaterialRelationship(IfcMaterial relatingMaterial,
				IfcMaterialRelationshipRelatedMaterials relatedMaterials,
				String expression,
				String name,
				String description,
				String href,
				String reference,
				String id,
				String path,
				String[] pos) : base(name,
				description,
				href,
				reference,
				id,
				path,
				pos)
		{
			this.relatingMaterialField = relatingMaterial;
			this.relatedMaterialsField = relatedMaterials;
			this.expressionField = expression;
		}
	}
}