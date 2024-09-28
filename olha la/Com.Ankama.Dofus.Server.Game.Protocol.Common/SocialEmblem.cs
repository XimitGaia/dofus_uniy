using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000B02")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class SocialEmblem : IMessage<SocialEmblem>, IMessage, IEquatable<SocialEmblem>, IDeepCloneable<SocialEmblem>, IBufferMessage
{
	[Token(Token = "0x40028B4")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<SocialEmblem> _parser;

	[Token(Token = "0x40028B5")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40028B6")]
	public const int SymbolShapeIdFieldNumber = 1;

	[Token(Token = "0x40028B7")]
	[FieldOffset(Offset = "0x18")]
	private int symbolShapeId_;

	[Token(Token = "0x40028B8")]
	public const int SymbolColorFieldNumber = 2;

	[Token(Token = "0x40028B9")]
	[FieldOffset(Offset = "0x1C")]
	private int symbolColor_;

	[Token(Token = "0x40028BA")]
	public const int BackgroundShapeIdFieldNumber = 3;

	[Token(Token = "0x40028BB")]
	[FieldOffset(Offset = "0x20")]
	private int backgroundShapeId_;

	[Token(Token = "0x40028BC")]
	public const int BackgroundColorFieldNumber = 4;

	[Token(Token = "0x40028BD")]
	[FieldOffset(Offset = "0x24")]
	private int backgroundColor_;

	[Token(Token = "0x17001958")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SocialEmblem> Parser
	{
		[Token(Token = "0x6007398")]
		[Address(RVA = "0xBFF430", Offset = "0xBFE830", VA = "0x180BFF430")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001959")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007399")]
		[Address(RVA = "0xBFF380", Offset = "0xBFE780", VA = "0x180BFF380")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700195A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600739A")]
		[Address(RVA = "0xBFF480", Offset = "0xBFE880", VA = "0x180BFF480", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700195B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SymbolShapeId
	{
		[Token(Token = "0x600739E")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600739F")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x1700195C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SymbolColor
	{
		[Token(Token = "0x60073A0")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60073A1")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x1700195D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BackgroundShapeId
	{
		[Token(Token = "0x60073A2")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60073A3")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x1700195E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BackgroundColor
	{
		[Token(Token = "0x60073A4")]
		[Address(RVA = "0x87D140", Offset = "0x87C540", VA = "0x18087D140")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60073A5")]
		[Address(RVA = "0x9342C0", Offset = "0x9336C0", VA = "0x1809342C0")]
		set
		{
		}
	}

	[Token(Token = "0x600739B")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SocialEmblem()
	{
	}

	[Token(Token = "0x600739C")]
	[Address(RVA = "0x945650", Offset = "0x944A50", VA = "0x180945650")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SocialEmblem(SocialEmblem other)
	{
	}

	[Token(Token = "0x600739D")]
	[Address(RVA = "0xBFF0F0", Offset = "0xBFE4F0", VA = "0x180BFF0F0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SocialEmblem Clone()
	{
		return null;
	}

	[Token(Token = "0x60073A6")]
	[Address(RVA = "0xBFF180", Offset = "0xBFE580", VA = "0x180BFF180", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60073A7")]
	[Address(RVA = "0xBA0E80", Offset = "0xBA0280", VA = "0x180BA0E80", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SocialEmblem other)
	{
		return default(bool);
	}

	[Token(Token = "0x60073A8")]
	[Address(RVA = "0xBADA20", Offset = "0xBACE20", VA = "0x180BADA20", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60073A9")]
	[Address(RVA = "0xBFF220", Offset = "0xBFE620", VA = "0x180BFF220", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60073AA")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60073AB")]
	[Address(RVA = "0xBADD40", Offset = "0xBAD140", VA = "0x180BADD40", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60073AC")]
	[Address(RVA = "0xBFEFE0", Offset = "0xBFE3E0", VA = "0x180BFEFE0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60073AD")]
	[Address(RVA = "0xBA0F80", Offset = "0xBA0380", VA = "0x180BA0F80", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(SocialEmblem other)
	{
	}

	[Token(Token = "0x60073AE")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60073AF")]
	[Address(RVA = "0xBA1220", Offset = "0xBA0620", VA = "0x180BA1220", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
