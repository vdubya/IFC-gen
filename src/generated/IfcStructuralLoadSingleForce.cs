/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcStructuralLoadSingleForce : IfcStructuralLoadStatic 
	{
		public IfcStructuralLoadSingleForce(Double forceX,
				Boolean forceXSpecified,
				Double forceY,
				Boolean forceYSpecified,
				Double forceZ,
				Boolean forceZSpecified,
				Double momentX,
				Boolean momentXSpecified,
				Double momentY,
				Boolean momentYSpecified,
				Double momentZ,
				Boolean momentZSpecified,
				String name,
				String href,
				String reference,
				String id,
				String path,
				String[] pos) : base(name,
				href,
				reference,
				id,
				path,
				pos)
		{
			this.forceXField = forceX;
			this.forceXSpecifiedField = forceXSpecified;
			this.forceYField = forceY;
			this.forceYSpecifiedField = forceYSpecified;
			this.forceZField = forceZ;
			this.forceZSpecifiedField = forceZSpecified;
			this.momentXField = momentX;
			this.momentXSpecifiedField = momentXSpecified;
			this.momentYField = momentY;
			this.momentYSpecifiedField = momentYSpecified;
			this.momentZField = momentZ;
			this.momentZSpecifiedField = momentZSpecified;
		}
	}
}