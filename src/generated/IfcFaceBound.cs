/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcFaceBound : IfcTopologicalRepresentationItem 
	{
		public IfcFaceBound(IfcLoop bound,
				Boolean orientation,
				Boolean orientationSpecified,
				IfcStyledItem styledByItem,
				String href,
				String reference,
				String id,
				String path,
				String[] pos) : base(styledByItem,
				href,
				reference,
				id,
				path,
				pos)
		{
			this.boundField = bound;
			this.orientationField = orientation;
			this.orientationSpecifiedField = orientationSpecified;
		}
	}
}