using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using System.Collections.Generic;
using NHapi.Model.V281.Segment;
using NHapi.Model.V281.Datatype;
using NHapi.Base.Model;

namespace NHapi.Model.V281.Group
{
///<summary>
///Represents the EHC_E15_PRODUCT_SERVICE_GROUP Group.  A Group is an ordered collection of message 
/// segments that can repeat together or be optionally in/excluded together.
/// This Group contains the following elements: 
///<ol>
///<li>0: PSG (Product/Service Group) </li>
///<li>1: EHC_E15_PSL_ITEM_INFO (a Group object) repeating</li>
///</ol>
///</summary>
[Serializable]
public class EHC_E15_PRODUCT_SERVICE_GROUP : AbstractGroup {

	///<summary> 
	/// Creates a new EHC_E15_PRODUCT_SERVICE_GROUP Group.
	///</summary>
	public EHC_E15_PRODUCT_SERVICE_GROUP(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(PSG), true, false);
	      this.add(typeof(EHC_E15_PSL_ITEM_INFO), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating EHC_E15_PRODUCT_SERVICE_GROUP - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns PSG (Product/Service Group) - creates it if necessary
	///</summary>
	public PSG PSG { 
get{
	   PSG ret = null;
	   try {
	      ret = (PSG)this.GetStructure("PSG");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of EHC_E15_PSL_ITEM_INFO (a Group object) - creates it if necessary
	///</summary>
	public EHC_E15_PSL_ITEM_INFO GetPSL_ITEM_INFO() {
	   EHC_E15_PSL_ITEM_INFO ret = null;
	   try {
	      ret = (EHC_E15_PSL_ITEM_INFO)this.GetStructure("PSL_ITEM_INFO");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of EHC_E15_PSL_ITEM_INFO
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public EHC_E15_PSL_ITEM_INFO GetPSL_ITEM_INFO(int rep) { 
	   return (EHC_E15_PSL_ITEM_INFO)this.GetStructure("PSL_ITEM_INFO", rep);
	}

	/** 
	 * Returns the number of existing repetitions of EHC_E15_PSL_ITEM_INFO 
	 */ 
	public int PSL_ITEM_INFORepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("PSL_ITEM_INFO").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the EHC_E15_PSL_ITEM_INFO results 
	 */ 
	public IEnumerable<EHC_E15_PSL_ITEM_INFO> PSL_ITEM_INFOs 
	{ 
		get
		{
			for (int rep = 0; rep < PSL_ITEM_INFORepetitionsUsed; rep++)
			{
				yield return (EHC_E15_PSL_ITEM_INFO)this.GetStructure("PSL_ITEM_INFO", rep);
			}
		}
	}

	///<summary>
	///Adds a new EHC_E15_PSL_ITEM_INFO
	///</summary>
	public EHC_E15_PSL_ITEM_INFO AddPSL_ITEM_INFO()
	{
		return this.AddStructure("PSL_ITEM_INFO") as EHC_E15_PSL_ITEM_INFO;
	}

	///<summary>
	///Removes the given EHC_E15_PSL_ITEM_INFO
	///</summary>
	public void RemovePSL_ITEM_INFO(EHC_E15_PSL_ITEM_INFO toRemove)
	{
		this.RemoveStructure("PSL_ITEM_INFO", toRemove);
	}

	///<summary>
	///Removes the EHC_E15_PSL_ITEM_INFO at the given index
	///</summary>
	public void RemovePSL_ITEM_INFOAt(int index)
	{
		this.RemoveRepetition("PSL_ITEM_INFO", index);
	}

}
}
