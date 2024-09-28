using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic;

[Token(Token = "0x2000C1D")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class OutfitCreateEmptyRequest : IMessage<OutfitCreateEmptyRequest>, IMessage, IEquatable<OutfitCreateEmptyRequest>, IDeepCloneable<OutfitCreateEmptyRequest>, IBufferMessage
{
	[Token(Token = "0x4002CED")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<OutfitCreateEmptyRequest> _parser;

	[Token(Token = "0x4002CEE")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002CEF")]
	public const int NameFieldNumber = 1;

	[Token(Token = "0x4002CF0")]
	[FieldOffset(Offset = "0x18")]
	private string name_;

	[Token(Token = "0x4002CF1")]
	public const int PictogramIdFieldNumber = 2;

	[Token(Token = "0x4002CF2")]
	[FieldOffset(Offset = "0x20")]
	private int pictogramId_;

	[Token(Token = "0x4002CF3")]
	public const int FaceIdFieldNumber = 3;

	[Token(Token = "0x4002CF4")]
	[FieldOffset(Offset = "0x24")]
	private int faceId_;

	[Token(Token = "0x17001BF3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<OutfitCreateEmptyRequest> Parser
	{
		[Token(Token = "0x6007F63")]
		[Address(RVA = "0xC601E0", Offset = "0xC5F5E0", VA = "0x180C601E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BF4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007F64")]
		[Address(RVA = "0xC60130", Offset = "0xC5F530", VA = "0x180C60130")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BF5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007F65")]
		[Address(RVA = "0xC60320", Offset = "0xC5F720", VA = "0x180C60320", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BF6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Name
	{
		[Token(Token = "0x6007F69")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007F6A")]
		[Address(RVA = "0xC60400", Offset = "0xC5F800", VA = "0x180C60400")]
		set
		{
		}
	}

	[Token(Token = "0x17001BF7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PictogramId
	{
		[Token(Token = "0x6007F6B")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007F6C")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x17001BF8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int FaceId
	{
		[Token(Token = "0x6007F6D")]
		[Address(RVA = "0x87D140", Offset = "0x87C540", VA = "0x18087D140")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007F6E")]
		[Address(RVA = "0x9342C0", Offset = "0x9336C0", VA = "0x1809342C0")]
		set
		{
		}
	}

	[Token(Token = "0x6007F66")]
	[Address(RVA = "0xC60030", Offset = "0xC5F430", VA = "0x180C60030")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OutfitCreateEmptyRequest()
	{
	}

	[Token(Token = "0x6007F67")]
	[Address(RVA = "0xC60080", Offset = "0xC5F480", VA = "0x180C60080")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OutfitCreateEmptyRequest(OutfitCreateEmptyRequest other)
	{
	}

	[Token(Token = "0x6007F68")]
	[Address(RVA = "0xC5FCB0", Offset = "0xC5F0B0", VA = "0x180C5FCB0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OutfitCreateEmptyRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6007F6F")]
	[Address(RVA = "0xC5FD90", Offset = "0xC5F190", VA = "0x180C5FD90", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007F70")]
	[Address(RVA = "0x954650", Offset = "0x953A50", VA = "0x180954650", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OutfitCreateEmptyRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007F71")]
	[Address(RVA = "0x9546D0", Offset = "0x953AD0", VA = "0x1809546D0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007F72")]
	[Address(RVA = "0xC5FED0", Offset = "0xC5F2D0", VA = "0x180C5FED0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007F73")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007F74")]
	[Address(RVA = "0x954C50", Offset = "0x954050", VA = "0x180954C50", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007F75")]
	[Address(RVA = "0xC5FBD0", Offset = "0xC5EFD0", VA = "0x180C5FBD0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007F76")]
	[Address(RVA = "0xC5FE50", Offset = "0xC5F250", VA = "0x180C5FE50", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OutfitCreateEmptyRequest other)
	{
	}

	[Token(Token = "0x6007F77")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007F78")]
	[Address(RVA = "0xC60230", Offset = "0xC5F630", VA = "0x180C60230", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
