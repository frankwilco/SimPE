using System;
using SimPe.Interfaces.Plugin;

namespace SimPe.Plugin
{
	/// <summary>
	/// This is the actual FileWrapper
	/// </summary>
	/// <remarks>
	/// The wrapper is used to (un)serialize the Data of a file into it's Attributes. So Basically it reads 
	/// a BinaryStream and translates the data into some userdefine Attributes.
	/// </remarks>
	public class MyPackedFileWrapper
		: AbstractWrapper				//Implements some of the default Behaviur of a Handler, you can Implement yourself if you want more flexibility!
		, IFileWrapper					//This Interface is used when loading a File
		, IFileWrapperSaveExtension		//This Interface (if available) will be used to store a File
		//,IPackedFileProperties		//This Interface can be used by thirdparties to retrive the FIleproperties, however you don't have to implement it!
	{
		#region Example Attribute
		/// <summary>
		/// Contains the Data of the File
		/// </summary>
		/// <remarks>
		/// This is just an example Attribute, so you probably have to replace it with another one
		/// </remarks>
		/// TODO: Replace this Attribute with the onex you need
		private string data;

		/// <summary>
		/// Returns/Sets the Data of the File
		/// </summary>
		/// <remarks>
		/// This is just an example Attribute, so you probably have to replace it with another one
		/// </remarks>
		/// TODO: Replace this Attribute with the onex you need
		public string Data 
		{
			get { return data;	}			
			set { data = value; }
		}
		#endregion

		/// <summary>
		/// Constructor
		/// </summary>
		public MyPackedFileWrapper() : base()
		{
			///
			/// TODO: Add your Contructor Stuff here (if needed)
			///
		}

		#region IWrapper member
		public override bool CheckVersion(uint version) 
		{
			if ( (version==0009) //0.00
				|| (version==0010) //0.10
				) 
			{
				return true;
			}

			return false;
		}
		#endregion
		
		#region AbstractWrapper Member
		protected override IPackedFileUI CreateDefaultUIHandler()
		{
			return new MyPackedFileUI();
		}
		/// <summary>
		/// Returns a Human Readable Description of this Wrapper
		/// </summary>
		/// <returns>Human Readable Description</returns>
		protected override IWrapperInfo CreateWrapperInfo()
		{
			///
			/// TODO: Change the Description passed here
			/// 
			return new AbstractWrapperInfo(
				"Example Wrapper (Please Change!)",
				"Quaxi",
				"---",
				1
				); 
		}

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		protected override void Unserialize(System.IO.BinaryReader reader)
		{
			///
			/// TODO: You have to put some real Code here, just delete the example
			/// 

			reader.BaseStream.Seek(0x17, System.IO.SeekOrigin.Begin);
			char[] loaded = reader.ReadChars(10);
			data = "";
			foreach (char c in loaded) data += c;			
		}

		/// <summary>
		/// Serializes a the Attributes stored in this Instance to the BinaryStream
		/// </summary>
		/// <param name="writer">The Stream the Data should be stored to</param>
		/// <remarks>
		/// Be sure that the Position of the stream is Proper on 
		/// return (i.e. must point to the first Byte after your actual File)
		/// </remarks>
		protected override void Serialize(System.IO.BinaryWriter writer)
		{
			///
			/// TODO: You can put some Code here
			/// 			
		}
		#endregion

		#region IFileWrapperSaveExtension Member		
			//all covered by Serialize()
		#endregion

		#region IFileWrapper Member

		/// <summary>
		/// Returns the Signature that can be used to identify Files processable with this Plugin
		/// </summary>
		public byte[] FileSignature
		{
			get
			{
				/// 
				/// TODO:  Add the Signature Array if needed
				/// 
				return new byte[0];
			}
		}

		/// <summary>
		/// Returns a list of File Type this Plugin can process
		/// </summary>
		public uint[] AssignableTypes
		{
			get
			{
				///
				/// TODO: Change or Remove the Filetypes
				/// 

				uint[] types = {0xEBFEE342}; //handles the Version Information File
				return types;
			}
		}

		#endregion		
	}
}
