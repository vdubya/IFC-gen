/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcCircleProfileDef : IfcParameterizedProfileDef 
	{
		public IfcCircleProfileDef(Double radius,
				Boolean radiusSpecified,
				IfcAxis2Placement2D position,
				IfcProfileDefHasProperties hasProperties,
				IfcProfileTypeEnum profileType,
				Boolean profileTypeSpecified,
				String profileName,
				String href,
				String reference,
				String id,
				String path,
				String[] pos) : base(position,
				hasProperties,
				profileType,
				profileTypeSpecified,
				profileName,
				href,
				reference,
				id,
				path,
				pos)
		{
			this.radiusField = radius;
			this.radiusSpecifiedField = radiusSpecified;
		}
	}
}