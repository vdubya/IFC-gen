/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcSlippageConnectionCondition : IfcStructuralConnectionCondition 
	{
		public IfcSlippageConnectionCondition(Double slippageX,
				Boolean slippageXSpecified,
				Double slippageY,
				Boolean slippageYSpecified,
				Double slippageZ,
				Boolean slippageZSpecified,
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
			this.slippageXField = slippageX;
			this.slippageXSpecifiedField = slippageXSpecified;
			this.slippageYField = slippageY;
			this.slippageYSpecifiedField = slippageYSpecified;
			this.slippageZField = slippageZ;
			this.slippageZSpecifiedField = slippageZSpecified;
		}
	}
}